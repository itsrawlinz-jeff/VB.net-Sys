Public Class frmEditStudent
    Private Sub frmEditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtStudentId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentId.TextChanged

        sql = "SELECT * FROM ay"
        fillCombo(sql, cboAddSy, "ACADYR")

        StudentTxtFill(Me)

    End Sub

    Private Sub dtpDbirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDbirth.ValueChanged
        Try
            Dim age As Integer
            age = DateDiff(DateInterval.Year, dtpDbirth.Value, Now())
            txtAge.Text = age
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Try
            If rdoMale.Checked = True Then
                radioSEX = "MALE"
            Else
                radioSEX = "FEMALE"
            End If
            checkOption(chkBirthCert, Nyesno)
            checkOption(chkCertification, Cyesno)
            checkOption(chkPic, Pyesno)
            checkOption(chkReportCard, Ryesno)
            'students siblings

            'student(requirements)
            sql = "UPDATE  `tblrequirements` SET `NSO`='" & Nyesno & "', `PICID`='" & Pyesno & "', `REPORTCARD`='" & Ryesno _
                    & "', `CERTIFICATE_OF_TRANSFER`='" & Cyesno & "' WHERE IDNO='" & txtStudentId.Text & "'"
            edit(sql)
            'student basic info
            sql = "UPDATE tblstudent SET   `FNAME`='" & txtFName.Text & "', `LNAME`='" & txtLName.Text & "', `MNAME`='" & txtMName.Text _
                    & "', `SEX`='" & radioSEX & "', `BDAY`='" & dtpDbirth.Text & "', `BPLACE`='" & txtPBirth.Text & "', `AGE`='" & txtAge.Text _
                    & "', `HOME_ADD`='" & txtAddress.Text & "',GUARDIAN='" & txtguardian.Text & "',GUARDIAN_ADD ='" & txtguardianadd.Text _
                    & "',GUARDIAN_TEL ='" & txtguardiantel.Text & "',`LASTSCHOOLATTEND`='" & txtLastSchoolAttend.Text _
                    & "', WEIGTH='" & txtWeigth.Text & "',HEIGTH='" & txtHeight.Text & "' WHERE IDNO='" & txtStudentId.Text & "'"

            messageTrue = "Student has been updated."
            messageFalse = "No student's record for this id. No record to be updated."
            CreateUpdateDeleteAllMessage(sql, messageTrue, messageFalse)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCLose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If rdoMale.Checked = True Then
                radioSEX = "MALE"
            Else
                radioSEX = "FEMALE"
            End If
            checkOption(chkBirthCert, Nyesno)
            checkOption(chkCertification, Cyesno)
            checkOption(chkPic, Pyesno)
            checkOption(chkReportCard, Ryesno)
            'students siblings

            'student(requirements)
            sql = "UPDATE  `tblrequirements` SET `NSO`='" & Nyesno & "', `PICID`='" & Pyesno & "', `REPORTCARD`='" & Ryesno _
                    & "', `CERTIFICATE_OF_TRANSFER`='" & Cyesno & "' WHERE IDNO='" & txtStudentId.Text & "'"
            edit(sql)
            'student basic info
            sql = "UPDATE tblstudent SET   `FNAME`='" & txtFName.Text & "', `LNAME`='" & txtLName.Text & "', `MNAME`='" & txtMName.Text _
                    & "', `SEX`='" & radioSEX & "', `BDAY`='" & dtpDbirth.Text & "', `BPLACE`='" & txtPBirth.Text & "', `AGE`='" & txtAge.Text _
                    & "', `HOME_ADD`='" & txtAddress.Text & "',GUARDIAN='" & txtguardian.Text & "',GUARDIAN_ADD ='" & txtguardianadd.Text _
                    & "',GUARDIAN_TEL ='" & txtguardiantel.Text & "',`LASTSCHOOLATTEND`='" & txtLastSchoolAttend.Text _
                    & "', WEIGTH='" & txtWeigth.Text & "',HEIGTH='" & txtHeight.Text & "' WHERE IDNO='" & txtStudentId.Text & "'"

            messageTrue = "Student has been updated."
            messageFalse = "No student's record for this id. No record to be updated."
            CreateUpdateDeleteAllMessage(sql, messageTrue, messageFalse)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class