Imports System.Windows.Forms

Namespace Controls
    Public Class ResumenMesaViewControl
        Dim _cliente As New Logica.Cliente

        Public Sub ResumenMesaViewControl_Load(sender As Object, e As EventArgs) Handles Me.Load
            UpdateControls()
        End Sub

        Private Sub UpdateControls()
            Dim listMesas As List(Of Models.MesaDTO) = _cliente.GetMesas(Me.DateTimePicker1.Value.Date)
            If listMesas IsNot Nothing Then
                Me.ResumenMesaGridControl1.MesaDTOBindingSource.DataSource = listMesas
            End If
        End Sub

        Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
            UpdateControls()
        End Sub
    End Class
End Namespace
