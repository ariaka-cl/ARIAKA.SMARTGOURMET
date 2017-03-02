Namespace Logica
    Public Class CrearTicket

        Public Function CrearDocument(listsp As List(Of spImprimir)) As String

            If listsp.Count = 0 Then Return Nothing

            Dim memStrem As String = String.Format("*************************************{0}" &
                                               "                COMANDA              {1}" &
                                               "*************************************{2}" &
                                               "Fecha: {3}                           {4} " &
                                               "Hora: {5}                            {6} " &
                                               "Mesa: {7}                            {8} " &
                                               "Atiende: {9}                         {10}" &
                                               "**************************************{11}", vbCrLf, vbCrLf, vbCrLf, Date.Now.Date.ToShortDateString,
                                               vbCrLf, Date.Now.ToShortTimeString, vbCrLf, listsp.Item(0).MesaNumero, vbCrLf, listsp.Item(0).UserName, vbCrLf, vbCrLf)

            For Each producto As spImprimir In listsp
                Dim productosStr As String = String.Format("-- {0} {1} {2}{3} ", producto.VentasCantidad, producto.ProductoName, producto.VentasComentario, vbCrLf)
                memStrem = String.Concat(memStrem, productosStr)
            Next

            Dim footerStr As String = String.Format("*************************************{0}" &
                                                "IMPRESORA: CAJA                      {1}" &
                                                "*************************************{2}" &
                                                "                                     {3}" &
                                                "        RINCONADA DE AZAPA           {4}" &
                                                "                                     {5}" &
                                                "*************************************{6}", vbCrLf, vbCrLf, vbCrLf, vbCrLf, vbCrLf, vbCrLf, vbCrLf)
            memStrem = String.Concat(memStrem, footerStr)
            Return memStrem
        End Function

    End Class

    Public Class MesaPrint
        Property MesaId As Integer
        Property MesaDate As Date
    End Class

    Public Class spImprimir
        Property VentasId As Integer
        Property MesaNumero As Integer
        Property MesaDate As Date
        Property VentasCantidad As Integer
        Property UserName As String
        Property ProductoName As String
        Property VentasComentario As String
    End Class
End Namespace