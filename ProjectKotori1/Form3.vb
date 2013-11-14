Public Class Form3
    Dim numberofrecords As Integer
    Dim dbfilename As String = "responsedbkotori.raf"
    Dim avifilename As String = "aviWaiting.avi"
    <VBFixedString(30)> Public response As String
    Dim previousresponse As String = ""
    Dim prepreviousresponse As String = ""
    Dim username As String = "User"
    Dim password As String
    Dim camindex As Integer = 1
    Dim firstresponse As Boolean = True
    Dim time As Integer
    Dim EMV As Long = 1000
    Dim Carryon As Boolean = True
    Structure chatdb
        <VBFixedString(90)> Public rule As String
        <VBFixedString(30)> Public response1 As String
        <VBFixedString(30)> Public response2 As String
        <VBFixedString(30)> Public response3 As String
        <VBFixedString(30)> Public response4 As String
        <VBFixedString(30)> Public response5 As String
        <VBFixedString(30)> Public response6 As String
        <VBFixedString(30)> Public response7 As String
        <VBFixedString(30)> Public response8 As String
        <VBFixedString(15)> Public animationfilename As String
    End Structure
    Private Sub send()
        If Carryon = True Then
            If firstresponse = True Then
                Timer1.Enabled = True
                firstresponse = False
            End If
            lstChat.Items.Add(username & ": " & txtUser.Text)
            prepreviousresponse = previousresponse
            previousresponse = response
            response = txtUser.Text
            If response = previousresponse Then
                kotori("double1")
            ElseIf response = prepreviousresponse Then
                kotori("double2")
            Else
                kotori(response)
            End If
            txtUser.Text = ""
            txtUser.Focus()
        ElseIf txtUser.Text.ToLower = "quit" Then
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time = time + 1
        If time = 300 Then
            Carryon = False
            MsgBox("Time is up.")
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub kotori(ByVal response As String)
        Dim ruledb As New chatdb
        Dim recordnumber As Integer
        Dim responseind As String
        FileOpen(1, dbfilename, OpenMode.Random, , , Len(ruledb))
        Dim found As Boolean = False
        Do While found = False And (Not EOF(1))
            recordnumber = recordnumber + 1
            FileGet(1, ruledb, recordnumber)
            If response.Contains(ruledb.rule.Trim()) Then
                If EMV < 375 Then
                    responseind = "Kotori: " + ruledb.response1
                    lstChat.Items.Add(responseind)
                ElseIf EMV < 750 Then
                    responseind = "Kotori: " + ruledb.response2
                    lstChat.Items.Add(responseind)
                ElseIf EMV < 1125 Then
                    responseind = "Kotori: " + ruledb.response3
                    lstChat.Items.Add(responseind)
                ElseIf EMV < 1500 Then
                    responseind = "Kotori: " + ruledb.response4
                    lstChat.Items.Add(responseind)
                ElseIf EMV < 1875 Then
                    responseind = "Kotori: " + ruledb.response5
                    lstChat.Items.Add(responseind)
                ElseIf EMV < 2250 Then
                    responseind = "Kotori: " + ruledb.response6
                    lstChat.Items.Add(responseind)
                ElseIf EMV < 2625 Then
                    responseind = "Kotori: " + ruledb.response7
                    lstChat.Items.Add(responseind)
                Else
                    responseind = "Kotori: " + ruledb.response8
                    lstChat.Items.Add(responseind)
                End If
                found = True
            End If
        Loop
        FileClose(1)
        If Not found Then
            lstChat.Items.Add("Kotori: Sorry, I haven't got that in my dictionary, please write it down o.o")
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If EMV < 0 Then
            EMV = 1
        ElseIf EMV > 3000 Then
            EMV = 2999
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim onerecord As chatdb
        FileOpen(1, dbfilename, OpenMode.Random, , , Len(onerecord))
        numberofrecords = LOF(1) / Len(onerecord)
        FileClose(1)
        Randomize()
        Dim rnd = New Random()
        EMV = rnd.Next(3000)
    End Sub
    Private Sub txtUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            send()
        End If
    End Sub
End Class