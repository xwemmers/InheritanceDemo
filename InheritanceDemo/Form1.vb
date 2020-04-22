Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim p As New Person
        p.Firstname = "Thijs"
        p.Lastname = "Van der Wal"

        Dim emp As New Employee
        emp.Firstname = "Ferdi"
        emp.Lastname = "Van der Horst"
        emp.Salary = 1234567

        Dim c As New Customer
        c.Firstname = "Xander"
        c.Lastname = "Wemmers"
        c.CustomerCard = 123

        'Collectie
        Dim lijst As New List(Of Person)
        lijst.Add(p)
        lijst.Add(emp)
        lijst.Add(c)

        dgv.DataSource = lijst
        ListBox1.DataSource = lijst

        For Each obj In lijst
            MessageBox.Show(obj.ToString())
        Next

    End Sub
End Class
