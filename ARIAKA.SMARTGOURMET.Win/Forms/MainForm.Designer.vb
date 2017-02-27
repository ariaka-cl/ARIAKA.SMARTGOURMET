Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainForm
        Inherits DevExpress.XtraEditors.XtraForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.DefaultLookAndFeel_Main = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.TableLayoutPanel_Main = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
            Me.TableLayoutPanel_Dash = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel_Main.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'DefaultLookAndFeel_Main
            '
            Me.DefaultLookAndFeel_Main.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
            Me.DefaultLookAndFeel_Main.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
            '
            'TableLayoutPanel_Main
            '
            Me.TableLayoutPanel_Main.BackColor = System.Drawing.Color.Gainsboro
            Me.TableLayoutPanel_Main.ColumnCount = 2
            Me.TableLayoutPanel_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.4605!))
            Me.TableLayoutPanel_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.5395!))
            Me.TableLayoutPanel_Main.Controls.Add(Me.TableLayoutPanel1, 0, 1)
            Me.TableLayoutPanel_Main.Controls.Add(Me.TableLayoutPanel_Dash, 1, 1)
            Me.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Main.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main"
            Me.TableLayoutPanel_Main.RowCount = 2
            Me.TableLayoutPanel_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.77379!))
            Me.TableLayoutPanel_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.22621!))
            Me.TableLayoutPanel_Main.Size = New System.Drawing.Size(1038, 557)
            Me.TableLayoutPanel_Main.TabIndex = 0
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.SimpleButton1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.SimpleButton2, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.SimpleButton3, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.SimpleButton4, 0, 3)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 102)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 4
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 313)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'SimpleButton1
            '
            Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton1.Appearance.Options.UseFont = True
            Me.SimpleButton1.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.SimpleButton1.AppearanceHovered.Options.UseBackColor = True
            Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
            Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton1.Location = New System.Drawing.Point(3, 3)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(189, 72)
            Me.SimpleButton1.TabIndex = 0
            Me.SimpleButton1.Text = "Mesas"
            '
            'SimpleButton2
            '
            Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton2.Appearance.Options.UseFont = True
            Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
            Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton2.Location = New System.Drawing.Point(3, 81)
            Me.SimpleButton2.Name = "SimpleButton2"
            Me.SimpleButton2.Size = New System.Drawing.Size(189, 72)
            Me.SimpleButton2.TabIndex = 1
            Me.SimpleButton2.Text = "Productos"
            '
            'SimpleButton3
            '
            Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton3.Appearance.Options.UseFont = True
            Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
            Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton3.Location = New System.Drawing.Point(3, 159)
            Me.SimpleButton3.Name = "SimpleButton3"
            Me.SimpleButton3.Size = New System.Drawing.Size(189, 72)
            Me.SimpleButton3.TabIndex = 2
            Me.SimpleButton3.Text = "Categoria"
            '
            'SimpleButton4
            '
            Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton4.Appearance.Options.UseFont = True
            Me.SimpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
            Me.SimpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton4.Location = New System.Drawing.Point(3, 237)
            Me.SimpleButton4.Name = "SimpleButton4"
            Me.SimpleButton4.Size = New System.Drawing.Size(189, 73)
            Me.SimpleButton4.TabIndex = 3
            Me.SimpleButton4.Text = "Usuarios"
            '
            'TableLayoutPanel_Dash
            '
            Me.TableLayoutPanel_Dash.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TableLayoutPanel_Dash.ColumnCount = 1
            Me.TableLayoutPanel_Dash.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Dash.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Dash.Location = New System.Drawing.Point(204, 102)
            Me.TableLayoutPanel_Dash.Name = "TableLayoutPanel_Dash"
            Me.TableLayoutPanel_Dash.RowCount = 1
            Me.TableLayoutPanel_Dash.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Dash.Size = New System.Drawing.Size(831, 452)
            Me.TableLayoutPanel_Dash.TabIndex = 1
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1038, 557)
            Me.Controls.Add(Me.TableLayoutPanel_Main)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
            Me.Name = "MainForm"
            Me.Text = "Smart Gourtmet"
            Me.TableLayoutPanel_Main.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents DefaultLookAndFeel_Main As DevExpress.LookAndFeel.DefaultLookAndFeel
        Friend WithEvents TableLayoutPanel_Main As Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents TableLayoutPanel_Dash As Windows.Forms.TableLayoutPanel
    End Class
End Namespace