Imports System.Windows.Forms

Public Class LicenseDialog


    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM Two variables are used as a means of having some false safe way of ensuring that the user has agreed to the terms.

        My.Settings.BoolFirstRun = True

        If My.Settings.BoolFirstRun = True Or My.Settings.boolLicenseAgree = False Then

        Else
            Form1.Show()
            Me.Close()
        End If
    End Sub


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        My.Settings.BoolFirstRun = False

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        My.Settings.boolLicenseAgree = True
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        My.Settings.BoolFirstRun = False

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
