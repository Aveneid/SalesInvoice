Imports System.Configuration
Imports System.Collections.Specialized
Imports System.IO
Imports System.IO.Compression
Namespace Utils
    Public Class Globals

        Public Shared cAppConfig As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
        Public Shared asSettings As AppSettingsSection = cAppConfig.AppSettings
        Public Shared DBobjects = My.Resources.Database.ResourceManager

        Public Shared rm As Resources.ResourceManager
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