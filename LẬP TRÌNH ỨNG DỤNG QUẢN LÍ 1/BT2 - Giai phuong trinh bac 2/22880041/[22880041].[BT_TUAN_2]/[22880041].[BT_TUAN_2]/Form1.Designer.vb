<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        IKQ = New Label()
        Button1 = New Button()
        Button2 = New Button()
        IA = New TextBox()
        IB = New TextBox()
        IC = New TextBox()
        bXoa = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(136, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(321, 30)
        Label1.TabIndex = 0
        Label1.Text = "Giải Phương Trình Ax^2+Bx+C=0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 15)
        Label2.TabIndex = 1
        Label2.Text = "A:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(226, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(17, 15)
        Label3.TabIndex = 2
        Label3.Text = "B:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(378, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(18, 15)
        Label4.TabIndex = 3
        Label4.Text = "C:"
        ' 
        ' IKQ
        ' 
        IKQ.AutoSize = True
        IKQ.Font = New Font("Segoe UI", 14F)
        IKQ.Location = New Point(43, 127)
        IKQ.Name = "IKQ"
        IKQ.Size = New Size(0, 25)
        IKQ.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(152, 171)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 45)
        Button1.TabIndex = 4
        Button1.Text = "Kết Quả"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(378, 171)
        Button2.Name = "Button2"
        Button2.Size = New Size(79, 45)
        Button2.TabIndex = 6
        Button2.Text = "Thoát"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' IA
        ' 
        IA.Location = New Point(114, 85)
        IA.Name = "IA"
        IA.Size = New Size(88, 23)
        IA.TabIndex = 1
        ' 
        ' IB
        ' 
        IB.Location = New Point(261, 85)
        IB.Name = "IB"
        IB.Size = New Size(88, 23)
        IB.TabIndex = 2
        ' 
        ' IC
        ' 
        IC.Location = New Point(423, 85)
        IC.Name = "IC"
        IC.Size = New Size(88, 23)
        IC.TabIndex = 3
        ' 
        ' bXoa
        ' 
        bXoa.Location = New Point(261, 171)
        bXoa.Name = "bXoa"
        bXoa.Size = New Size(79, 45)
        bXoa.TabIndex = 5
        bXoa.Text = "Xóa"
        bXoa.UseMnemonic = False
        bXoa.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(566, 261)
        Controls.Add(bXoa)
        Controls.Add(IC)
        Controls.Add(IB)
        Controls.Add(IA)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(IKQ)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Giải Phương Trình"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IKQ As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents IA As TextBox
    Friend WithEvents IB As TextBox
    Friend WithEvents IC As TextBox
    Friend WithEvents bXoa As Button

End Class
