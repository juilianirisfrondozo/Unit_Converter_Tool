Public Class frmUnitConverter

    Private Function ToMeters(value As Double, unit As String) As Double
        Select Case unit
            Case "Millimeters" : Return value / 1000
            Case "Centimeters" : Return value / 100
            Case "Meters" : Return value
            Case "Kilometers" : Return value * 1000
            Case "Inches" : Return value * 0.0254
            Case "Feet" : Return value * 0.3048
            Case "Yards" : Return value * 0.9144
            Case "Miles" : Return value * 1609.34
            Case Else : Return 0
        End Select
    End Function


    Private Function FromMeters(meters As Double, unit As String) As Double
        Select Case unit
            Case "Millimeters" : Return meters * 1000
            Case "Centimeters" : Return meters * 100
            Case "Meters" : Return meters
            Case "Kilometers" : Return meters / 1000
            Case "Inches" : Return meters / 0.0254
            Case "Feet" : Return meters / 0.3048
            Case "Yards" : Return meters / 0.9144
            Case "Miles" : Return meters / 1609.34
            Case Else : Return 0
        End Select
    End Function

    Private Sub frmUnitConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        For Each cmb As ComboBox In {cmbFrom, cmbTo}
            cmb.DrawMode = DrawMode.OwnerDrawFixed
            cmb.DropDownStyle = ComboBoxStyle.DropDownList
            AddHandler cmb.DrawItem, AddressOf DrawComboItem
        Next


        Dim units() As String = {
        "Millimeters", "Centimeters", "Meters", "Kilometers",
        "Inches", "Feet", "Yards", "Miles"
    }

        cmbFrom.Items.AddRange(units)
        cmbTo.Items.AddRange(units)

        cmbFrom.SelectedIndex = -1
        cmbTo.SelectedIndex = -1
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        If txtValue.Text.Trim() = "" Then
            Dim ask = MessageBox.Show(
                "No value entered. Do you want to continue?",
                "Empty Value",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If ask = DialogResult.No Then Exit Sub
        End If

        If txtValue.Text.Trim() <> "" AndAlso Not IsNumeric(txtValue.Text) Then
            MessageBox.Show("Input must be a number.", "Invalid Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If cmbFrom.SelectedIndex = -1 Or cmbTo.SelectedIndex = -1 Then
            MessageBox.Show("Please select both units.", "Selection Missing",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim inputValue As Double = 0
        If txtValue.Text.Trim() <> "" Then
            inputValue = CDbl(txtValue.Text)
        End If

        Dim baseMeters As Double = ToMeters(inputValue, cmbFrom.Text)
        Dim finalValue As Double = FromMeters(baseMeters, cmbTo.Text)


        txtResult.Text = $"{inputValue} {cmbFrom.Text} = {Math.Round(finalValue, 6)} {cmbTo.Text}"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim ask = MessageBox.Show("Do you want to exit?", "Confirm Exit",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ask = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValue.Clear()
        cmbFrom.SelectedIndex = -1
        cmbTo.SelectedIndex = -1
        txtResult.Clear()
    End Sub

    Public Sub DrawComboItem(sender As Object, e As DrawItemEventArgs)
        If e.Index < 0 Then Exit Sub

        Dim combo As ComboBox = DirectCast(sender, ComboBox)
        e.DrawBackground()

        Dim bgColor As Color
        Dim textColor As Color = Color.DeepPink

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            bgColor = Color.LavenderBlush  ' Highlight
        Else
            bgColor = Color.White                     ' Normal
        End If

        ' Fill the background
        Using bgBrush As New SolidBrush(bgColor)
            e.Graphics.FillRectangle(bgBrush, e.Bounds)
        End Using

        ' Get item text properly
        Dim text As String = combo.GetItemText(combo.Items(e.Index))

        ' Draw the text
        Using textBrush As New SolidBrush(textColor)
            e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds)
        End Using

        e.DrawFocusRectangle()
    End Sub


End Class
