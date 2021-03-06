Public Class frmManageSection
    Public id As Integer = 0
    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try

            If id = 0 Then
                sql = "SELECT * FROM tblsection WHERE SECTION LIKE '%" & txtSection.Text & "%'"
                fillSpecifictxt(sql)
                maxrow = dt.Rows.Count
                If maxrow > 0 Then
                    MsgBox("Data is already exist!", MsgBoxStyle.Exclamation)
                    Return
                Else
                    sql = "INSERT INTO  `tblsection`  (`SECTION`) VALUES ('" & txtSection.Text & "')"
                    create(sql)
                    MsgBox("New Data has been saved in the database.")
                End If
            Else
                sql = "UPDATE tblsection SET SECTION ='" & txtSection.Text & "' WHERE SECTIONID=" & id
                edit(sql)
                MsgBox("Data has been updated in the database.")
            End If

            Call frmSection_Load(sender, e)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT `SECTIONID` as 'ID', `SECTION` FROM `tblsection`"
        fillGrid(sql, dtgList)
        txtSection.Clear()
        txtSection.Focus()
        id = 0
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT `SECTIONID` as 'ID', `SECTION` FROM `tblsection` WHERE SECTION LIKE '%" & txtSearch.Text & "%'"
        fillGrid(sql, dtgList)
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try
            sql = "DELETE FROM tblsection WHERE SECTIONID = '" & dtgList.CurrentRow.Cells(0).Value & "'"
            deleting(sql)
            MsgBox("Data has been deleted in the database.")
            Call frmSection_Load(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CLEAR(sender As Object, e As EventArgs) Handles btn_clear.Click
        sql = "SELECT `SECTIONID` as 'ID', `SECTION` FROM `tblsection`"
        fillGrid(sql, dtgList)
        txtSection.Clear()
        txtSection.Focus()
        id = 0
    End Sub
End Class
