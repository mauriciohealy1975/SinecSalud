Public Class Reloj
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LH.Text = Format(DateAndTime.TimeOfDay, "hh") & ":"
        LM.Text = Format(DateAndTime.TimeOfDay, "mm")
        LS.Text = Format(DateAndTime.TimeOfDay, "ss")

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Val(LH.Text) > 11 Then
            LDN.Text = "PM"
        Else
            LDN.Text = "AM"
        End If
    End Sub

    Private Sub Reloj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.1

    End Sub
End Class