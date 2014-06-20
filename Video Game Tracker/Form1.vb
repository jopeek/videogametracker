Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Globalization
Imports System.Data.SQLite
Imports System.Data.Common
Imports System.ComponentModel
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Text.RegularExpressions
Imports Microsoft.Win32

Public Class Form1



    Dim listofGames As New DataTable
    Dim thisGame As New Giantbomb.Game
    Dim dbFileName As String
    Dim gameURL As String
    Dim ignoreSelectedIndexChanged As Boolean
    Dim displayGameDetails As Boolean

    Public Delegate Sub PictureVisibilityDelegate(ByVal visibility As Boolean)
    Dim ChangePictureVisibility As PictureVisibilityDelegate

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Splashscreen.BarLong(100)
        'Dim i As Integer = 0
        'While i <= 100
        '    Splashscreen.ShowBar(i)
        '    i += 1
        '    Threading.Thread.Sleep(100)
        'End While

        StartupStuff()

    End Sub

    Private Sub StartupStuff()

#If DEBUG Then
#Else
        Try
#End If

        ChangePictureVisibility = AddressOf ChangeVisibility

        Me.Text = My.Application.Info.AssemblyName.ToString

        lblStatus.Text = ""

        panRight.Visible = False

        CheckForIllegalCrossThreadCalls = False

        ActiveControl = txtSearch

        lblVersion.Text = "Version: " & My.Application.Info.Version.ToString

        picLoading.Top = 307
        picLoading.Left = 695
        picLoading.Parent = Me
        picLoading.Visible = False

        picTopBar.Parent = Me
        picTopBar.Top = 80
        picTopBar.Left = 521
        picTopBar.Width = 700
        picTopBar.Height = 25
        picTopBar.Visible = True
        picTopBar.BringToFront()

        picBottomBar.Parent = Me
        picBottomBar.Top = 675
        picBottomBar.Left = 521
        picBottomBar.Width = 700
        picBottomBar.Height = 4
        picBottomBar.Visible = True
        picBottomBar.BringToFront()

        picRightBar.Parent = Me
        picRightBar.Top = 80
        picRightBar.Left = 1040
        picRightBar.Width = 4
        picRightBar.Height = 599
        picRightBar.Visible = True
        picRightBar.BringToFront()

        picMiddleBar.Parent = Me
        picMiddleBar.Top = 80
        picMiddleBar.Left = 517
        picMiddleBar.Width = 4
        picMiddleBar.Height = 599
        picMiddleBar.Visible = True
        picMiddleBar.BringToFront()

        'this does some funky shit by adding the automatically generated version numbers to 1/1/2000 to get the build date
        Dim buildDate As DateTime = New DateTime(2000, 1, 1).AddDays(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build)


        'Setup the listofGames datatable
        Try
            listofGames.Columns.Add("name")
            listofGames.Columns.Add("api_detail_url")
        Catch ex As Exception
            'columns already exist cause it's a reload
        End Try
        

        lblVersion.Text &= " (Built: " & buildDate.ToString("MM/dd/yyyy") & ")"

        LoadDatabase()
        Splashscreen.ShowBar(10)

        LoadMyGames()
        Splashscreen.ShowBar(50)

        LoadAllNews()
        Splashscreen.ShowBar(90)

        LoadOptions()
        Splashscreen.ShowBar(100)


#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub
    Private Sub LoadOptions()

#If DEBUG Then
#Else
        Try
#End If

        'Theme stuff
        Select Case My.Settings.Theme
            Case "Light"
                picHeaderBG.Image = My.Resources.headerbg
                picHeader.Image = My.Resources.header
                picLoading.Image = My.Resources.spinner
                Me.BackColor = Color.White
                tabSearch.BackColor = Color.White
                tabLatestNews.BackColor = Color.White
                tabMyGames.BackColor = Color.White
                tabOptions.BackColor = Color.White
                listResults.BackColor = Color.White
                listResults.ForeColor = Color.Black
                dgvMyGames.BackgroundColor = Color.White
                dgvMyGames.DefaultCellStyle.BackColor = Color.White
                dgvMyGames.DefaultCellStyle.ForeColor = Color.Black
                dgvNews.BackgroundColor = Color.White
                dgvNews.DefaultCellStyle.BackColor = Color.White
                dgvNews.DefaultCellStyle.ForeColor = Color.Black

                For Each formLabel As Label In tabOptions.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.Black
                Next formLabel
                For Each formLinkLabel As LinkLabel In tabOptions.Controls.OfType(Of LinkLabel)()
                    formLinkLabel.LinkColor = Color.Black
                Next formLinkLabel
                For Each formLabel As Label In tabSearch.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.Black
                Next formLabel
                For Each formLabel As Label In tabLatestNews.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.Black
                Next formLabel
                For Each formLabel As Label In tabMyGames.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.Black
                Next formLabel
                For Each formLabel As Label In panLeft.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.Black
                Next formLabel
                For Each formLabel As Label In panRight.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.Black
                Next formLabel
                For Each formLinkLabel As LinkLabel In panRight.Controls.OfType(Of LinkLabel)()
                    formLinkLabel.LinkColor = Color.Black
                Next formLinkLabel

            Case "Dark"
                picHeaderBG.Image = My.Resources.headerbg_dark
                picHeader.Image = My.Resources.header_dark
                picLoading.Image = My.Resources.spinner_dark
                Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#808080")
                tabSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#808080")
                tabLatestNews.BackColor = System.Drawing.ColorTranslator.FromHtml("#808080")
                tabMyGames.BackColor = System.Drawing.ColorTranslator.FromHtml("#808080")
                tabOptions.BackColor = System.Drawing.ColorTranslator.FromHtml("#808080")
                listResults.BackColor = System.Drawing.ColorTranslator.FromHtml("#808080")
                listResults.ForeColor = Color.LightGray
                dgvMyGames.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#808080")
                dgvMyGames.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#808080")
                dgvMyGames.DefaultCellStyle.ForeColor = Color.LightGray
                dgvNews.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#808080")
                dgvNews.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#808080")
                dgvNews.DefaultCellStyle.ForeColor = Color.LightGray

                For Each formLabel As Label In tabOptions.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.LightGray
                Next formLabel
                For Each formLinkLabel As LinkLabel In tabOptions.Controls.OfType(Of LinkLabel)()
                    formLinkLabel.LinkColor = Color.LightGray
                Next formLinkLabel
                For Each formLabel As Label In tabSearch.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.LightGray
                Next formLabel
                For Each formLabel As Label In tabLatestNews.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.LightGray
                Next formLabel
                For Each formLabel As Label In tabMyGames.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.LightGray
                Next formLabel
                For Each formLabel As Label In panLeft.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.LightGray
                Next formLabel
                For Each formLabel As Label In panRight.Controls.OfType(Of Label)()
                    formLabel.ForeColor = Color.LightGray
                Next formLabel
                For Each formLinkLabel As LinkLabel In panRight.Controls.OfType(Of LinkLabel)()
                    formLinkLabel.LinkColor = Color.LightGray
                Next formLinkLabel



        End Select


        'Open default tab
        Select Case My.Settings.DefaultTab
            Case "Search"
                TabControl1.SelectedIndex = 0
            Case "Latest News"
                TabControl1.SelectedIndex = 1
            Case "My Games"
                TabControl1.SelectedIndex = 2
            Case "Options"
                TabControl1.SelectedIndex = 3
        End Select

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub

    Private Sub LoadDatabase()

#If DEBUG Then
#Else
        Try
#End If

        Dim appdataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Video Game Tracker\"

        If (Not System.IO.Directory.Exists(appdataPath)) Then
            System.IO.Directory.CreateDirectory(appdataPath)
        End If

        'Minor cleanup from test versions:
        If System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Video Game Tracker\") Then
            Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Video Game Tracker\", True)
        End If

        dbFileName = appdataPath & "mygames.s3db"

        Dim conn = New SQLiteConnection()
        conn.ConnectionString = New DbConnectionStringBuilder() From { _
         {"Data Source", dbFileName}, _
         {"Version", "3"}, _
         {"FailIfMissing", "False"} _
        }.ConnectionString
        conn.Open()


        Dim command As New SQLiteCommand
        command.Connection = conn

        'Ensure tables exist
        command.CommandText = "CREATE TABLE if not exists [tblGames] ([id] INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL,[gbid] TEXT  NULL,[name] TEXT  NULL,[descr] TEXT  NULL,[platforms] TEXT  NULL,[developers] TEXT  NULL,[publishers] TEXT  NULL,[original_release_date] date  NULL,[expReleaseDate] date  NULL,[site_detail_url] TEXT  NULL,[image] BLOB  NULL,[lastupdated] date  NULL, GamesRadarID TEXT NULL, rsslink TEXT NULL, steamid TEXT NULL)"
        command.ExecuteNonQuery()

        command.CommandText = "CREATE TABLE if not exists [tblNews] ([id] INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL,[gbid] TEXT  NULL,[GameName] TEXT  NULL,[title] TEXT  NULL,[link] TEXT  NULL,[description] TEXT  NULL,[pubDate] DATE  NULL,[lastUpdated] DATE  NULL)"
        command.ExecuteNonQuery()




        'Table Updates
        Dim notifiedOfChange As Boolean = False
        command.CommandText = "ALTER TABLE [tblGames] ADD COLUMN GamesRadarID TEXT"
        Try
            command.ExecuteNonQuery()
            notifiedOfChange = True
        Catch ex As Exception
            'column already exists - ignore
        End Try
        command.CommandText = "ALTER TABLE [tblGames] ADD COLUMN rsslink TEXT"
        Try
            command.ExecuteNonQuery()
            notifiedOfChange = True
        Catch ex As Exception
            'column already exists - ignore
        End Try
        command.CommandText = "ALTER TABLE [tblGames] ADD COLUMN steamid TEXT"
        Try
            command.ExecuteNonQuery()
            notifiedOfChange = True
        Catch ex As Exception
            'column already exists - ignore
        End Try
        command.CommandText = "ALTER TABLE [tblNews] ADD COLUMN image BLOB"
        Try
            command.ExecuteNonQuery()
            notifiedOfChange = True
        Catch ex As Exception
            'column already exists - ignore
        End Try

        If notifiedOfChange Then MsgBox("The database has changed. Please run ""Refresh All Games"" from the Options tab.", MsgBoxStyle.Exclamation, "Shit's gonna break if you don't...")



        conn.Close()



#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Private Sub LoadMyGames()

#If DEBUG Then
#Else
        Try
#End If

        'Save how the grid is sorted 
        Dim sortedBy As DataGridViewColumn = dgvMyGames.SortedColumn

        Dim direction As ListSortDirection
        If dgvMyGames.SortOrder = SortOrder.Ascending Then
            direction = ListSortDirection.Ascending
        Else
            direction = ListSortDirection.Descending
        End If



        Dim db As New SQLiteDatabase(dbFileName)

        Dim results As New DataTable

        Dim query As [String] = "select gbid, image, name as 'Name', date(case when original_release_date = '' then case when expReleaseDate = '' then '9999-01-01' else expReleaseDate end else original_release_date end) as 'Release Date' from tblGames order by name"
        results = db.GetDataTable(query)

        dgvMyGames.DataSource = results


        dgvMyGames.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dgvMyGames.Columns(1).HeaderText = ""
        'width totals 488
        dgvMyGames.Columns(1).Width = 40
        dgvMyGames.Columns(2).Width = 339
        dgvMyGames.Columns(3).Width = 100

        Dim progbarStart As Integer = 10
        Dim progbarMax As Integer = 40
        Dim progbarUpdateEveryNth As Integer = 1
        If dgvMyGames.RowCount > 0 Then
            If progbarMax / dgvMyGames.RowCount > 1 Then
                progbarUpdateEveryNth = 1
            Else
                progbarUpdateEveryNth = CInt(dgvMyGames.RowCount / progbarMax)
            End If
        End If

        For i = 0 To dgvMyGames.RowCount - 1

            If progbarUpdateEveryNth Mod (i + 1) = 0 Then
                progbarStart += progbarUpdateEveryNth
                Splashscreen.ShowBar(progbarStart)
                'Threading.Thread.Sleep(1000)
            End If

            Try

                Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(TryCast(dgvMyGames.Rows(i).Cells(1).Value, Byte()))
                Dim img As Image = System.Drawing.Image.FromStream(ms)
                dgvMyGames.Rows(i).Cells(1).Value = ResizeImage(img, 35, 35, False)

            Catch ex As Exception
                dgvMyGames.Rows(i).Cells(1).Value = My.Resources.ResourceManager.GetObject("blank")

            End Try
        Next

        dgvMyGames.Columns(0).Visible = False

        dgvMyGames.ClearSelection()




        'Restore sort order
        If Not sortedBy Is Nothing Then
            Dim newColumn As DataGridViewColumn = dgvMyGames.Columns(sortedBy.Name.ToString())
            dgvMyGames.Sort(newColumn, direction)
            newColumn.HeaderCell.SortGlyphDirection = If(direction = ListSortDirection.Ascending, SortOrder.Ascending, SortOrder.Descending)
        End If



#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Public Shared Function ResizeImage(img As Image, width As Integer, height As Integer, onlyResizeIfWider As Boolean) As Image
        Using image__1 As Image = img
            ' Prevent using images internal thumbnail
            image__1.RotateFlip(RotateFlipType.Rotate180FlipNone)
            image__1.RotateFlip(RotateFlipType.Rotate180FlipNone)

            If onlyResizeIfWider = True Then
                If image__1.Width <= width Then
                    width = image__1.Width
                End If
            End If

            Dim newHeight As Integer = image__1.Height * width / image__1.Width
            If newHeight > height Then
                ' Resize with height instead
                width = image__1.Width * height / image__1.Height
                newHeight = height
            End If

            Dim NewImage As Image = image__1.GetThumbnailImage(width, newHeight, Nothing, IntPtr.Zero)

            Return NewImage
        End Using
    End Function


    Public Sub ChangeVisibility(ByVal visibility As Boolean)
        picLoading.Visible = visibility
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click

#If DEBUG Then
#Else
        Try
#End If

        lblResults.Visible = False
        listResults.Visible = False

        lblStatus.Text = "Searching for " & txtSearch.Text & "..."
        panRight.Visible = False
        panLeft.Enabled = False
        Application.DoEvents()



        If Not bgwSearch.IsBusy = True Then
            bgwSearch.RunWorkerAsync()
        End If

        'bw.RunWorkerAsync()

        'Do While bw.IsBusy
        '    Application.DoEvents()
        'Loop



#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Private Sub listResults_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles listResults.SelectedIndexChanged

#If DEBUG Then
#Else
        Try
#End If
        If Not ignoreSelectedIndexChanged Then
            If Not listResults.SelectedItem Is Nothing Then
                ' Get the currently selected item in the ListBox. 
                Dim curItem As String = listResults.SelectedItem("name").ToString()

                Dim api_detail_url As String = listResults.SelectedItem("api_detail_url").ToString

                panRight.Visible = False
                Application.DoEvents()

                LoadGameDetailAPI(api_detail_url, curItem)
            End If
        End If

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Private Sub LoadGameDetailAPI(ByVal api_detail_url As String, ByVal gameName As String, Optional ByVal display As Boolean = True)

#If DEBUG Then
#Else
        Try
#End If

        'Lock Down form while loading stuff
        panLeft.Enabled = False


        lblStatus.Text = "Retrieving details for " & gameName & " from API..."
        Application.DoEvents()
        panRight.Visible = False

        btnRemove.Enabled = False
        btnRefreshFromAPI.Visible = False

        If display Then displayGameDetails = True Else displayGameDetails = False

        If Not bgwLoadGame.IsBusy = True Then
            bgwLoadGame.RunWorkerAsync(api_detail_url)
        End If


        'If display Then
        '    panRight.Visible = True
        '    panLeft.Enabled = True

        '    listResults.Focus()
        'End If



#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Private Sub LoadGameDetailLocal(ByVal api_detail_url As String, ByVal gameName As String)

#If DEBUG Then
#Else
        Try
#End If

        'Lock Down form while loading stuff
        panLeft.Enabled = False


        lblStatus.Text = "Retrieving details for " & gameName & " from local database..."
        Application.DoEvents()
        panRight.Visible = False

        btnRefreshFromAPI.Visible = True

        picStar.Image = My.Resources.ResourceManager.GetObject("Buzz_Star_icon")
        picStar.Visible = True


        If Not bgwLoadGameLocal.IsBusy = True Then
            bgwLoadGameLocal.RunWorkerAsync(api_detail_url)
        End If





#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub

    Private Sub btnClearSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnClearSearch.Click

#If DEBUG Then
#Else
        Try
#End If

        txtSearch.Text = ""

        listResults.DataSource = Nothing
        listofGames.Clear()

        panRight.Visible = False

        btnClearSearch.Enabled = False

        txtSearch.Focus()

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub

    Private Sub lnkMoreInfo_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkMoreInfo.LinkClicked

#If DEBUG Then
#Else
        Try
#End If

        System.Diagnostics.Process.Start(gameURL)

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If
    End Sub

    Private Sub bgwSearch_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles bgwSearch.RunWorkerCompleted
        Me.Invoke(ChangePictureVisibility, False)

        ignoreSelectedIndexChanged = True
        listResults.DataSource = listofGames
        listResults.ValueMember = "api_detail_url"
        listResults.DisplayMember = "name"
        ignoreSelectedIndexChanged = False

        If listResults.Items.Count = 1 Then
            listResults.SelectedIndex = 0
            Dim curItem As String = listResults.SelectedItem("name").ToString()

            Dim api_detail_url As String = listResults.SelectedItem("api_detail_url").ToString

            panRight.Visible = False
            Application.DoEvents()

            LoadGameDetailAPI(api_detail_url, curItem)
        End If

        lblResults.Visible = True
        listResults.Visible = True
        btnClearSearch.Enabled = True
        btnSearch.Enabled = True
        panLeft.Enabled = True
        'panRight.Visible = True

        listResults.Focus()

        lblStatus.Text = "Returned " & listofGames.Rows.Count & " results."
        Application.DoEvents()
    End Sub

    Private Sub bgwSearch_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwSearch.DoWork

#If DEBUG Then
#Else
        Try
#End If
        btnSearch.Enabled = False
        btnClearSearch.Enabled = False
        Application.DoEvents()

        Me.Invoke(ChangePictureVisibility, True)

        ' Create a request for the URL. 
        Dim request As WebRequest = WebRequest.Create("http://www.giantbomb.com/api/search/?api_key=" & My.Settings.Giantbomb_APIKey & "&format=json&query=""" & txtSearch.Text & """&resources=game")



        ' Get the response.
        Dim response As WebResponse = request.GetResponse()

        ' Display the status.
        'Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)

        ' Get the stream containing content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()

        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)

        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()

        ' Display the content.
        'lblResults.Text = responseFromServer

        'Create Games object from response
        'Dim searchResults As Games = JsonConvert.DeserializeObject(responseFromServer)

        Dim token As JToken = JObject.Parse(responseFromServer)

        'Check for error
        Dim status_code As JToken = token.SelectToken("status_code")

        Select Case status_code.ToString
            Case "1"
                'all good, continue
            Case Else
                MsgBox("An error has occurred! API returned Status Code of " & status_code.ToString, MsgBoxStyle.Critical, "Aww damn!")
                Exit Sub
        End Select

        Dim results As JToken = token.SelectToken("results")

        listofGames.Clear()




        For Each result As JToken In results

            Dim name As JToken = result.SelectToken("name")

            Dim api_detail_url As JToken = result.SelectToken("api_detail_url")

            'Try
            'listofGames.Add(name.ToString, api_detail_url.ToString)
            'listResults.Items.Add(name.ToString)
            Dim newRow As DataRow = listofGames.NewRow
            newRow.Item("name") = name.ToString
            newRow.Item("api_detail_url") = api_detail_url.ToString
            listofGames.Rows.Add(newRow)
            'Catch ex As Exception
            'if this fails it's likely cause there's a duplicate name so we'll ignore - this isn't great but will do for now. need to not key on the name of the game in the future and use its id instead
            'End Try


        Next



        ' Clean up the streams and the response.
        reader.Close()
        response.Close()



#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub

    Private Sub lnkCreditsAPI_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCreditsAPI.LinkClicked

        System.Diagnostics.Process.Start("http://www.giantbomb.com/api/")

    End Sub

    Private Sub lnkCreditsIcon_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCreditsIcon.LinkClicked

        System.Diagnostics.Process.Start("http://www.iconarchive.com/show/sugar-icons-by-snobawm/games-icon.html")

    End Sub

    Private Sub btnAddToMyGames_Click(sender As System.Object, e As System.EventArgs) Handles btnAddToMyGames.Click, picStar.Click

#If DEBUG Then
#Else
        Try
#End If

        Dim db As New SQLiteDatabase(dbFileName)

        'Check if entry already exists in local database

        Dim results As DataTable
        Dim query As [String] = "select NAME from tblGames where gbid = '" & thisGame.gbid & "'"
        results = db.GetDataTable(query)

        If results.Rows.Count >= 1 Then
            MsgBox(thisGame.name & " already exists in your list of games.", MsgBoxStyle.Exclamation, "Wait what?!")
            Exit Sub
        End If


        Dim converter As New ImageConverter



        Dim data As New Dictionary(Of [String], [String])()

        data.Add("gbid", thisGame.gbid)
        data.Add("name", thisGame.name)
        data.Add("descr", thisGame.descr)
        data.Add("platforms", thisGame.platforms)
        data.Add("developers", thisGame.developers)
        data.Add("publishers", thisGame.publishers)
        data.Add("original_release_date", IIf(thisGame.original_release_date.ToString("yyyy-MM-dd HH:mm:ss") = "0001-01-01 00:00:00", "", thisGame.original_release_date.ToString("yyyy-MM-dd HH:mm:ss")))
        data.Add("expReleaseDate", IIf(thisGame.expReleaseDate.ToString("yyyy-MM-dd HH:mm:ss") = "0001-01-01 00:00:00", "", thisGame.expReleaseDate.ToString("yyyy-MM-dd HH:mm:ss")))
        data.Add("site_detail_url", thisGame.site_detail_url)
        data.Add("lastupdated", Now.ToString("yyyy-MM-dd HH:mm:ss"))
        data.Add("GamesRadarID", thisGame.GamesRadarID)
        data.Add("rsslink", thisGame.rsslink)

        db.Insert("tblGames", data)



        Using connection = New SQLiteConnection("Data Source=" & dbFileName & ";Version=3")
            Dim command As New SQLiteCommand
            command.Connection = connection
            connection.Open()

            command.CommandText = "UPDATE tblGames SET image = @image where gbid = '" & thisGame.gbid & "'"
            command.Parameters.Add("@image", DbType.Binary, 20).Value = converter.ConvertTo(thisGame.image, GetType(Byte()))
            command.ExecuteNonQuery()

            connection.Close()

        End Using


        RetrieveNews(thisGame.gbid)

        Do While bgwLoadGameNews.IsBusy
            Application.DoEvents()
        Loop

        'MsgBox(thisGame.name & " was added to your list of games!", MsgBoxStyle.Information)



        picStar.Image = My.Resources.ResourceManager.GetObject("Buzz_Star_icon")
        btnAddToMyGames.Enabled = False
        btnRemove.Enabled = True
        btnRefreshFromAPI.Visible = True
        LoadMyGames()
        LoadAllNews()

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Private Shared Function GetBytes(reader As SQLiteDataReader) As Byte()
        Const CHUNK_SIZE As Integer = 2 * 1024
        Dim buffer As Byte() = New Byte(CHUNK_SIZE - 1) {}
        Dim bytesRead As Long
        Dim fieldOffset As Long = 0
        Using stream As New MemoryStream()
            While (InlineAssignHelper(bytesRead, reader.GetBytes(0, fieldOffset, buffer, 0, buffer.Length))) > 0
                stream.Write(buffer, 0, CInt(bytesRead))
                fieldOffset += bytesRead
            End While
            Return stream.ToArray()
        End Using
    End Function
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function

    Private Sub lnkCreditsStarIcon_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCreditsStarIcon.LinkClicked

        System.Diagnostics.Process.Start("http://www.iconarchive.com/show/icons8-metro-style-icons-by-visualpharm/Buzz-Star-icon.html")

    End Sub

    Private Sub dgvMyGames_CellClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles dgvMyGames.CellClick

#If DEBUG Then
#Else
        Try
#End If

        If e.RowIndex <> -1 Then

            If Not dgvMyGames.CurrentRow Is Nothing Then

                dgvMyGames.Rows(e.RowIndex).Selected = True

                Dim api_detail_url As String = dgvMyGames.CurrentRow.Cells(0).Value
                Dim gameName As String = dgvMyGames.CurrentRow.Cells(2).Value

                LoadGameDetailLocal(api_detail_url, gameName)

            End If

        End If

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If
    End Sub

    Private Sub TabControl1_Selected(sender As System.Object, e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected

        panRight.Visible = False
        webNews.Visible = False
        webAllNews.Visible = False
        lblStatus.Text = ""

    End Sub

    Private Sub btnResetDatabase_Click(sender As System.Object, e As System.EventArgs) Handles btnResetDatabase.Click

#If DEBUG Then
#Else
        Try
#End If

        Dim result As Integer = MessageBox.Show("This will reset the local database file and DELETE all the games you have added! Are you sure?", "ARE YOU SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.No Then

            Exit Sub

        ElseIf result = DialogResult.Yes Then

            Dim result2 As Integer = MessageBox.Show("ARE YOU *REALLY* SURE?", "ARE YOU *REALLY* SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If result2 = DialogResult.No Then

                Exit Sub

            ElseIf result2 = DialogResult.Yes Then

                Using connection = New SQLiteConnection("Data Source=" & dbFileName & ";Version=3")
                    Dim command As New SQLiteCommand
                    command.Connection = connection
                    connection.Open()

                    command.CommandText = "DELETE FROM tblGames"
                    command.ExecuteNonQuery()

                    command.CommandText = "DELETE FROM tblNews"
                    command.ExecuteNonQuery()

                    connection.Close()

                End Using

                LoadMyGames()
                LoadAllNews()

                MsgBox("Your database is now clean.", MsgBoxStyle.Information, "Well it's what you wanted...")

            End If


        End If



#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click

#If DEBUG Then
#Else
        Try
#End If

        Using connection = New SQLiteConnection("Data Source=" & dbFileName & ";Version=3")
            Dim command As New SQLiteCommand
            command.Connection = connection
            connection.Open()

            command.CommandText = "DELETE FROM tblGames where gbid = '" & thisGame.gbid & "'"
            command.ExecuteNonQuery()

            command.CommandText = "DELETE FROM tblNews where gbid = '" & thisGame.gbid & "'"
            command.ExecuteNonQuery()

            connection.Close()

        End Using

        'MsgBox(thisGame.name & " was removed from your list of games!", MsgBoxStyle.Information)

        picStar.Image = My.Resources.ResourceManager.GetObject("Buzz_Star_icon2")
        btnAddToMyGames.Enabled = True
        btnRemove.Enabled = False
        btnRefreshFromAPI.Visible = False
        LoadMyGames()
        LoadAllNews()


#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub

    Private Sub picDonation_Click(sender As System.Object, e As System.EventArgs) Handles picDonation.Click

        System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=4AANT8N22S3UW")

    End Sub

    Private Sub btnRefreshFromAPI_Click(sender As System.Object, e As System.EventArgs) Handles btnRefreshFromAPI.Click

#If DEBUG Then
#Else
        Try
#End If

        lblStatus.Text = "Refreshing data for " & thisGame.name & " from the API..."
        Application.DoEvents()

        LoadGameDetailAPI(thisGame.gbid, thisGame.name, True)

        Do While bgwLoadGame.IsBusy
            Application.DoEvents()
        Loop

        UpdateLocalGameDetail(thisGame.gbid, thisGame.name)

        'LoadGameDetailLocal(thisGame.gbid, thisGame.name)

        btnRefreshFromAPI.Visible = True

        LoadMyGames()


        dgvMyGames.Focus()




#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Private Sub UpdateLocalGameDetail(ByVal gbid As String, ByVal name As String)

#If DEBUG Then
#Else
        Try
#End If

        Dim db As New SQLiteDatabase(dbFileName)

        'Check if entry already exists in local database

        Dim results As DataTable
        Dim query As [String] = "select NAME from tblGames where gbid = '" & thisGame.gbid & "'"
        results = db.GetDataTable(query)

        If results.Rows.Count < 1 Then
            'game isn't in local db... wtf?
            Exit Sub
        End If


        Dim converter As New ImageConverter

        Dim data As New Dictionary(Of [String], [String])()

        data.Add("gbid", thisGame.gbid)
        data.Add("name", thisGame.name)
        data.Add("descr", thisGame.descr)
        data.Add("platforms", thisGame.platforms)
        data.Add("developers", thisGame.developers)
        data.Add("publishers", thisGame.publishers)
        data.Add("original_release_date", IIf(thisGame.original_release_date.ToString("yyyy-MM-dd HH:mm:ss") = "0001-01-01 00:00:00", "", thisGame.original_release_date.ToString("yyyy-MM-dd HH:mm:ss")))
        data.Add("expReleaseDate", IIf(thisGame.expReleaseDate.ToString("yyyy-MM-dd HH:mm:ss") = "0001-01-01 00:00:00", "", thisGame.expReleaseDate.ToString("yyyy-MM-dd HH:mm:ss")))
        data.Add("site_detail_url", thisGame.site_detail_url)
        data.Add("lastupdated", Now.ToString("yyyy-MM-dd HH:mm:ss"))
        data.Add("GamesRadarID", thisGame.GamesRadarID)
        data.Add("rsslink", thisGame.rsslink)

        db.Update("tblGames", data, "gbid = '" & gbid & "'")



        Using connection = New SQLiteConnection("Data Source=" & dbFileName & ";Version=3")
            Dim command As New SQLiteCommand
            command.Connection = connection
            connection.Open()

            command.CommandText = "UPDATE tblGames SET image = @image where gbid = '" & gbid & "'"
            command.Parameters.Add("@image", DbType.Binary, 20).Value = converter.ConvertTo(thisGame.image, GetType(Byte()))
            command.ExecuteNonQuery()

            connection.Close()

        End Using


        'MsgBox("Updated info for " & name & " from API.", MsgBoxStyle.Information)



#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub

    Private Sub dgvMyGames_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvMyGames.CellFormatting

#If DEBUG Then
#Else
        Try
#End If

        If e.ColumnIndex = dgvMyGames.Columns("Release Date").Index Then

            Dim releaseDate As String = e.Value.ToString()

            If releaseDate IsNot Nothing Then

                If IsDate(releaseDate) Then

                    If releaseDate > Today Then
                        If releaseDate = "9999-01-01" Then
                            Select Case My.Settings.Theme
                                Case "Light"
                                    dgvMyGames.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Maroon
                                Case "Dark"
                                    dgvMyGames.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.DarkSalmon
                            End Select
                            dgvMyGames.Rows(e.RowIndex).Cells(3).Value = "Unknown"
                        Else
                            Select Case My.Settings.Theme
                                Case "Light"
                                    dgvMyGames.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Maroon
                                Case "Dark"
                                    dgvMyGames.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.DarkSalmon
                            End Select
                        End If

                    Else
                        Select Case My.Settings.Theme
                            Case "Light"
                                dgvMyGames.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
                            Case "Dark"
                                dgvMyGames.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.LightGray
                        End Select
                    End If

                Else
                    Select Case My.Settings.Theme
                        Case "Light"
                            dgvMyGames.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Maroon
                        Case "Dark"
                            dgvMyGames.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.DarkSalmon
                    End Select


                End If

            End If
        End If


#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        Select Case TabControl1.SelectedIndex
            Case 0
                'Search
                If txtSearch.Text = "" Then txtSearch.Focus() Else listResults.Focus()
            Case 1
                'Latest News
                panLeft.Width = 1046
                panRight.Width = 0
                LoadAllNews()
                dgvNews.Focus()
                'webAllNews.Dock = DockStyle.Right
                webAllNews.Left = 517
                webAllNews.Top = 0
                webAllNews.Width = 519
                webAllNews.Height = 572
                webAllNews.Visible = False

            Case 2
                'My Games
                dgvMyGames.Focus()

            Case 3
                'Options
                cboTheme.SelectedItem = My.Settings.Theme
                cboDefaultTab.SelectedItem = My.Settings.DefaultTab

        End Select

        If TabControl1.SelectedIndex <> 1 Then
            panLeft.Width = 521
            panRight.Width = 525
        End If

    End Sub




    Private Function getGameIDfromGamesRadar(ByVal name As String, Optional ByVal platforms As String = "pc") As String

#If DEBUG Then
#Else
        Try
#End If

        name = name.ToUpper 'just so we can not fuck around with case differences, bad enough we have to rely on names >.<

        'Gotta narrow the platforms down to one.... this is gonna be ugly
        'I want to search by priority so it's even more ugly
        Dim platformToUse As String = GetPlatformToUse(platforms)

        ' Retrieve XML document  
        Dim reader As XmlTextReader = New XmlTextReader("http://api.gamesradar.com/search/gameName/" & platformToUse & "/" & name & "?api_key=" & My.Settings.GamesRadar_APIKey)

        ' Skip non-significant whitespace  
        reader.WhitespaceHandling = WhitespaceHandling.Significant

        If reader IsNot Nothing Then

            'Get all the games returned from the search
            Dim gameResults As New GamesRadar.games
            Dim serializer As New XmlSerializer(GetType(GamesRadar.games))

            Try

                gameResults = DirectCast(serializer.Deserialize(reader), GamesRadar.games)

                'Find the one we actually want!
                For Each game As GamesRadar.gamesGame In gameResults.game

                    If game.name.ToUpper = name Then
                        Return game.id
                    End If

                Next

            Catch ex As Exception
                'no games found on gamesradar
            End Try

        End If

        Return ""

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Function


    Private Function GetPlatformToUse(ByVal platforms As String) As String

        For Each platform As String In platforms.Split(", ")
            If platform.Trim.ToUpper = "PC" Then
                Return ("pc")
            End If
        Next

        For Each platform As String In platforms.Split(", ")
            If platform.Trim.ToUpper = "XBOX ONE" Then
                Return ("Xbox One") 'appears not implemented
            End If
        Next

        For Each platform As String In platforms.Split(", ")
            If platform.Trim.ToUpper = "PLAYSTATION 4" Then
                Return ("ps4") 'appears not implemented
            End If
        Next

        For Each platform As String In platforms.Split(", ")
            If platform.Trim.ToUpper = "XBOX 360" Then
                Return ("xbox360")
            End If
        Next

        For Each platform As String In platforms.Split(", ")
            If platform.Trim.ToUpper = "PLAYSTATION 3" Then
                Return ("ps3")
            End If
        Next

        'failsafe
        Return ("pc")

    End Function


    Private Function getRSSFeedfromGamesRadarID(ByVal id As String) As String

#If DEBUG Then
#Else
        Try
#End If

        If id = "" Then
            Return ""
        End If

        ' Retrieve XML document  
        Dim reader As XmlTextReader = New XmlTextReader("http://api.gamesradar.com/game/" & id & "?api_key=" & My.Settings.GamesRadar_APIKey)

        ' Skip non-significant whitespace  
        reader.WhitespaceHandling = WhitespaceHandling.Significant

        'Get all the games returned from the search
        Dim gameResult As New GamesRadar.game
        Dim serializer As New XmlSerializer(GetType(GamesRadar.game))

        gameResult = DirectCast(serializer.Deserialize(reader), GamesRadar.game)

        If Not gameResult.links Is Nothing Then
            Dim rss As GamesRadar.gameLinks = gameResult.links(0)
            Return rss.rss

        End If

        Return ""

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Function

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        System.Diagnostics.Process.Start("http://www.gamesradar.com/developer/")

    End Sub


    Private Function ReadRSS(ByVal URL As String, ByVal includeDescription As Boolean, ByVal forWeb As Boolean, Optional ByVal returnDatatable As Boolean = False)

#If DEBUG Then
#Else
        Try
#End If

        Dim wr As WebRequest = System.Net.WebRequest.Create(URL)
        Dim resp As WebResponse = wr.GetResponse()

        Dim rssStream As Stream = resp.GetResponseStream()
        Dim rssDoc As New XmlDocument()
        rssDoc.Load(rssStream)

        Dim rssItems As XmlNodeList = rssDoc.SelectNodes("rss/channel/item")

        Dim title As String = ""
        Dim link As String = ""
        Dim description As String = ""
        Dim pubDate As New Date
        Dim i As Integer

        Dim returnString As String = ""



        If forWeb Then
            Select Case My.Settings.Theme
                Case "Light"
                    returnString = "<style>body { padding: 0px; font-family: Sans-Serif; color: #000; font-size: 8.25pt; font-weight: normal; } a, a.visited { color: #000; }</style>"
                Case "Dark"
                    returnString = "<style>body { background-color: #808080; padding: 0px; font-family: Sans-Serif; color: #f0f0f0; font-size: 8.25pt; font-weight: normal; } a, a.visited { color: #f0f0f0; }</style>"
            End Select

            returnString &= "Latest News: <br>"
        End If

        'GamesRadar doesn't sort their RSS feed so I have to do it here!! :(
        Dim newsResults As New DataTable
        newsResults.Columns.Add("title", GetType(System.String))
        newsResults.Columns.Add("link", GetType(System.String))
        newsResults.Columns.Add("description", GetType(System.String))
        newsResults.Columns.Add("pubDate", GetType(System.DateTime))

        For i = 0 To rssItems.Count - 1

            Dim thisRow As DataRow = newsResults.NewRow()

            Dim rssDetail As XmlNode
            'Get the title
            rssDetail = rssItems.Item(i).SelectSingleNode("title")
            If rssDetail.Equals(Nothing) = False Then
                title = rssDetail.InnerText
            Else
                title = ""
            End If
            'Get the link
            rssDetail = rssItems.Item(i).SelectSingleNode("link")
            If rssDetail.Equals(Nothing) = False Then
                link = rssDetail.InnerText
            Else
                link = ""
            End If
            'Get the description
            rssDetail = rssItems.Item(i).SelectSingleNode("description")
            If rssDetail.Equals(Nothing) = False Then
                description = rssDetail.InnerText
            Else
                description = ""
            End If
            'Get the date
            rssDetail = rssItems.Item(i).SelectSingleNode("pubDate")
            If rssDetail.Equals(Nothing) = False Then
                pubDate = rssDetail.InnerText
            Else
                description = ""
            End If

            thisRow.Item("title") = title
            thisRow.Item("link") = link
            thisRow.Item("description") = description
            thisRow.Item("pubDate") = pubDate

            newsResults.Rows.Add(thisRow)

        Next

        Dim rowList() As DataRow = newsResults.Select("", "pubDate DESC")

        If returnDatatable Then Return newsResults

        For Each r As DataRow In rowList
            If forWeb Then
                returnString &= CDate(r("pubDate")).ToString("yyyy-MM-dd") & ": <a href='" & r("link") & "' target=new>" & r("title") & "</a>" & IIf(includeDescription, r("description") & "<br>", "<br>")
            Else
                returnString &= r("title") & " (" & CDate(r("pubDate")).ToShortDateString & ")" & IIf(includeDescription, r("description") & vbNewLine, vbNewLine)
            End If
        Next

        Return returnString


#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If


    End Function

    Private Function StripTags(ByVal html As String) As String
        ' Remove HTML tags.
        Return Regex.Replace(html, "<.*?>", "")
    End Function

    Private Sub dgvMyGames_MouseEnter(sender As System.Object, e As System.EventArgs) Handles dgvMyGames.MouseEnter
        dgvMyGames.Focus()
    End Sub

    Private Sub listResults_MouseEnter(sender As System.Object, e As System.EventArgs) Handles listResults.MouseEnter
        listResults.Focus()
    End Sub

    Private Sub btnRefreshAll_Click(sender As System.Object, e As System.EventArgs) Handles btnRefreshAll.Click

#If DEBUG Then
#Else
        Try
#End If

        Dim result As Integer = MessageBox.Show("This will refresh ALL the games in your My Games list with data from the web and may take a significat amount of time depending on the number of games. It may also harm small kittens... Are you sure you wish to proceed?", "ARE YOU SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.No Then

            Exit Sub

        ElseIf result = DialogResult.Yes Then

            progBrowser.Maximum = dgvMyGames.RowCount
            progBrowser.Value = 0
            progBrowser.Visible = True
            panLeft.Enabled = False

            For Each thisRow As DataGridViewRow In dgvMyGames.Rows

                progBrowser.Value += 1

                Dim api_detail_url As String = thisRow.Cells(0).Value
                Dim gameName As String = thisRow.Cells(2).Value

                'MsgBox(gameName)
                'LoadGameDetailAPI(api_detail_url, gameName, False)
                lblStatus.Text = "Refreshing " & gameName & "..."
                Application.DoEvents()

                DoActuallyLoadGame(api_detail_url)

                UpdateLocalGameDetail(api_detail_url, gameName)

            Next

            progBrowser.Value = progBrowser.Maximum


            panLeft.Enabled = True

            MsgBox("All done! And the kittens are okay, thanks for your concern.", MsgBoxStyle.Information, "Can't believe this worked...")

            progBrowser.Visible = False

            lblStatus.Text = ""
            Application.DoEvents()

        End If



#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        System.Diagnostics.Process.Start("http://www.twitter.com/ChalkOne/")

    End Sub


    Private Sub RetrieveNews(ByVal api_detail_url As String)

#If DEBUG Then
#Else
        Try
#End If

        panLeft.Enabled = False

        If Not bgwLoadGameNews.IsBusy = True Then
            bgwLoadGameNews.RunWorkerAsync(api_detail_url)
        End If

        'Debug.Print(newsResults.Rows.Count)

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Private Sub RetrieveAllNews()

#If DEBUG Then
#Else
        Try
#End If

        panLeft.Enabled = False
        progBrowser.Visible = True

        If Not bgwLoadAllGameNews.IsBusy = True Then
            bgwLoadAllGameNews.RunWorkerAsync()
        End If

        

        'Debug.Print(newsResults.Rows.Count)

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Private Sub LoadAllNews()

#If DEBUG Then
#Else
        Try
#End If

        'Save how the grid is sorted 
        Dim sortedBy As DataGridViewColumn = dgvNews.SortedColumn

        Dim direction As ListSortDirection
        If dgvNews.SortOrder = SortOrder.Ascending Then
            direction = ListSortDirection.Ascending
        Else
            direction = ListSortDirection.Descending
        End If



        Dim db As New SQLiteDatabase(dbFileName)

        Dim results As New DataTable

        Dim query As [String] = "select id, date(pubDate) as 'Date', GameName as 'Game', title as 'Title', link, image from tblNews order by pubDate DESC"
        results = db.GetDataTable(query)


        dgvNews.DataSource = results


        dgvNews.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        'total width of 488
        dgvNews.Columns(1).Width = 71
        dgvNews.Columns(2).Width = 150
        dgvNews.Columns(3).Width = 238


        dgvNews.Columns(0).Visible = False
        dgvNews.Columns(4).Visible = False
        dgvNews.Columns(5).HeaderText = ""


        dgvNews.Columns(5).Width = 20

        Dim progbarStart As Integer = 50
        Dim progbarMax As Integer = 40
        Dim progbarUpdateEveryNth As Integer = 1
        If dgvNews.RowCount > 0 Then
            If progbarMax / dgvNews.RowCount > 1 Then
                progbarUpdateEveryNth = 1
            Else
                progbarUpdateEveryNth = CInt(dgvNews.RowCount / progbarMax)
            End If
        End If


        For i = 0 To dgvNews.RowCount - 1

            If progbarUpdateEveryNth Mod (i + 1) = 0 Then
                progbarStart += progbarUpdateEveryNth
                Splashscreen.ShowBar(progbarStart)
                'Threading.Thread.Sleep(1000)
            End If


            dgvNews.Rows(i).Cells(5).Value = My.Resources.ResourceManager.GetObject("externallink")


        Next


        dgvNews.ClearSelection()


        'Restore sort order
        If Not sortedBy Is Nothing Then
            Dim newColumn As DataGridViewColumn = dgvNews.Columns(sortedBy.Name.ToString())
            dgvNews.Sort(newColumn, direction)
            newColumn.HeaderCell.SortGlyphDirection = If(direction = ListSortDirection.Ascending, SortOrder.Ascending, SortOrder.Descending)
        End If






#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If
    End Sub

    Private Sub btnRefreshAllNews_Click_1(sender As System.Object, e As System.EventArgs) Handles btnRefreshAllNews.Click

        RetrieveAllNews()

        LoadAllNews()

    End Sub

    Private Sub dgvNews_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNews.CellClick

#If DEBUG Then
#Else
        Try
#End If

        If e.RowIndex <> -1 Then

            If Not dgvNews.CurrentRow Is Nothing Then

                If Not e.ColumnIndex = 5 Then
                    dgvNews.Rows(e.RowIndex).Selected = True

                    Dim id As String = dgvNews.CurrentRow.Cells(0).Value
                    Dim gameName As String = dgvNews.CurrentRow.Cells(2).Value

                    'load description into webbrowser or something
                    DisplayNewsinBrowser(id, gameName)
                End If

            End If

        End If

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Private Sub DisplayNewsinBrowser(ByVal id As String, ByVal gameName As String)

#If DEBUG Then
#Else
        Try
#End If

        Dim db As New SQLiteDatabase(dbFileName)
        Dim results As DataTable
        Dim link As String = ""

        Dim query As [String] = "select link from tblNews where id = '" & id & "'"
        results = db.GetDataTable(query)

        For Each r As DataRow In results.Rows
            link = r("link")
        Next

        dgvNews.Enabled = False
        btnRefreshAllNews.Enabled = False

        lblStatus.Text = "Loading article. This may take a while..."
        Application.DoEvents()

        'Dim webString = "<html><head><style>body { padding: 0px; font-family: Sans-Serif; color: #000; font-size: 8.25pt; font-weight: normal; } a, a.visited { color: blue; } img { max-width: 480px !important; }</style></head><body>"

        'webString &= "<h1>" & title & "</h1>"
        'webString &= "<h5>Published on " & pubDate & "</h5>"
        'webString &= description
        'webString &= "</body></html>"

        'webAllNews.ScriptErrorsSuppressed = True
        'webAllNews.Focus()

        'If Not bgwLoadNews.IsBusy = True Then
        '    bgwLoadNews.RunWorkerAsync(link)
        'End If

        progBrowser.Value = 0
        progBrowser.Visible = True
        btnCancel.Visible = True
        btnCancel.ForeColor = Color.White

        webAllNews.Visible = False

        Me.Invoke(ChangePictureVisibility, True)
        picLoading.BringToFront()

        webAllNews.Navigate(link)




#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If
    End Sub

    Private Sub dgvNews_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNews.CellDoubleClick

        If e.RowIndex <> -1 Then

            If Not dgvNews.CurrentRow Is Nothing Then

                If e.ColumnIndex = 5 Then
                    dgvNews.Rows(e.RowIndex).Selected = True

                    Dim link As String = dgvNews.CurrentRow.Cells(4).Value

                    System.Diagnostics.Process.Start(link)

                End If

            End If

        End If

    End Sub



    Private Sub dgvNews_MouseEnter(sender As Object, e As System.EventArgs) Handles dgvNews.MouseEnter
        dgvNews.Focus()
    End Sub




    Private Sub webAllNews_DocumentCompleted(sender As System.Object, e As Gecko.Events.GeckoDocumentCompletedEventArgs) Handles webAllNews.DocumentCompleted

        Me.Invoke(ChangePictureVisibility, False)

        dgvNews.Enabled = True
        btnRefreshAllNews.Enabled = True

        btnCancel.Visible = False
        webAllNews.Visible = True
        lblStatus.Text = ""
        Application.DoEvents()
        webAllNews.Focus()
        progBrowser.Visible = False

    End Sub


    Private Sub webAllNews_MouseEnter(sender As System.Object, e As System.EventArgs) Handles webAllNews.MouseEnter
        webAllNews.Focus()
    End Sub

    Private Sub btnBackupDatabase_Click(sender As System.Object, e As System.EventArgs) Handles btnBackupDatabase.Click

#If DEBUG Then
#Else
        Try
#End If



        If fbdBackupPath.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        Else
            Dim targetLocation As String = fbdBackupPath.SelectedPath & "\"
            Dim targetFileName As String = dbFileName.Replace(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Video Game Tracker\", targetLocation)

            File.Copy(dbFileName, targetFileName, True)

            MsgBox("Database saved to " & targetFileName & ".", MsgBoxStyle.Information, "Backups are good!")
        End If

        

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If
    End Sub


    Private Sub bgwLoadNews_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLoadNews.DoWork

#If DEBUG Then
#Else
        Try
#End If

        Me.Invoke(ChangePictureVisibility, True)

        picLoading.BringToFront()

        webAllNews.Visible = False

        webAllNews.Navigate(DirectCast(e.Argument, String))

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub



    Private Sub bgwLoadGame_DoWork_1(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLoadGame.DoWork

#If DEBUG Then
#Else
        Try
#End If

        panRight.Visible = False

        Me.Invoke(ChangePictureVisibility, True)

        picLoading.BringToFront()

        Dim api_detail_url As String = DirectCast(e.Argument, String)

        DoActuallyLoadGame(api_detail_url)

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    Private Sub DoActuallyLoadGame(ByVal api_detail_url As String)

#If DEBUG Then
#Else
        Try
#End If

        Dim requestURL As String = api_detail_url & "?api_key=" & My.Settings.Giantbomb_APIKey & "&format=json&field_list=name,description,date_last_updated,deck,developers,expected_release_day,expected_release_month,expected_release_year,image,original_release_date,site_detail_url,platforms,publishers"

        ' Create a request for the URL. 
        Dim request As WebRequest = WebRequest.Create(requestURL)

        'for debug:
        'Try
        '    Clipboard.SetText(requestURL)
        'Catch ex As Exception
        '    Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        'End Try


        ' Get the response.
        Dim response As WebResponse = request.GetResponse()

        ' Display the status.
        'Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)

        ' Get the stream containing content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()

        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)

        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()


        'Create Games object from response

        Dim token As JToken = JObject.Parse(responseFromServer)

        'Check for error
        Dim status_code As JToken = token.SelectToken("status_code")

        Select Case status_code.ToString
            Case "1"
                'all good, continue
            Case Else
                MsgBox("An error has occurred! API returned Status Code of " & status_code.ToString, MsgBoxStyle.Critical, "Oh noes!")
                Exit Sub
        End Select

        Dim results As JToken = token.SelectToken("results")

        thisGame = New Giantbomb.Game

        Dim name As JToken = results.SelectToken("name")
        thisGame.name = name.ToString

        'Dim gbid As JToken = results.SelectToken("site_detail_url")
        thisGame.gbid = api_detail_url


        Dim db As New SQLiteDatabase(dbFileName)

        'Check if entry already exists in local database

        Dim dbresults As DataTable
        Dim query As [String] = "select NAME from tblGames where gbid = '" & thisGame.gbid & "'"
        dbresults = db.GetDataTable(query)

        If dbresults.Rows.Count >= 1 Then
            picStar.Image = My.Resources.ResourceManager.GetObject("Buzz_Star_icon")
            picStar.Visible = True
            btnAddToMyGames.Enabled = False
            btnRemove.Enabled = True
        Else
            picStar.Image = My.Resources.ResourceManager.GetObject("Buzz_Star_icon2")
            picStar.Visible = True
            btnAddToMyGames.Enabled = True
            btnRemove.Enabled = False
        End If


        Dim descr As JToken = results.SelectToken("deck")
        thisGame.descr = descr.ToString

        Dim platforms As JToken = results.SelectToken("platforms")
        Dim developers As JToken = results.SelectToken("developers")
        Dim publishers As JToken = results.SelectToken("publishers")
        Dim original_release_date As JToken = results.SelectToken("original_release_date")
        Dim expected_release_day As JToken = results.SelectToken("expected_release_day")
        Dim expected_release_month As JToken = results.SelectToken("expected_release_month")
        Dim expected_release_year As JToken = results.SelectToken("expected_release_year")

        Dim site_detail_url As JToken = results.SelectToken("site_detail_url")
        thisGame.site_detail_url = site_detail_url.ToString

        Dim expReleaseDate As Date = Nothing
        Dim expReleaseString As String = ""

        Dim enUS As New CultureInfo("en-US")

        If Not expected_release_year Is Nothing And Not expected_release_month Is Nothing And Not expected_release_day Is Nothing Then

            expReleaseString = expected_release_month.ToString & "/" & expected_release_day.ToString & "/" & expected_release_year.ToString

            Date.TryParseExact(expReleaseString, "M/d/yyyy", enUS, DateTimeStyles.None, expReleaseDate)
            expReleaseString = expected_release_year.ToString & "-" & expected_release_month.ToString & "-" & expected_release_day.ToString
            thisGame.expReleaseDate = expReleaseDate
        End If

        Dim image As JToken = results.SelectToken("image")
        Dim imgURL As JToken = image.SelectToken("small_url")

        Try

            If Not imgURL Is Nothing Then
                thisGame.image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(imgURL.ToString)))
                picThumb.Image = thisGame.image
            Else
                picThumb.Image = Nothing
            End If

        Catch ex As Exception
            picThumb.Image = Nothing
        End Try

        If Not name Is Nothing Then
            lblName.Text = name.ToString
        Else
            lblName.Text = "WTF happened?"
        End If

        Try
            Select Case My.Settings.Theme
                Case "Light"
                    lblReleaseDate.ForeColor = Color.Black
                Case "Dark"
                    lblReleaseDate.ForeColor = Color.LightGray
            End Select
            lblReleaseDate.Text = "Release Date: " & CDate(original_release_date.ToString).ToString("yyyy-MM-dd")
            thisGame.original_release_date = CDate(original_release_date.ToString)
        Catch ex As Exception
            Select Case My.Settings.Theme
                Case "Light"
                    lblReleaseDate.ForeColor = Color.Maroon
                Case "Dark"
                    lblReleaseDate.ForeColor = Color.DarkSalmon
            End Select
            lblReleaseDate.Text = "Release Date: " & expReleaseString
        End Try

        If Not descr Is Nothing Then
            lblDescription.Text = descr.ToString
        Else
            lblDescription.Text = ""
        End If

        If Not site_detail_url Is Nothing Then
            gameURL = site_detail_url.ToString
            lnkMoreInfo.Visible = True
        Else
            gameURL = ""
            lnkMoreInfo.Visible = False
        End If

        Dim platformsString As String = ""
        If Not platforms Is Nothing And platforms.ToString <> "" Then
            lblPlatforms.Text = "Platform(s): "
            For Each platform As JToken In platforms
                Dim pname As JToken = platform.SelectToken("name")
                platformsString &= pname.ToString & ", "
            Next
            platformsString = platformsString.Substring(0, platformsString.Length - 2)
            lblPlatforms.Text &= platformsString
            thisGame.platforms = platformsString
        End If

        If Not developers Is Nothing And developers.ToString <> "" Then
            lblDeveloper.Text = "Developer(s): "
            Dim devString As String = ""
            For Each developer As JToken In developers
                Dim devname As JToken = developer.SelectToken("name")
                devString &= devname.ToString & ", "
            Next
            devString = devString.Substring(0, devString.Length - 2)
            lblDeveloper.Text &= devString
            thisGame.developers = devString
        End If

        If Not publishers Is Nothing And publishers.ToString <> "" Then
            lblPublisher.Text = "Publisher(s): "
            Dim pubString As String = ""
            For Each publisher As JToken In publishers
                Dim pubname As JToken = publisher.SelectToken("name")
                pubString &= pubname.ToString & ", "
            Next
            pubString = pubString.Substring(0, pubString.Length - 2)
            lblPublisher.Text &= pubString
            thisGame.publishers = pubString
        End If

        reader.Close()
        response.Close()

        'Now get GamesRadarID
        thisGame.GamesRadarID = getGameIDfromGamesRadar(thisGame.name, platformsString)

        thisGame.rsslink = getRSSFeedfromGamesRadarID(thisGame.GamesRadarID)

        'Get Game News
        If thisGame.rsslink <> "" Then
            webNews.DocumentText = ReadRSS(thisGame.rsslink, False, True)
            webNews.Visible = True
        Else
            webNews.DocumentText = ""
            webNews.Visible = False
        End If

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub

    Private Sub bgwLoadGame_RunWorkerCompleted1(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwLoadGame.RunWorkerCompleted

        Me.Invoke(ChangePictureVisibility, False)

        If displayGameDetails Then
            panRight.Visible = True
            panLeft.Enabled = True

            listResults.Focus()
        End If

        lblStatus.Text = "Successfully loaded " & thisGame.name & "."
        Application.DoEvents()
    End Sub

    Private Sub bgwLoadGameLocal_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLoadGameLocal.DoWork

#If DEBUG Then
#Else
        Try
#End If

        panRight.Visible = False

        Me.Invoke(ChangePictureVisibility, True)

        picLoading.BringToFront()

        Dim api_detail_url As String = DirectCast(e.Argument, String)

        Dim db As New SQLiteDatabase(dbFileName)

        'Check if entry already exists in local database

        Dim results As DataTable
        Dim query As [String] = "select gbid, name as 'Name', descr, platforms, developers, publishers, image, site_detail_url, date(case when expReleaseDate = '' then original_release_date else expReleaseDate end) as 'Release Date', date(expReleaseDate) as expReleaseDate, date(original_release_date) as original_release_date, GamesRadarID, rsslink from tblGames where gbid = '" & api_detail_url & "'"
        results = db.GetDataTable(query)

        btnAddToMyGames.Enabled = False
        btnRemove.Enabled = True

        For Each r As DataRow In results.Rows

            thisGame.gbid = r("gbid")
            thisGame.name = r("name")
            If r("GamesRadarID") IsNot DBNull.Value Then thisGame.GamesRadarID = r("GamesRadarID") Else thisGame.GamesRadarID = ""
            If r("rsslink") IsNot DBNull.Value Then thisGame.rsslink = r("rsslink") Else thisGame.rsslink = ""

            lblName.Text = r("name")

            lblDescription.Text = r("descr")
            thisGame.descr = r("descr")

            lblPlatforms.Text = "Platform(s): "
            lblPlatforms.Text &= r("platforms")
            thisGame.platforms = r("platforms")

            lblDeveloper.Text = "Developer(s): "
            lblDeveloper.Text &= r("developers")
            thisGame.developers = r("developers")

            lblPublisher.Text = "Publisher(s): "
            lblPublisher.Text &= r("publishers")
            thisGame.publishers = r("publishers")

            Try
                Dim buffer As Byte() = r("image")
                Dim imageStream As New IO.MemoryStream(buffer)
                thisGame.image = Image.FromStream(imageStream)
                picThumb.Image = thisGame.image
            Catch ex As Exception
                picThumb.Image = My.Resources.ResourceManager.GetObject("blank")
            End Try

            If r("expReleaseDate") IsNot DBNull.Value Then thisGame.expReleaseDate = r("expReleaseDate") Else thisGame.expReleaseDate = Nothing
            If r("original_release_date") IsNot DBNull.Value Then thisGame.original_release_date = r("original_release_date") Else thisGame.original_release_date = Nothing
           

            If IsDate(r("Release Date")) Then
                If CDate(r("Release Date").ToString) > Today Then
                    Select Case My.Settings.Theme
                        Case "Light"
                            lblReleaseDate.ForeColor = Color.Maroon
                        Case "Dark"
                            lblReleaseDate.ForeColor = Color.DarkSalmon
                    End Select
                Else
                    Select Case My.Settings.Theme
                        Case "Light"
                            lblReleaseDate.ForeColor = Color.Black
                        Case "Dark"
                            lblReleaseDate.ForeColor = Color.LightGray
                    End Select
                End If
                lblReleaseDate.Text = "Release Date: " & CDate(r("Release Date").ToString).ToString("yyyy-MM-dd")
                'thisGame.original_release_date = CDate(r("Release Date").ToString)
            Else
                Select Case My.Settings.Theme
                    Case "Light"
                        lblReleaseDate.ForeColor = Color.Maroon
                    Case "Dark"
                        lblReleaseDate.ForeColor = Color.DarkSalmon
                End Select
                lblReleaseDate.Text = "Release Date: Unknown"
            End If



            If Not r("site_detail_url") Is Nothing Then
                gameURL = r("site_detail_url")
                thisGame.site_detail_url = r("site_detail_url")
                lnkMoreInfo.Visible = True
            Else
                gameURL = ""
                lnkMoreInfo.Visible = False
            End If

        Next




        'Get Game News
        If thisGame.rsslink <> "" Then
            webNews.DocumentText = ReadRSS(thisGame.rsslink, False, True)
            webNews.Visible = True
        Else
            webNews.DocumentText = ""
            webNews.Visible = False
        End If

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If
    End Sub

    Private Sub bgwLoadGameLocal_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwLoadGameLocal.RunWorkerCompleted

        Me.Invoke(ChangePictureVisibility, False)

        panRight.Visible = True
        panLeft.Enabled = True

        dgvMyGames.Focus()

        lblStatus.Text = "Successfully loaded " & thisGame.name & "."
        Application.DoEvents()
    End Sub

    Private Sub bgwLoadGameNews_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLoadGameNews.DoWork

#If DEBUG Then
#Else
        Try
#End If

        panRight.Visible = False

        Me.Invoke(ChangePictureVisibility, True)

        picLoading.BringToFront()

        Dim api_detail_url As String = DirectCast(e.Argument, String)

        Dim newsResults As New DataTable
        newsResults.Columns.Add("gbid", GetType(System.String))
        newsResults.Columns.Add("GameName", GetType(System.String))
        newsResults.Columns.Add("title", GetType(System.String))
        newsResults.Columns.Add("link", GetType(System.String))
        newsResults.Columns.Add("description", GetType(System.String))
        newsResults.Columns.Add("pubDate", GetType(System.DateTime))



        'remove news
        Using connection = New SQLiteConnection("Data Source=" & dbFileName & ";Version=3")
            Dim command As New SQLiteCommand
            command.Connection = connection
            connection.Open()

            command.CommandText = "DELETE FROM tblNews where gbid = '" & api_detail_url & "'"
            command.ExecuteNonQuery()

            connection.Close()

        End Using


        Dim rsslink As String = ""
        Dim gameName As String = ""



        'Read RSS news and save it into database for faster retrieval
        Dim db As New SQLiteDatabase(dbFileName)
        Dim results As DataTable
        Dim query As [String] = "select rsslink, name from tblGames where gbid = '" & api_detail_url & "'"
        results = db.GetDataTable(query)

        For Each r As DataRow In results.Rows
            rsslink = r("rsslink")
            gameName = r("name")
        Next

        lblStatus.Text = "Retrieving News for " & gameName & "..."
        Application.DoEvents()

        If rsslink <> "" Then

            Dim resultDT As DataTable = ReadRSS(rsslink, True, False, True)

            For Each r As DataRow In resultDT.Rows

                Dim newRow As DataRow = newsResults.NewRow()

                newRow.Item("gbid") = api_detail_url
                newRow.Item("GameName") = gameName
                newRow.Item("title") = r("title")
                newRow.Item("link") = r("link")
                newRow.Item("description") = r("description")
                newRow.Item("pubDate") = r("pubDate")

                newsResults.Rows.Add(newRow)

                Dim data As New Dictionary(Of [String], [String])()

                data.Add("gbid", api_detail_url)
                data.Add("GameName", gameName)
                data.Add("title", r("title").ToString.Replace("&#39", "'"))
                data.Add("link", r("link"))
                data.Add("description", r("description"))
                data.Add("pubDate", CDate(r("pubDate")).ToString("yyyy-MM-dd HH:mm:ss"))
                data.Add("lastupdated", Now.ToString("yyyy-MM-dd HH:mm:ss"))

                db.Insert("tblNews", data)

            Next

        End If


        lblStatus.Text = "Retrieved a total of " & newsResults.Rows.Count & " News items."
        Application.DoEvents()



#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If
    End Sub

    Private Sub bgwLoadGameNews_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwLoadGameNews.RunWorkerCompleted

        Me.Invoke(ChangePictureVisibility, False)

        panLeft.Enabled = True
        panRight.Visible = True

        Application.DoEvents()

    End Sub

    Private Sub bgwLoadAllGameNews_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwLoadAllGameNews.DoWork

#If DEBUG Then
#Else
        Try
#End If

        webAllNews.Visible = False

        Me.Invoke(ChangePictureVisibility, True)

        picLoading.BringToFront()


        Dim newsResults As New DataTable
        newsResults.Columns.Add("gbid", GetType(System.String))
        newsResults.Columns.Add("GameName", GetType(System.String))
        newsResults.Columns.Add("title", GetType(System.String))
        newsResults.Columns.Add("link", GetType(System.String))
        newsResults.Columns.Add("description", GetType(System.String))
        newsResults.Columns.Add("pubDate", GetType(System.DateTime))



        'Empty news table
        Using connection = New SQLiteConnection("Data Source=" & dbFileName & ";Version=3")
            Dim command As New SQLiteCommand
            command.Connection = connection
            connection.Open()

            command.CommandText = "DELETE FROM tblNews"
            command.ExecuteNonQuery()

            connection.Close()

        End Using

        progBrowser.Maximum = dgvMyGames.RowCount
        progBrowser.Value = 0


        For Each thisRow As DataGridViewRow In dgvMyGames.Rows

            Dim api_detail_url As String = thisRow.Cells(0).Value
            Dim gameName As String = thisRow.Cells(2).Value
            Dim rsslink As String = ""

            lblStatus.Text = "Retrieving News for " & gameName & "..."
            progBrowser.Value += 1
            Application.DoEvents()

            'Read RSS news and save it into database for faster retrieval
            Dim db As New SQLiteDatabase(dbFileName)
            Dim results As DataTable
            Dim query As [String] = "select rsslink from tblGames where gbid = '" & api_detail_url & "'"
            results = db.GetDataTable(query)

            For Each r As DataRow In results.Rows
                rsslink = r("rsslink")
            Next

            If rsslink <> "" Then

                Dim resultDT As DataTable = ReadRSS(rsslink, True, False, True)

                For Each r As DataRow In resultDT.Rows

                    Dim newRow As DataRow = newsResults.NewRow()

                    newRow.Item("gbid") = api_detail_url
                    newRow.Item("GameName") = gameName
                    newRow.Item("title") = r("title")
                    newRow.Item("link") = r("link")
                    newRow.Item("description") = r("description")
                    newRow.Item("pubDate") = r("pubDate")

                    newsResults.Rows.Add(newRow)

                    Dim data As New Dictionary(Of [String], [String])()

                    data.Add("gbid", api_detail_url)
                    data.Add("GameName", gameName)
                    data.Add("title", r("title").ToString.Replace("&#39", "'"))
                    data.Add("link", r("link"))
                    data.Add("description", r("description"))
                    data.Add("pubDate", CDate(r("pubDate")).ToString("yyyy-MM-dd HH:mm:ss"))
                    data.Add("lastupdated", Now.ToString("yyyy-MM-dd HH:mm:ss"))

                    db.Insert("tblNews", data)

                Next

            End If



        Next


        lblStatus.Text = "Retrieved a total of " & newsResults.Rows.Count & " News items."

        Application.DoEvents()

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub

    Private Sub bgwLoadAllGameNews_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwLoadAllGameNews.RunWorkerCompleted

        Me.Invoke(ChangePictureVisibility, False)

        panLeft.Enabled = True
        progBrowser.Visible = False

        LoadAllNews()

        dgvNews.Focus()

        Me.Refresh()

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub webAllNews_ProgressChanged(sender As Object, e As Gecko.GeckoProgressEventArgs) Handles webAllNews.ProgressChanged

        If progBrowser.Value + 5 <= progBrowser.Maximum Then
            progBrowser.Value += 5
        Else
            progBrowser.Maximum += 500
            progBrowser.Value += 5
        End If
        Application.DoEvents()

    End Sub

   
    Private Sub webAllNews_StatusTextChanged(sender As Object, e As System.EventArgs) Handles webAllNews.StatusTextChanged
        lblStatus.Text = webAllNews.StatusText
        Application.DoEvents()
    End Sub

    Private Sub btnSaveOptions_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveOptions.Click

        My.Settings.Theme = cboTheme.SelectedItem
        My.Settings.DefaultTab = cboDefaultTab.SelectedItem

        LoadOptions()
        Application.DoEvents()

        MsgBox("Options saved!", MsgBoxStyle.Information, "We'll try to remember that...")
    End Sub

    Private Sub btnImportDatabase_Click(sender As System.Object, e As System.EventArgs) Handles btnImportDatabase.Click

#If DEBUG Then
#Else
        Try
#End If

        ofdImportDatabase.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        If ofdImportDatabase.ShowDialog <> DialogResult.OK Then

            Exit Sub

        Else

            Dim fileToImport As String = ofdImportDatabase.FileName

            File.Copy(fileToImport, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Video Game Tracker\mygames.s3db", True)

            StartupStuff()

            MsgBox("Successfully imported database file.", MsgBoxStyle.Information, "New things are now in the thing...")

        End If



#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

        webAllNews.Stop()

        Me.Invoke(ChangePictureVisibility, False)

        dgvNews.Enabled = True
        btnRefreshAllNews.Enabled = True


        webAllNews.Visible = True
        lblStatus.Text = ""
        Application.DoEvents()
        webAllNews.Focus()
        progBrowser.Visible = False
        btnCancel.Visible = False

    End Sub

    Private Sub btnImportSteamGames_Click(sender As System.Object, e As System.EventArgs) Handles btnImportSteamGames.Click

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

        If MsgBox("Importing your games from Steam is somewhat experimental and depending on the size of your library may take a while. Your profile also needs to be public. Making a backup of your database first is highly encouraged! Do you wish to proceed?", MsgBoxStyle.YesNo, "Erm, so, yeah...") <> MsgBoxResult.Yes Then Exit Sub

        Dim steamID As String = InputBox("Please enter your Steam profile ID." & vbNewLine & "This is the username in http://steamcommunity.com/id/<THIS NAME>/.... For example ""chalkone"".", "So you want to add some steam...?", "")

        If steamID = "" Then
            Exit Sub
        End If

        panLeft.Enabled = False

        Dim steamGames As New Hashtable

        Dim doc As New XmlDocument
        doc.Load("http://steamcommunity.com/id/" & steamID & "/games?xml=1&l=english")

        For Each game As XmlElement In doc.DocumentElement.GetElementsByTagName("game")

            Dim appID As String = ""
            Dim name As String = ""

            For Each child As XmlElement In game.ChildNodes

                If child.Name = "appID" Then appID = child.InnerXml
                If child.Name = "name" Then name = child.InnerText

            Next

            steamGames.Add(appID, name)

        Next

        'So now we have a list of games, great...
        Dim gamesToRemove As New List(Of String)

        Dim db As New SQLiteDatabase(dbFileName)

        For Each steamGame As DictionaryEntry In steamGames

            'check if it's in the db already


            'Check if entry already exists in local database

            Dim resultsDT As DataTable
            Dim query As [String] = "select NAME from tblGames where name = '" & steamGame.Value.ToString.Replace("'", "''") & "'"
            resultsDT = db.GetDataTable(query)

            If resultsDT.Rows.Count >= 1 Then
                gamesToRemove.Add(steamGame.Key)
            End If

        Next

        For Each gameToRemove As String In gamesToRemove
            steamGames.Remove(gameToRemove)
        Next

        Dim i As Integer = 0
        Dim j As Integer = 0

        progBrowser.Maximum = steamGames.Count
        progBrowser.Value = 0
        progBrowser.Visible = True

        For Each steamGame As DictionaryEntry In steamGames


            'need to get the giantbomb api_detail_url for this
            'then add it to the table
            'then refresh all games

            j += 1

            'If j = 20 Then
            '    Exit For
            'End If

            lblStatus.Text = "Importing " & steamGame.Value & "..."
            progBrowser.Value += 1
            Application.DoEvents()

            'Search the GB API for this game name
            Dim request As WebRequest = WebRequest.Create("http://www.giantbomb.com/api/search/?api_key=" & My.Settings.Giantbomb_APIKey & "&format=json&query=""" & steamGame.Value & """&resources=game")

            Dim response As WebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Dim token As JToken = JObject.Parse(responseFromServer)
            Dim status_code As JToken = token.SelectToken("status_code")

            Select Case status_code.ToString
                Case "1"
                    'all good, continue
                Case Else
                    MsgBox("An error has occurred! API returned Status Code of " & status_code.ToString, MsgBoxStyle.Critical, "Aww damn!")
                    Exit Sub
            End Select

            Dim results As JToken = token.SelectToken("results")

            For Each result As JToken In results



                Dim api_detail_url As JToken = result.SelectToken("api_detail_url")

                Dim name As JToken = result.SelectToken("name")

                If name.ToString.ToUpper = steamGame.Value.ToString.ToUpper Then

                    i += 1

                    'Now save this game name and api_detail_url to the database
                    Dim data As New Dictionary(Of [String], [String])()

                    data.Add("gbid", api_detail_url)
                    data.Add("name", steamGame.Value)
                    data.Add("steamid", steamGame.Key)

                    db.Insert("tblGames", data)

                    DoActuallyLoadGame(api_detail_url)

                    UpdateLocalGameDetail(api_detail_url, steamGame.Value)

                End If

            Next



            ' Clean up the streams and the response.
            reader.Close()
            response.Close()


        Next

        If i > 0 Then
            LoadMyGames()
            RetrieveAllNews()

            Do While bgwLoadAllGameNews.IsBusy
                Application.DoEvents()
            Loop

            LoadAllNews()
        End If

        lblStatus.Text = ""
        panLeft.Enabled = True
        progBrowser.Visible = False
        Application.DoEvents()

        MsgBox("Imported " & j & " games from your Steam library and found " & i & " matching titles in the API." & vbNewLine & "If those don't match up you may have some duplicates, missing, or strange entries...", MsgBoxStyle.Information, "This can't go well...")




#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If

    End Sub


    
    Private Sub btnSteamWishlist_Click(sender As System.Object, e As System.EventArgs) Handles btnSteamWishlist.Click

#If DEBUG Then
#Else
        Try
#End If

        'Bit sneaky but we'll load the wishlist url into a hidden webbrowser and then scrape its elements looking for a div called wishlistRowItem and getting the h4 tag inside which contains the game title. That's the theory anyway.

        If MsgBox("Importing your wishlist from Steam is EXTREMELY experimental and will break if Steam makes any changes. Your profile also needs to be public. Making a backup of your database first is highly encouraged! Do you wish to proceed?", MsgBoxStyle.YesNo, "Erm, so, really...?") <> MsgBoxResult.Yes Then Exit Sub

        Dim steamID As String = InputBox("Please enter your Steam profile ID." & vbNewLine & "This is the username in http://steamcommunity.com/id/<THIS NAME>/.... For example ""chalkone"".", "So you want to add some wish... what?", "")

        If steamID = "" Then
            Exit Sub
        End If

        panLeft.Enabled = False

        Dim steamGames As New Hashtable

        webSteamWishlist.ScriptErrorsSuppressed = True

        webSteamWishlist.Navigate("http://steamcommunity.com/id/" & steamID & "/wishlist")

        lblStatus.Text = "Loading Steam Wishlist..."
        Application.DoEvents()

        Do While webSteamWishlist.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        Loop

        Dim gameName As String = ""
        Dim gameID As String = ""

        For Each element As HtmlElement In webSteamWishlist.Document.All

            If element.TagName().ToUpper = "H4" Then
                gameName = element.InnerText
                gameID = "" 'reset it
            End If

            If element.TagName().ToUpper = "DIV" Then
                If Not element.Id Is Nothing Then
                    If element.Id.ToUpper.Contains("LINKS_DROPDOWN") Then
                        gameID = element.Id.ToUpper.Split("_")(2)

                        If gameName <> "" And gameID <> "" Then
                            'Debug.Print(gameName & "-->" & gameID)
                            lblStatus.Text = "Found " & gameName & "..."
                            Application.DoEvents()
                            steamGames.Add(gameID, gameName)
                        End If

                        gameName = ""   'reset it
                    End If
                End If
            End If

        Next


        'So now we have a list of games, great...
        Dim gamesToRemove As New List(Of String)

        Dim db As New SQLiteDatabase(dbFileName)

        For Each steamGame As DictionaryEntry In steamGames

            'check if it's in the db already


            'Check if entry already exists in local database

            Dim resultsDT As DataTable
            Dim query As [String] = "select NAME from tblGames where name = '" & steamGame.Value.ToString.Replace("'", "''") & "'"
            resultsDT = db.GetDataTable(query)

            If resultsDT.Rows.Count >= 1 Then
                gamesToRemove.Add(steamGame.Key)
            End If

        Next

        For Each gameToRemove As String In gamesToRemove
            steamGames.Remove(gameToRemove)
        Next

        Dim i As Integer = 0
        Dim j As Integer = 0

        progBrowser.Maximum = steamGames.Count
        progBrowser.Value = 0
        progBrowser.Visible = True

        For Each steamGame As DictionaryEntry In steamGames


            'need to get the giantbomb api_detail_url for this
            'then add it to the table
            'then refresh all games

            j += 1

            'If j = 20 Then
            '    Exit For
            'End If

            lblStatus.Text = "Importing " & steamGame.Value & "..."
            progBrowser.Value += 1
            Application.DoEvents()

            'Search the GB API for this game name
            Dim request As WebRequest = WebRequest.Create("http://www.giantbomb.com/api/search/?api_key=" & My.Settings.Giantbomb_APIKey & "&format=json&query=""" & steamGame.Value & """&resources=game")

            Dim response As WebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Dim token As JToken = JObject.Parse(responseFromServer)
            Dim status_code As JToken = token.SelectToken("status_code")

            Select Case status_code.ToString
                Case "1"
                    'all good, continue
                Case Else
                    MsgBox("An error has occurred! API returned Status Code of " & status_code.ToString, MsgBoxStyle.Critical, "Aww damn!")
                    Exit Sub
            End Select

            Dim results As JToken = token.SelectToken("results")

            For Each result As JToken In results



                Dim api_detail_url As JToken = result.SelectToken("api_detail_url")

                Dim name As JToken = result.SelectToken("name")

                If name.ToString.ToUpper = steamGame.Value.ToString.ToUpper Then

                    i += 1

                    'Now save this game name and api_detail_url to the database
                    Dim data As New Dictionary(Of [String], [String])()

                    data.Add("gbid", api_detail_url)
                    data.Add("name", steamGame.Value)
                    data.Add("steamid", steamGame.Key)

                    db.Insert("tblGames", data)

                    DoActuallyLoadGame(api_detail_url)

                    UpdateLocalGameDetail(api_detail_url, steamGame.Value)

                End If

            Next



            ' Clean up the streams and the response.
            reader.Close()
            response.Close()


        Next

        If i > 0 Then

            LoadMyGames()
            RetrieveAllNews()

            Do While bgwLoadAllGameNews.IsBusy
                Application.DoEvents()
            Loop

            LoadAllNews()
        End If

        lblStatus.Text = ""
        panLeft.Enabled = True
        progBrowser.Visible = False
        Application.DoEvents()

        MsgBox("Imported " & j & " games from your Steam wishlist and found " & i & " matching titles in the API." & vbNewLine & "If those don't match up you may have some duplicates, missing, or strange entries...", MsgBoxStyle.Information, "This can't go well, or can it...?")

#If DEBUG Then
#Else
        Catch ex As Exception
            Msgbox(ex.message, MsgBoxStyle.Critical, "Aw damn!")
        End Try
#End If
    End Sub

    Private Sub lnkSteam_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSteam.LinkClicked

        System.Diagnostics.Process.Start("http://steamcommunity.com/dev")

    End Sub
End Class
