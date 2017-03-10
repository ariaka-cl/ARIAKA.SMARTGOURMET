Namespace Controls
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenMesaGridControl
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.TableLayoutPanel_Contenedor = New System.Windows.Forms.TableLayoutPanel()
            Me.GridControl_ResumenMesa = New DevExpress.XtraGrid.GridControl()
            Me.MesaDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFechaCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotas = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUsuarioID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TableLayoutPanel_Contenedor.SuspendLayout()
            CType(Me.GridControl_ResumenMesa, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MesaDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel_Contenedor
            '
            Me.TableLayoutPanel_Contenedor.ColumnCount = 1
            Me.TableLayoutPanel_Contenedor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Contenedor.Controls.Add(Me.GridControl_ResumenMesa, 0, 0)
            Me.TableLayoutPanel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Contenedor.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_Contenedor.Name = "TableLayoutPanel_Contenedor"
            Me.TableLayoutPanel_Contenedor.RowCount = 1
            Me.TableLayoutPanel_Contenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Contenedor.Size = New System.Drawing.Size(853, 452)
            Me.TableLayoutPanel_Contenedor.TabIndex = 0
            '
            'GridControl_ResumenMesa
            '
            Me.GridControl_ResumenMesa.DataSource = Me.MesaDTOBindingSource
            Me.GridControl_ResumenMesa.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_ResumenMesa.Location = New System.Drawing.Point(3, 3)
            Me.GridControl_ResumenMesa.MainView = Me.CardView1
            Me.GridControl_ResumenMesa.Name = "GridControl_ResumenMesa"
            Me.GridControl_ResumenMesa.Size = New System.Drawing.Size(847, 446)
            Me.GridControl_ResumenMesa.TabIndex = 0
            Me.GridControl_ResumenMesa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CardView1})
            '
            'MesaDTOBindingSource
            '
            Me.MesaDTOBindingSource.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.MesaDTO)
            '
            'CardView1
            '
            Me.CardView1.Appearance.Card.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CardView1.Appearance.Card.Options.UseFont = True
            Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNumero, Me.colFechaCreacion, Me.colEstado, Me.colNotas, Me.colUsuarioID, Me.colUsuario})
            Me.CardView1.FocusedCardTopFieldIndex = 0
            Me.CardView1.GridControl = Me.GridControl_ResumenMesa
            Me.CardView1.Name = "CardView1"
            Me.CardView1.OptionsBehavior.Editable = False
            Me.CardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            '
            'colNumero
            '
            Me.colNumero.Caption = "Numero"
            Me.colNumero.FieldName = "Numero"
            Me.colNumero.Name = "colNumero"
            Me.colNumero.Visible = True
            Me.colNumero.VisibleIndex = 0
            '
            'colFechaCreacion
            '
            Me.colFechaCreacion.Caption = "Hora"
            Me.colFechaCreacion.DisplayFormat.FormatString = "HH:mm"
            Me.colFechaCreacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.colFechaCreacion.FieldName = "FechaCreacion"
            Me.colFechaCreacion.Name = "colFechaCreacion"
            Me.colFechaCreacion.Visible = True
            Me.colFechaCreacion.VisibleIndex = 1
            '
            'colEstado
            '
            Me.colEstado.FieldName = "Estado"
            Me.colEstado.Name = "colEstado"
            '
            'colNotas
            '
            Me.colNotas.FieldName = "Notas"
            Me.colNotas.Name = "colNotas"
            '
            'colUsuarioID
            '
            Me.colUsuarioID.FieldName = "UsuarioID"
            Me.colUsuarioID.Name = "colUsuarioID"
            '
            'colUsuario
            '
            Me.colUsuario.Caption = "Atiende"
            Me.colUsuario.FieldName = "Usuario.Nombre"
            Me.colUsuario.Name = "colUsuario"
            Me.colUsuario.Visible = True
            Me.colUsuario.VisibleIndex = 2
            '
            'ResumenMesaGridControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel_Contenedor)
            Me.Name = "ResumenMesaGridControl"
            Me.Size = New System.Drawing.Size(853, 452)
            Me.TableLayoutPanel_Contenedor.ResumeLayout(False)
            CType(Me.GridControl_ResumenMesa, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MesaDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel_Contenedor As Windows.Forms.TableLayoutPanel
    Friend WithEvents GridControl_ResumenMesa As DevExpress.XtraGrid.GridControl
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
        Friend WithEvents MesaDTOBindingSource As Windows.Forms.BindingSource
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFechaCreacion As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotas As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUsuarioID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
