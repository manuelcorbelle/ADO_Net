Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Create_Drop_Table
    Inherits System.Web.UI.Page

    Protected Sub CreateTable(sender As Object, e As EventArgs)
        Dim query As String = "IF OBJECT_ID('dbo.CustomersTest', 'U') IS NULL "
        query += "BEGIN "
        query += "CREATE TABLE [dbo].[CustomersTest]("
        query += "[CustomerId] INT IDENTITY(1,1) NOT NULL CONSTRAINT pkCustomerId PRIMARY KEY,"
        query += "[Name] VARCHAR(100) NOT NULL,"
        query += "[Country] VARCHAR(50) NOT NULL"
        query += ")"
        query += " END"
        Label2.Visible = False
        Label1.Visible = True
        Label1.Text = "Tabla Creada......."
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand(query)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub

    Protected Sub DropTable(sender As Object, e As EventArgs)
        Dim query As String = "IF OBJECT_ID('dbo.CustomersTest', 'U') IS NOT NULL "
        query += "BEGIN "
        query += "DROP TABLE dbo.CustomersTest "
        query += "END"
        Label1.Visible = False
        Label1.Text = "Tabla Creada......."
        Label2.Visible = True
        Label2.Text = "Tabla Borrada......."
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand(query)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Visible = False
        Label2.Visible = False
    End Sub
End Class