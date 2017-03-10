Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CategoriaViewControl
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoriaViewControl))
            Me.TableLayoutPanel_Container = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel_Container_Grid = New System.Windows.Forms.TableLayoutPanel()
            Me.SimpleButton_Eliminar = New DevExpress.XtraEditors.SimpleButton()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.TextEdit_Nombre = New DevExpress.XtraEditors.TextEdit()
            Me.SimpleButton_Guardar = New DevExpress.XtraEditors.SimpleButton()
            Me.CategoriaControl = New ARIAKA.SMARTGOURMET.Win.Controls.CategoriaControl()
            Me.TableLayoutPanel_Container.SuspendLayout()
            Me.TableLayoutPanel_Container_Grid.SuspendLayout()
            CType(Me.TextEdit_Nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel_Container
            '
            Me.TableLayoutPanel_Container.ColumnCount = 1
            Me.TableLayoutPanel_Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Container.Controls.Add(Me.TableLayoutPanel_Container_Grid, 0, 0)
            Me.TableLayoutPanel_Container.Controls.Add(Me.CategoriaControl, 0, 1)
            Me.TableLayoutPanel_Container.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Container.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_Container.Margin = New System.Windows.Forms.Padding(2)
            Me.TableLayoutPanel_Container.Name = "TableLayoutPanel_Container"
            Me.TableLayoutPanel_Container.RowCount = 2
            Me.TableLayoutPanel_Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
            Me.TableLayoutPanel_Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Container.Size = New System.Drawing.Size(766, 443)
            Me.TableLayoutPanel_Container.TabIndex = 0
            '
            'TableLayoutPanel_Container_Grid
            '
            Me.TableLayoutPanel_Container_Grid.ColumnCount = 4
            Me.TableLayoutPanel_Container_Grid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.25!))
            Me.TableLayoutPanel_Container_Grid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.75!))
            Me.TableLayoutPanel_Container_Grid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
            Me.TableLayoutPanel_Container_Grid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139.0!))
            Me.TableLayoutPanel_Container_Grid.Controls.Add(Me.SimpleButton_Eliminar, 3, 0)
            Me.TableLayoutPanel_Container_Grid.Controls.Add(Me.LabelControl1, 0, 0)
            Me.TableLayoutPanel_Container_Grid.Controls.Add(Me.TextEdit_Nombre, 1, 0)
            Me.TableLayoutPanel_Container_Grid.Controls.Add(Me.SimpleButton_Guardar, 2, 0)
            Me.TableLayoutPanel_Container_Grid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Container_Grid.Location = New System.Drawing.Point(2, 2)
            Me.TableLayoutPanel_Container_Grid.Margin = New System.Windows.Forms.Padding(2)
            Me.TableLayoutPanel_Container_Grid.Name = "TableLayoutPanel_Container_Grid"
            Me.TableLayoutPanel_Container_Grid.RowCount = 1
            Me.TableLayoutPanel_Container_Grid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Container_Grid.Size = New System.Drawing.Size(762, 56)
            Me.TableLayoutPanel_Container_Grid.TabIndex = 0
            '
            'SimpleButton_Eliminar
            '
            Me.SimpleButton_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.SimpleButton_Eliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Eliminar.Appearance.Options.UseFont = True
            Me.SimpleButton_Eliminar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Eliminar.Image = CType(resources.GetObject("SimpleButton_Eliminar.Image"), System.Drawing.Image)
            Me.SimpleButton_Eliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
            Me.SimpleButton_Eliminar.Location = New System.Drawing.Point(624, 7)
            Me.SimpleButton_Eliminar.Margin = New System.Windows.Forms.Padding(2)
            Me.SimpleButton_Eliminar.Name = "SimpleButton_Eliminar"
            Me.SimpleButton_Eliminar.Size = New System.Drawing.Size(109, 42)
            Me.SimpleButton_Eliminar.TabIndex = 3
            Me.SimpleButton_Eliminar.Text = "Eliminar"
            '
            'LabelControl1
            '
            Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl1.Location = New System.Drawing.Point(74, 19)
            Me.LabelControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(59, 18)
            Me.LabelControl1.TabIndex = 0
            Me.LabelControl1.Text = "Nombre"
            '
            'TextEdit_Nombre
            '
            Me.TextEdit_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextEdit_Nombre.Location = New System.Drawing.Point(137, 16)
            Me.TextEdit_Nombre.Margin = New System.Windows.Forms.Padding(2)
            Me.TextEdit_Nombre.Name = "TextEdit_Nombre"
            Me.TextEdit_Nombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextEdit_Nombre.Properties.Appearance.Options.UseFont = True
            Me.TextEdit_Nombre.Size = New System.Drawing.Size(167, 24)
            Me.TextEdit_Nombre.TabIndex = 1
            '
            'SimpleButton_Guardar
            '
            Me.SimpleButton_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.SimpleButton_Guardar.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Guardar.Appearance.Options.UseFont = True
            Me.SimpleButton_Guardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Guardar.Image = CType(resources.GetObject("SimpleButton_Guardar.Image"), System.Drawing.Image)
            Me.SimpleButton_Guardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
            Me.SimpleButton_Guardar.Location = New System.Drawing.Point(498, 7)
            Me.SimpleButton_Guardar.Margin = New System.Windows.Forms.Padding(2)
            Me.SimpleButton_Guardar.Name = "SimpleButton_Guardar"
            Me.SimpleButton_Guardar.Size = New System.Drawing.Size(109, 42)
            Me.SimpleButton_Guardar.TabIndex = 2
            Me.SimpleButton_Guardar.Text = "Guardar"
            '
            'CategoriaControl
            '
            Me.CategoriaControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CategoriaControl.Location = New System.Drawing.Point(2, 62)
            Me.CategoriaControl.Margin = New System.Windows.Forms.Padding(2)
            Me.CategoriaControl.Name = "CategoriaControl"
            Me.CategoriaControl.Size = New System.Drawing.Size(762, 379)
            Me.CategoriaControl.TabIndex = 1
            '
            'CategoriaViewControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel_Container)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "CategoriaViewControl"
            Me.Size = New System.Drawing.Size(766, 443)
            Me.TableLayoutPanel_Container.ResumeLayout(False)
            Me.TableLayoutPanel_Container_Grid.ResumeLayout(False)
            Me.TableLayoutPanel_Container_Grid.PerformLayout()
            CType(Me.TextEdit_Nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel_Container As Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel_Container_Grid As Windows.Forms.TableLayoutPanel
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents TextEdit_Nombre As DevExpress.XtraEditors.TextEdit
        Friend WithEvents SimpleButton_Guardar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton_Eliminar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents CategoriaControl As CategoriaControl
    End Class
End Namespace