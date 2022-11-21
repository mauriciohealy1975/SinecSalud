Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Odontograma

    Dim col As Integer
    Dim color_del_diente As String
    Private Sub colorearPanel(ByVal numColor As Integer, btn As String)


        If Not Controls(btn).BackColor = Color.Silver Then
            Controls(btn).BackColor = Color.Silver

        Else
            If col = 1 Then
                Controls(btn).BackColor = Color.Red
                color_del_diente = "rojo"
                MessageBox.Show(color_del_diente)
            End If
            If col = 2 Then
                Controls(btn).BackColor = Color.Green
                color_del_diente = "verde"
                MessageBox.Show(color_del_diente)
            End If
            If col = 3 Then
                Controls(btn).BackColor = Color.Blue
                color_del_diente = "azul"
                MessageBox.Show(color_del_diente)
            End If
            If col = 4 Then
                Controls(btn).BackColor = Color.Black
                color_del_diente = "negro"
                MessageBox.Show(color_del_diente)
            End If
        End If


    End Sub
    '========================= BOTONES DE LOS COLORES ====================================================
    Private Function colorearPanelPrueba(ByVal numColor As Integer)
        If col = 1 Then
            BackColor = Color.Red
        End If
    End Function

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        panelPrueba.BackColor = Color.Red
        col = 1

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        panelPrueba.BackColor = Color.Green
        col = 2

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        panelPrueba.BackColor = Color.Blue
        col = 3

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        panelPrueba.BackColor = Color.Black
        col = 4

    End Sub
    Private Sub panelPrueba_Click(sender As Object, e As EventArgs)

    End Sub
    '=======================================PANELES ======================================================
    Private Sub diente18medio_Click(sender As Object, e As EventArgs) Handles diente18medio.Click
        Dim numeroDiente As Integer = 18
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)

        MessageBox.Show(lado)
        MessageBox.Show(numeroDiente)


    End Sub

    Private Sub diente18abajo_Click(sender As Object, e As EventArgs) Handles diente18abajo.Click
        Dim numeroDiente As Integer = 18
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)

        MessageBox.Show(lado)
        MessageBox.Show(numeroDiente)
    End Sub

    Private Sub diente18arriba_Click(sender As Object, e As EventArgs) Handles diente18arriba.Click
        Dim numeroDiente As Integer = 18
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)

        MessageBox.Show(lado)
        MessageBox.Show(numeroDiente)
    End Sub

    Private Sub diente18izquierda_Click(sender As Object, e As EventArgs) Handles diente18izquierda.Click
        Dim numeroDiente As Integer = 18
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)

        MessageBox.Show(lado)
        MessageBox.Show(numeroDiente)
    End Sub


    Private Sub diente18derecha_Click(sender As Object, e As EventArgs) Handles diente18derecha.Click
        Dim numeroDiente As Integer = 18
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)

        MessageBox.Show(lado)
        MessageBox.Show(numeroDiente)
    End Sub

    Private Sub diente17abajo_Click(sender As Object, e As EventArgs) Handles diente17abajo.Click
        Dim numeroDiente As Integer = 17
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)

        MessageBox.Show(lado)
    End Sub

    Private Sub diente17derecha_Click(sender As Object, e As EventArgs) Handles diente17derecha.Click
        Dim numeroDiente As Integer = 17
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)

        MessageBox.Show(lado)
    End Sub

    Private Sub diente17arriba_Click(sender As Object, e As EventArgs) Handles diente17arriba.Click
        Dim numeroDiente As Integer = 17
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)

        MessageBox.Show(lado)
    End Sub

    Private Sub diente17medio_Click(sender As Object, e As EventArgs) Handles diente17medio.Click
        Dim numeroDiente As Integer = 17
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)

        MessageBox.Show(lado)
    End Sub

    Private Sub diente17izquierda_Click(sender As Object, e As EventArgs) Handles diente17izquierda.Click
        Dim numeroDiente As Integer = 17
        Dim lado As String = "izquierdo"
        Dim btn = sender.name
        colorearPanel(col, btn)

        MessageBox.Show(lado)
    End Sub

    Private Sub Panel190_Click(sender As Object, e As EventArgs) Handles Panel190.Click
        Dim numeroDiente As Integer = 16
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)

        MessageBox.Show(lado)
    End Sub

    Private Sub Panel241_Click(sender As Object, e As EventArgs) Handles Panel241.Click
        Dim numeroDiente As Integer = 16
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel209_Click(sender As Object, e As EventArgs) Handles Panel209.Click
        Dim numeroDiente As Integer = 16
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub diente16arriba_Click(sender As Object, e As EventArgs) Handles diente16arriba.Click
        Dim numeroDiente As Integer = 16
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel225_Click(sender As Object, e As EventArgs) Handles Panel225.Click
        Dim numeroDiente As Integer = 16
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel178_Click(sender As Object, e As EventArgs) Handles Panel178.Click
        Dim numeroDiente As Integer = 15
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel217_Click(sender As Object, e As EventArgs) Handles Panel217.Click
        Dim numeroDiente As Integer = 15
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel182_Click(sender As Object, e As EventArgs) Handles Panel182.Click
        Dim numeroDiente As Integer = 15
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel233_Click(sender As Object, e As EventArgs) Handles Panel233.Click
        Dim numeroDiente As Integer = 15
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel198_Click(sender As Object, e As EventArgs) Handles Panel198.Click
        Dim numeroDiente As Integer = 15
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel247_Click(sender As Object, e As EventArgs) Handles Panel247.Click
        Dim numeroDiente As Integer = 14
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel215_Click(sender As Object, e As EventArgs) Handles Panel215.Click
        Dim numeroDiente As Integer = 14
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel251_Click(sender As Object, e As EventArgs) Handles Panel251.Click
        Dim numeroDiente As Integer = 14
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel231_Click(sender As Object, e As EventArgs) Handles Panel231.Click
        Dim numeroDiente As Integer = 14
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub
    Private Sub Panel200_Click(sender As Object, e As EventArgs) Handles Panel200.Click
        Dim numeroDiente As Integer = 14
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel184_Click(sender As Object, e As EventArgs) Handles Panel184.Click
        Dim numeroDiente As Integer = 13
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel223_Click(sender As Object, e As EventArgs) Handles Panel223.Click
        Dim numeroDiente As Integer = 13
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel192_Click(sender As Object, e As EventArgs) Handles Panel192.Click
        Dim numeroDiente As Integer = 13
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel239_Click(sender As Object, e As EventArgs) Handles Panel239.Click
        Dim numeroDiente As Integer = 13
        Dim laso As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel207_Click(sender As Object, e As EventArgs) Handles Panel207.Click
        Dim numeroDiente As Integer = 13
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel188_Click(sender As Object, e As EventArgs) Handles Panel188.Click
        Dim numeroDiente As Integer = 12
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel235_Click(sender As Object, e As EventArgs) Handles Panel235.Click
        Dim numeroDiente As Integer = 12
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel202_Click(sender As Object, e As EventArgs) Handles Panel202.Click
        Dim numeroDiente As Integer = 12
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel243_Click(sender As Object, e As EventArgs) Handles Panel243.Click
        Dim numeroDiente As Integer = 12
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel219_Click(sender As Object, e As EventArgs) Handles Panel219.Click
        Dim numeroDiente As Integer = 12
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel176_Click(sender As Object, e As EventArgs) Handles Panel176.Click
        Dim numeroDiente As Integer = 11
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel211_Click(sender As Object, e As EventArgs) Handles Panel211.Click
        Dim numeroDiente As Integer = 11
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel180_Click(sender As Object, e As EventArgs) Handles Panel180.Click
        Dim numeroDiente As Integer = 11
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel227_Click(sender As Object, e As EventArgs) Handles Panel227.Click
        Dim numeroDiente As Integer = 11
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel196_Click(sender As Object, e As EventArgs) Handles Panel196.Click
        Dim numeroDiente As Integer = 11
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel250_Click(sender As Object, e As EventArgs) Handles Panel250.Click
        Dim numeroDiente As Integer = 21
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel218_Click(sender As Object, e As EventArgs) Handles Panel218.Click
        Dim numeroDiente As Integer = 21
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel252_Click(sender As Object, e As EventArgs) Handles Panel252.Click
        Dim numeroDiente As Integer = 21
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel234_Click(sender As Object, e As EventArgs) Handles Panel234.Click
        Dim numeroDiente As Integer = 21
        Dim lado As String = "izquierdo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel203_Click(sender As Object, e As EventArgs) Handles Panel203.Click
        Dim numeroDiente As Integer = 21
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel185_Click(sender As Object, e As EventArgs) Handles Panel185.Click
        Dim numeroDiente As Integer = 22
        Dim las As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel210_Click(sender As Object, e As EventArgs) Handles Panel210.Click
        Dim numeroDiente As Integer = 22
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel226_Click(sender As Object, e As EventArgs) Handles Panel226.Click
        Dim numeroDiente As Integer = 22
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel193_Click(sender As Object, e As EventArgs) Handles Panel193.Click
        Dim numeroDiente As Integer = 22
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel242_Click(sender As Object, e As EventArgs) Handles Panel242.Click
        Dim numeroDiente As Integer = 22
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel189_Click(sender As Object, e As EventArgs) Handles Panel189.Click
        Dim numeroDiente As Integer = 23
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel238_Click(sender As Object, e As EventArgs) Handles Panel238.Click
        Dim numeroDiente As Integer = 23
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel206_Click(sender As Object, e As EventArgs) Handles Panel206.Click
        Dim numeroDiente As Integer = 23
        Dim lado As String = "derecho"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel246_Click(sender As Object, e As EventArgs) Handles Panel246.Click
        Dim numeroDiente As Integer = 23
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel222_Click(sender As Object, e As EventArgs) Handles Panel222.Click
        Dim numeroDiente As Integer = 23
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel177_Click(sender As Object, e As EventArgs) Handles Panel177.Click
        Dim numeroDiente As Integer = 24
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel214_Click(sender As Object, e As EventArgs) Handles Panel214.Click
        Dim numeroDiente As Integer = 24
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel181_Click(sender As Object, e As EventArgs) Handles Panel181.Click
        Dim numeroDiente As Integer = 24
        Dim lado As String = "derecho"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel230_Click(sender As Object, e As EventArgs) Handles Panel230.Click
        Dim numeroDiente As Integer = 24
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel197_Click(sender As Object, e As EventArgs) Handles Panel197.Click
        Dim numeroDiente As Integer = 24
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel199_Click(sender As Object, e As EventArgs) Handles Panel199.Click
        Dim numeroDiente As Integer = 25
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel244_Click(sender As Object, e As EventArgs) Handles Panel244.Click
        Dim numeroDiente As Integer = 25
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel212_Click(sender As Object, e As EventArgs) Handles Panel212.Click
        Dim numeroDiente As Integer = 25
        Dim lado As String = "derecho"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel248_Click(sender As Object, e As EventArgs) Handles Panel248.Click
        Dim numeroDiente As Integer = 25
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel228_Click(sender As Object, e As EventArgs) Handles Panel228.Click
        Dim numeroDiente As Integer = 25
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel183_Click(sender As Object, e As EventArgs) Handles Panel183.Click
        Dim numeroDiente As Integer = 26
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel220_Click(sender As Object, e As EventArgs) Handles Panel220.Click
        Dim numeroDiente As Integer = 26
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel191_Click(sender As Object, e As EventArgs) Handles Panel191.Click
        Dim numeroDiente As Integer = 26
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel236_Click(sender As Object, e As EventArgs) Handles Panel236.Click
        Dim numeroDiente As Integer = 26
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel204_Click(sender As Object, e As EventArgs) Handles Panel204.Click
        Dim numeroDiente As Integer = 26
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel187_Click(sender As Object, e As EventArgs) Handles Panel187.Click
        Dim numeroDiente As Integer = 27
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel232_Click(sender As Object, e As EventArgs) Handles Panel232.Click
        Dim numeroDiente As Integer = 27
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel201_Click(sender As Object, e As EventArgs) Handles Panel201.Click
        Dim numeroDiente As Integer = 27
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel240_Click(sender As Object, e As EventArgs) Handles Panel240.Click
        Dim numeroDiente As Integer = 27
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel216_Click(sender As Object, e As EventArgs) Handles Panel216.Click
        Dim numeroDiente As Integer = 27
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel175_Click(sender As Object, e As EventArgs) Handles Panel175.Click
        Dim numeroDiente As Integer = 28
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel208_Click(sender As Object, e As EventArgs) Handles Panel208.Click
        Dim numeroDiente As Integer = 28
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel179_Click(sender As Object, e As EventArgs) Handles Panel179.Click
        Dim numeroDiente As Integer = 28
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel224_Click(sender As Object, e As EventArgs) Handles Panel224.Click
        Dim numeroDiente As Integer = 28
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel195_Click(sender As Object, e As EventArgs) Handles Panel195.Click
        Dim numeroDiente As Integer = 28
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub prueba5_Click(sender As Object, e As EventArgs) Handles prueba5.Click
        Dim numeroDiente As Integer = 48
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub prueba2_Click(sender As Object, e As EventArgs) Handles prueba2.Click
        Dim numeroDiente As Integer = 48
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub prueba4_Click(sender As Object, e As EventArgs) Handles prueba4.Click
        Dim numeroDiente As Integer = 48
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub prueba1_Click(sender As Object, e As EventArgs) Handles prueba1.Click
        Dim numeroDiente As Integer = 48
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub prueba3_Click(sender As Object, e As EventArgs) Handles prueba3.Click
        Dim numeroDiente As Integer = 48
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel20_Click(sender As Object, e As EventArgs) Handles Panel20.Click
        Dim numeroDiente As Integer = 47
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel23_Click(sender As Object, e As EventArgs) Handles Panel23.Click
        Dim numeroDiente As Integer = 47
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel21_Click(sender As Object, e As EventArgs) Handles Panel21.Click
        Dim numeroDiente As Integer = 47
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel24_Click(sender As Object, e As EventArgs) Handles Panel24.Click
        Dim numeroDiente As Integer = 47
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel22_Click(sender As Object, e As EventArgs) Handles Panel22.Click
        Dim numeroDiente As Integer = 47
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel27_Click(sender As Object, e As EventArgs) Handles Panel27.Click
        Dim numeroDiente As Integer = 46
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel33_Click(sender As Object, e As EventArgs) Handles Panel33.Click
        Dim numeroDiente As Integer = 46
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel29_Click(sender As Object, e As EventArgs) Handles Panel29.Click
        Dim numeroDiente As Integer = 46
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel34_Click(sender As Object, e As EventArgs) Handles Panel34.Click
        Dim numeroDiente As Integer = 46
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel31_Click(sender As Object, e As EventArgs) Handles Panel31.Click
        Dim numeroDiente As Integer = 46
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel25_Click(sender As Object, e As EventArgs) Handles Panel25.Click
        Dim numeroDiente As Integer = 45
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel30_Click(sender As Object, e As EventArgs) Handles Panel30.Click
        Dim numeroDiente As Integer = 45
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel26_Click(sender As Object, e As EventArgs) Handles Panel26.Click
        Dim numeroDiente As Integer = 45
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel32_Click(sender As Object, e As EventArgs) Handles Panel32.Click
        Dim numeroDiente As Integer = 45
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel28_Click(sender As Object, e As EventArgs) Handles Panel28.Click
        Dim numeroDiente As Integer = 45
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel41_Click(sender As Object, e As EventArgs) Handles Panel41.Click
        Dim numeroDiente As Integer = 44
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel53_Click(sender As Object, e As EventArgs) Handles Panel53.Click
        Dim numeroDiente As Integer = 44
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel45_Click(sender As Object, e As EventArgs) Handles Panel45.Click
        Dim numeroDiente As Integer = 44
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel54_Click(sender As Object, e As EventArgs) Handles Panel54.Click
        Dim numeroDiente As Integer = 44
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel49_Click(sender As Object, e As EventArgs) Handles Panel49.Click
        Dim numeroDiente As Integer = 44
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel37_Click(sender As Object, e As EventArgs) Handles Panel37.Click
        Dim numeroDiente As Integer = 43
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel47_Click(sender As Object, e As EventArgs) Handles Panel47.Click
        Dim numeroDiente As Integer = 43
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel39_Click(sender As Object, e As EventArgs) Handles Panel39.Click
        Dim numeroDiente As Integer = 43
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel51_Click(sender As Object, e As EventArgs) Handles Panel51.Click
        Dim numeroDiente As Integer = 43
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel43_Click(sender As Object, e As EventArgs) Handles Panel43.Click
        Dim numeroDiente As Integer = 43
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel38_Click(sender As Object, e As EventArgs) Handles Panel38.Click
        Dim numeroDiente As Integer = 42
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel50_Click(sender As Object, e As EventArgs) Handles Panel50.Click
        Dim numeroDiente As Integer = 42
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel42_Click(sender As Object, e As EventArgs) Handles Panel42.Click
        Dim numeroDiente As Integer = 42
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel52_Click(sender As Object, e As EventArgs) Handles Panel52.Click
        Dim numeroDiente As Integer = 42
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel46_Click(sender As Object, e As EventArgs) Handles Panel46.Click
        Dim numeroDiente As Integer = 42
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel35_Click(sender As Object, e As EventArgs) Handles Panel35.Click
        Dim numeroDiente As Integer = 41
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel44_Click(sender As Object, e As EventArgs) Handles Panel44.Click
        Dim numeroDiente As Integer = 41
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel36_Click(sender As Object, e As EventArgs) Handles Panel36.Click
        Dim numeroDiente As Integer = 41
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel48_Click(sender As Object, e As EventArgs) Handles Panel48.Click
        Dim numeroDiente As Integer = 41
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel40_Click(sender As Object, e As EventArgs) Handles Panel40.Click
        Dim numeroDiente As Integer = 41
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel69_Click(sender As Object, e As EventArgs) Handles Panel69.Click
        Dim numeroDiente As Integer = 31
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel93_Click(sender As Object, e As EventArgs) Handles Panel93.Click
        Dim numeroDiente As Integer = 31
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel77_Click(sender As Object, e As EventArgs) Handles Panel77.Click
        Dim numeroDiente As Integer = 31
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel94_Click(sender As Object, e As EventArgs) Handles Panel94.Click
        Dim numeroDiente As Integer = 31
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel85_Click(sender As Object, e As EventArgs) Handles Panel85.Click
        Dim numeroDiente As Integer = 31
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel60_Click(sender As Object, e As EventArgs) Handles Panel60.Click
        Dim numeroDiente As Integer = 32
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel81_Click(sender As Object, e As EventArgs) Handles Panel81.Click
        Dim numeroDiente As Integer = 32
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel64_Click(sender As Object, e As EventArgs) Handles Panel64.Click
        Dim numeroDiente As Integer = 32
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel89_Click(sender As Object, e As EventArgs) Handles Panel89.Click
        Dim numeroDiente As Integer = 32
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel73_Click(sender As Object, e As EventArgs) Handles Panel73.Click
        Dim numeroDiente As Integer = 32
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel62_Click(sender As Object, e As EventArgs) Handles Panel62.Click
        Dim numeroDiente As Integer = 33
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel87_Click(sender As Object, e As EventArgs) Handles Panel87.Click
        Dim numeroDiente As Integer = 33
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel71_Click(sender As Object, e As EventArgs) Handles Panel71.Click
        Dim numeroDiente As Integer = 33
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel91_Click(sender As Object, e As EventArgs) Handles Panel91.Click
        Dim numeroDiente As Integer = 33
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel79_Click(sender As Object, e As EventArgs) Handles Panel79.Click
        Dim numeroDiente As Integer = 33
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel56_Click(sender As Object, e As EventArgs) Handles Panel56.Click
        Dim numeroDiente As Integer = 34
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel75_Click(sender As Object, e As EventArgs) Handles Panel75.Click
        Dim numeroDiente As Integer = 34
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel58_Click(sender As Object, e As EventArgs) Handles Panel58.Click
        Dim numeroDiente As Integer = 34
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel83_Click(sender As Object, e As EventArgs) Handles Panel83.Click
        Dim numeroDiente As Integer = 34
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel66_Click(sender As Object, e As EventArgs) Handles Panel66.Click
        Dim numeroDiente As Integer = 34
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel67_Click(sender As Object, e As EventArgs) Handles Panel67.Click
        Dim numeroDiente As Integer = 35
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel90_Click(sender As Object, e As EventArgs) Handles Panel90.Click
        Dim numeroDiente As Integer = 35
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel74_Click(sender As Object, e As EventArgs) Handles Panel74.Click
        Dim numeroDiente As Integer = 35
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel92_Click(sender As Object, e As EventArgs) Handles Panel92.Click
        Dim numeroDiente As Integer = 35
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel82_Click(sender As Object, e As EventArgs) Handles Panel82.Click
        Dim numeroDiente As Integer = 35
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel59_Click(sender As Object, e As EventArgs) Handles Panel59.Click
        Dim numeroDiente As Integer = 36
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel78_Click(sender As Object, e As EventArgs) Handles Panel78.Click
        Dim numeroDiente As Integer = 36
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel63_Click(sender As Object, e As EventArgs) Handles Panel63.Click
        Dim numeroDiente As Integer = 36
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel86_Click(sender As Object, e As EventArgs) Handles Panel86.Click
        Dim numeroDiente As Integer = 36
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel70_Click(sender As Object, e As EventArgs) Handles Panel70.Click
        Dim numeroDiente As Integer = 36
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel61_Click(sender As Object, e As EventArgs) Handles Panel61.Click
        Dim numeroDiente As Integer = 37
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel84_Click(sender As Object, e As EventArgs) Handles Panel84.Click
        Dim numeroDiente As Integer = 37
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel68_Click(sender As Object, e As EventArgs) Handles Panel68.Click
        Dim numeroDiente As Integer = 37
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel88_Click(sender As Object, e As EventArgs) Handles Panel88.Click
        Dim numeroDiente As Integer = 37
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel76_Click(sender As Object, e As EventArgs) Handles Panel76.Click
        Dim numeroDiente As Integer = 37
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel55_Click(sender As Object, e As EventArgs) Handles Panel55.Click
        Dim numeroDiente As Integer = 38
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel72_Click(sender As Object, e As EventArgs) Handles Panel72.Click
        Dim numeroDiente As Integer = 38
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel57_Click(sender As Object, e As EventArgs) Handles Panel57.Click
        Dim numeroDiente As Integer = 38
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel80_Click(sender As Object, e As EventArgs) Handles Panel80.Click
        Dim numeroDiente As Integer = 38
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel65_Click(sender As Object, e As EventArgs) Handles Panel65.Click
        Dim numeroDiente As Integer = 38
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel104_Click(sender As Object, e As EventArgs) Handles Panel104.Click
        Dim numeroDiente As Integer = 55
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel134_Click(sender As Object, e As EventArgs) Handles Panel134.Click
        Dim numeroDiente As Integer = 55
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel113_Click(sender As Object, e As EventArgs) Handles Panel113.Click
        Dim numeroDiente As Integer = 55
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel139_Click(sender As Object, e As EventArgs) Handles Panel139.Click
        Dim numeroDiente As Integer = 55
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel124_Click(sender As Object, e As EventArgs) Handles Panel124.Click
        Dim numeroDiente As Integer = 55
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel96_Click(sender As Object, e As EventArgs) Handles Panel96.Click
        Dim numeroDiente As Integer = 54
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel119_Click(sender As Object, e As EventArgs) Handles Panel119.Click
        Dim numeroDiente As Integer = 54
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel99_Click(sender As Object, e As EventArgs) Handles Panel99.Click
        Dim numeroDiente As Integer = 54
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel129_Click(sender As Object, e As EventArgs) Handles Panel129.Click
        Dim numeroDiente As Integer = 54
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel109_Click(sender As Object, e As EventArgs) Handles Panel109.Click
        Dim numeroDiente As Integer = 54
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel114_Click(sender As Object, e As EventArgs) Handles Panel114.Click
        Dim numeroDiente As Integer = 53
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel143_Click(sender As Object, e As EventArgs) Handles Panel143.Click
        Dim numeroDiente As Integer = 53
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel123_Click(sender As Object, e As EventArgs) Handles Panel123.Click
        Dim numeroDiente As Integer = 53
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel144_Click(sender As Object, e As EventArgs) Handles Panel144.Click
        Dim numeroDiente As Integer = 53
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel133_Click(sender As Object, e As EventArgs) Handles Panel133.Click
        Dim numeroDiente As Integer = 53
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel102_Click(sender As Object, e As EventArgs) Handles Panel102.Click
        Dim numeroDiente As Integer = 52
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel128_Click(sender As Object, e As EventArgs) Handles Panel128.Click
        Dim numeroDiente As Integer = 52
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel107_Click(sender As Object, e As EventArgs) Handles Panel107.Click
        Dim numeroDiente As Integer = 52
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel138_Click(sender As Object, e As EventArgs) Handles Panel138.Click
        Dim numeroDiente As Integer = 52
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel118_Click(sender As Object, e As EventArgs) Handles Panel118.Click
        Dim numeroDiente As Integer = 52
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel105_Click(sender As Object, e As EventArgs) Handles Panel105.Click
        Dim numeroDiente As Integer = 51
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel136_Click(sender As Object, e As EventArgs) Handles Panel136.Click
        Dim numeroDiente As Integer = 51
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel116_Click(sender As Object, e As EventArgs) Handles Panel116.Click
        Dim numeroDiente As Integer = 51
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel141_Click(sender As Object, e As EventArgs) Handles Panel141.Click
        Dim numeroDiente As Integer = 51
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel126_Click(sender As Object, e As EventArgs) Handles Panel126.Click
        Dim numeroDiente As Integer = 51
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel97_Click(sender As Object, e As EventArgs) Handles Panel97.Click
        Dim numeroDiente As Integer = 61
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel121_Click(sender As Object, e As EventArgs) Handles Panel121.Click
        Dim numeroDiente As Integer = 61
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel100_Click(sender As Object, e As EventArgs) Handles Panel100.Click
        Dim numeroDiente As Integer = 61
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel131_Click(sender As Object, e As EventArgs) Handles Panel131.Click
        Dim numeroDiente As Integer = 61
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel110_Click(sender As Object, e As EventArgs) Handles Panel110.Click
        Dim numeroDiente As Integer = 61
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel111_Click(sender As Object, e As EventArgs) Handles Panel111.Click
        Dim numeroDiente As Integer = 62
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel140_Click(sender As Object, e As EventArgs) Handles Panel140.Click
        Dim numeroDiente As Integer = 62
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel120_Click(sender As Object, e As EventArgs) Handles Panel120.Click
        Dim numeroDiente As Integer = 62
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel142_Click(sender As Object, e As EventArgs) Handles Panel142.Click
        Dim numeroDiente As Integer = 62
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel130_Click(sender As Object, e As EventArgs) Handles Panel130.Click
        Dim numeroDiente As Integer = 62
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel101_Click(sender As Object, e As EventArgs) Handles Panel101.Click
        Dim numeroDiente As Integer = 63
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel125_Click(sender As Object, e As EventArgs) Handles Panel125.Click
        Dim numeroDiente As Integer = 63
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel106_Click(sender As Object, e As EventArgs) Handles Panel106.Click
        Dim numeroDiente As Integer = 63
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel135_Click(sender As Object, e As EventArgs) Handles Panel135.Click
        Dim numeroDiente As Integer = 63
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel115_Click(sender As Object, e As EventArgs) Handles Panel115.Click
        Dim numeroDiente As Integer = 63
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel103_Click(sender As Object, e As EventArgs) Handles Panel103.Click
        Dim numeroDiente As Integer = 64
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel132_Click(sender As Object, e As EventArgs) Handles Panel132.Click
        Dim numeroDiente As Integer = 64
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel112_Click(sender As Object, e As EventArgs) Handles Panel112.Click
        Dim numeroDiente As Integer = 64
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel137_Click(sender As Object, e As EventArgs) Handles Panel137.Click
        Dim numeroDiente As Integer = 64
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel122_Click(sender As Object, e As EventArgs) Handles Panel122.Click
        Dim numeroDiente As Integer = 64
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel95_Click(sender As Object, e As EventArgs) Handles Panel95.Click
        Dim numeroDiente As Integer = 65
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel117_Click(sender As Object, e As EventArgs) Handles Panel117.Click
        Dim numeroDiente As Integer = 65
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel98_Click(sender As Object, e As EventArgs) Handles Panel98.Click
        Dim numeroDiente As Integer = 65
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel127_Click(sender As Object, e As EventArgs) Handles Panel127.Click
        Dim numeroDiente As Integer = 65
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel108_Click(sender As Object, e As EventArgs) Handles Panel108.Click
        Dim numeroDiente As Integer = 65
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel154_Click(sender As Object, e As EventArgs) Handles Panel154.Click
        Dim numeroDiente As Integer = 85
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel264_Click(sender As Object, e As EventArgs) Handles Panel264.Click
        Dim numeroDiente As Integer = 85
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel163_Click(sender As Object, e As EventArgs) Handles Panel163.Click
        Dim numeroDiente As Integer = 85
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel269_Click(sender As Object, e As EventArgs) Handles Panel269.Click
        Dim numeroDiente As Integer = 85
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel174_Click(sender As Object, e As EventArgs) Handles Panel174.Click
        Dim numeroDiente As Integer = 85
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel146_Click(sender As Object, e As EventArgs) Handles Panel146.Click
        Dim numeroDiente As Integer = 84
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel169_Click(sender As Object, e As EventArgs) Handles Panel169.Click
        Dim numeroDiente As Integer = 84
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel149_Click(sender As Object, e As EventArgs) Handles Panel149.Click
        Dim numeroDiente As Integer = 84
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel259_Click(sender As Object, e As EventArgs) Handles Panel259.Click
        Dim numeroDiente As Integer = 84
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel159_Click(sender As Object, e As EventArgs) Handles Panel159.Click
        Dim numeroDiente As Integer = 84
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel164_Click(sender As Object, e As EventArgs) Handles Panel164.Click
        Dim numeroDiente As Integer = 83
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel273_Click(sender As Object, e As EventArgs) Handles Panel273.Click
        Dim numeroDiente As Integer = 83
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel173_Click(sender As Object, e As EventArgs) Handles Panel173.Click
        Dim numeroDiente As Integer = 83
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel274_Click(sender As Object, e As EventArgs) Handles Panel274.Click
        Dim numeroDiente As Integer = 83
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel263_Click(sender As Object, e As EventArgs) Handles Panel263.Click
        Dim numeroDiente As Integer = 83
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel152_Click(sender As Object, e As EventArgs) Handles Panel152.Click
        Dim numeroDiente As Integer = 82
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel258_Click(sender As Object, e As EventArgs) Handles Panel258.Click
        Dim numeroDiente As Integer = 82
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel157_Click(sender As Object, e As EventArgs) Handles Panel157.Click
        Dim numeroDiente As Integer = 82
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel268_Click(sender As Object, e As EventArgs) Handles Panel268.Click
        Dim numeroDiente As Integer = 82
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel168_Click(sender As Object, e As EventArgs) Handles Panel168.Click
        Dim numeroDiente As Integer = 82
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel155_Click(sender As Object, e As EventArgs) Handles Panel155.Click
        Dim numeroDiente As Integer = 81
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel266_Click(sender As Object, e As EventArgs) Handles Panel266.Click
        Dim numeroDiente As Integer = 81
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel166_Click(sender As Object, e As EventArgs) Handles Panel166.Click
        Dim numeroDiente As Integer = 81
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel271_Click(sender As Object, e As EventArgs) Handles Panel271.Click
        Dim numeroDiente As Integer = 81
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel256_Click(sender As Object, e As EventArgs) Handles Panel256.Click
        Dim numeroDiente As Integer = 81
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel147_Click(sender As Object, e As EventArgs) Handles Panel147.Click
        Dim numeroDiente As Integer = 71
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel171_Click(sender As Object, e As EventArgs) Handles Panel171.Click
        Dim numeroDiente As Integer = 71
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel150_Click(sender As Object, e As EventArgs) Handles Panel150.Click
        Dim numeroDiente As Integer = 71
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel261_Click(sender As Object, e As EventArgs) Handles Panel261.Click
        Dim numeroDiente As Integer = 71
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel160_Click(sender As Object, e As EventArgs) Handles Panel160.Click
        Dim numeroDiente As Integer = 71
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel161_Click(sender As Object, e As EventArgs) Handles Panel161.Click
        Dim numeroDiente As Integer = 72
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel270_Click(sender As Object, e As EventArgs) Handles Panel270.Click
        Dim numeroDiente As Integer = 72
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel170_Click(sender As Object, e As EventArgs) Handles Panel170.Click
        Dim numeroDiente As Integer = 72
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel272_Click(sender As Object, e As EventArgs) Handles Panel272.Click
        Dim numeroDiente As Integer = 72
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel260_Click(sender As Object, e As EventArgs) Handles Panel260.Click
        Dim numeroDiente As Integer = 72
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel151_Click(sender As Object, e As EventArgs) Handles Panel151.Click
        Dim numeroDiente As Integer = 73
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel255_Click(sender As Object, e As EventArgs) Handles Panel255.Click
        Dim numeroDiente As Integer = 73
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel156_Click(sender As Object, e As EventArgs) Handles Panel156.Click
        Dim numeroDiente As Integer = 73
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel265_Click(sender As Object, e As EventArgs) Handles Panel265.Click
        Dim numeroDiente As Integer = 73
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel165_Click(sender As Object, e As EventArgs) Handles Panel165.Click
        Dim numeroDiente As Integer = 73
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel153_Click(sender As Object, e As EventArgs) Handles Panel153.Click
        Dim numeroDiente As Integer = 74
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel262_Click(sender As Object, e As EventArgs) Handles Panel262.Click
        Dim numeroDiente As Integer = 74
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel162_Click(sender As Object, e As EventArgs) Handles Panel162.Click
        Dim numeroDiente As Integer = 74
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel267_Click(sender As Object, e As EventArgs) Handles Panel267.Click
        Dim numeroDiente As Integer = 74
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel172_Click(sender As Object, e As EventArgs) Handles Panel172.Click
        Dim numeroDiente As Integer = 74
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel145_Click(sender As Object, e As EventArgs) Handles Panel145.Click
        Dim numeroDiente As Integer = 75
        Dim lado As String = "medio"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel167_Click(sender As Object, e As EventArgs) Handles Panel167.Click
        Dim numeroDiente As Integer = 75
        Dim lado As String = "abajo"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel148_Click(sender As Object, e As EventArgs) Handles Panel148.Click
        Dim numeroDiente As Integer = 75
        Dim lado As String = "derecha"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel257_Click(sender As Object, e As EventArgs) Handles Panel257.Click
        Dim numeroDiente As Integer = 75
        Dim lado As String = "arriba"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub

    Private Sub Panel158_Click(sender As Object, e As EventArgs) Handles Panel158.Click
        Dim numeroDiente As Integer = 75
        Dim lado As String = "izquierda"
        Dim btn = sender.name
        colorearPanel(col, btn)
    End Sub


End Class
