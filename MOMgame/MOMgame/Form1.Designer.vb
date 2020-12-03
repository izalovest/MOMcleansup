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
        Me.couch = New System.Windows.Forms.PictureBox()
        Me.mom = New System.Windows.Forms.PictureBox()
        CType(Me.couch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'couch
        '
        Me.couch.BackColor = System.Drawing.Color.Transparent
        Me.couch.Image = CType(resources.GetObject("couch.Image"), System.Drawing.Image)
        Me.couch.Location = New System.Drawing.Point(370, 180)
        Me.couch.Name = "couch"
        Me.couch.Size = New System.Drawing.Size(253, 122)
        Me.couch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.couch.TabIndex = 1
        Me.couch.TabStop = False
        '
        'mom
        '
        Me.mom.BackColor = System.Drawing.Color.Transparent
        Me.mom.Image = Global.MOMgame.My.Resources.Resources.Mom_character
        Me.mom.Location = New System.Drawing.Point(614, 153)
        Me.mom.Name = "mom"
        Me.mom.Size = New System.Drawing.Size(100, 217)
        Me.mom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mom.TabIndex = 2
        Me.mom.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MOMgame.My.Resources.Resources.room
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mom)
        Me.Controls.Add(Me.couch)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.couch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents couch As PictureBox
    Friend WithEvents mom As PictureBox
End Class
