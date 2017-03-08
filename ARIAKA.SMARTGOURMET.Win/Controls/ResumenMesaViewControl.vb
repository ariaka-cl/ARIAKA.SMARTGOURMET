Imports System.Windows.Forms

Namespace Controls
    Public Class ResumenMesaViewControl
        Dim _cliente As New Logica.Cliente

        Public Sub ResumenMesaViewControl_Load(sender As Object, e As EventArgs) Handles Me.Load
            UpdateControls()
        End Sub

        Private Sub UpdateControls()
            Dim row As Integer = 0
            Dim col As Integer = 0
            Dim count As Integer = 0
            Dim listMesas As List(Of Models.MesaDTO) = _cliente.GetMesas()
            If listMesas IsNot Nothing Then

                Dim layout As New TableLayoutPanel With {.ColumnCount = 5,
                                                                   .Dock = DockStyle.Fill,
                                                                   .Name = "TableLayoutPanel_Resumen_Mesas",
                                                                   .AllowDrop = True}

                For Each mesaDTO As Models.MesaDTO In listMesas.OrderBy(Function(m) m.Numero)
                    col = count Mod 5
                    layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, CSng(100 / 5)))
                    Dim resumenMesa As New ResumenMesaControl With {.Anchor = AnchorStyles.Top, .Dock = DockStyle.Fill}
                    resumenMesa.LabelControl_Garzon_Value.Text = mesaDTO.UsuarioID
                    resumenMesa.LabelControl_MesaN_Value.Text = mesaDTO.Numero
                    resumenMesa.LabelControl_Hora_Value.Text = mesaDTO.FechaCreacion.Value.ToShortTimeString()
                    layout.Controls.Add(resumenMesa, col, row)

                    If col = 5 Then
                        row += 1
                    End If
                    count += 1
                Next
                Me.TableLayoutPanel_ResumenContainer.Controls.Add(layout, 0, 1)
            End If
        End Sub
    End Class
End Namespace
