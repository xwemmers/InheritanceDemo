Public Class Employee
    Inherits Person

    Public Property Salary As Integer

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & " " & Salary
    End Function

End Class
