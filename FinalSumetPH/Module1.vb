Imports System.Data
Imports System.Data.SqlClient
Module Module1

    Friend conStr As String = "Data Source=.\SQLEXPRESS;" & _
        "AttachDbFilename=|DataDirectory|\Dormitory.mdf;" & _
        "Integrated Security=True;User Instance=True;"

    '-------------------------------------------------------
    Friend connection As SqlConnection
    Friend command As SqlCommand
    Friend dataSt As DataSet
    Friend adapter As SqlDataAdapter
    Friend bindingSrc As BindingSource
    Friend reader As SqlDataReader
    Friend sql As String

    '--------------------------------------------------------
    Friend Function IsInteger(ByVal num As Double) As Boolean
        If num Mod 1 <> 0 Then
            Return False
        Else
            Return True
        End If
    End Function

End Module
