Imports System.Data
Imports System.Data.SqlClient

Public Class FormRef
    Private hasRows As Boolean = False
    Private Sub FormRef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connection = New SqlConnection(conStr)

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        sql = "SELECT * FROM Ref"
        command = New SqlCommand(sql, connection)
        reader = command.ExecuteReader()
        '-----------------------------------------------
        hasRows = reader.HasRows
        While reader.Read()
            TextNumFloors.Text = reader("NumFloors")
            TextRoomsPerFloor.Text = reader("RoomsPerFloor")
            TextRental.Text = reader("Rental")
        End While
        reader.Close()

    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click

        If Not (IsNumeric(TextNumFloors.Text) OrElse _
            IsInteger(TextNumFloors.Text)) Then
            MessageBox.Show("จำนวนชั้นต้องเป็นตัวเลขจำนวนเต็ม")
            Exit Sub
        ElseIf Not (IsNumeric(TextRoomsPerFloor.Text) OrElse _
        IsInteger(TextRoomsPerFloor.Text)) Then
            MessageBox.Show("จำนวนห้องต้องเป็นตัวเลขจำนวนเต็ม")
            Exit Sub
        ElseIf Not IsNumeric(TextNumFloors.Text) Then
            MessageBox.Show("ค่าเช่าต้องเป็นตัวเลข")
            Exit Sub
        End If
        '------------------------------------------------------------------------
        If hasRows Then
            sql = "UPDATE Ref SET " & _
            "NumFloors = @floors, " & _
           "RoomsPerFloor = @rooms, " & _
            "Rental = @rent"
        Else
            sql = "INSERT INTO Ref(NumFloors, RoomsPerFloor, Rental) " & _
            "VALUES(@floors, @rooms, @rent)"
        End If
        command = New SqlCommand(sql, connection)
        command.Parameters.Clear()
        command.Parameters.AddWithValue("floors", TextNumFloors.Text)
        command.Parameters.AddWithValue("rooms", TextRoomsPerFloor.Text)
        command.Parameters.AddWithValue("rent", TextRental.Text)
        Dim r As Integer = command.ExecuteNonQuery()
        If r = 1 Then
            MessageBox.Show("ปรับปรุงข้อมูลแล้ว")
            connection.Close()
            FormRef_Load(sender, e)
        Else
            MessageBox.Show("เกิดข้อผิดพลาด")
        End If

    End Sub
End Class
