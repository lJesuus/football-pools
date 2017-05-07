Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class Class_Int
    Private _Adaptador As New MySqlDataAdapter

    Public Function InsertarDatos(ByVal datos As Clase_Datos) As Boolean
        Dim estado As Boolean = True
        Try
            conexion_Global()
            '----------------------------------------------------------------------------------REGISTRO
            _Adaptador.InsertCommand = New MySqlCommand("INSERT INTO usuarios(NOM_USUARIO,CEDULA,NOMBRES,APELLIDOS,EMAIL,PASSWORD) VALUES(@NOM_USUARIO,@CEDULA,@NOMBRES,@APELLIDOS,@EMAIL,@PASSWORD)", _Conexion)
            _Adaptador.InsertCommand.Parameters.Add("@NOM_USUARIO", MySqlDbType.VarChar, 30).Value = datos.NOM_USUARIO
            _Adaptador.InsertCommand.Parameters.Add("@CEDULA", MySqlDbType.Int32, 30).Value = datos.CEDULA
            _Adaptador.InsertCommand.Parameters.Add("@NOMBRES", MySqlDbType.VarChar, 30).Value = datos.NOMBRES
            _Adaptador.InsertCommand.Parameters.Add("@APELLIDOS", MySqlDbType.VarChar, 30).Value = datos.APELLIDOS
            _Adaptador.InsertCommand.Parameters.Add("@EMAIL", MySqlDbType.VarChar, 30).Value = datos.EMAIL
            _Adaptador.InsertCommand.Parameters.Add("@PASSWORD", MySqlDbType.VarChar, 30).Value = datos.PASSWORD
            '----------------------------------------------------------------------------------FIN REGISTRO
            _Conexion.Open()
            _Adaptador.InsertCommand.Connection = _Conexion
            _Adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function
End Class
