Imports System.Windows.Forms
Imports ARIAKA.SMARTGOURMET.Data
Namespace Logica
    Public Class Cliente

        Public Function GuardarMesa(mesaModel As Models.MesaDTO) As Models.MesaDTO
            Dim db As New SGContext
            Try

                Dim user As User = db.Users.Where(Function(u) u.ID = mesaModel.UsuarioID).SingleOrDefault()
                Dim mesa As New Mesa With {.Numero = mesaModel.Numero,
                                           .UsuarioID = mesaModel.UsuarioID,
                                           .FechaCreacion = mesaModel.FechaCreacion,
                                           .Estado = Models.MesaEstado.Ocupada,
                                           .Notas = mesaModel.Notas}
                db.Mesas.Add(mesa)
                db.SaveChanges()
                mesaModel.ID = mesa.ID

                For Each detalle As Models.MesaDetalleDTO In mesaModel.MesaDetalles
                    Dim detalleBD As New MesaDetalle With {.MesaID = mesa.ID, .ProductoID = detalle.ProductoID, .EstadoImpreso = 0,
                                                            .FechaPedido = detalle.FechaPedido}
                    db.MesaDetalles.Add(detalleBD)
                Next
                db.SaveChanges()

                Dim listMesaDetalle As List(Of Data.MesaDetalle) = db.MesaDetalles.Where(Function(md) md.MesaID = mesaModel.ID).ToList()
                Dim listProducts As List(Of Producto) = db.Productoes.ToList()
                Dim listCate As List(Of Categoria) = db.Categorias.ToList()
                Dim listMesaDetalleDto As New List(Of Models.MesaDetalleDTO)
                For Each mdetalle As Data.MesaDetalle In listMesaDetalle
                    Dim prod As New Models.ProductosDTO With {.Id = mdetalle.ProductoID,
                        .Nombre = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.Nombre).SingleOrDefault(),
                        .Precio = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.Precio).SingleOrDefault(),
                        .ProducCodigo = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.ProductoCodigo).SingleOrDefault(),
                        .Stock = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.Stock).SingleOrDefault(),
                        .CategoriaID = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.CategoriaID).SingleOrDefault(),
                        .Categoria = New Models.CategoriaDTO With {.ID = mdetalle.Producto.CategoriaID,
                                                             .Nombre = listCate.Where(Function(c) c.ID = mdetalle.Producto.CategoriaID) _
                                                             .Select(Function(c) c.Nombre).SingleOrDefault()}}

                    listMesaDetalleDto.Add(New Models.MesaDetalleDTO With {.ID = mdetalle.ID,
                                                                           .MesaID = mdetalle.MesaID,
                                                                           .EstadoImpreso = mdetalle.EstadoImpreso,
                                                                           .FechaPedido = mdetalle.FechaPedido,
                                                                           .ProductoID = mdetalle.ProductoID,
                                                                           .Producto = prod})
                Next
                mesaModel.MesaDetalles = listMesaDetalleDto
                Return mesaModel
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Agregar Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New Models.MesaDTO
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
                MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error Verificar Mesa", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error Resumen Mesas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New List(Of Models.MesaDTO)
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
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error lista productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New List(Of Models.ProductosDTO)
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function GuardarDetalleMesa(mesaDetalles As List(Of Models.MesaDetalleDTO), mesaID As Integer) As List(Of Models.MesaDetalleDTO)
            Dim db As New SGContext
            Try
                For Each detalle As Models.MesaDetalleDTO In mesaDetalles
                    Dim detalleBD As New MesaDetalle With {.MesaID = mesaID, .ProductoID = detalle.ProductoID, .EstadoImpreso = 0,
                                                            .FechaPedido = detalle.FechaPedido}
                    db.MesaDetalles.Add(detalleBD)
                Next
                db.SaveChanges()
                Dim listMesaDetalle As List(Of Data.MesaDetalle) = db.MesaDetalles.Where(Function(md) md.MesaID = mesaID).ToList()
                Dim listProducts As List(Of Producto) = db.Productoes.ToList()
                Dim listCate As List(Of Categoria) = db.Categorias.ToList()
                Dim listMesaDetalleDto As New List(Of Models.MesaDetalleDTO)
                For Each mdetalle As Data.MesaDetalle In listMesaDetalle
                    Dim prod As New Models.ProductosDTO With {.Id = mdetalle.ProductoID,
                        .Nombre = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.Nombre).SingleOrDefault(),
                        .Precio = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.Precio).SingleOrDefault(),
                        .ProducCodigo = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.ProductoCodigo).SingleOrDefault(),
                        .Stock = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.Stock).SingleOrDefault(),
                        .CategoriaID = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.CategoriaID).SingleOrDefault(),
                        .Categoria = New Models.CategoriaDTO With {.ID = mdetalle.Producto.CategoriaID,
                                                             .Nombre = listCate.Where(Function(c) c.ID = mdetalle.Producto.CategoriaID) _
                                                             .Select(Function(c) c.Nombre).SingleOrDefault()}}
                    listMesaDetalleDto.Add(New Models.MesaDetalleDTO With {.ID = mdetalle.ID,
                                                                           .MesaID = mdetalle.MesaID,
                                                                           .EstadoImpreso = mdetalle.EstadoImpreso,
                                                                           .FechaPedido = mdetalle.FechaPedido,
                                                                           .ProductoID = mdetalle.ProductoID,
                                                                           .Producto = prod})
                Next
                Return listMesaDetalleDto
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Agregar Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New List(Of Models.MesaDetalleDTO)
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function EliminarDetalleMesa(id As Integer) As Boolean
            Dim db As New SGContext
            Try
                Dim detalle As MesaDetalle = db.MesaDetalles.Where(Function(md) md.ID = id).SingleOrDefault()
                db.MesaDetalles.Remove(detalle)
                db.SaveChanges()
                Return True
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Eliminar Detalle", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                db.Dispose()
            End Try
        End Function
        Public Function GetGarzones() As List(Of Models.UserDTO)
            Dim db As New SGContext
            Try
                Dim listUser As List(Of User) = db.Users.Where(Function(u) u.RolID = 2).ToList()
                Dim listUserDto As New List(Of Models.UserDTO)
                For Each usuario As User In listUser
                    listUserDto.Add(New Models.UserDTO With {.ID = usuario.ID,
                                                             .Nombre = usuario.Nombre,
                                                             .RolID = usuario.RolID})
                Next
                Return listUserDto
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Obtener Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New List(Of Models.UserDTO)
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function GetMesaDetalles(mesaID As Integer) As List(Of Models.MesaDetalleDTO)
            Dim db As New SGContext
            Try
                Dim listMesaDetalle As List(Of Data.MesaDetalle) = db.MesaDetalles.Where(Function(md) md.MesaID = mesaID).ToList()
                Dim listProducts As List(Of Producto) = db.Productoes.ToList()
                Dim listCate As List(Of Categoria) = db.Categorias.ToList()
                Dim listMesaDetalleDto As New List(Of Models.MesaDetalleDTO)
                For Each mdetalle As Data.MesaDetalle In listMesaDetalle
                    Dim prod As New Models.ProductosDTO With {.Id = mdetalle.ProductoID,
                        .Nombre = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.Nombre).SingleOrDefault(),
                        .Precio = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.Precio).SingleOrDefault(),
                        .ProducCodigo = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.ProductoCodigo).SingleOrDefault(),
                        .Stock = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.Stock).SingleOrDefault(),
                        .CategoriaID = listProducts.Where(Function(p) p.ID = mdetalle.ProductoID).Select(Function(p) p.CategoriaID).SingleOrDefault(),
                        .Categoria = New Models.CategoriaDTO With {.ID = mdetalle.Producto.CategoriaID,
                                                             .Nombre = listCate.Where(Function(c) c.ID = mdetalle.Producto.CategoriaID) _
                                                             .Select(Function(c) c.Nombre).SingleOrDefault()}}

                    listMesaDetalleDto.Add(New Models.MesaDetalleDTO With {.ID = mdetalle.ID,
                                                                           .MesaID = mdetalle.MesaID,
                                                                           .EstadoImpreso = mdetalle.EstadoImpreso,
                                                                           .FechaPedido = mdetalle.FechaPedido,
                                                                           .ProductoID = mdetalle.ProductoID,
                                                                           .Producto = prod})
                Next

                Return listMesaDetalleDto
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Obtiene Detalle Mesa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New List(Of Models.MesaDetalleDTO)
            Finally
                db.Dispose()
            End Try

        End Function

        Public Function PagarMesa(mesaID As Integer) As Boolean
            Dim db As New SGContext
            Try
                Dim mesaPagar As Mesa = db.Mesas.Where(Function(m) m.ID = mesaID AndAlso m.Estado = Models.MesaEstado.Impresa).SingleOrDefault()
                If mesaPagar IsNot Nothing Then
                    mesaPagar.Estado = Models.MesaEstado.Pagada
                    db.SaveChanges()
                    Return True
                End If
                Return False
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Pagando Mesa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function CreacionBoleta(modelBoleta As Models.BoletaDTO) As Boolean
            Dim db As New SGContext
            Try
                Dim mesaId As Integer = modelBoleta.MesaID
                Dim mesaImpresa As Mesa = db.Mesas.Where(Function(m) m.ID = mesaId AndAlso m.Estado = Models.MesaEstado.Ocupada).SingleOrDefault()
                If mesaImpresa IsNot Nothing Then
                    mesaImpresa.Estado = Models.MesaEstado.Impresa
                    db.SaveChanges()

                    Dim boleta As New Boleta With {.MesaID = modelBoleta.MesaID,
                                                   .EstadoImpresa = Models.BoletaEstado.NoImpresa,
                                                   .Total = modelBoleta.Total,
                                                   .Propina = modelBoleta.Propina,
                                                   .FechaCreacion = modelBoleta.FechaCreacion}
                    db.Boletas.Add(boleta)
                    db.SaveChanges()
                    Return True
                End If
                Return False
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Creando Boleta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                db.Dispose()
            End Try
        End Function

    End Class
End Namespace
