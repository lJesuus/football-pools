Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing

Public Class Quiniela
    Public ValorX As Integer = 0

    Public Pro1 As String
    Public Pro2 As String
    Public Pro3 As String
    Public Pro4 As String
    Public Pro5 As String
    Public Pro6 As String
    Public Pro7 As String
    Public Pro8 As String
    Public Pro9 As String
    Public Pro10 As String
    Public Pro11 As String
    Public Pro12 As String
    Public Pro13 As String
    Public Pro14 As String
    Public Pro15 As String

    Sub MyMultipleEventHandler(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click, Button37.Click, Button38.Click, Button39.Click, Button40.Click, Button49.Click, Button50.Click, Button51.Click, Button52.Click, Button53.Click, Button54.Click, Button55.Click, Button56.Click, Button41.Click, Button42.Click, Button57.Click, Button58.Click, Button59.Click, Button60.Click, Button61.Click, Button62.Click, Button63.Click, Button64.Click, Button65.Click, Button66.Click, Button67.Click, Button68.Click, Button69.Click, Button70.Click, Button71.Click, Button72.Click, Button73.Click, Button74.Click, Button75.Click, Button76.Click, Button77.Click, Button78.Click, Button79.Click, Button80.Click, Button81.Click, Button82.Click, Button83.Click, Button84.Click, Button85.Click, Button86.Click, Button87.Click, Button88.Click, Button89.Click, Button90.Click, Button94.Click, Button95.Click, Button96.Click, Button97.Click, Button98.Click, Button99.Click, Button100.Click, Button101.Click, Button102.Click, Button103.Click, Button104.Click, Button105.Click, Button106.Click, Button107.Click, Button108.Click, Button109.Click, Button110.Click, Button111.Click, Button112.Click, Button113.Click, Button114.Click, Button115.Click, Button116.Click, Button117.Click, Button118.Click, Button119.Click, Button120.Click, Button121.Click, Button122.Click, Button123.Click, Button124.Click, Button125.Click, Button126.Click, Button127.Click, Button128.Click, Button129.Click, Button130.Click, Button131.Click, Button132.Click, Button133.Click, Button134.Click, Button135.Click, Button139.Click, Button140.Click, Button141.Click, Button142.Click, Button143.Click, Button144.Click, Button145.Click, Button146.Click, Button147.Click, Button148.Click, Button149.Click, Button150.Click, Button151.Click, Button152.Click, Button153.Click, Button154.Click, Button155.Click, Button156.Click, Button157.Click, Button158.Click, Button159.Click, Button160.Click, Button161.Click, Button162.Click, Button163.Click, Button164.Click, Button165.Click, Button166.Click, Button167.Click, Button168.Click, Button169.Click, Button170.Click, Button171.Click, Button172.Click, Button173.Click, Button174.Click, Button175.Click, Button176.Click, Button177.Click, Button178.Click, Button179.Click, Button180.Click, Button184.Click, Button185.Click, Button186.Click, Button187.Click, Button188.Click, Button189.Click, Button190.Click, Button194.Click, Button195.Click, Button196.Click, Button197.Click, Button198.Click, Button199.Click, Button200.Click, Button201.Click, Button202.Click, Button203.Click, Button204.Click, Button205.Click, Button206.Click, Button207.Click, Button208.Click, Button209.Click, Button210.Click, Button211.Click, Button212.Click, Button213.Click, Button214.Click, Button215.Click, Button216.Click, Button217.Click, Button218.Click, Button219.Click, Button220.Click, Button221.Click, Button222.Click, Button223.Click, Button224.Click, Button225.Click, Button229.Click, Button230.Click, Button231.Click, Button232.Click, Button233.Click, Button234.Click, Button235.Click, Button236.Click, Button237.Click, Button238.Click, Button239.Click, Button240.Click, Button241.Click, Button242.Click, Button243.Click, Button244.Click, Button245.Click, Button246.Click, Button247.Click, Button248.Click, Button249.Click, Button250.Click, Button251.Click, Button252.Click, Button253.Click, Button254.Click, Button255.Click, Button256.Click, Button257.Click, Button258.Click, Button259.Click, Button260.Click, Button261.Click, Button262.Click, Button263.Click, Button264.Click, Button265.Click, Button266.Click, Button267.Click, Button268.Click, Button269.Click, Button270.Click, Button274.Click, Button275.Click, Button276.Click, Button277.Click, Button278.Click, Button279.Click, Button280.Click, Button281.Click, Button282.Click, Button283.Click, Button284.Click, Button285.Click, Button286.Click, Button287.Click, Button288.Click, Button289.Click, Button290.Click, Button291.Click, Button292.Click, Button293.Click, Button294.Click, Button295.Click, Button296.Click, Button297.Click, Button298.Click, Button299.Click, Button300.Click, Button301.Click, Button302.Click, Button303.Click, Button304.Click, Button305.Click, Button306.Click, Button307.Click, Button308.Click, Button309.Click, Button310.Click, Button311.Click, Button312.Click, Button313.Click, Button314.Click, Button315.Click, Button319.Click, Button320.Click, Button321.Click, Button322.Click, Button323.Click, Button324.Click, Button325.Click, Button326.Click, Button327.Click, Button328.Click, Button329.Click, Button330.Click, Button331.Click, Button332.Click, Button333.Click, Button334.Click, Button335.Click, Button336.Click, Button337.Click, Button338.Click, Button339.Click, Button340.Click, Button341.Click, Button342.Click, Button343.Click, Button344.Click, Button345.Click, Button346.Click, Button347.Click, Button348.Click, Button349.Click, Button350.Click, Button351.Click, Button352.Click, Button353.Click, Button354.Click, Button355.Click, Button356.Click, Button357.Click, Button358.Click, Button359.Click, Button360.Click, Button192.Click, Button191.Click, Button193.Click, Button43.Click, Button44.Click, Button45.Click
        Dim b As Button = CType(sender, Button)
        b.Text = "X"
        b.Font = New Font(b.Font, FontStyle.Bold)
        If b.Text = "X" Then
            ValorX += 10
            TextBox32.Text = ValorX
        End If
        If Button43.Text = "X" Then
            ValorX += 20
        Else
        End If
        If Button44.Text = "X" Then
            ValorX += 20
        Else
        End If
        If Button45.Text = "X" Then
            ValorX += 20
        Else
        End If
    End Sub

    Private Sub Quiniela_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Usuarios.Close()
    End Sub

    Private Sub Quiniela_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta_Datos()
        DataGridView1.DataSource = _dtvDatos
        llenacombobox()
        Lbl_ID.Text = ID_J
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        '-------------------------'
        If Button1.Text = "X" Then
            Pro1 = "1"
        Else
        End If
        If Button2.Text = "X" Then
            Pro1 = "X"
        Else
        End If
        If Button3.Text = "X" Then
            Pro1 = "2"
        Else
        End If
        '-------------------------'
        If Button4.Text = "X" Then
            Pro2 = "2"
        Else
        End If
        If Button5.Text = "X" Then
            Pro2 = "X"
        Else
        End If
        If Button6.Text = "X" Then
            Pro2 = "1"
        Else
        End If
        '-------------------------'
        If Button7.Text = "X" Then
            Pro3 = "2"
        Else
        End If
        If Button8.Text = "X" Then
            Pro3 = "X"
        Else
        End If
        If Button9.Text = "X" Then
            Pro3 = "1"
        Else
        End If
        '-------------------------'
        If Button10.Text = "X" Then
            Pro4 = "2"
        Else
        End If
        If Button11.Text = "X" Then
            Pro4 = "X"
        Else
        End If
        If Button12.Text = "X" Then
            Pro4 = "1"
        Else
        End If
        '-------------------------'
        If Button13.Text = "X" Then
            Pro5 = "2"
        Else
        End If
        If Button14.Text = "X" Then
            Pro5 = "X"
        Else
        End If
        If Button15.Text = "X" Then
            Pro5 = "1"
        Else
        End If
        '-------------------------'
        If Button16.Text = "X" Then
            Pro6 = "2"
        Else
        End If
        If Button17.Text = "X" Then
            Pro6 = "X"
        Else
        End If
        If Button18.Text = "X" Then
            Pro6 = "1"
        Else
        End If
        '-------------------------'
        If Button19.Text = "X" Then
            Pro7 = "2"
        Else
        End If
        If Button20.Text = "X" Then
            Pro7 = "X"
        Else
        End If
        If Button21.Text = "X" Then
            Pro7 = "1"
        Else
        End If
        '-------------------------'
        If Button22.Text = "X" Then
            Pro8 = "2"
        Else
        End If
        If Button23.Text = "X" Then
            Pro8 = "X"
        Else
        End If
        If Button24.Text = "X" Then
            Pro8 = "1"
        Else
        End If
        '-------------------------'
        If Button25.Text = "X" Then
            Pro9 = "2"
        Else
        End If
        If Button26.Text = "X" Then
            Pro9 = "X"
        Else
        End If
        If Button27.Text = "X" Then
            Pro9 = "1"
        Else
        End If
        '-------------------------'
        If Button287.Text = "X" Then
            Pro10 = "2"
        Else
        End If
        If Button29.Text = "X" Then
            Pro10 = "X"
        Else
        End If
        If Button30.Text = "X" Then
            Pro10 = "1"
        Else
        End If
        '-------------------------'
        If Button31.Text = "X" Then
            Pro11 = "2"
        Else
        End If
        If Button32.Text = "X" Then
            Pro11 = "X"
        Else
        End If
        If Button33.Text = "X" Then
            Pro11 = "1"
        Else
        End If
        '-------------------------'
        If Button34.Text = "X" Then
            Pro12 = "2"
        Else
        End If
        If Button35.Text = "X" Then
            Pro12 = "X"
        Else
        End If
        If Button36.Text = "X" Then
            Pro12 = "1"
        Else
        End If
        '-------------------------'
        If Button37.Text = "X" Then
            Pro13 = "2"
        Else
        End If
        If Button38.Text = "X" Then
            Pro13 = "X"
        Else
        End If
        If Button39.Text = "X" Then
            Pro13 = "1"
        Else
        End If
        '-------------------------'
        If Button40.Text = "X" Then
            Pro14 = "2"
        Else
        End If
        If Button41.Text = "X" Then
            Pro14 = "X"
        Else
        End If
        If Button42.Text = "X" Then
            Pro14 = "1"
        Else
        End If
        '-----------END------------'
        If Button43.Text = "X" Then
            Pro15 = "2"
        Else
        End If
        If Button44.Text = "X" Then
            Pro15 = "X"
        Else
        End If
        If Button45.Text = "X" Then
            Pro15 = "1"
        Else
        End If
        '-----------END------------'
        Confirma.Show()
    End Sub

    Private Sub IrAJornadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrAJornadaToolStripMenuItem.Click
        Ir_a.Show()
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem.Click
        Factura.Show()
    End Sub

    Private Sub InformacionGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionGeneralToolStripMenuItem.Click
        Manual.Show()
    End Sub

    Private Sub PremiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PremiosToolStripMenuItem.Click
        Premio.Show()
    End Sub
End Class