Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports MySql.Data.Types
Public Class Admin
    Public Usuariosl As Integer
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Admin_Equipos()
        Jornada.Text = ID_J
        Contador()
        Usuarios.Text = Usuariosl - 1
        Contador1()
        Contador2()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ID_Jornada
    End Sub

    Public Sub UpdateEquipos()
        Dim Adaptador1 As New MySqlDataAdapter
        Dim Adaptador2 As New MySqlDataAdapter
        Dim Adaptador3 As New MySqlDataAdapter
        Dim Adaptador4 As New MySqlDataAdapter
        Dim Adaptador5 As New MySqlDataAdapter
        Dim Adaptador6 As New MySqlDataAdapter
        Dim Adaptador7 As New MySqlDataAdapter
        Dim Adaptador8 As New MySqlDataAdapter
        Dim Adaptador9 As New MySqlDataAdapter
        Dim Adaptador10 As New MySqlDataAdapter
        Dim Adaptador11 As New MySqlDataAdapter
        Dim Adaptador12 As New MySqlDataAdapter
        Dim Adaptador13 As New MySqlDataAdapter
        Dim Adaptador14 As New MySqlDataAdapter
        Dim Adaptador15 As New MySqlDataAdapter
        Dim Adaptador16 As New MySqlDataAdapter
        Dim Adaptador17 As New MySqlDataAdapter
        Dim Adaptador18 As New MySqlDataAdapter
        Dim Adaptador19 As New MySqlDataAdapter
        Dim Adaptador20 As New MySqlDataAdapter
        Dim Adaptador21 As New MySqlDataAdapter
        Dim Adaptador22 As New MySqlDataAdapter
        Dim Adaptador23 As New MySqlDataAdapter
        Dim Adaptador24 As New MySqlDataAdapter
        Dim Adaptador25 As New MySqlDataAdapter
        Dim Adaptador26 As New MySqlDataAdapter
        Dim Adaptador27 As New MySqlDataAdapter
        Dim Adaptador28 As New MySqlDataAdapter
        Dim Adaptador29 As New MySqlDataAdapter
        Dim Adaptador30 As New MySqlDataAdapter

        Try
            conexion_Global()
            Adaptador1.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox2.Text & "' WHERE ID_EQUIPO = 1", _Conexion)
            Adaptador2.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox3.Text & "' WHERE ID_EQUIPO = 2", _Conexion)
            Adaptador3.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox4.Text & "' WHERE ID_EQUIPO = 3", _Conexion)
            Adaptador4.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox5.Text & "' WHERE ID_EQUIPO = 4", _Conexion)
            Adaptador5.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox6.Text & "' WHERE ID_EQUIPO = 5", _Conexion)
            Adaptador6.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox7.Text & "' WHERE ID_EQUIPO = 6", _Conexion)
            Adaptador7.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox8.Text & "' WHERE ID_EQUIPO = 7", _Conexion)
            Adaptador8.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox9.Text & "' WHERE ID_EQUIPO = 8", _Conexion)
            Adaptador9.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox10.Text & "' WHERE ID_EQUIPO = 9", _Conexion)
            Adaptador10.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox11.Text & "' WHERE ID_EQUIPO = 10", _Conexion)
            Adaptador11.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox12.Text & "' WHERE ID_EQUIPO = 11", _Conexion)
            Adaptador12.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox13.Text & "' WHERE ID_EQUIPO = 12", _Conexion)
            Adaptador13.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox14.Text & "' WHERE ID_EQUIPO = 13", _Conexion)
            Adaptador14.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox15.Text & "' WHERE ID_EQUIPO = 14", _Conexion)
            Adaptador15.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox16.Text & "' WHERE ID_EQUIPO = 15", _Conexion)
            Adaptador16.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox31.Text & "' WHERE ID_EQUIPO = 16", _Conexion)
            Adaptador17.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox30.Text & "' WHERE ID_EQUIPO = 17", _Conexion)
            Adaptador18.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox29.Text & "' WHERE ID_EQUIPO = 18", _Conexion)
            Adaptador19.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox28.Text & "' WHERE ID_EQUIPO = 19", _Conexion)
            Adaptador20.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox27.Text & "' WHERE ID_EQUIPO = 20", _Conexion)
            Adaptador21.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox26.Text & "' WHERE ID_EQUIPO = 21", _Conexion)
            Adaptador22.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox25.Text & "' WHERE ID_EQUIPO = 22", _Conexion)
            Adaptador23.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox24.Text & "' WHERE ID_EQUIPO = 23", _Conexion)
            Adaptador24.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox23.Text & "' WHERE ID_EQUIPO = 24", _Conexion)
            Adaptador25.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox22.Text & "' WHERE ID_EQUIPO = 25", _Conexion)
            Adaptador26.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox21.Text & "' WHERE ID_EQUIPO = 26", _Conexion)
            Adaptador27.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox20.Text & "' WHERE ID_EQUIPO = 27", _Conexion)
            Adaptador28.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox19.Text & "' WHERE ID_EQUIPO = 28", _Conexion)
            Adaptador29.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox18.Text & "' WHERE ID_EQUIPO = 29", _Conexion)
            Adaptador30.InsertCommand = New MySqlCommand("UPDATE EQUIPOS SET EQUIPO='" & TextBox17.Text & "' WHERE ID_EQUIPO = 30", _Conexion)
            _Conexion.Open()
            Adaptador1.InsertCommand.ExecuteNonQuery()
            Adaptador2.InsertCommand.ExecuteNonQuery()
            Adaptador3.InsertCommand.ExecuteNonQuery()
            Adaptador4.InsertCommand.ExecuteNonQuery()
            Adaptador5.InsertCommand.ExecuteNonQuery()
            Adaptador6.InsertCommand.ExecuteNonQuery()
            Adaptador7.InsertCommand.ExecuteNonQuery()
            Adaptador8.InsertCommand.ExecuteNonQuery()
            Adaptador9.InsertCommand.ExecuteNonQuery()
            Adaptador10.InsertCommand.ExecuteNonQuery()
            Adaptador11.InsertCommand.ExecuteNonQuery()
            Adaptador12.InsertCommand.ExecuteNonQuery()
            Adaptador13.InsertCommand.ExecuteNonQuery()
            Adaptador14.InsertCommand.ExecuteNonQuery()
            Adaptador15.InsertCommand.ExecuteNonQuery()
            Adaptador16.InsertCommand.ExecuteNonQuery()
            Adaptador17.InsertCommand.ExecuteNonQuery()
            Adaptador18.InsertCommand.ExecuteNonQuery()
            Adaptador19.InsertCommand.ExecuteNonQuery()
            Adaptador20.InsertCommand.ExecuteNonQuery()
            Adaptador21.InsertCommand.ExecuteNonQuery()
            Adaptador22.InsertCommand.ExecuteNonQuery()
            Adaptador23.InsertCommand.ExecuteNonQuery()
            Adaptador24.InsertCommand.ExecuteNonQuery()
            Adaptador25.InsertCommand.ExecuteNonQuery()
            Adaptador26.InsertCommand.ExecuteNonQuery()
            Adaptador27.InsertCommand.ExecuteNonQuery()
            Adaptador28.InsertCommand.ExecuteNonQuery()
            Adaptador29.InsertCommand.ExecuteNonQuery()
            Adaptador30.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Quiniela.Show()
    End Sub
End Class