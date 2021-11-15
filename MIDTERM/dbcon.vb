Imports MySql.Data.MySqlClient

Module dbcon
    Public objconn As New MySqlConnection
    Public objcmd As New MySqlCommand
    Public strsql, strreportname As String
    Public acsds As New DataSet
    Public objda As New MySqlDataAdapter
    Public objdr As MySqlDataReader
    Public objdt As DataTable
End Module
