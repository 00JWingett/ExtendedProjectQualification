Public Class Form2
    Dim dbfilename As String = "responsedbkotori.raf"
    Dim recordsfilename As String = "responsedbkotori.nor"
    Dim numberofrecords As Integer

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
    Private Sub btnaddrecord_Click(sender As System.Object, e As System.EventArgs) Handles btnaddrecord.Click
        Dim onerecord As chatdb
        onerecord.rule = TextBox1.Text
        onerecord.response1 = TextBox2.Text
        onerecord.response2 = TextBox3.Text
        onerecord.response3 = TextBox4.Text
        onerecord.response4 = TextBox5.Text
        onerecord.response5 = TextBox6.Text
        onerecord.response6 = TextBox7.Text
        onerecord.response7 = TextBox8.Text
        onerecord.response8 = TextBox9.Text
        onerecord.animationfilename = TextBox10.Text
        FileOpen(1, dbfilename, OpenMode.Random, , , Len(onerecord))
        FilePut(1, onerecord, numberofrecords + 1)
        FileClose(1)
        numberofrecords = numberofrecords + 1
        lblrecords.Text = numberofrecords
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim onerecord As chatdb
        FileOpen(1, dbfilename, OpenMode.Random, , , Len(onerecord))
        numberofrecords = LOF(1) / Len(onerecord)
        FileClose(1)
    End Sub
End Class