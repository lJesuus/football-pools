Public Class Jornada
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Consulta_Datosv2()
        DataGridView1.DataSource = _dtv1Datos
    End Sub
End Class