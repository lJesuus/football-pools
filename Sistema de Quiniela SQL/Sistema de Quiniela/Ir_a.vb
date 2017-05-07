Public Class Ir_a

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Not TypeOf ComboBox1.SelectedValue Is DataRowView Then
            Dim row As DataRowView = DirectCast(ComboBox1.SelectedItem, DataRowView)
            ID_Jornada = row.Item("ID_JORNADA").ToString
            Jornada.Show()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenacombobox()
    End Sub
End Class