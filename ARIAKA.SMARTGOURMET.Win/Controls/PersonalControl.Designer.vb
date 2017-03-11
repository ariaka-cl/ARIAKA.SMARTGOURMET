Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class PersonalControl
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
            Me.TableLayoutPanel_Container = New System.Windows.Forms.TableLayoutPanel()
            Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.UserDTOBindingSource = New System.Windows.Forms.BindingSource()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRun = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUserName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPassword = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFechaCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRolID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TableLayoutPanel_Container.SuspendLayout()
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UserDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel_Container
            '
            Me.TableLayoutPanel_Container.ColumnCount = 1
            Me.TableLayoutPanel_Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Container.Controls.Add(Me.GridControl1, 0, 0)
            Me.TableLayoutPanel_Container.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Container.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_Container.Name = "TableLayoutPanel_Container"
            Me.TableLayoutPanel_Container.RowCount = 1
            Me.TableLayoutPanel_Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Container.Size = New System.Drawing.Size(676, 361)
            Me.TableLayoutPanel_Container.TabIndex = 0
            '
            'GridControl1
            '
            Me.GridControl1.DataSource = Me.UserDTOBindingSource
            Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl1.Location = New System.Drawing.Point(3, 3)
            Me.GridControl1.MainView = Me.GridView1
            Me.GridControl1.Name = "GridControl1"
            Me.GridControl1.Size = New System.Drawing.Size(670, 355)
            Me.GridControl1.TabIndex = 0
            Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
            '
            'UserDTOBindingSource
            '
            Me.UserDTOBindingSource.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.UserDTO)
            '
            'GridView1
            '
            Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colRun, Me.colNombre, Me.colUserName, Me.colPassword, Me.colFechaCreacion, Me.colRolID})
            Me.GridView1.GridControl = Me.GridControl1
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
            'colRun
            '
            Me.colRun.FieldName = "Run"
            Me.colRun.Name = "colRun"
            Me.colRun.Visible = True
            Me.colRun.VisibleIndex = 1
            Me.colRun.Width = 103
            '
            'colNombre
            '
            Me.colNombre.FieldName = "Nombre"
            Me.colNombre.Name = "colNombre"
            Me.colNombre.Visible = True
            Me.colNombre.VisibleIndex = 2
            Me.colNombre.Width = 103
            '
            'colUserName
            '
            Me.colUserName.FieldName = "UserName"
            Me.colUserName.Name = "colUserName"
            Me.colUserName.Visible = True
            Me.colUserName.VisibleIndex = 3
            Me.colUserName.Width = 103
            '
            'colPassword
            '
            Me.colPassword.FieldName = "Password"
            Me.colPassword.Name = "colPassword"
            Me.colPassword.Width = 103
            '
            'colFechaCreacion
            '
            Me.colFechaCreacion.FieldName = "FechaCreacion"
            Me.colFechaCreacion.Name = "colFechaCreacion"
            Me.colFechaCreacion.Visible = True
            Me.colFechaCreacion.VisibleIndex = 4
            Me.colFechaCreacion.Width = 103
            '
            'colRolID
            '
            Me.colRolID.Caption = "Rol"
            Me.colRolID.FieldName = "Rol.Nombre"
            Me.colRolID.Name = "colRolID"
            Me.colRolID.Visible = True
            Me.colRolID.VisibleIndex = 5
            Me.colRolID.Width = 107
            '
            'PersonalControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel_Container)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "PersonalControl"
            Me.Size = New System.Drawing.Size(676, 361)
            Me.TableLayoutPanel_Container.ResumeLayout(False)
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UserDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel_Container As Windows.Forms.TableLayoutPanel
        Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
        Friend WithEvents UserDTOBindingSource As Windows.Forms.BindingSource
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRun As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUserName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPassword As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFechaCreacion As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRolID As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace