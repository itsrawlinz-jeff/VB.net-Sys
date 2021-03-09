Public Class frmEditSubject

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txtsubjDesc.Text = "" Or txtsujCode.Text = "" Then
                MsgBox("Empty fields must be filled up.", MsgBoxStyle.Exclamation)
                Return
            End If
            'sql = "UPDATE `subject` SET `SUBJ_CODE`='" & txtsujCode.Text & "', `SUBJ_DESCRIPTION`='" & txtsubjDesc.Text & "', `YR`='" _
            '    & cboYear.Text & "', `AY`='" & cbosy.Text & "' WHERE SUBJ_ID ='" & txtSubjectID.Text & "'"
            sql = "UPDATE `subject` SET `SUBJ_CODE`='" & txtsujCode.Text & "', `SUBJ_DESCRIPTION`='" & txtsubjDesc.Text & "', `YR`='" _
                & cboYear.Text & "' WHERE SUBJ_ID ='" & txtSubjectID.Text & "'"
            messageTrue = "Subject has been updated."
            messageFalse = "Failed to update a sabject."
            CreateUpdateDeleteAllMessage(sql, messageTrue, messageFalse)
        Catch ex As Exception

        End Try
    End Sub
End Class