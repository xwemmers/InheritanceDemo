Public Class Person
    Public Property Firstname As String
    Public Property Lastname As String

    Public Overrides Function ToString() As String
        Return Firstname & " " & Lastname
    End Function

End Class
