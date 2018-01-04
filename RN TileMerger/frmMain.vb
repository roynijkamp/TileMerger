
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmMain
    Dim sSourceDir As String
    Dim sTarget As String
    Dim iImagesFound As Integer
    Dim iSrcWidth As Integer
    Dim iSrcHeight As Integer
    Dim iTargetWidth As Integer
    Dim iTargetHeight As Integer
    Dim iTargetCols As Integer
    Dim iTargetRows As Integer

    Private Sub cmdSource_Click(sender As Object, e As EventArgs) Handles cmdSource.Click
        Dim myFldrBrwsr As FolderBrowserDialog = New FolderBrowserDialog()
        If myFldrBrwsr.ShowDialog = DialogResult.OK Then
            sSourceDir = myFldrBrwsr.SelectedPath
            lblBron.Text = sSourceDir
            Dim extensions As New List(Of String)
            extensions.Add("*.png")
            extensions.Add("*.jpg")
            ' And so on, until all are in...
            iImagesFound = 0
            For i As Integer = 0 To extensions.Count - 1
                iImagesFound += Directory.GetFiles(sSourceDir, extensions(i), SearchOption.AllDirectories).Length
            Next
            lblImgCount.Text = "# " & iImagesFound.ToString & " Afbeeldingen gevonden"
            analyseNames()
        End If
    End Sub

    Public Sub analyseNames()
        Dim dirInfo As New DirectoryInfo(sSourceDir)
        Dim images As FileInfo() = dirInfo.GetFiles()
        Dim iColCount As Integer = 0
        Dim bIsPDOK As Boolean = False
        For Each image As FileInfo In images
            If image.Name.Contains("PDOK") Then
                bIsPDOK = True
                ' Y
                ' |
                ' |____X
                Dim sFilename As String() = image.Name.Split(".")
                Dim aCoords As String() = sFilename(1).Split("-")
                'acoords(0) = y
                'acoords(1) = x
                Dim iYcoord As Integer = CInt(aCoords(0)) 'rijen
                Dim iXcoord As Integer = CInt(aCoords(1))
                If iXcoord > iColCount Then
                    iColCount = iXcoord
                End If
            Else

            End If
        Next
        If bIsPDOK Then
            chkPDOK.Checked = True
            updownColumns.Value = iColCount + 1
        End If
    End Sub

    Private Sub cmdTarget_Click(sender As Object, e As EventArgs) Handles cmdTarget.Click
        Dim mySaveDlg As SaveFileDialog = New SaveFileDialog()
        mySaveDlg.Filter = "PNG Image|*.png"
        If mySaveDlg.ShowDialog = DialogResult.OK Then
            sTarget = mySaveDlg.FileName
            lblTarget.Text = sTarget
            cmdProcess.Enabled = True
        End If
    End Sub

    Private Sub cmdProcess_Click(sender As Object, e As EventArgs) Handles cmdProcess.Click
        If sTarget.Length > 0 And sSourceDir.Length > 0 Then
            'clear picturebox
            'pcbOutput.Image = Nothing
            Dim baseImgFound As Boolean = False
            Dim iStartX As Integer = 0
            Dim iStartY As Integer = 0
            Dim iYmax As Integer = 0
            Dim iColCount As Integer = 0
            'get dimensions of first image
            Dim dirInfo As New DirectoryInfo(sSourceDir)
            Dim images As FileInfo() = dirInfo.GetFiles()
            Dim gOutput As Graphics
            Dim bOutput As Bitmap
            Dim iItmCount As Integer = 1
            'Dim pcbInput As PictureBox
            For Each image As FileInfo In images
                If baseImgFound = False Then
                    If image.Extension = ".png" Or image.Extension = ".jpg" Then
                        Dim bmp As New Bitmap(image.FullName)
                        'MsgBox("Afmetingen tiles: " & bmp.Width.ToString & " - " & bmp.Height.ToString)
                        iSrcWidth = bmp.Width
                        iSrcHeight = bmp.Height
                        iTargetCols = CInt(updownColumns.Value)
                        iTargetRows = iImagesFound / iTargetCols
                        iTargetWidth = iSrcWidth * iTargetCols
                        iTargetHeight = iTargetRows * iSrcHeight
                        'MsgBox("Afmetingen Output: " & iTargetWidth.ToString & " - " & iTargetHeight.ToString)
                        'build total image
                        'pcbOutput.Width = iTargetWidth
                        'pcbOutput.Height = iTargetHeight
                        'pcbInput.Width = iTargetWidth
                        'pcbInput.Height = iTargetHeight
                        baseImgFound = True
                        'TODO: startpunt verwerken, voor nu basis links onder
                        ' Y
                        ' |
                        ' |____X
                        iStartX = 0
                        iStartY = iTargetHeight - iSrcHeight
                        iYmax = iStartY
                        bOutput = New Bitmap(iTargetWidth, iTargetHeight)
                        gOutput = Graphics.FromImage(bOutput)
                        Exit For
                    End If
                End If
            Next

            For Each image As FileInfo In images
                Dim bBitmap As New Bitmap(image.FullName)
                If chkPDOK.Checked Then
                    'plaatsing op basis van PDOK bestandsnaam
                    'PDOKtop25.0-0.10.522.552.png
                    Dim sFilename As String() = image.Name.Split(".")
                    Dim aCoords As String() = sFilename(1).Split("-")
                    'acoords(0) = y
                    'acoords(1) = x
                    Dim iYcoord As Integer = CInt(aCoords(0))
                    Dim iXcoord As Integer = CInt(aCoords(1))
                    iStartX = 0 + (iXcoord * iSrcWidth)
                    iStartY = iYmax - (iYcoord * iSrcHeight)
                End If
                gOutput.DrawImage(bBitmap, New Point(iStartX, iStartY))
                gOutput.Flush()
                If Not chkPDOK.Checked Then
                    iColCount = iColCount + 1
                    If iColCount = iTargetCols Then
                        iStartX = 0
                        iStartY = iStartY - iSrcHeight
                        iColCount = 0
                    Else
                        iStartX = iStartX + iSrcWidth
                    End If
                End If
                iItmCount = iItmCount + 1
                lblImgCount.Text = "# " & iItmCount.ToString
                Me.Update()
                'afbeelding toevoegen
            Next
            bOutput.Save(sTarget, Imaging.ImageFormat.Png)
            Me.Update()
            MsgBox("Gereed")
        End If


        'klaar, rest van form
        cmdProcess.Enabled = False
        sTarget = ""
        sSourceDir = ""
        lblTarget.Text = "DOEL"
        lblBron.Text = "BRON"
        lblImgCount.Text = "#0"
    End Sub

    Public Shared Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdLocatie.SelectedIndex = 1
    End Sub
End Class
