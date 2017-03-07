Namespace Forms
    Public Class MainForm
        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.SimpleButton_AddTable.Visible = False
        End Sub

        Private Sub SimpleButton_Mesas_Click(sender As Object, e As EventArgs) Handles SimpleButton_Mesas.Click
            Me.SimpleButton_AddTable.Visible = True
            Me.TableLayoutPanel_Dash.Controls.Clear()
            'Dim resumenMesaView As New Controls.ResumenMesaViewControl With {.Dock = Windows.Forms.DockStyle.Fill}
            'Me.TableLayoutPanel_Dash.Controls.Add(resumenMesaView, 0, 0)

        End Sub

        Private Sub SimpleButton_AddTable_Click(sender As Object, e As EventArgs) Handles SimpleButton_AddTable.Click
            Me.TableLayoutPanel_Dash.Controls.Clear()
            Dim nuevaMesa As New MesaControl With {.Dock = Windows.Forms.DockStyle.Fill, .Visible = True}
            Me.TableLayoutPanel_Dash.Controls.Add(nuevaMesa, 0, 0)
            Me.TableLayoutPanel_Dash.Refresh()
        End Sub

    End Class
End Namespace