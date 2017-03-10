Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ProductosViewControl
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductosViewControl))
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.ComboBox_Categoria = New System.Windows.Forms.ComboBox()
            Me.CategoriaDTOBindingSource = New System.Windows.Forms.BindingSource()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.ProductosControl1 = New ARIAKA.SMARTGOURMET.Win.Controls.ProductosControl()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.CategoriaDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 6
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.07031!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.8125!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.11719!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.SimpleButton2, 5, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl2, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl3, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl4, 2, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl5, 4, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 3, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 3, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.MaskedTextBox1, 5, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.SimpleButton1, 4, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_Categoria, 1, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
            Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(837, 86)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'SimpleButton2
            '
            Me.SimpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
            Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton2.Location = New System.Drawing.Point(674, 2)
            Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(2)
            Me.SimpleButton2.Name = "SimpleButton2"
            Me.SimpleButton2.Size = New System.Drawing.Size(98, 39)
            Me.SimpleButton2.TabIndex = 11
            Me.SimpleButton2.Text = "Eliminar"
            '
            'LabelControl1
            '
            Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl1.Location = New System.Drawing.Point(70, 12)
            Me.LabelControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(51, 18)
            Me.LabelControl1.TabIndex = 0
            Me.LabelControl1.Text = "Codigo"
            '
            'LabelControl2
            '
            Me.LabelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl2.Location = New System.Drawing.Point(48, 55)
            Me.LabelControl2.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl2.Name = "LabelControl2"
            Me.LabelControl2.Size = New System.Drawing.Size(73, 18)
            Me.LabelControl2.TabIndex = 1
            Me.LabelControl2.Text = "Categoria"
            '
            'LabelControl3
            '
            Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl3.Location = New System.Drawing.Point(358, 12)
            Me.LabelControl3.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl3.Name = "LabelControl3"
            Me.LabelControl3.Size = New System.Drawing.Size(59, 18)
            Me.LabelControl3.TabIndex = 2
            Me.LabelControl3.Text = "Nombre"
            '
            'LabelControl4
            '
            Me.LabelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl4.Location = New System.Drawing.Point(369, 55)
            Me.LabelControl4.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl4.Name = "LabelControl4"
            Me.LabelControl4.Size = New System.Drawing.Size(48, 18)
            Me.LabelControl4.TabIndex = 3
            Me.LabelControl4.Text = "Precio"
            '
            'LabelControl5
            '
            Me.LabelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl5.Location = New System.Drawing.Point(627, 55)
            Me.LabelControl5.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl5.Name = "LabelControl5"
            Me.LabelControl5.Size = New System.Drawing.Size(43, 18)
            Me.LabelControl5.TabIndex = 4
            Me.LabelControl5.Text = "Stock"
            '
            'TextBox1
            '
            Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.Location = New System.Drawing.Point(125, 9)
            Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(133, 24)
            Me.TextBox1.TabIndex = 5
            '
            'TextBox2
            '
            Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox2.Location = New System.Drawing.Point(421, 9)
            Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(133, 24)
            Me.TextBox2.TabIndex = 6
            '
            'TextBox3
            '
            Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox3.Location = New System.Drawing.Point(421, 52)
            Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(133, 24)
            Me.TextBox3.TabIndex = 7
            '
            'MaskedTextBox1
            '
            Me.MaskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MaskedTextBox1.Location = New System.Drawing.Point(674, 52)
            Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(2)
            Me.MaskedTextBox1.Name = "MaskedTextBox1"
            Me.MaskedTextBox1.Size = New System.Drawing.Size(133, 24)
            Me.MaskedTextBox1.TabIndex = 8
            '
            'SimpleButton1
            '
            Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
            Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton1.Location = New System.Drawing.Point(572, 2)
            Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(2)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(98, 39)
            Me.SimpleButton1.TabIndex = 9
            Me.SimpleButton1.Text = "Guardar"
            '
            'ComboBox_Categoria
            '
            Me.ComboBox_Categoria.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.ComboBox_Categoria.DataSource = Me.CategoriaDTOBindingSource
            Me.ComboBox_Categoria.DisplayMember = "Nombre"
            Me.ComboBox_Categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ComboBox_Categoria.FormattingEnabled = True
            Me.ComboBox_Categoria.Location = New System.Drawing.Point(126, 51)
            Me.ComboBox_Categoria.Name = "ComboBox_Categoria"
            Me.ComboBox_Categoria.Size = New System.Drawing.Size(132, 26)
            Me.ComboBox_Categoria.TabIndex = 12
            Me.ComboBox_Categoria.ValueMember = "ID"
            '
            'CategoriaDTOBindingSource
            '
            Me.CategoriaDTOBindingSource.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.CategoriaDTO)
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.ProductosControl1, 0, 1)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 2
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(841, 458)
            Me.TableLayoutPanel2.TabIndex = 1
            '
            'ProductosControl1
            '
            Me.ProductosControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ProductosControl1.Location = New System.Drawing.Point(3, 93)
            Me.ProductosControl1.Name = "ProductosControl1"
            Me.ProductosControl1.Size = New System.Drawing.Size(835, 362)
            Me.ProductosControl1.TabIndex = 1
            '
            'ProductosViewControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel2)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "ProductosViewControl"
            Me.Size = New System.Drawing.Size(841, 458)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            CType(Me.CategoriaDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents TextBox1 As Windows.Forms.TextBox
        Friend WithEvents TextBox2 As Windows.Forms.TextBox
        Friend WithEvents TextBox3 As Windows.Forms.TextBox
        Friend WithEvents MaskedTextBox1 As Windows.Forms.MaskedTextBox
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents TableLayoutPanel2 As Windows.Forms.TableLayoutPanel
        Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents ProductosControl1 As ProductosControl
        Friend WithEvents ComboBox_Categoria As Windows.Forms.ComboBox
        Friend WithEvents CategoriaDTOBindingSource As Windows.Forms.BindingSource
    End Class
End Namespace