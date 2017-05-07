Imports MySql.Data.MySqlClient

Public Class Iniciar_Sesion
    Function Existeusuario(ByVal Usuario As String, ByVal Password As String) As Boolean
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As MySqlDataAdapter
        Dim oDataSet As New DataSet
        Dim nDataSet As New DataSet
        Dim sSql As String
        Dim sw As Boolean = False
        Dim fila As DataRow
        Try
            oConexion.ConnectionString = "server=localhost; database=mydb; user id=root;password=admin;"
            sSql = "SELECT * FROM usuarios WHERE NOM_USUARIO='" & Usuario & "' And PASSWORD= '" & Password & "'"
            oConexion.Open()
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "usuarios")

            If (oDataSet.Tables("usuarios").Rows.Count() <> 0) Then
                fila = oDataSet.Tables("usuarios").Rows(0)
                ID = fila("ID_USUARIO")
                MessageBox.Show("Bienvenido al Sistema", "Sistema")
                sw = True
            Else
                MessageBox.Show("Ususario y/o Contraseña no Validos", "Sistema")
                sw = False
            End If
        Catch ex As Exception
        End Try
        Return (sw)


    End Function

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If txtUsuario.Text = "ADMIN" Then
            MessageBox.Show("Acceso Administrador concedido", "Sistema")
            Admin.Show()
            Quiniela.Hide()
        Else
            If (Existeusuario(txtUsuario.Text, txtContraseña.Text)) Then
                Me.Hide()
                Quiniela.Show()
            End If
            Conectar()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Registro.Show()
        Me.Hide()
    End Sub

    Private Sub Iniciar_Sesion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Usuarios.Close()
    End Sub

    Private Sub Iniciar_Sesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class