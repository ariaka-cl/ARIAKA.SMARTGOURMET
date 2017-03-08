Namespace Controls
    Public Class ResumenMesaControl

        Private Property _cliente As New Logica.Cliente

        Public Sub TableLayoutPanel1_Click() Handles TableLayoutPanel1.Click
            My.Forms.MainForm.TableLayoutPanel_Dash.Controls.Clear()
            Dim nuevaMesa As New MesaControl With {.Dock = Windows.Forms.DockStyle.Fill, .Visible = True}
            My.Forms.MainForm.TableLayoutPanel_Dash.Controls.Add(nuevaMesa, 0, 0)
            My.Forms.MainForm.TableLayoutPanel_Dash.Refresh()
        End Sub

    End Class
End Namespace
