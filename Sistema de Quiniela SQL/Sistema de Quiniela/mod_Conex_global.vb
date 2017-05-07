Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module mod_Conex_global
    Public _Cadena As String
    Public _Conexion As New MySqlConnection

    Public Function conexion_Global() As Boolean
        Dim Estado As Boolean = True
        Try
            _Cadena = ("server=localhost; database=mydb; user id=root;password=admin;")
            _Conexion = New MySqlConnection(_Cadena)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Estado = False
        End Try
        Return Estado
    End Function

    Public Sub cerrar()
        _Conexion.Close()
    End Sub
End Module
