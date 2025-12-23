<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUnitConverter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnitConverter))
        lblEnterValue = New Label()
        txtValue = New TextBox()
        cmbFrom = New ComboBox()
        cmbTo = New ComboBox()
        txtResult = New TextBox()
        btnConvert = New Button()
        pnlAll = New Panel()
        btnClear = New Button()
        btnExit = New Button()
        lblConvertTo = New Label()
        lblFrom = New Label()
        pnlHeader = New Panel()
        lblUnitConverter = New Label()
        Panel3 = New Panel()
        lblResultOutput = New Label()
        pnlAll.SuspendLayout()
        pnlHeader.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblEnterValue
        ' 
        lblEnterValue.AutoSize = True
        lblEnterValue.BackColor = Color.Transparent
        lblEnterValue.Font = New Font("Microsoft New Tai Lue", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEnterValue.ForeColor = Color.DeepPink
        lblEnterValue.Location = New Point(122, 120)
        lblEnterValue.Name = "lblEnterValue"
        lblEnterValue.Size = New Size(203, 45)
        lblEnterValue.TabIndex = 0
        lblEnterValue.Text = "Enter Value"
        ' 
        ' txtValue
        ' 
        txtValue.BorderStyle = BorderStyle.FixedSingle
        txtValue.Font = New Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtValue.ForeColor = Color.DeepPink
        txtValue.Location = New Point(352, 120)
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(359, 34)
        txtValue.TabIndex = 1
        ' 
        ' cmbFrom
        ' 
        cmbFrom.FlatStyle = FlatStyle.Flat
        cmbFrom.Font = New Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbFrom.FormattingEnabled = True
        cmbFrom.Location = New Point(352, 200)
        cmbFrom.Name = "cmbFrom"
        cmbFrom.Size = New Size(359, 33)
        cmbFrom.TabIndex = 4
        ' 
        ' cmbTo
        ' 
        cmbTo.FlatStyle = FlatStyle.Flat
        cmbTo.Font = New Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbTo.FormattingEnabled = True
        cmbTo.Location = New Point(352, 288)
        cmbTo.Name = "cmbTo"
        cmbTo.Size = New Size(359, 34)
        cmbTo.TabIndex = 5
        ' 
        ' txtResult
        ' 
        txtResult.BackColor = Color.White
        txtResult.BorderStyle = BorderStyle.FixedSingle
        txtResult.Font = New Font("Microsoft New Tai Lue", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtResult.ForeColor = Color.DeepPink
        txtResult.Location = New Point(17, 60)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(744, 43)
        txtResult.TabIndex = 7
        ' 
        ' btnConvert
        ' 
        btnConvert.BackColor = Color.DeepPink
        btnConvert.FlatStyle = FlatStyle.Flat
        btnConvert.Font = New Font("Microsoft New Tai Lue", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConvert.ForeColor = Color.LavenderBlush
        btnConvert.Location = New Point(95, 526)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(144, 51)
        btnConvert.TabIndex = 8
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = False
        ' 
        ' pnlAll
        ' 
        pnlAll.BackColor = Color.LavenderBlush
        pnlAll.BackgroundImage = CType(resources.GetObject("pnlAll.BackgroundImage"), Image)
        pnlAll.Controls.Add(btnClear)
        pnlAll.Controls.Add(cmbTo)
        pnlAll.Controls.Add(cmbFrom)
        pnlAll.Controls.Add(btnExit)
        pnlAll.Controls.Add(btnConvert)
        pnlAll.Controls.Add(lblConvertTo)
        pnlAll.Controls.Add(lblFrom)
        pnlAll.Controls.Add(pnlHeader)
        pnlAll.Controls.Add(lblEnterValue)
        pnlAll.Controls.Add(txtValue)
        pnlAll.Controls.Add(Panel3)
        pnlAll.Location = New Point(-3, -2)
        pnlAll.Name = "pnlAll"
        pnlAll.Size = New Size(817, 615)
        pnlAll.TabIndex = 10
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.DeepPink
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Microsoft New Tai Lue", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.LavenderBlush
        btnClear.Location = New Point(261, 526)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(144, 51)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Crimson
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Microsoft New Tai Lue", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.LavenderBlush
        btnExit.Location = New Point(584, 526)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(138, 51)
        btnExit.TabIndex = 11
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblConvertTo
        ' 
        lblConvertTo.AutoSize = True
        lblConvertTo.BackColor = Color.Transparent
        lblConvertTo.Font = New Font("Microsoft New Tai Lue", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblConvertTo.ForeColor = Color.DeepPink
        lblConvertTo.Location = New Point(123, 277)
        lblConvertTo.Name = "lblConvertTo"
        lblConvertTo.Size = New Size(189, 45)
        lblConvertTo.TabIndex = 9
        lblConvertTo.Text = "Convert to"
        ' 
        ' lblFrom
        ' 
        lblFrom.AutoSize = True
        lblFrom.BackColor = Color.Transparent
        lblFrom.Font = New Font("Microsoft New Tai Lue", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFrom.ForeColor = Color.DeepPink
        lblFrom.Location = New Point(122, 200)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(104, 45)
        lblFrom.TabIndex = 8
        lblFrom.Text = "From"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.DeepPink
        pnlHeader.Controls.Add(lblUnitConverter)
        pnlHeader.Location = New Point(3, 3)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(829, 74)
        pnlHeader.TabIndex = 4
        ' 
        ' lblUnitConverter
        ' 
        lblUnitConverter.AutoSize = True
        lblUnitConverter.Font = New Font("Impact", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUnitConverter.ForeColor = Color.Linen
        lblUnitConverter.Location = New Point(14, 14)
        lblUnitConverter.Name = "lblUnitConverter"
        lblUnitConverter.Size = New Size(349, 48)
        lblUnitConverter.TabIndex = 8
        lblUnitConverter.Text = "Unit Converter Tool"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DeepPink
        Panel3.Controls.Add(lblResultOutput)
        Panel3.Controls.Add(txtResult)
        Panel3.Location = New Point(17, 371)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(779, 125)
        Panel3.TabIndex = 12
        ' 
        ' lblResultOutput
        ' 
        lblResultOutput.AutoSize = True
        lblResultOutput.BackColor = Color.DeepPink
        lblResultOutput.Font = New Font("Microsoft New Tai Lue", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResultOutput.ForeColor = Color.LavenderBlush
        lblResultOutput.Location = New Point(17, 12)
        lblResultOutput.Name = "lblResultOutput"
        lblResultOutput.Size = New Size(243, 45)
        lblResultOutput.TabIndex = 10
        lblResultOutput.Text = "Result Output"
        ' 
        ' frmUnitConverter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(814, 610)
        Controls.Add(pnlAll)
        Name = "frmUnitConverter"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Unit Converter Tool"
        pnlAll.ResumeLayout(False)
        pnlAll.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblEnterValue As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents cmbFrom As ComboBox
    Friend WithEvents cmbTo As ComboBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents pnlAll As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblUnitConverter As Label
    Friend WithEvents lblResultOutput As Label
    Friend WithEvents lblConvertTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClear As Button

End Class
