﻿Imports DevExpress.Skins
Imports System
Imports System.Windows.Forms

Namespace DXSample
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()
            SkinManager.EnableFormSkins()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Main())
        End Sub
    End Class
End Namespace