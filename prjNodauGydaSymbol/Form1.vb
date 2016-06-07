Public Class Form1

    Private Sub btnTrosi_Click(sender As Object, e As EventArgs) Handles btnTrosi.Click
        'Trosi Nod Gwreiddiol i nod arferol
        Dim NodGwreiddiol As String
        Dim TrosiIBrif As String
        Dim NodArferol As String

        'Darllen mewnbwn 
        NodGwreiddiol = txtNod.Text
        TrosiIBrif = NodGwreiddiol.ToUpper

        'Newid i llythyren normal
        Select Case AscW(TrosiIBrif)
            Case 192 To 197
                NodArferol = "A"
            Case 199
                NodArferol = "C"
            Case 200 To 203
                NodArferol = "E"
            Case 204 To 207
                NodArferol = "I"
            Case 209
                NodArferol = "N"
            Case 210 To 214
                NodArferol = "O"
            Case 217 To 220
                NodArferol = "U"
            Case 221
                NodArferol = "Y"
            Case Else
                NodArferol = ("Nid yw'n nod anarferol")
        End Select


        lblAllbwn.Text = NodArferol

    End Sub
End Class
