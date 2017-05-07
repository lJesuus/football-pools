Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports MySql.Data.Types
Module mod_Consulta
    Public PRO As Integer
    Public ID As String
    Public ID_Jornada As String = 46
    Public ID_J As String = 46
    Public _Adaptador As New MySqlDataAdapter
    Private _Adaptador1 As New MySqlDataAdapter

    Public _dtsDatos As New DataSet
    Public _dtvDatos As New DataView
    Public _dts1Datos As New DataSet
    Public _dtv1Datos As New DataView
    Public _dts2Datos As New DataSet
    Public _dtv2Datos As New DataView
    Public _dts3Datos As New DataSet
    Public _dtv3Datos As New DataView
    Public _dtsJornada As New DataSet
    Public _dtsContador As New DataSet
    Public _dtsContador1 As New DataSet
    Public _dtsSuma As New DataSet
    Public _DatosEquipo As New DataSet
    Public Dt_Cliente As New DataTable


    Public Sub Consulta_Datos()
        Try
            conexion_Global()
            _Adaptador.SelectCommand = New MySqlCommand("select L.EQUIPO LOCAL , V.EQUIPO VISITANTE from JORNADAS J, EVENTOS E, EQUIPOS L, EQUIPOS V where J.ID_JORNADA = E.ID_JORNADA and E.LOCAL = L.ID_EQUIPO and E.VISITANTE = V.ID_EQUIPO and (J.ID_JORNADA = '" & ID_Jornada & "') order by J.FECHA", _Conexion)
            _Adaptador.Fill(_dtsDatos)
            _dtvDatos.Table = _dtsDatos.Tables(0)
            _Conexion.Open()
            _Adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Public Sub llenacombobox()
        Try
            conexion_Global()
            _Adaptador.SelectCommand = New MySqlCommand("SELECT * FROM jornadas", _Conexion)
            _Adaptador.Fill(Dt_Cliente)
            _Conexion.Open()
            Ir_a.ComboBox1.DataSource = Dt_Cliente
            Ir_a.ComboBox1.DisplayMember = "NOMBRE"
            Ir_a.ComboBox1.ValueMember = "ID_JORNADA"
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Public Sub Conectar()
        Try
            conexion_Global()
            _Conexion.Open()
            Dim SSel As String
            SSel = "Select NOMBRES from usuarios where ID_USUARIO=" + ID
            Dim da As MySqlDataAdapter
            Dim ds As New DataSet
            Dim da1 As MySqlDataAdapter
            Dim ds1 As New DataSet
            ds.Clear()
            da = New MySqlDataAdapter(SSel, _Conexion)
            da1 = New MySqlDataAdapter(SSel, _Conexion)
            da.Fill(ds)
            da1.Fill(ds1)
            Quiniela.Label23.Text = ds.Tables(0).Rows(0)("NOMBRES")
            Factura.Nombre.Text = ds1.Tables(0).Rows(0)("NOMBRES")
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
    End Sub
    Public Sub Consulta_Datosv2()
        Try
            conexion_Global()
            _dts1Datos.Clear()
            _Adaptador.SelectCommand = New MySqlCommand("select date_format(J.FECHA,'%d-%m-%Y') FECHA, L.EQUIPO LOCAL , V.EQUIPO VISITANTE, E.RESULTADO from JORNADAS J, EVENTOS E, EQUIPOS L, EQUIPOS V where J.ID_JORNADA = E.ID_JORNADA and E.LOCAL = L.ID_EQUIPO and E.VISITANTE = V.ID_EQUIPO and (J.ID_JORNADA = '" & ID_Jornada & "') order by J.FECHA", _Conexion)
            _Adaptador.Fill(_dts1Datos)
            _dtv1Datos.Table = _dts1Datos.Tables(0)
            _Conexion.Open()
            _Adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Public Sub Consulta_Datosv3()
        Try
            conexion_Global()
            _dts1Datos.Clear()
            _Adaptador.SelectCommand = New MySqlCommand("select PRONOSTICO from PRONOSTICOS where usuario='" & ID & "'", _Conexion)
            _Adaptador.Fill(_dts2Datos)
            _dtv2Datos.Table = _dts2Datos.Tables(0)
            _Conexion.Open()
            _Adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Public Sub Consulta_Datosv4()
        Try
            conexion_Global()
            _Adaptador.SelectCommand = New MySqlCommand("select date_format(J.FECHA,'%d-%m-%Y') FECHA, L.EQUIPO LOCAL , V.EQUIPO VISITANTE from JORNADAS J, EVENTOS E, EQUIPOS L, EQUIPOS V where J.ID_JORNADA = E.ID_JORNADA and E.LOCAL = L.ID_EQUIPO and E.VISITANTE = V.ID_EQUIPO and (J.ID_JORNADA = '" & ID_Jornada & "') order by J.FECHA", _Conexion)
            _Adaptador.Fill(_dts3Datos)
            _dtv3Datos.Table = _dts3Datos.Tables(0)
            _Conexion.Open()
            _Adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Public Sub Admin_Equipos()
        Try
            conexion_Global()
            _Conexion.Open()
            Dim SSel As String
            SSel = "Select EQUIPO from EQUIPOS"
            Dim da As MySqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New MySqlDataAdapter(SSel, _Conexion)
            da.Fill(ds)
            Admin.TextBox2.Text = ds.Tables(0).Rows(0)("EQUIPO")
            Admin.TextBox3.Text = ds.Tables(0).Rows(1)("EQUIPO")
            Admin.TextBox4.Text = ds.Tables(0).Rows(2)("EQUIPO")
            Admin.TextBox5.Text = ds.Tables(0).Rows(3)("EQUIPO")
            Admin.TextBox6.Text = ds.Tables(0).Rows(4)("EQUIPO")
            Admin.TextBox7.Text = ds.Tables(0).Rows(5)("EQUIPO")
            Admin.TextBox8.Text = ds.Tables(0).Rows(6)("EQUIPO")
            Admin.TextBox9.Text = ds.Tables(0).Rows(7)("EQUIPO")
            Admin.TextBox10.Text = ds.Tables(0).Rows(8)("EQUIPO")
            Admin.TextBox11.Text = ds.Tables(0).Rows(9)("EQUIPO")
            Admin.TextBox12.Text = ds.Tables(0).Rows(10)("EQUIPO")
            Admin.TextBox13.Text = ds.Tables(0).Rows(11)("EQUIPO")
            Admin.TextBox14.Text = ds.Tables(0).Rows(12)("EQUIPO")
            Admin.TextBox15.Text = ds.Tables(0).Rows(13)("EQUIPO")
            Admin.TextBox16.Text = ds.Tables(0).Rows(14)("EQUIPO")
            Admin.TextBox31.Text = ds.Tables(0).Rows(15)("EQUIPO")
            Admin.TextBox30.Text = ds.Tables(0).Rows(16)("EQUIPO")
            Admin.TextBox29.Text = ds.Tables(0).Rows(17)("EQUIPO")
            Admin.TextBox28.Text = ds.Tables(0).Rows(18)("EQUIPO")
            Admin.TextBox27.Text = ds.Tables(0).Rows(19)("EQUIPO")
            Admin.TextBox26.Text = ds.Tables(0).Rows(20)("EQUIPO")
            Admin.TextBox25.Text = ds.Tables(0).Rows(21)("EQUIPO")
            Admin.TextBox24.Text = ds.Tables(0).Rows(22)("EQUIPO")
            Admin.TextBox23.Text = ds.Tables(0).Rows(23)("EQUIPO")
            Admin.TextBox22.Text = ds.Tables(0).Rows(24)("EQUIPO")
            Admin.TextBox21.Text = ds.Tables(0).Rows(25)("EQUIPO")
            Admin.TextBox20.Text = ds.Tables(0).Rows(26)("EQUIPO")
            Admin.TextBox19.Text = ds.Tables(0).Rows(27)("EQUIPO")
            Admin.TextBox18.Text = ds.Tables(0).Rows(28)("EQUIPO")
            Admin.TextBox17.Text = ds.Tables(0).Rows(29)("EQUIPO")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Public Sub Contador()
        Try
            conexion_Global()
            _Adaptador.SelectCommand = New MySqlCommand("SELECT Count(ID_USUARIO) FROM USUARIOS", _Conexion)
            _Adaptador.Fill(_dtsContador)
            Admin.Usuariosl = _dtsContador.Tables(0).Rows(0)("Count(ID_USUARIO)")
            _Conexion.Open()
            _Adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Public Sub Contador1()
        Try
            conexion_Global()
            _Adaptador.SelectCommand = New MySqlCommand("SELECT MAX(ID_QUINIELA) FROM quinielas", _Conexion)
            _Adaptador.Fill(_dtsContador1)
            Admin.Quinielas.Text = _dtsContador1.Tables(0).Rows(0)("MAX(ID_QUINIELA)")
            _Conexion.Open()
            _Adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Public Sub Contador2()
        Try
            conexion_Global()
            _Adaptador.SelectCommand = New MySqlCommand("SELECT SUM(PRO) FROM usuarios", _Conexion)
            _Adaptador.Fill(_dtsSuma)
            Admin.Label4.Text = _dtsSuma.Tables(0).Rows(0)("SUM(PRO)")
            _Conexion.Open()
            _Adaptador.SelectCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
End Module
