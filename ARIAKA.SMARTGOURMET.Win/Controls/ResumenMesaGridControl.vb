Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraGrid.Views.Layout.Events
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Namespace Controls
    Public Class ResumenMesaGridControl

        Sub New()
            InitializeComponent()
            CardView1.CardCaptionFormat = "Mesa N°: {2}"
            CardView1.OptionsView.ShowQuickCustomizeButton = False
        End Sub

        Private Sub gridView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles CardView1.DoubleClick
            Dim view As CardView = CType(sender, CardView)
            Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
            DoRowDoubleClick(view, pt)
        End Sub

        Private Shared Sub DoRowDoubleClick(ByVal view As CardView, ByVal pt As Point)
            Dim info As ViewInfo.CardHitInfo = view.CalcHitInfo(pt)
            If info.InCard OrElse info.InCardCaption Then
                Dim mesaID As Integer = CType(TryCast(info.View.DataSource, BindingSource).Current, Models.MesaDTO).ID
                If mesaID = Nothing Then
                    MessageBox.Show(String.Format("Fallo al obtener Comanda N°: {0}", mesaID), "Obtener Mesa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                CallMesasView(mesaID)
            End If
        End Sub

        Private Shared Sub CallMesasView(mesaID As Integer)
            My.Forms.MainForm.TableLayoutPanel_Dash.Controls.Clear()
            Dim nuevaMesa As New MesaControl With {.Dock = DockStyle.Fill, .Visible = True}
            nuevaMesa.MesaID = mesaID
            My.Forms.MainForm.TableLayoutPanel_Dash.Controls.Add(nuevaMesa, 0, 0)
            My.Forms.MainForm.TableLayoutPanel_Dash.Refresh()

        End Sub

        'Private Sub CardView1_CustomDrawCardFieldValue(sender As Object, e As CardCaptionCustomDrawEventArgs) Handles CardView1.CustomDrawCardCaption
        '    Dim view As CardView = CType(sender, CardView)
        '    Dim mesa As Models.MesaDTO = TryCast(CType(view.DataSource, BindingSource).Current, Models.MesaDTO)
        '    Dim brush As Brush = Nothing
        '    If mesa.Estado = Models.MesaEstado.Ocupada Then Return

        '    Select Case mesa.Estado
        '        Case 2
        '            brush = e.Cache.GetGradientBrush(e.Bounds, Color.Red, Color.Crimson, LinearGradientMode.Horizontal, 2)
        '            e.Graphics.FillRectangle(brush, e.Bounds)
        '            e.Appearance.DrawString(e.Cache, view.GetCardCaption(e.RowHandle), e.Bounds)
        '            e.Handled = True
        '        Case 3
        '            brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.SkyBlue, LinearGradientMode.Horizontal)
        '            e.Appearance.ForeColor = Color.Indigo
        '            e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Bold)
        '            e.Graphics.FillRectangle(brush, e.Bounds)
        '            e.Appearance.DrawString(e.Cache, view.GetCardCaption(e.RowHandle), e.Bounds)
        '            e.Handled = True
        '    End Select

        'End Sub

    End Class
End Namespace
