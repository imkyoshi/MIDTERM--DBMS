Imports MySql.Data.MySqlClient

Module dbcon
    Public objconn As New MySqlConnection
    Public objcmd As New MySqlCommand
    Public strsql, strreportname As String
    Public objdr As MySqlDataReader
End Module
