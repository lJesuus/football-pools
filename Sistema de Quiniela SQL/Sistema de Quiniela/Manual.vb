Public Class Manual

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox2.Text = "Cómo se juega" & vbNewLine & "Selecciona el tipo de apuesta, elige los números y pulsa 'Continuar'" & vbNewLine & "Se apuesta para la jornada inmediatamente siguiente de fútbol." & vbNewLine & "Elige los 15 pronósticos en cada apuesta. En los 15  hay que acertar en cada partido si gana el primer equipo (1), empatan (X) o gana el segundo equipo (2)." & vbNewLine & "Revisa tu apuesta y pulsa en 'Aceptar'" & vbNewLine & "Decide si quieres guardar tu apuesta y revísala antes de pagar." & vbNewLine & "Compra tu apuesta" & vbNewLine & "Cada apuesta vale desde 10-30 Bs.F segun la cantidad de pronosticos hechos. Debes realizar al menos dos apuestas para validar un boleto. " & vbNewLine & "En general tendrás premio si aciertas al menos el pronóstico de 10 partidos de entre los catorce primeros. (Véase la normativa al respecto)." & vbNewLine & "El escrutinio se realiza unos 30 minutos después de la celebración del último evento de la jornada de fútbol."
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = "Cómo se juega" & vbNewLine & vbNewLine & "Selecciona el tipo de apuesta, elige los números y pulsa 'Continuar'" & vbNewLine & "Se apuesta para la jornada inmediatamente siguiente de fútbol." & vbNewLine & vbNewLine & "Elige los 15 pronósticos en cada apuesta. En los 15  hay que acertar en cada partido si gana el primer equipo (1), empatan (X) o gana el segundo equipo (2)." & vbNewLine & vbNewLine & "Revisa tu apuesta y pulsa en 'Aceptar'" & vbNewLine & vbNewLine & "Decide si quieres guardar tu apuesta y revísala antes de pagar." & vbNewLine & vbNewLine & "Compra tu apuesta" & vbNewLine & vbNewLine & "Cada apuesta vale desde 10-30 Bs.F segun la cantidad de pronosticos hechos. Debes realizar al menos dos apuestas para validar un boleto. " & vbNewLine & vbNewLine & "En general tendrás premio si aciertas al menos el pronóstico de 10 partidos de entre los catorce primeros. (Véase la normativa al respecto)." & vbNewLine & vbNewLine & "El escrutinio se realiza unos 30 minutos después de la celebración del último evento de la jornada de fútbol."
    End Sub
End Class