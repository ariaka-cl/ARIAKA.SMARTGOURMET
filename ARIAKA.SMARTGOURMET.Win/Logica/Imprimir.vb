Namespace Logica
    Public Class Imprimir
        Public Shared Function ListPrinters() As List(Of String)
            Dim listPrint As New List(Of String)

            For Each printer As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
                listPrint.Add(printer)
            Next
            Return listPrint
        End Function
    End Class
End Namespace
