Public Class ProductosMesaControl
    Sub New()

        InitializeComponent()

        GridControl_DetallesMesa.DataSource = New List(Of Models.ProductosDTO)() ' TODO: Assign the real data here.
    End Sub



End Class
