Imports MySql.Data.MySqlClient

Public Class Registro

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim conexion As New Class_Int
        Dim datos As New Clase_Datos

        datos.NOM_USUARIO = txtUsuario.Text
        datos.NOMBRES = txtNombre.Text
        datos.CEDULA = txtCedula.Text
        datos.APELLIDOS = txtApellido.Text
        datos.EMAIL = txtEmail.Text
        datos.PASSWORD = txtContraseña.Text

        If conexion.InsertarDatos(datos) Then
            MessageBox.Show("Datos Guardados")
            Me.Close()
            Iniciar_Sesion.Show()
        Else
            MessageBox.Show("Datos No Guardados")
        End If
    End Sub

    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class