Imports ARIAKA.SMARTGOURMET.Win.Controls
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.DefaultLookAndFeel_Main = New DevExpress.LookAndFeel.DefaultLookAndFeel()
            Me.TableLayoutPanel_Main = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel_Dash = New System.Windows.Forms.TableLayoutPanel()
            Me.PictureBox_HomeImage = New System.Windows.Forms.PictureBox()
            Me.TableLayoutPanel_Header = New System.Windows.Forms.TableLayoutPanel()
            Me.SimpleButton_AddTable = New DevExpress.XtraEditors.SimpleButton()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.TableLayoutPanel_LeftMenu = New System.Windows.Forms.TableLayoutPanel()
            Me.SimpleButton_Mesas = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton_Productos = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton_Categorias = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton_Usuarios = New DevExpress.XtraEditors.SimpleButton()
            Me.TableLayoutPanel_Main.SuspendLayout()
            Me.TableLayoutPanel_Dash.SuspendLayout()
            CType(Me.PictureBox_HomeImage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel_Header.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel_LeftMenu.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel_Main
            '
            Me.TableLayoutPanel_Main.BackColor = System.Drawing.Color.Gainsboro
            Me.TableLayoutPanel_Main.ColumnCount = 2
            Me.TableLayoutPanel_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.4605!))
            Me.TableLayoutPanel_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.5395!))
            Me.TableLayoutPanel_Main.Controls.Add(Me.TableLayoutPanel_Dash, 1, 1)
            Me.TableLayoutPanel_Main.Controls.Add(Me.TableLayoutPanel_Header, 1, 0)
            Me.TableLayoutPanel_Main.Controls.Add(Me.PictureBox1, 0, 0)
            Me.TableLayoutPanel_Main.Controls.Add(Me.TableLayoutPanel_LeftMenu, 0, 1)
            Me.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Main.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main"
            Me.TableLayoutPanel_Main.RowCount = 2
            Me.TableLayoutPanel_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.77379!))
            Me.TableLayoutPanel_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.22621!))
            Me.TableLayoutPanel_Main.Size = New System.Drawing.Size(1053, 651)
            Me.TableLayoutPanel_Main.TabIndex = 0
            '
            'TableLayoutPanel_Dash
            '
            Me.TableLayoutPanel_Dash.AutoSize = True
            Me.TableLayoutPanel_Dash.BackColor = System.Drawing.SystemColors.Control
            Me.TableLayoutPanel_Dash.ColumnCount = 1
            Me.TableLayoutPanel_Dash.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Dash.Controls.Add(Me.PictureBox_HomeImage, 0, 0)
            Me.TableLayoutPanel_Dash.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Dash.Location = New System.Drawing.Point(207, 118)
            Me.TableLayoutPanel_Dash.Name = "TableLayoutPanel_Dash"
            Me.TableLayoutPanel_Dash.RowCount = 1
            Me.TableLayoutPanel_Dash.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Dash.Size = New System.Drawing.Size(843, 530)
            Me.TableLayoutPanel_Dash.TabIndex = 1
            '
            'PictureBox_HomeImage
            '
            Me.PictureBox_HomeImage.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox_HomeImage.Image = CType(resources.GetObject("PictureBox_HomeImage.Image"), System.Drawing.Image)
            Me.PictureBox_HomeImage.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox_HomeImage.Name = "PictureBox_HomeImage"
            Me.PictureBox_HomeImage.Size = New System.Drawing.Size(837, 524)
            Me.PictureBox_HomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox_HomeImage.TabIndex = 0
            Me.PictureBox_HomeImage.TabStop = False
            '
            'TableLayoutPanel_Header
            '
            Me.TableLayoutPanel_Header.ColumnCount = 2
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Header.Controls.Add(Me.SimpleButton_AddTable, 0, 0)
            Me.TableLayoutPanel_Header.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Header.Location = New System.Drawing.Point(207, 3)
            Me.TableLayoutPanel_Header.Name = "TableLayoutPanel_Header"
            Me.TableLayoutPanel_Header.RowCount = 1
            Me.TableLayoutPanel_Header.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Header.Size = New System.Drawing.Size(843, 109)
            Me.TableLayoutPanel_Header.TabIndex = 2
            '
            'SimpleButton_AddTable
            '
            Me.SimpleButton_AddTable.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.SimpleButton_AddTable.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_AddTable.Appearance.Options.UseFont = True
            Me.SimpleButton_AddTable.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.SimpleButton_AddTable.AppearanceHovered.Options.UseBackColor = True
            Me.SimpleButton_AddTable.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_AddTable.Image = CType(resources.GetObject("SimpleButton_AddTable.Image"), System.Drawing.Image)
            Me.SimpleButton_AddTable.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_AddTable.Location = New System.Drawing.Point(26, 24)
            Me.SimpleButton_AddTable.Name = "SimpleButton_AddTable"
            Me.SimpleButton_AddTable.Size = New System.Drawing.Size(94, 60)
            Me.SimpleButton_AddTable.TabIndex = 0
            Me.SimpleButton_AddTable.Text = "Mesa"
            '
            'PictureBox1
            '
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(198, 109)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 3
            Me.PictureBox1.TabStop = False
            '
            'TableLayoutPanel_LeftMenu
            '
            Me.TableLayoutPanel_LeftMenu.ColumnCount = 1
            Me.TableLayoutPanel_LeftMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_LeftMenu.Controls.Add(Me.SimpleButton_Mesas, 0, 0)
            Me.TableLayoutPanel_LeftMenu.Controls.Add(Me.SimpleButton_Productos, 0, 1)
            Me.TableLayoutPanel_LeftMenu.Controls.Add(Me.SimpleButton_Categorias, 0, 2)
            Me.TableLayoutPanel_LeftMenu.Controls.Add(Me.SimpleButton_Usuarios, 0, 3)
            Me.TableLayoutPanel_LeftMenu.Dock = System.Windows.Forms.DockStyle.Top
            Me.TableLayoutPanel_LeftMenu.Location = New System.Drawing.Point(3, 118)
            Me.TableLayoutPanel_LeftMenu.Name = "TableLayoutPanel_LeftMenu"
            Me.TableLayoutPanel_LeftMenu.RowCount = 4
            Me.TableLayoutPanel_LeftMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
            Me.TableLayoutPanel_LeftMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
            Me.TableLayoutPanel_LeftMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
            Me.TableLayoutPanel_LeftMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
            Me.TableLayoutPanel_LeftMenu.Size = New System.Drawing.Size(198, 313)
            Me.TableLayoutPanel_LeftMenu.TabIndex = 0
            '
            'SimpleButton_Mesas
            '
            Me.SimpleButton_Mesas.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Mesas.Appearance.Options.UseFont = True
            Me.SimpleButton_Mesas.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.SimpleButton_Mesas.AppearanceHovered.Options.UseBackColor = True
            Me.SimpleButton_Mesas.AutoSize = True
            Me.SimpleButton_Mesas.AutoWidthInLayoutControl = True
            Me.SimpleButton_Mesas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Mesas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleButton_Mesas.Image = CType(resources.GetObject("SimpleButton_Mesas.Image"), System.Drawing.Image)
            Me.SimpleButton_Mesas.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Mesas.Location = New System.Drawing.Point(3, 3)
            Me.SimpleButton_Mesas.Name = "SimpleButton_Mesas"
            Me.SimpleButton_Mesas.Size = New System.Drawing.Size(192, 72)
            Me.SimpleButton_Mesas.TabIndex = 0
            Me.SimpleButton_Mesas.Text = "Mesas"
            '
            'SimpleButton_Productos
            '
            Me.SimpleButton_Productos.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Productos.Appearance.Options.UseFont = True
            Me.SimpleButton_Productos.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.SimpleButton_Productos.AppearanceHovered.Options.UseBackColor = True
            Me.SimpleButton_Productos.AutoSize = True
            Me.SimpleButton_Productos.AutoWidthInLayoutControl = True
            Me.SimpleButton_Productos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Productos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleButton_Productos.Image = CType(resources.GetObject("SimpleButton_Productos.Image"), System.Drawing.Image)
            Me.SimpleButton_Productos.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Productos.Location = New System.Drawing.Point(3, 81)
            Me.SimpleButton_Productos.Name = "SimpleButton_Productos"
            Me.SimpleButton_Productos.Size = New System.Drawing.Size(192, 72)
            Me.SimpleButton_Productos.TabIndex = 1
            Me.SimpleButton_Productos.Text = "Productos"
            '
            'SimpleButton_Categorias
            '
            Me.SimpleButton_Categorias.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Categorias.Appearance.Options.UseFont = True
            Me.SimpleButton_Categorias.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.SimpleButton_Categorias.AppearanceHovered.Options.UseBackColor = True
            Me.SimpleButton_Categorias.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Categorias.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleButton_Categorias.Image = CType(resources.GetObject("SimpleButton_Categorias.Image"), System.Drawing.Image)
            Me.SimpleButton_Categorias.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Categorias.Location = New System.Drawing.Point(3, 159)
            Me.SimpleButton_Categorias.Name = "SimpleButton_Categorias"
            Me.SimpleButton_Categorias.Size = New System.Drawing.Size(192, 72)
            Me.SimpleButton_Categorias.TabIndex = 2
            Me.SimpleButton_Categorias.Text = "Categoria"
            '
            'SimpleButton_Usuarios
            '
            Me.SimpleButton_Usuarios.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Usuarios.Appearance.Options.UseFont = True
            Me.SimpleButton_Usuarios.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleButton_Usuarios.Image = CType(resources.GetObject("SimpleButton_Usuarios.Image"), System.Drawing.Image)
            Me.SimpleButton_Usuarios.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Usuarios.Location = New System.Drawing.Point(3, 237)
            Me.SimpleButton_Usuarios.Name = "SimpleButton_Usuarios"
            Me.SimpleButton_Usuarios.Size = New System.Drawing.Size(192, 73)
            Me.SimpleButton_Usuarios.TabIndex = 3
            Me.SimpleButton_Usuarios.Text = "Usuarios"
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1053, 651)
            Me.Controls.Add(Me.TableLayoutPanel_Main)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
            Me.Name = "MainForm"
            Me.Text = "Smart Gourtmet"
            Me.TableLayoutPanel_Main.ResumeLayout(False)
            Me.TableLayoutPanel_Main.PerformLayout()
            Me.TableLayoutPanel_Dash.ResumeLayout(False)
            CType(Me.PictureBox_HomeImage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel_Header.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel_LeftMenu.ResumeLayout(False)
            Me.TableLayoutPanel_LeftMenu.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents DefaultLookAndFeel_Main As DevExpress.LookAndFeel.DefaultLookAndFeel
        Friend WithEvents TableLayoutPanel_Main As Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel_LeftMenu As Windows.Forms.TableLayoutPanel
        Friend WithEvents SimpleButton_Mesas As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton_Productos As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton_Categorias As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton_Usuarios As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents TableLayoutPanel_Dash As Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel_Header As Windows.Forms.TableLayoutPanel
        Friend WithEvents SimpleButton_AddTable As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
        Friend WithEvents PictureBox_HomeImage As Windows.Forms.PictureBox
    End Class
End Namespace