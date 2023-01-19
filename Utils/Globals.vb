Imports System.Configuration
Imports System.Collections.Specialized
Imports System.IO
Imports System.IO.Compression
Namespace Utils
    Public Class Globals
        Public Shared DB = DatabaseHelper.getInstance()

        Public Shared cAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
        Public Shared asSettings As AppSettingsSection = cAppConfig.AppSettings
        Public Shared DBobjects = My.Resources.Database.ResourceManager

        Public Shared rm As Resources.ResourceManager

        'singleton pattern - probably wont needed in future
        'Private Shared objGlobals As Globals
        'Private Sub New()

        'End Sub

        'Public Shared Function getInstance() As Globals
        '    If objGlobals Is Nothing Then
        '        objGlobals = New Globals
        '    End If
        '    Return objGlobals
        'End Function


        Public Shared Function fileExists(path As String)
            Return System.IO.File.Exists(path)
        End Function

        Public Shared Function getName(filePath As String)
            Return System.IO.Path.GetFileName(filePath)
        End Function

        Public Shared Sub reloadLanguage()
            If asSettings.Settings.Item("lang").Value = "en-US" Then
                rm = My.Resources.Language_en.ResourceManager
            ElseIf asSettings.Settings.Item("lang").Value = "pl-PL" Then
                rm = My.Resources.Language_pl.ResourceManager
            End If
        End Sub
    End Class
End Namespace