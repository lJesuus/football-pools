Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports MySql.Data.Types
Public Class Confirma

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = Quiniela.ValorX
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        InsertaDatos()
        InsertarValorX()
        Factura.Show()
    End Sub

    Public Sub InsertaDatos()
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
        Try
            conexion_Global()
            Adaptador1.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(676,1,'" & ID_J & "',1,'" & Quiniela.Pro1 & "','" & ID & "')", _Conexion)
            Adaptador2.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(677,2,'" & ID_J & "',2,'" & Quiniela.Pro2 & "','" & ID & "')", _Conexion)
            Adaptador3.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(678,3,'" & ID_J & "',3,'" & Quiniela.Pro3 & "','" & ID & "')", _Conexion)
            Adaptador4.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(679,4,'" & ID_J & "',4,'" & Quiniela.Pro4 & "','" & ID & "')", _Conexion)
            Adaptador5.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(680,5,'" & ID_J & "',5,'" & Quiniela.Pro5 & "','" & ID & "')", _Conexion)
            Adaptador6.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(681,6,'" & ID_J & "',6,'" & Quiniela.Pro6 & "','" & ID & "')", _Conexion)
            Adaptador7.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(682,7,'" & ID_J & "',7,'" & Quiniela.Pro7 & "','" & ID & "')", _Conexion)
            Adaptador8.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(683,8,'" & ID_J & "',8,'" & Quiniela.Pro8 & "','" & ID & "')", _Conexion)
            Adaptador9.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(684,9,'" & ID_J & "',9,'" & Quiniela.Pro9 & "','" & ID & "')", _Conexion)
            Adaptador10.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(685,10,'" & ID_J & "',10,'" & Quiniela.Pro10 & "','" & ID & "')", _Conexion)
            Adaptador11.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(686,11,'" & ID_J & "',11,'" & Quiniela.Pro11 & "','" & ID & "')", _Conexion)
            Adaptador12.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(687,12,'" & ID_J & "',12,'" & Quiniela.Pro12 & "','" & ID & "')", _Conexion)
            Adaptador13.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(688,13,'" & ID_J & "',13,'" & Quiniela.Pro13 & "','" & ID & "')", _Conexion)
            Adaptador14.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(689,14,'" & ID_J & "',14,'" & Quiniela.Pro14 & "','" & ID & "')", _Conexion)
            Adaptador15.InsertCommand = New MySqlCommand("insert into PRONOSTICOS(ID_QUINIELA, ID_PRO, ID_JORNADA, ID_EVENTO, PRONOSTICO, USUARIO) VALUES(690,15,'" & ID_J & "',15,'" & Quiniela.Pro15 & "','" & ID & "')", _Conexion)
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
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
    Public Sub InsertarValorX()
        Dim Adaptador As New MySqlDataAdapter
        Try
            conexion_Global()
            Adaptador.InsertCommand = New MySqlCommand("insert into USUARIOS(PRO) VALUES('" & Quiniela.ValorX & "') WHERE ID_USUARIO='" & ID & "'", _Conexion)
            _Conexion.Open()    
            Adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            cerrar()
        End Try
    End Sub
End Class