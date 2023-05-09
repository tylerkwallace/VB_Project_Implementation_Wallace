<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picCheck = New System.Windows.Forms.PictureBox()
        Me.lblExpensesApp = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMonthly = New System.Windows.Forms.RadioButton()
        Me.radWeekly = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        CType(Me.picCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCheck
        '
        Me.picCheck.BackgroundImage = CType(resources.GetObject("picCheck.BackgroundImage"), System.Drawing.Image)
        Me.picCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCheck.Location = New System.Drawing.Point(2, 1)
        Me.picCheck.Name = "picCheck"
        Me.picCheck.Size = New System.Drawing.Size(342, 328)
        Me.picCheck.TabIndex = 0
        Me.picCheck.TabStop = False
        '
        'lblExpensesApp
        '
        Me.lblExpensesApp.AutoSize = True
        Me.lblExpensesApp.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblExpensesApp.Location = New System.Drawing.Point(358, 26)
        Me.lblExpensesApp.Name = "lblExpensesApp"
        Me.lblExpensesApp.Size = New System.Drawing.Size(431, 43)
        Me.lblExpensesApp.TabIndex = 1
        Me.lblExpensesApp.Text = "Average Expenses App"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMonthly)
        Me.GroupBox1.Controls.Add(Me.radWeekly)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(422, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 123)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Expense Type"
        Me.GroupBox1.UseWaitCursor = True
        '
        'radMonthly
        '
        Me.radMonthly.AutoSize = True
        Me.radMonthly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radMonthly.Location = New System.Drawing.Point(16, 72)
        Me.radMonthly.Name = "radMonthly"
        Me.radMonthly.Size = New System.Drawing.Size(105, 28)
        Me.radMonthly.TabIndex = 1
        Me.radMonthly.TabStop = True
        Me.radMonthly.Text = "Monthly"
        Me.radMonthly.UseVisualStyleBackColor = True
        Me.radMonthly.UseWaitCursor = True
        '
        'radWeekly
        '
        Me.radWeekly.AutoSize = True
        Me.radWeekly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.radWeekly.Location = New System.Drawing.Point(16, 38)
        Me.radWeekly.Name = "radWeekly"
        Me.radWeekly.Size = New System.Drawing.Size(100, 28)
        Me.radWeekly.TabIndex = 0
        Me.radWeekly.TabStop = True
        Me.radWeekly.Text = "Weekly"
        Me.radWeekly.UseVisualStyleBackColor = True
        Me.radWeekly.UseWaitCursor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(82, 469)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(162, 44)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(319, 469)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(162, 44)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(556, 469)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(162, 44)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.AllowPromptAsInput = False
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaskedTextBox1.Location = New System.Drawing.Point(389, 300)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(332, 29)
        Me.MaskedTextBox1.TabIndex = 6
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstructions.Location = New System.Drawing.Point(354, 242)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(61, 22)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Label1"
        Me.lblInstructions.Visible = False
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAverage.Location = New System.Drawing.Point(70, 595)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(111, 35)
        Me.lblAverage.TabIndex = 8
        Me.lblAverage.Text = "Label2"
        Me.lblAverage.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 766)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblExpensesApp)
        Me.Controls.Add(Me.picCheck)
        Me.Name = "Form1"
        Me.Text = "Expense App"
        CType(Me.picCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCheck As PictureBox
    Friend WithEvents lblExpensesApp As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMonthly As RadioButton
    Friend WithEvents radWeekly As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblAverage As Label
End Class
