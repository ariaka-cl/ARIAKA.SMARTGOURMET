Namespace Controls
    Public Class ResumenMesaViewControl
        Private Sub TableLayoutPanel_ResumenContainer_Paint(sender As Object, e As EventArgs) _
            Handles MyBase.Paint
            'TODO: agregar los controlores según la mesas que existan, y se debe agregar un layout por cada mesa para que no se descuadre.
            Dim resumenMesa As New ResumenMesaControl
            Me.TableLayoutPanel_ResumenContainer.Controls.Add(resumenMesa, 0, 1)
        End Sub
    End Class
End Namespace
