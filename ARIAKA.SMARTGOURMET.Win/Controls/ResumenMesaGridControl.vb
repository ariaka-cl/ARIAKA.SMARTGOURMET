﻿Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing.Drawing2D

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

    End Class
End Namespace
