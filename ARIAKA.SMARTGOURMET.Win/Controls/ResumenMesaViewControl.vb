Namespace Controls
    Public Class ResumenMesaViewControl
        Dim _cliente As New Logica.Cliente
        Private Sub TableLayoutPanel_ResumenContainer_Paint(sender As Object, e As EventArgs) _
            Handles MyBase.Paint

            Dim row As Integer = 0
            Dim col As Integer = 0
            Dim count As Integer = 0
            Dim layout As New Windows.Forms.TableLayoutPanel With {.ColumnCount = 4}

            Me.TableLayoutPanel_ResumenContainer.Controls.Add(layout, 0, 1)
            Dim listMesas As List(Of Models.MesaDTO) = _cliente.GetMesas()
            For Each mesaDTO As Models.MesaDTO In listMesas
                col = count Mod 4
                Dim resumenMesa As New ResumenMesaControl With {.AutoSize = True}
                resumenMesa.LabelControl_Garzon_Value.Text = mesaDTO.UsuarioID
                resumenMesa.LabelControl_MesaN_Value.Text = mesaDTO.Numero
                resumenMesa.LabelControl_Hora_Value.Text = mesaDTO.FechaCreacion.Value.TimeOfDay.ToString.Substring(0, 5)
                layout.Controls.Add(resumenMesa, col, row)

                If col = 3 Then
                    row += 1
                End If
                count += 1
            Next

        End Sub
    End Class
End Namespace
