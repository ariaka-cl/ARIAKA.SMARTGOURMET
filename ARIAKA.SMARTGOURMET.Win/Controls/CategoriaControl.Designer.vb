Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CategoriaControl
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
            Me.TableLayoutPanel_ContenedorGrid = New System.Windows.Forms.TableLayoutPanel()
            Me.GridControl_Categoria = New DevExpress.XtraGrid.GridControl()
            Me.CategoriaDTOBindingSource = New System.Windows.Forms.BindingSource()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TableLayoutPanel_ContenedorGrid.SuspendLayout()
            CType(Me.GridControl_Categoria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CategoriaDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel_ContenedorGrid
            '
            Me.TableLayoutPanel_ContenedorGrid.ColumnCount = 1
            Me.TableLayoutPanel_ContenedorGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_ContenedorGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel_ContenedorGrid.Controls.Add(Me.GridControl_Categoria, 0, 0)
            Me.TableLayoutPanel_ContenedorGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_ContenedorGrid.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_ContenedorGrid.Name = "TableLayoutPanel_ContenedorGrid"
            Me.TableLayoutPanel_ContenedorGrid.RowCount = 1
            Me.TableLayoutPanel_ContenedorGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_ContenedorGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel_ContenedorGrid.Size = New System.Drawing.Size(501, 269)
            Me.TableLayoutPanel_ContenedorGrid.TabIndex = 0
            '
            'GridControl_Categoria
            '
            Me.GridControl_Categoria.DataSource = Me.CategoriaDTOBindingSource
            Me.GridControl_Categoria.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_Categoria.Location = New System.Drawing.Point(3, 3)
            Me.GridControl_Categoria.MainView = Me.GridView1
            Me.GridControl_Categoria.Name = "GridControl_Categoria"
            Me.GridControl_Categoria.Size = New System.Drawing.Size(495, 263)
            Me.GridControl_Categoria.TabIndex = 0
            Me.GridControl_Categoria.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
            '
            'CategoriaDTOBindingSource
            '
            Me.CategoriaDTOBindingSource.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.CategoriaDTO)
            '
            'GridView1
            '
            Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNombre})
            Me.GridView1.GridControl = Me.GridControl_Categoria
            Me.GridView1.Name = "GridView1"
            Me.GridView1.OptionsBehavior.Editable = False
            Me.GridView1.OptionsView.ShowGroupPanel = False
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            Me.colID.Width = 30
            '
            'colNombre
            '
            Me.colNombre.FieldName = "Nombre"
            Me.colNombre.Name = "colNombre"
            Me.colNombre.Visible = True
            Me.colNombre.VisibleIndex = 1
            Me.colNombre.Width = 447
            '
            'CategoriaControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel_ContenedorGrid)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "CategoriaControl"
            Me.Size = New System.Drawing.Size(501, 269)
            Me.TableLayoutPanel_ContenedorGrid.ResumeLayout(False)
            CType(Me.GridControl_Categoria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CategoriaDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel_ContenedorGrid As Windows.Forms.TableLayoutPanel
        Friend WithEvents GridControl_Categoria As DevExpress.XtraGrid.GridControl
        Friend WithEvents CategoriaDTOBindingSource As Windows.Forms.BindingSource
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace