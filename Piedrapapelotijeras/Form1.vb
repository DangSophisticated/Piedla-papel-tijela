Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Dim rachapartidas As Integer = 0
    Dim rojo, azul, verde, amarillo As String
    Dim rachacero = 0


    Private Enum opciones
        piedra
        papel
        tijera
    End Enum


    Private Function ganadorperdedor(jugador As opciones, computadora As opciones) As String
        If jugador = computadora Then
            Return "Empate."
        ElseIf (jugador = opciones.piedra AndAlso computadora = opciones.tijera) OrElse
                (jugador = opciones.papel AndAlso computadora = opciones.piedra) OrElse
                (jugador = opciones.tijera AndAlso computadora = opciones.papel) Then
            rachapartidas += 1
            lbl_racha.Text = rachapartidas
            Return "¡Ganaste!"

        Else
            rachapartidas = 0
            lbl_racha.Text = 0
            Return "Perdiste..."

        End If
    End Function

    Private Function generadorcpu() As opciones
        Dim rand As New Random()
        Return CType(rand.Next(0, 3), opciones)
    End Function

    Private Sub jugar(opcionJugador As opciones)
        Dim opcioncomp As opciones = generadorcpu()
        MessageBox.Show(ganadorperdedor(opcionJugador, opcioncomp))
        lbl_respuestacpu.Text = "Tu rival habia elegido... " & opcioncomp.ToString
    End Sub

    Private Sub lbl_titulo_Click(sender As Object, e As EventArgs) Handles lbl_titulo.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()

        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Hong Kong 97 theme (Remastered).wav", AudioPlayMode.BackgroundLoop)



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        rojo = Int(Rnd() * 255)
        verde = Int(Rnd() * 255)
        azul = Int(Rnd() * 255)
        amarillo = Int(Rnd() * 255)
        lbl_titulo.ForeColor = Color.FromArgb(rojo, azul, verde, amarillo)


    End Sub

    Private Sub btn_piedra_Click(sender As Object, e As EventArgs) Handles btn_piedra.Click
        jugar(opciones.piedra)
    End Sub

    Private Sub btn_papel_Click(sender As Object, e As EventArgs) Handles btn_papel.Click
        jugar(opciones.papel)
    End Sub

    Private Sub btn_tijera_Click(sender As Object, e As EventArgs) Handles btn_tijera.Click
        jugar(opciones.tijera)
    End Sub

End Class
