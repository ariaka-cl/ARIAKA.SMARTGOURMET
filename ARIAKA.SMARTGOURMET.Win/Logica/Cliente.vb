Imports ARIAKA.SMARTGOURMET.Data
Namespace Logica
    Public Class Cliente

        Public Function GuardarMesa(mesaModel As Models.MesaDTO) As Boolean
            Dim db As New Data.SGContext
            Try

                Dim user As User = db.Users.Where(Function(u) u.ID = mesaModel.UsuarioID).SingleOrDefault()
                'Preguntar si existe mesa, comprobar que no se repitan los productos en las listas.

                Dim mesa As New Mesa With {.Numero = mesaModel.Numero, .UsuarioID = mesaModel.UsuarioID,
                    .FechaCreacion = Date.Now(), .Estado = Models.MesaEstado.Ocupada}
                db.Mesas.Add(mesa)
                db.SaveChanges()
                mesaModel.ID = mesa.ID

                For Each detalle As Models.MesaDetalleDTO In mesaModel.MesaDetalles
                    Dim detalleBD As New MesaDetalle With {.MesaID = mesa.ID, .ProductoID = detalle.ProductoID, .EstadoImpreso = 0,
                                                            .FechaPedido = detalle.FechaPedido}
                    db.MesaDetalles.Add(detalleBD)
                Next
                db.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function SaberEstadoMesa(numero As String) As Models.MesaEstado
            Dim db As New Data.SGContext
            Try
                Dim mesaEstado As Integer? = db.Mesas.Where(Function(m) m.Numero = numero).Select(Function(m) m.Estado).SingleOrDefault()
                If mesaEstado Is Nothing Then Return 0
                Return mesaEstado
            Catch ex As Exception
                Windows.Forms.MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error Verificar Mesa")
                Return 501
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function GetMesas() As List(Of Models.MesaDTO)
            Dim db As New Data.SGContext
            Try
                Dim listMesa As List(Of Mesa) = db.Mesas.Where(Function(m) m.Estado = Models.MesaEstado.Ocupada _
                                                                   OrElse m.Estado = Models.MesaEstado.Impresa).ToList()
                Dim listMesaDTO As New List(Of Models.MesaDTO)
                If listMesa Is Nothing OrElse listMesa.Count = 0 Then Return listMesaDTO
                For Each mesa As Mesa In listMesa
                    listMesaDTO.Add(New Models.MesaDTO With {.ID = mesa.ID, .Estado = mesa.Estado, .FechaCreacion = mesa.FechaCreacion,
                                                            .Numero = mesa.Numero, .UsuarioID = mesa.UsuarioID})
                Next
                Return listMesaDTO
            Catch ex As Exception
                Windows.Forms.MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error Resumen Mesas")
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function GetProductos() As List(Of Models.ProductosDTO)
            Dim db As New Data.SGContext
            Try
                Dim listProductos As List(Of Producto) = db.Productoes.ToList()
                Dim listProductosDto As New List(Of Models.ProductosDTO)
                For Each producto As Producto In listProductos
                    listProductosDto.Add(New Models.ProductosDTO With {.Id = producto.ID, .Nombre = producto.Nombre,
                                                                        .CategoriaID = producto.CategoriaID, .ProducCodigo = producto.ProductoCodigo,
                                                                        .Precio = producto.Precio, .Stock = producto.Stock})
                Next
                Return listProductosDto
            Catch ex As Exception
                Windows.Forms.MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error lista productos")
            Finally
                db.Dispose()
            End Try
        End Function
    End Class
End Namespace
