﻿Imports MySql.Data.MySqlClient
Module connection
    Public Function strConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=db_enrolment;sslMode=none")
    End Function
    Public con As MySqlConnection = strConnection()

End Module
