Public Class frmEF
    Dim E_id As Integer = 0

    Private Sub cboLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboLevel.KeyPress
        e.Handled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub frmEF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call btn_clear_Click(sender, e)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub dtgList_Click(sender As Object, e As EventArgs) Handles dtgList.Click
        Try
            btn_delete.Enabled = True
            With dtgList
                E_id = .CurrentRow.Cells(0).Value
                txtDesc.Text = .CurrentRow.Cells(1).Value
                txtAmount.Text = .CurrentRow.Cells(2).Value
                cboLevel.Text = .CurrentRow.Cells(3).Value
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If E_id = 0 Then '
            sql = "INSERT INTO tblessentialfees (`Description`, `Fees`, `YearLevel`) VALUES ('" & txtDesc.Text & "','" & txtAmount.Text & "','" & cboLevel.Text & "')"
            create(sql)
            Call btn_clear_Click(sender, e)
        Else
            sql = "UPDATE tblessentialfees SET `Description`='" & txtDesc.Text & "', `Fees`='" & txtAmount.Text & "', `YearLevel`='" & cboLevel.Text & "' WHERE `EsentialID`=" & E_id
            edit(sql)
            Call btn_clear_Click(sender, e)
        End If
    End Sub



    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        sql = "DELETE FROM `tblessentialfees` WHERE `EsentialID` = " & E_id
        deleting(sql)
        Call btn_clear_Click(sender, e)
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Try

            E_id = 0
            txtDesc.Clear()
            txtAmount.Clear()
            btn_delete.Enabled = False

            sql = "SELECT * FROM `level`"
            fillCombo(sql, cboLevel, "LEVEL")

            sql = "SELECT * FROM `tblessentialfees`"
            RetrieveData("EssentialFees", sql, dtgList)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
