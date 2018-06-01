'
' Created by SharpDevelop.
' User: IP-Man
' Date: 1/9/2017
' Time: 1:51 PM
' 
Imports System.IO
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'		
		
	End Sub
		Delegate Sub UpdateTextBoxDelg(ByVal text As String)
		Public myDelegate As UpdateTextBoxDelg = New UpdateTextBoxDelg(AddressOf UpdateApkBuilderOutput)
		
		Public Sub UpdateApkBuilderOutput(ByVal text As String) 'This will update the listbox
			Dim line As String	= text
			apkbuilder_output.Items.Add(text)
			apkbuilder_output.TopIndex = apkbuilder_output.Items.Count - 1	
			If line.Contains("Compressing") Then statuLBL.Text = "Compressing using 7z."
			If line.Contains("Extracting") Then statuLBL.Text = "Extracting Files."
			If line.Contains("You have not got java") Then statuLBL.Text = "Java not found!. Please install Java."
			If line.Contains("sign apk") Then 
				statuLBL.Text = "APK has been created!."
				Process.Start("explorer.exe", "apk")
			End If
    End Sub

    Public Sub proc_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        On Error Resume Next
        If Me.InvokeRequired = True Then
            Me.Invoke(myDelegate, e.Data)
        Else
             UpdateApkBuilderOutput(e.Data)
        End If

    End Sub
    
    Private Sub BuildAPK()
        Dim Proc = New Process()
		
		Proc.StartInfo.FileName = "go.bat"
        Proc.StartInfo.RedirectStandardOutput = True
        Proc.StartInfo.RedirectStandardError = True
        Proc.EnableRaisingEvents = True
        Application.DoEvents()
        Proc.StartInfo.CreateNoWindow = True
        Proc.StartInfo.UseShellExecute = False

        AddHandler Proc.ErrorDataReceived, AddressOf proc_OutputDataReceived
        AddHandler Proc.OutputDataReceived, AddressOf proc_OutputDataReceived
        Proc.Start()
        Proc.BeginErrorReadLine()
        Proc.BeginOutputReadLine()
        'Proc.WaitForExit()
        End Sub 
	
	Sub BuildAPKbtnClick(sender As Object, e As EventArgs)
		apkbuilder_output.Items.Clear
		Call BuildAPK
	End Sub
	
	Sub SourcePathTextChanged(sender As Object, e As EventArgs)

	End Sub
	
	
	Sub MoveAllItems(ByVal fromPath As String, ByVal toPath As String)
		''Create the target directory if necessary
		Dim toPathInfo = New DirectoryInfo(toPath)
		If (Not toPathInfo.Exists) Then
			toPathInfo.Create()
		End If
		Dim fromPathInfo = New DirectoryInfo(fromPath)
		''move all files
		For Each file As FileInfo In fromPathInfo.GetFiles()
			file.CopyTo(Path.Combine(toPath, file.Name))
			
		Next
		
		''move all folders
		For Each dir As DirectoryInfo In fromPathInfo.GetDirectories()	
			dir.MoveTo(Path.Combine(toPath, dir.Name))
		Next
		
	End Sub
	
	Sub SourceFind_BTNClick(sender As Object, e As EventArgs)
		folderBrowserDialog.ShowDialog
		SourcePath.Text=folderBrowserDialog.SelectedPath
		System.IO.Directory.Delete("./html5",true)
		System.IO.Directory.CreateDirectory("./html5")
		MoveAllItems(SourcePath.Text,"./html5")
	End Sub
	
	Sub Edit_keysBTNClick(sender As Object, e As EventArgs)
		Process.Start("explorer.exe", "key")
	End Sub
	
	Sub Tools_BTNClick(sender As Object, e As EventArgs)
		Process.Start("explorer.exe", "tools")
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		Process.Start("explorer.exe", "apk")
	End Sub
End Class
