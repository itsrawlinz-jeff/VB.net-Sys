﻿Public Class frmSOA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_preview.Click
        sql = "SELECT * ,IF((SELECT COUNT(*) FROM tblnonessentialfees WHERE YearLevel=LEVEL) > 0 ,(SELECT DESCRIPTION FROM tblnonessentialfees WHERE YearLevel=LEVEL),'') as 'NonEDesc',IF((SELECT COUNT(*) FROM tblnonessentialfees WHERE YearLevel=LEVEL) > 0 ,(SELECT FEES FROM tblnonessentialfees WHERE YearLevel=LEVEL),'') as 'NonEFees' FROM `tblstudupdatelevel` s, `tblstatementofaccounts` sa,`tblessentialfees` ef WHERE s.`IDNO`=sa.`IDNO` AND LEVEL=sa.`YearLevel` AND sa.`YearLevel`=ef.`YearLevel` AND s.IDNO = '" & txtSearch.Text & "'"
        reports(sql, "statementofaccounts", CrystalReportViewer1)
    End Sub
End Class
