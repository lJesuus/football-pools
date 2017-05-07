Public Class Factura

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta_Datosv4()
        Consulta_Datosv3()
        DataGridView1.DataSource = _dtv3Datos
        DataGridView2.DataSource = _dtv2Datos
        Dim ThisMoment As Date
        ThisMoment = Now
        Fecha.Text = ThisMoment
        Valor.Text = Quiniela.ValorX
    End Sub
End Class