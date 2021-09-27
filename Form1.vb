

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Reflection
Imports System.Threading

Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim Qty As String = ConfigurationManager.AppSettings("Qty")
		Dim Line_A As String = ConfigurationManager.AppSettings("Line_A")
		Dim Line_B As String = ConfigurationManager.AppSettings("Line_B")
		Dim Line_C As String = ConfigurationManager.AppSettings("Line_C")


		Try

			Lbl_PathlineA.Text = Line_A
			If My.Computer.FileSystem.DirectoryExists(Line_A) = True Then
				Lbl_StatusLineA.Text = "OK"
				WriteLog(ModApi.Path_Common_Log, "Line A : " & "" & Line_A & "Status : " & Lbl_StatusLineA.Text)
			Else
				Lbl_StatusLineA.Text = "NG"
				WriteLog(ModApi.Path_Common_Log, "Line A : " & "" & Line_A & "Status : " & Lbl_StatusLineA.Text)
			End If

			Lbl_PathLineB.Text = Line_B
			If My.Computer.FileSystem.DirectoryExists(Line_B) = True Then
				Lbl_StatusLineB.Text = "OK"
				WriteLog(ModApi.Path_Common_Log, "Line B : " & "" & Line_B & "Status : " & Lbl_StatusLineB.Text)
			Else
				Lbl_StatusLineB.Text = "NG"
				WriteLog(ModApi.Path_Common_Log, "Line B : " & "" & Line_B & "Status : " & Lbl_StatusLineB.Text)
			End If

			Lbl_pathLineC.Text = Line_C
			If My.Computer.FileSystem.DirectoryExists(Line_C) = True Then
				Lbl_StatusLineC.Text = "OK"
				WriteLog(ModApi.Path_Common_Log, "Line C : " & "" & Line_C & "Status : " & Lbl_StatusLineC.Text)
			Else
				Lbl_StatusLineC.Text = "NG"
				WriteLog(ModApi.Path_Common_Log, "Line C : " & "" & Line_C & "Status : " & Lbl_StatusLineC.Text)
			End If

		Catch ex As Exception
			WriteErrLog(ModApi.Path_Common_Log, ex.Message)
		End Try

	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Form1_Load(Me, Nothing)
	End Sub
End Class
