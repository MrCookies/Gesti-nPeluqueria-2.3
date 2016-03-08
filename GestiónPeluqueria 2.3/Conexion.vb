Imports System.Data.OleDb
Module Conexion
    Public cnnPeluqueria As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source='peluqueria.accdb'")
End Module
