Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class PersonalViewControl
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonalViewControl))
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.LabelControl_Rut = New DevExpress.XtraEditors.LabelControl()
            Me.SimpleButton_Guardar = New DevExpress.XtraEditors.SimpleButton()
            Me.LabelControl_Nombre = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl_Pass = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl_Rol = New DevExpress.XtraEditors.LabelControl()
            Me.TextEdit_Rut = New DevExpress.XtraEditors.TextEdit()
            Me.TextEdit_UserName = New DevExpress.XtraEditors.TextEdit()
            Me.TextEdit_Nombre = New DevExpress.XtraEditors.TextEdit()
            Me.TextEdit_Pass = New DevExpress.XtraEditors.TextEdit()
            Me.LabelControl_Usuario = New DevExpress.XtraEditors.LabelControl()
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.ComboBox_Rol = New System.Windows.Forms.ComboBox()
            Me.RolDTOBindingSource = New System.Windows.Forms.BindingSource()
            Me.PersonalControl1 = New ARIAKA.SMARTGOURMET.Win.Controls.PersonalControl()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            CType(Me.TextEdit_Rut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_UserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Pass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RolDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.PersonalControl1, 0, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.18126!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.81874!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(848, 423)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.ColumnCount = 6
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel2.Controls.Add(Me.LabelControl_Rut, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.SimpleButton_Guardar, 4, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.LabelControl_Nombre, 2, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.LabelControl_Pass, 2, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.LabelControl_Rol, 4, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.TextEdit_Rut, 1, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.TextEdit_UserName, 1, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.TextEdit_Nombre, 3, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.TextEdit_Pass, 3, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.LabelControl_Usuario, 0, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.SimpleButton1, 5, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.ComboBox_Rol, 5, 1)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 2)
            Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 2
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(844, 85)
            Me.TableLayoutPanel2.TabIndex = 0
            '
            'LabelControl_Rut
            '
            Me.LabelControl_Rut.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Rut.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Rut.Location = New System.Drawing.Point(109, 11)
            Me.LabelControl_Rut.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl_Rut.Name = "LabelControl_Rut"
            Me.LabelControl_Rut.Size = New System.Drawing.Size(29, 19)
            Me.LabelControl_Rut.TabIndex = 0
            Me.LabelControl_Rut.Text = "Rut"
            '
            'SimpleButton_Guardar
            '
            Me.SimpleButton_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.SimpleButton_Guardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Guardar.Image = CType(resources.GetObject("SimpleButton_Guardar.Image"), System.Drawing.Image)
            Me.SimpleButton_Guardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Guardar.Location = New System.Drawing.Point(600, 2)
            Me.SimpleButton_Guardar.Margin = New System.Windows.Forms.Padding(2)
            Me.SimpleButton_Guardar.Name = "SimpleButton_Guardar"
            Me.SimpleButton_Guardar.Size = New System.Drawing.Size(98, 38)
            Me.SimpleButton_Guardar.TabIndex = 5
            Me.SimpleButton_Guardar.Text = "Guardar"
            '
            'LabelControl_Nombre
            '
            Me.LabelControl_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Nombre.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Nombre.Location = New System.Drawing.Point(354, 11)
            Me.LabelControl_Nombre.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl_Nombre.Name = "LabelControl_Nombre"
            Me.LabelControl_Nombre.Size = New System.Drawing.Size(64, 19)
            Me.LabelControl_Nombre.TabIndex = 2
            Me.LabelControl_Nombre.Text = "Nombre"
            '
            'LabelControl_Pass
            '
            Me.LabelControl_Pass.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Pass.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Pass.Location = New System.Drawing.Point(325, 54)
            Me.LabelControl_Pass.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl_Pass.Name = "LabelControl_Pass"
            Me.LabelControl_Pass.Size = New System.Drawing.Size(93, 19)
            Me.LabelControl_Pass.TabIndex = 3
            Me.LabelControl_Pass.Text = "Contraseña"
            '
            'LabelControl_Rol
            '
            Me.LabelControl_Rol.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Rol.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Rol.Location = New System.Drawing.Point(671, 54)
            Me.LabelControl_Rol.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl_Rol.Name = "LabelControl_Rol"
            Me.LabelControl_Rol.Size = New System.Drawing.Size(27, 19)
            Me.LabelControl_Rol.TabIndex = 4
            Me.LabelControl_Rol.Text = "Rol"
            '
            'TextEdit_Rut
            '
            Me.TextEdit_Rut.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextEdit_Rut.Location = New System.Drawing.Point(142, 8)
            Me.TextEdit_Rut.Margin = New System.Windows.Forms.Padding(2)
            Me.TextEdit_Rut.Name = "TextEdit_Rut"
            Me.TextEdit_Rut.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextEdit_Rut.Properties.Appearance.Options.UseFont = True
            Me.TextEdit_Rut.Size = New System.Drawing.Size(133, 26)
            Me.TextEdit_Rut.TabIndex = 0
            '
            'TextEdit_UserName
            '
            Me.TextEdit_UserName.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextEdit_UserName.Location = New System.Drawing.Point(142, 50)
            Me.TextEdit_UserName.Margin = New System.Windows.Forms.Padding(2)
            Me.TextEdit_UserName.Name = "TextEdit_UserName"
            Me.TextEdit_UserName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextEdit_UserName.Properties.Appearance.Options.UseFont = True
            Me.TextEdit_UserName.Size = New System.Drawing.Size(133, 26)
            Me.TextEdit_UserName.TabIndex = 2
            '
            'TextEdit_Nombre
            '
            Me.TextEdit_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextEdit_Nombre.Location = New System.Drawing.Point(422, 8)
            Me.TextEdit_Nombre.Margin = New System.Windows.Forms.Padding(2)
            Me.TextEdit_Nombre.Name = "TextEdit_Nombre"
            Me.TextEdit_Nombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextEdit_Nombre.Properties.Appearance.Options.UseFont = True
            Me.TextEdit_Nombre.Size = New System.Drawing.Size(133, 26)
            Me.TextEdit_Nombre.TabIndex = 1
            '
            'TextEdit_Pass
            '
            Me.TextEdit_Pass.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextEdit_Pass.Location = New System.Drawing.Point(422, 50)
            Me.TextEdit_Pass.Margin = New System.Windows.Forms.Padding(2)
            Me.TextEdit_Pass.Name = "TextEdit_Pass"
            Me.TextEdit_Pass.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextEdit_Pass.Properties.Appearance.Options.UseFont = True
            Me.TextEdit_Pass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.TextEdit_Pass.Size = New System.Drawing.Size(133, 26)
            Me.TextEdit_Pass.TabIndex = 3
            '
            'LabelControl_Usuario
            '
            Me.LabelControl_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Usuario.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Usuario.Location = New System.Drawing.Point(76, 54)
            Me.LabelControl_Usuario.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl_Usuario.Name = "LabelControl_Usuario"
            Me.LabelControl_Usuario.Size = New System.Drawing.Size(62, 19)
            Me.LabelControl_Usuario.TabIndex = 1
            Me.LabelControl_Usuario.Text = "Usuario"
            '
            'SimpleButton1
            '
            Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
            Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton1.Location = New System.Drawing.Point(702, 3)
            Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(2)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(98, 36)
            Me.SimpleButton1.TabIndex = 6
            Me.SimpleButton1.Text = "Eliminar"
            '
            'ComboBox_Rol
            '
            Me.ComboBox_Rol.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.ComboBox_Rol.DataSource = Me.RolDTOBindingSource
            Me.ComboBox_Rol.DisplayMember = "Nombre"
            Me.ComboBox_Rol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ComboBox_Rol.FormattingEnabled = True
            Me.ComboBox_Rol.Location = New System.Drawing.Point(703, 49)
            Me.ComboBox_Rol.Name = "ComboBox_Rol"
            Me.ComboBox_Rol.Size = New System.Drawing.Size(133, 28)
            Me.ComboBox_Rol.TabIndex = 4
            Me.ComboBox_Rol.ValueMember = "ID"
            '
            'RolDTOBindingSource
            '
            Me.RolDTOBindingSource.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.RolDTO)
            '
            'PersonalControl1
            '
            Me.PersonalControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PersonalControl1.Location = New System.Drawing.Point(2, 91)
            Me.PersonalControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.PersonalControl1.Name = "PersonalControl1"
            Me.PersonalControl1.Size = New System.Drawing.Size(844, 330)
            Me.PersonalControl1.TabIndex = 1
            '
            'PersonalViewControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "PersonalViewControl"
            Me.Size = New System.Drawing.Size(848, 423)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel2.PerformLayout()
            CType(Me.TextEdit_Rut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_UserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Pass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RolDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel2 As Windows.Forms.TableLayoutPanel
        Friend WithEvents LabelControl_Rut As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Usuario As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Nombre As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Pass As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Rol As DevExpress.XtraEditors.LabelControl
        Friend WithEvents TextEdit_Rut As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TextEdit_UserName As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TextEdit_Nombre As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TextEdit_Pass As DevExpress.XtraEditors.TextEdit
        Friend WithEvents SimpleButton_Guardar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents ComboBox_Rol As Windows.Forms.ComboBox
        Friend WithEvents RolDTOBindingSource As Windows.Forms.BindingSource
        Friend WithEvents PersonalControl1 As PersonalControl
    End Class
End Namespace