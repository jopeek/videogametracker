<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabSearch = New System.Windows.Forms.TabPage()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listResults = New System.Windows.Forms.ListBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.tabLatestNews = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.webAllNews = New Gecko.GeckoWebBrowser()
        Me.dgvNews = New System.Windows.Forms.DataGridView()
        Me.btnRefreshAllNews = New System.Windows.Forms.Button()
        Me.tabMyGames = New System.Windows.Forms.TabPage()
        Me.dgvMyGames = New System.Windows.Forms.DataGridView()
        Me.tabOptions = New System.Windows.Forms.TabPage()
        Me.btnImportDatabase = New System.Windows.Forms.Button()
        Me.cboDefaultTab = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSaveOptions = New System.Windows.Forms.Button()
        Me.cboTheme = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnBackupDatabase = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRefreshAll = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnResetDatabase = New System.Windows.Forms.Button()
        Me.lnkCreditsStarIcon = New System.Windows.Forms.LinkLabel()
        Me.lnkCreditsIcon = New System.Windows.Forms.LinkLabel()
        Me.lnkCreditsAPI = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.progBrowser = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSpacer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblReleaseDate = New System.Windows.Forms.Label()
        Me.lblPlatforms = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.panLeft = New System.Windows.Forms.Panel()
        Me.panRight = New System.Windows.Forms.Panel()
        Me.webNews = New System.Windows.Forms.WebBrowser()
        Me.btnRefreshFromAPI = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAddToMyGames = New System.Windows.Forms.Button()
        Me.lnkMoreInfo = New System.Windows.Forms.LinkLabel()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.bgwSearch = New System.ComponentModel.BackgroundWorker()
        Me.fbdBackupPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.bgwLoadNews = New System.ComponentModel.BackgroundWorker()
        Me.bgwLoadGame = New System.ComponentModel.BackgroundWorker()
        Me.bgwLoadGameLocal = New System.ComponentModel.BackgroundWorker()
        Me.bgwLoadGameNews = New System.ComponentModel.BackgroundWorker()
        Me.bgwLoadAllGameNews = New System.ComponentModel.BackgroundWorker()
        Me.ofdImportDatabase = New System.Windows.Forms.OpenFileDialog()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnImportSteamGames = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.webSteamWishlist = New System.Windows.Forms.WebBrowser()
        Me.btnSteamWishlist = New System.Windows.Forms.Button()
        Me.lnkSteam = New System.Windows.Forms.LinkLabel()
        Me.picStar = New System.Windows.Forms.PictureBox()
        Me.picThumb = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.picBottomBar = New System.Windows.Forms.PictureBox()
        Me.picMiddleBar = New System.Windows.Forms.PictureBox()
        Me.picRightBar = New System.Windows.Forms.PictureBox()
        Me.picTopBar = New System.Windows.Forms.PictureBox()
        Me.picLoading = New System.Windows.Forms.PictureBox()
        Me.picDonation = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.picHeader = New System.Windows.Forms.PictureBox()
        Me.picHeaderBG = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        Me.tabLatestNews.SuspendLayout()
        CType(Me.dgvNews, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMyGames.SuspendLayout()
        CType(Me.dgvMyGames, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOptions.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.panLeft.SuspendLayout()
        Me.panRight.SuspendLayout()
        CType(Me.picStar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThumb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottomBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMiddleBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDonation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeaderBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tabSearch)
        Me.TabControl1.Controls.Add(Me.tabLatestNews)
        Me.TabControl1.Controls.Add(Me.tabMyGames)
        Me.TabControl1.Controls.Add(Me.tabOptions)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(521, 599)
        Me.TabControl1.TabIndex = 2
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.btnClearSearch)
        Me.tabSearch.Controls.Add(Me.lblResults)
        Me.tabSearch.Controls.Add(Me.Label1)
        Me.tabSearch.Controls.Add(Me.listResults)
        Me.tabSearch.Controls.Add(Me.btnSearch)
        Me.tabSearch.Controls.Add(Me.txtSearch)
        Me.tabSearch.Location = New System.Drawing.Point(4, 25)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearch.Size = New System.Drawing.Size(513, 570)
        Me.tabSearch.TabIndex = 3
        Me.tabSearch.Text = "Search"
        Me.tabSearch.UseVisualStyleBackColor = True
        '
        'btnClearSearch
        '
        Me.btnClearSearch.Enabled = False
        Me.btnClearSearch.Location = New System.Drawing.Point(417, 540)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(89, 23)
        Me.btnClearSearch.TabIndex = 5
        Me.btnClearSearch.Text = "Clear Results"
        Me.btnClearSearch.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(5, 73)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(245, 13)
        Me.lblResults.TabIndex = 4
        Me.lblResults.Text = "Select a title from the results to view further details."
        Me.lblResults.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "To search for a specific game, enter a title or part of a title or description be" & _
    "low and click Search."
        '
        'listResults
        '
        Me.listResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listResults.FormattingEnabled = True
        Me.listResults.Location = New System.Drawing.Point(8, 100)
        Me.listResults.Name = "listResults"
        Me.listResults.Size = New System.Drawing.Size(497, 431)
        Me.listResults.Sorted = True
        Me.listResults.TabIndex = 2
        Me.listResults.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(431, 37)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(8, 39)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(417, 20)
        Me.txtSearch.TabIndex = 0
        '
        'tabLatestNews
        '
        Me.tabLatestNews.Controls.Add(Me.Label11)
        Me.tabLatestNews.Controls.Add(Me.Label6)
        Me.tabLatestNews.Controls.Add(Me.webAllNews)
        Me.tabLatestNews.Controls.Add(Me.dgvNews)
        Me.tabLatestNews.Controls.Add(Me.btnRefreshAllNews)
        Me.tabLatestNews.Controls.Add(Me.PictureBox3)
        Me.tabLatestNews.Location = New System.Drawing.Point(4, 25)
        Me.tabLatestNews.Name = "tabLatestNews"
        Me.tabLatestNews.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLatestNews.Size = New System.Drawing.Size(513, 570)
        Me.tabLatestNews.TabIndex = 0
        Me.tabLatestNews.Text = "Latest News"
        Me.tabLatestNews.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(226, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "to open in default browser."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(6, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Click on a row to load in app, double-click"
        '
        'webAllNews
        '
        Me.webAllNews.Location = New System.Drawing.Point(399, 530)
        Me.webAllNews.Name = "webAllNews"
        Me.webAllNews.Size = New System.Drawing.Size(75, 23)
        Me.webAllNews.TabIndex = 2
        Me.webAllNews.UseHttpActivityObserver = False
        Me.webAllNews.Visible = False
        '
        'dgvNews
        '
        Me.dgvNews.AllowUserToAddRows = False
        Me.dgvNews.AllowUserToDeleteRows = False
        Me.dgvNews.AllowUserToResizeRows = False
        Me.dgvNews.BackgroundColor = System.Drawing.Color.White
        Me.dgvNews.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNews.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNews.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNews.Location = New System.Drawing.Point(8, 41)
        Me.dgvNews.MultiSelect = False
        Me.dgvNews.Name = "dgvNews"
        Me.dgvNews.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNews.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvNews.RowHeadersVisible = False
        Me.dgvNews.ShowCellErrors = False
        Me.dgvNews.ShowCellToolTips = False
        Me.dgvNews.ShowEditingIcon = False
        Me.dgvNews.ShowRowErrors = False
        Me.dgvNews.Size = New System.Drawing.Size(497, 521)
        Me.dgvNews.TabIndex = 1
        '
        'btnRefreshAllNews
        '
        Me.btnRefreshAllNews.Location = New System.Drawing.Point(393, 7)
        Me.btnRefreshAllNews.Name = "btnRefreshAllNews"
        Me.btnRefreshAllNews.Size = New System.Drawing.Size(113, 23)
        Me.btnRefreshAllNews.TabIndex = 0
        Me.btnRefreshAllNews.Text = "Refresh All News"
        Me.btnRefreshAllNews.UseVisualStyleBackColor = True
        '
        'tabMyGames
        '
        Me.tabMyGames.Controls.Add(Me.dgvMyGames)
        Me.tabMyGames.Location = New System.Drawing.Point(4, 25)
        Me.tabMyGames.Name = "tabMyGames"
        Me.tabMyGames.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMyGames.Size = New System.Drawing.Size(513, 570)
        Me.tabMyGames.TabIndex = 1
        Me.tabMyGames.Text = "My Games"
        Me.tabMyGames.UseVisualStyleBackColor = True
        '
        'dgvMyGames
        '
        Me.dgvMyGames.AllowUserToAddRows = False
        Me.dgvMyGames.AllowUserToDeleteRows = False
        Me.dgvMyGames.AllowUserToResizeRows = False
        Me.dgvMyGames.BackgroundColor = System.Drawing.Color.White
        Me.dgvMyGames.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMyGames.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMyGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMyGames.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMyGames.Location = New System.Drawing.Point(8, 8)
        Me.dgvMyGames.MultiSelect = False
        Me.dgvMyGames.Name = "dgvMyGames"
        Me.dgvMyGames.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMyGames.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMyGames.RowHeadersVisible = False
        Me.dgvMyGames.RowTemplate.Height = 40
        Me.dgvMyGames.ShowCellErrors = False
        Me.dgvMyGames.ShowCellToolTips = False
        Me.dgvMyGames.ShowEditingIcon = False
        Me.dgvMyGames.ShowRowErrors = False
        Me.dgvMyGames.Size = New System.Drawing.Size(497, 554)
        Me.dgvMyGames.TabIndex = 0
        '
        'tabOptions
        '
        Me.tabOptions.Controls.Add(Me.lnkSteam)
        Me.tabOptions.Controls.Add(Me.btnSteamWishlist)
        Me.tabOptions.Controls.Add(Me.webSteamWishlist)
        Me.tabOptions.Controls.Add(Me.Label16)
        Me.tabOptions.Controls.Add(Me.btnImportSteamGames)
        Me.tabOptions.Controls.Add(Me.Label15)
        Me.tabOptions.Controls.Add(Me.picBottomBar)
        Me.tabOptions.Controls.Add(Me.picMiddleBar)
        Me.tabOptions.Controls.Add(Me.picRightBar)
        Me.tabOptions.Controls.Add(Me.picTopBar)
        Me.tabOptions.Controls.Add(Me.btnImportDatabase)
        Me.tabOptions.Controls.Add(Me.cboDefaultTab)
        Me.tabOptions.Controls.Add(Me.Label14)
        Me.tabOptions.Controls.Add(Me.btnSaveOptions)
        Me.tabOptions.Controls.Add(Me.cboTheme)
        Me.tabOptions.Controls.Add(Me.Label13)
        Me.tabOptions.Controls.Add(Me.Label12)
        Me.tabOptions.Controls.Add(Me.btnBackupDatabase)
        Me.tabOptions.Controls.Add(Me.Label10)
        Me.tabOptions.Controls.Add(Me.Label9)
        Me.tabOptions.Controls.Add(Me.LinkLabel2)
        Me.tabOptions.Controls.Add(Me.Label8)
        Me.tabOptions.Controls.Add(Me.Label7)
        Me.tabOptions.Controls.Add(Me.btnRefreshAll)
        Me.tabOptions.Controls.Add(Me.LinkLabel1)
        Me.tabOptions.Controls.Add(Me.Label5)
        Me.tabOptions.Controls.Add(Me.btnResetDatabase)
        Me.tabOptions.Controls.Add(Me.lnkCreditsStarIcon)
        Me.tabOptions.Controls.Add(Me.lnkCreditsIcon)
        Me.tabOptions.Controls.Add(Me.lnkCreditsAPI)
        Me.tabOptions.Controls.Add(Me.Label4)
        Me.tabOptions.Controls.Add(Me.Label3)
        Me.tabOptions.Controls.Add(Me.Label2)
        Me.tabOptions.Controls.Add(Me.picLoading)
        Me.tabOptions.Controls.Add(Me.picDonation)
        Me.tabOptions.Location = New System.Drawing.Point(4, 25)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOptions.Size = New System.Drawing.Size(513, 570)
        Me.tabOptions.TabIndex = 2
        Me.tabOptions.Text = "Options"
        Me.tabOptions.UseVisualStyleBackColor = True
        '
        'btnImportDatabase
        '
        Me.btnImportDatabase.Location = New System.Drawing.Point(364, 343)
        Me.btnImportDatabase.Name = "btnImportDatabase"
        Me.btnImportDatabase.Size = New System.Drawing.Size(111, 23)
        Me.btnImportDatabase.TabIndex = 24
        Me.btnImportDatabase.Text = "Import Database"
        Me.btnImportDatabase.UseVisualStyleBackColor = True
        '
        'cboDefaultTab
        '
        Me.cboDefaultTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDefaultTab.FormattingEnabled = True
        Me.cboDefaultTab.Items.AddRange(New Object() {"Search", "Latest News", "My Games", "Options"})
        Me.cboDefaultTab.Location = New System.Drawing.Point(85, 76)
        Me.cboDefaultTab.Name = "cboDefaultTab"
        Me.cboDefaultTab.Size = New System.Drawing.Size(121, 21)
        Me.cboDefaultTab.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Default Tab:"
        '
        'btnSaveOptions
        '
        Me.btnSaveOptions.Location = New System.Drawing.Point(15, 115)
        Me.btnSaveOptions.Name = "btnSaveOptions"
        Me.btnSaveOptions.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveOptions.TabIndex = 21
        Me.btnSaveOptions.Text = "Save Options"
        Me.btnSaveOptions.UseVisualStyleBackColor = True
        '
        'cboTheme
        '
        Me.cboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTheme.FormattingEnabled = True
        Me.cboTheme.Items.AddRange(New Object() {"Light", "Dark"})
        Me.cboTheme.Location = New System.Drawing.Point(85, 41)
        Me.cboTheme.Name = "cboTheme"
        Me.cboTheme.Size = New System.Drawing.Size(121, 21)
        Me.cboTheme.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Theme:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Options"
        '
        'btnBackupDatabase
        '
        Me.btnBackupDatabase.Location = New System.Drawing.Point(247, 343)
        Me.btnBackupDatabase.Name = "btnBackupDatabase"
        Me.btnBackupDatabase.Size = New System.Drawing.Size(111, 23)
        Me.btnBackupDatabase.TabIndex = 16
        Me.btnBackupDatabase.Text = "Export Database"
        Me.btnBackupDatabase.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 435)
        Me.Label10.MaximumSize = New System.Drawing.Size(420, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(419, 26)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "This app was inspired by a necessity to keep track of all the game announcements " & _
    "from E3 2014 and the desire to able to see at a glance what's coming and when. <" & _
    "3 Schatz"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 413)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Idea && Purpose:"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(83, 476)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(54, 13)
        Me.LinkLabel2.TabIndex = 13
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "ChalkOne"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 476)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Development:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 543)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "StitchingKitten, WhitePawn, BJSwick33"
        '
        'btnRefreshAll
        '
        Me.btnRefreshAll.Location = New System.Drawing.Point(15, 343)
        Me.btnRefreshAll.Name = "btnRefreshAll"
        Me.btnRefreshAll.Size = New System.Drawing.Size(112, 23)
        Me.btnRefreshAll.TabIndex = 10
        Me.btnRefreshAll.Text = "Refresh All Games"
        Me.btnRefreshAll.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(167, 499)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "GamesRadar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 543)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Testers:"
        '
        'btnResetDatabase
        '
        Me.btnResetDatabase.Location = New System.Drawing.Point(133, 343)
        Me.btnResetDatabase.Name = "btnResetDatabase"
        Me.btnResetDatabase.Size = New System.Drawing.Size(108, 23)
        Me.btnResetDatabase.TabIndex = 6
        Me.btnResetDatabase.Text = "Reset Database"
        Me.btnResetDatabase.UseVisualStyleBackColor = True
        '
        'lnkCreditsStarIcon
        '
        Me.lnkCreditsStarIcon.AutoSize = True
        Me.lnkCreditsStarIcon.Location = New System.Drawing.Point(167, 521)
        Me.lnkCreditsStarIcon.Name = "lnkCreditsStarIcon"
        Me.lnkCreditsStarIcon.Size = New System.Drawing.Size(89, 13)
        Me.lnkCreditsStarIcon.TabIndex = 5
        Me.lnkCreditsStarIcon.TabStop = True
        Me.lnkCreditsStarIcon.Text = "Metro Style Icons"
        '
        'lnkCreditsIcon
        '
        Me.lnkCreditsIcon.AutoSize = True
        Me.lnkCreditsIcon.Location = New System.Drawing.Point(83, 521)
        Me.lnkCreditsIcon.Name = "lnkCreditsIcon"
        Me.lnkCreditsIcon.Size = New System.Drawing.Size(64, 13)
        Me.lnkCreditsIcon.TabIndex = 4
        Me.lnkCreditsIcon.TabStop = True
        Me.lnkCreditsIcon.Text = "Sugar Icons"
        '
        'lnkCreditsAPI
        '
        Me.lnkCreditsAPI.AutoSize = True
        Me.lnkCreditsAPI.Location = New System.Drawing.Point(83, 499)
        Me.lnkCreditsAPI.Name = "lnkCreditsAPI"
        Me.lnkCreditsAPI.Size = New System.Drawing.Size(62, 13)
        Me.lnkCreditsAPI.TabIndex = 3
        Me.lnkCreditsAPI.TabStop = True
        Me.lnkCreditsAPI.Text = "Giant Bomb"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 521)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Icons:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 499)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "API Sources:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Credits"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(221, 40)
        Me.lblName.MaximumSize = New System.Drawing.Size(220, 60)
        Me.lblName.MinimumSize = New System.Drawing.Size(220, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(220, 60)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Game Title (Up to 3 Rows)"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progBrowser, Me.btnCancel, Me.lblStatus, Me.lblSpacer, Me.lblVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 679)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1044, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'progBrowser
        '
        Me.progBrowser.Name = "progBrowser"
        Me.progBrowser.Size = New System.Drawing.Size(100, 16)
        Me.progBrowser.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 17)
        Me.lblStatus.Text = "Status"
        '
        'lblSpacer
        '
        Me.lblSpacer.BackColor = System.Drawing.Color.Transparent
        Me.lblSpacer.Name = "lblSpacer"
        Me.lblSpacer.Size = New System.Drawing.Size(944, 17)
        Me.lblSpacer.Spring = True
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(46, 17)
        Me.lblVersion.Text = "Version"
        '
        'lblReleaseDate
        '
        Me.lblReleaseDate.AutoSize = True
        Me.lblReleaseDate.Location = New System.Drawing.Point(222, 115)
        Me.lblReleaseDate.MaximumSize = New System.Drawing.Size(280, 0)
        Me.lblReleaseDate.MinimumSize = New System.Drawing.Size(280, 0)
        Me.lblReleaseDate.Name = "lblReleaseDate"
        Me.lblReleaseDate.Size = New System.Drawing.Size(280, 13)
        Me.lblReleaseDate.TabIndex = 7
        Me.lblReleaseDate.Text = "Release Date: "
        '
        'lblPlatforms
        '
        Me.lblPlatforms.AutoSize = True
        Me.lblPlatforms.Location = New System.Drawing.Point(222, 137)
        Me.lblPlatforms.MaximumSize = New System.Drawing.Size(280, 30)
        Me.lblPlatforms.MinimumSize = New System.Drawing.Size(280, 30)
        Me.lblPlatforms.Name = "lblPlatforms"
        Me.lblPlatforms.Size = New System.Drawing.Size(280, 30)
        Me.lblPlatforms.TabIndex = 8
        Me.lblPlatforms.Text = "Platform(s):"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(20, 297)
        Me.lblDescription.MaximumSize = New System.Drawing.Size(490, 60)
        Me.lblDescription.MinimumSize = New System.Drawing.Size(490, 60)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(490, 60)
        Me.lblDescription.TabIndex = 10
        Me.lblDescription.Text = "Description "
        '
        'panLeft
        '
        Me.panLeft.Controls.Add(Me.TabControl1)
        Me.panLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panLeft.Location = New System.Drawing.Point(0, 80)
        Me.panLeft.Name = "panLeft"
        Me.panLeft.Size = New System.Drawing.Size(521, 599)
        Me.panLeft.TabIndex = 5
        '
        'panRight
        '
        Me.panRight.Controls.Add(Me.webNews)
        Me.panRight.Controls.Add(Me.btnRefreshFromAPI)
        Me.panRight.Controls.Add(Me.btnRemove)
        Me.panRight.Controls.Add(Me.picStar)
        Me.panRight.Controls.Add(Me.btnAddToMyGames)
        Me.panRight.Controls.Add(Me.lnkMoreInfo)
        Me.panRight.Controls.Add(Me.lblPublisher)
        Me.panRight.Controls.Add(Me.lblDeveloper)
        Me.panRight.Controls.Add(Me.lblDescription)
        Me.panRight.Controls.Add(Me.picThumb)
        Me.panRight.Controls.Add(Me.lblPlatforms)
        Me.panRight.Controls.Add(Me.lblName)
        Me.panRight.Controls.Add(Me.lblReleaseDate)
        Me.panRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.panRight.Location = New System.Drawing.Point(519, 80)
        Me.panRight.Name = "panRight"
        Me.panRight.Size = New System.Drawing.Size(525, 599)
        Me.panRight.TabIndex = 6
        '
        'webNews
        '
        Me.webNews.Location = New System.Drawing.Point(12, 394)
        Me.webNews.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webNews.Name = "webNews"
        Me.webNews.ScrollBarsEnabled = False
        Me.webNews.Size = New System.Drawing.Size(498, 198)
        Me.webNews.TabIndex = 19
        '
        'btnRefreshFromAPI
        '
        Me.btnRefreshFromAPI.Location = New System.Drawing.Point(398, 365)
        Me.btnRefreshFromAPI.Name = "btnRefreshFromAPI"
        Me.btnRefreshFromAPI.Size = New System.Drawing.Size(112, 23)
        Me.btnRefreshFromAPI.TabIndex = 18
        Me.btnRefreshFromAPI.Text = "Refresh from Web"
        Me.btnRefreshFromAPI.UseVisualStyleBackColor = True
        Me.btnRefreshFromAPI.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(242, 365)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(150, 23)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = "Remove from My Games"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAddToMyGames
        '
        Me.btnAddToMyGames.Location = New System.Drawing.Point(126, 365)
        Me.btnAddToMyGames.Name = "btnAddToMyGames"
        Me.btnAddToMyGames.Size = New System.Drawing.Size(110, 23)
        Me.btnAddToMyGames.TabIndex = 15
        Me.btnAddToMyGames.Text = "Add to My Games"
        Me.btnAddToMyGames.UseVisualStyleBackColor = True
        '
        'lnkMoreInfo
        '
        Me.lnkMoreInfo.AutoSize = True
        Me.lnkMoreInfo.Location = New System.Drawing.Point(222, 245)
        Me.lnkMoreInfo.Name = "lnkMoreInfo"
        Me.lnkMoreInfo.Size = New System.Drawing.Size(91, 13)
        Me.lnkMoreInfo.TabIndex = 14
        Me.lnkMoreInfo.TabStop = True
        Me.lnkMoreInfo.Text = "Click for more info"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(222, 209)
        Me.lblPublisher.MaximumSize = New System.Drawing.Size(280, 30)
        Me.lblPublisher.MinimumSize = New System.Drawing.Size(280, 30)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(280, 30)
        Me.lblPublisher.TabIndex = 13
        Me.lblPublisher.Text = "Publisher(s):"
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.Location = New System.Drawing.Point(222, 173)
        Me.lblDeveloper.MaximumSize = New System.Drawing.Size(280, 30)
        Me.lblDeveloper.MinimumSize = New System.Drawing.Size(280, 30)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(280, 30)
        Me.lblDeveloper.TabIndex = 12
        Me.lblDeveloper.Text = "Developer(s):"
        '
        'bgwSearch
        '
        '
        'bgwLoadNews
        '
        '
        'bgwLoadGame
        '
        '
        'bgwLoadGameLocal
        '
        '
        'bgwLoadGameNews
        '
        '
        'bgwLoadAllGameNews
        '
        '
        'ofdImportDatabase
        '
        Me.ofdImportDatabase.FileName = "mygames.s3db"
        Me.ofdImportDatabase.Filter = "Database File|*.s3db"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Importers"
        '
        'btnImportSteamGames
        '
        Me.btnImportSteamGames.Location = New System.Drawing.Point(16, 191)
        Me.btnImportSteamGames.Name = "btnImportSteamGames"
        Me.btnImportSteamGames.Size = New System.Drawing.Size(97, 23)
        Me.btnImportSteamGames.TabIndex = 30
        Me.btnImportSteamGames.Text = "Steam Games"
        Me.btnImportSteamGames.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 319)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Database Tools"
        '
        'webSteamWishlist
        '
        Me.webSteamWishlist.Location = New System.Drawing.Point(148, 251)
        Me.webSteamWishlist.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webSteamWishlist.Name = "webSteamWishlist"
        Me.webSteamWishlist.Size = New System.Drawing.Size(93, 64)
        Me.webSteamWishlist.TabIndex = 32
        Me.webSteamWishlist.Visible = False
        '
        'btnSteamWishlist
        '
        Me.btnSteamWishlist.Location = New System.Drawing.Point(119, 191)
        Me.btnSteamWishlist.Name = "btnSteamWishlist"
        Me.btnSteamWishlist.Size = New System.Drawing.Size(97, 23)
        Me.btnSteamWishlist.TabIndex = 33
        Me.btnSteamWishlist.Text = "Steam Wishlist"
        Me.btnSteamWishlist.UseVisualStyleBackColor = True
        '
        'lnkSteam
        '
        Me.lnkSteam.AutoSize = True
        Me.lnkSteam.Location = New System.Drawing.Point(260, 499)
        Me.lnkSteam.Name = "lnkSteam"
        Me.lnkSteam.Size = New System.Drawing.Size(37, 13)
        Me.lnkSteam.TabIndex = 34
        Me.lnkSteam.TabStop = True
        Me.lnkSteam.Text = "Steam"
        '
        'picStar
        '
        Me.picStar.BackColor = System.Drawing.Color.Transparent
        Me.picStar.Image = Global.Video_Game_Tracker.My.Resources.Resources.Buzz_Star_icon2
        Me.picStar.Location = New System.Drawing.Point(470, 40)
        Me.picStar.Name = "picStar"
        Me.picStar.Size = New System.Drawing.Size(32, 32)
        Me.picStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picStar.TabIndex = 16
        Me.picStar.TabStop = False
        '
        'picThumb
        '
        Me.picThumb.Location = New System.Drawing.Point(16, 40)
        Me.picThumb.Name = "picThumb"
        Me.picThumb.Size = New System.Drawing.Size(200, 240)
        Me.picThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picThumb.TabIndex = 4
        Me.picThumb.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Video_Game_Tracker.My.Resources.Resources.link
        Me.PictureBox3.Location = New System.Drawing.Point(210, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(12, 12)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'picBottomBar
        '
        Me.picBottomBar.Image = Global.Video_Game_Tracker.My.Resources.Resources.topbarbg
        Me.picBottomBar.Location = New System.Drawing.Point(282, 165)
        Me.picBottomBar.Name = "picBottomBar"
        Me.picBottomBar.Size = New System.Drawing.Size(59, 39)
        Me.picBottomBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBottomBar.TabIndex = 28
        Me.picBottomBar.TabStop = False
        Me.picBottomBar.Visible = False
        '
        'picMiddleBar
        '
        Me.picMiddleBar.Image = Global.Video_Game_Tracker.My.Resources.Resources.topbarbg
        Me.picMiddleBar.Location = New System.Drawing.Point(282, 206)
        Me.picMiddleBar.Name = "picMiddleBar"
        Me.picMiddleBar.Size = New System.Drawing.Size(59, 39)
        Me.picMiddleBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMiddleBar.TabIndex = 27
        Me.picMiddleBar.TabStop = False
        Me.picMiddleBar.Visible = False
        '
        'picRightBar
        '
        Me.picRightBar.Image = Global.Video_Game_Tracker.My.Resources.Resources.topbarbg
        Me.picRightBar.Location = New System.Drawing.Point(282, 251)
        Me.picRightBar.Name = "picRightBar"
        Me.picRightBar.Size = New System.Drawing.Size(59, 39)
        Me.picRightBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRightBar.TabIndex = 26
        Me.picRightBar.TabStop = False
        Me.picRightBar.Visible = False
        '
        'picTopBar
        '
        Me.picTopBar.Image = Global.Video_Game_Tracker.My.Resources.Resources.topbarbg
        Me.picTopBar.Location = New System.Drawing.Point(282, 296)
        Me.picTopBar.Name = "picTopBar"
        Me.picTopBar.Size = New System.Drawing.Size(59, 39)
        Me.picTopBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTopBar.TabIndex = 25
        Me.picTopBar.TabStop = False
        Me.picTopBar.Visible = False
        '
        'picLoading
        '
        Me.picLoading.Image = Global.Video_Game_Tracker.My.Resources.Resources.spinner
        Me.picLoading.Location = New System.Drawing.Point(312, 165)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(170, 170)
        Me.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLoading.TabIndex = 17
        Me.picLoading.TabStop = False
        '
        'picDonation
        '
        Me.picDonation.Image = Global.Video_Game_Tracker.My.Resources.Resources.paypal_donate
        Me.picDonation.Location = New System.Drawing.Point(335, 493)
        Me.picDonation.Name = "picDonation"
        Me.picDonation.Size = New System.Drawing.Size(170, 69)
        Me.picDonation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picDonation.TabIndex = 8
        Me.picDonation.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancel.Image = Global.Video_Game_Tracker.My.Resources.Resources.cancel
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(16, 17)
        Me.btnCancel.Visible = False
        '
        'picHeader
        '
        Me.picHeader.BackColor = System.Drawing.Color.Transparent
        Me.picHeader.Image = CType(resources.GetObject("picHeader.Image"), System.Drawing.Image)
        Me.picHeader.Location = New System.Drawing.Point(0, 0)
        Me.picHeader.Name = "picHeader"
        Me.picHeader.Size = New System.Drawing.Size(1000, 80)
        Me.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picHeader.TabIndex = 1
        Me.picHeader.TabStop = False
        '
        'picHeaderBG
        '
        Me.picHeaderBG.Dock = System.Windows.Forms.DockStyle.Top
        Me.picHeaderBG.Image = Global.Video_Game_Tracker.My.Resources.Resources.headerbg
        Me.picHeaderBG.Location = New System.Drawing.Point(0, 0)
        Me.picHeaderBG.Name = "picHeaderBG"
        Me.picHeaderBG.Size = New System.Drawing.Size(1044, 80)
        Me.picHeaderBG.TabIndex = 0
        Me.picHeaderBG.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1044, 701)
        Me.Controls.Add(Me.panRight)
        Me.Controls.Add(Me.panLeft)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.picHeader)
        Me.Controls.Add(Me.picHeaderBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Video Game Tracker"
        Me.TabControl1.ResumeLayout(False)
        Me.tabSearch.ResumeLayout(False)
        Me.tabSearch.PerformLayout()
        Me.tabLatestNews.ResumeLayout(False)
        Me.tabLatestNews.PerformLayout()
        CType(Me.dgvNews, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMyGames.ResumeLayout(False)
        CType(Me.dgvMyGames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOptions.ResumeLayout(False)
        Me.tabOptions.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.panLeft.ResumeLayout(False)
        Me.panRight.ResumeLayout(False)
        Me.panRight.PerformLayout()
        CType(Me.picStar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThumb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottomBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMiddleBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDonation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeaderBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picHeaderBG As System.Windows.Forms.PictureBox
    Friend WithEvents picHeader As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabLatestNews As System.Windows.Forms.TabPage
    Friend WithEvents tabMyGames As System.Windows.Forms.TabPage
    Friend WithEvents tabOptions As System.Windows.Forms.TabPage
    Friend WithEvents tabSearch As System.Windows.Forms.TabPage
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents listResults As System.Windows.Forms.ListBox
    Friend WithEvents picThumb As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents btnClearSearch As System.Windows.Forms.Button
    Friend WithEvents lblReleaseDate As System.Windows.Forms.Label
    Friend WithEvents lblPlatforms As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents panLeft As System.Windows.Forms.Panel
    Friend WithEvents panRight As System.Windows.Forms.Panel
    Friend WithEvents lblPublisher As System.Windows.Forms.Label
    Friend WithEvents lblDeveloper As System.Windows.Forms.Label
    Friend WithEvents lnkMoreInfo As System.Windows.Forms.LinkLabel
    Friend WithEvents bgwSearch As System.ComponentModel.BackgroundWorker
    Friend WithEvents lnkCreditsAPI As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lnkCreditsIcon As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAddToMyGames As System.Windows.Forms.Button
    Friend WithEvents lblVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSpacer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lnkCreditsStarIcon As System.Windows.Forms.LinkLabel
    Friend WithEvents picStar As System.Windows.Forms.PictureBox
    Friend WithEvents dgvMyGames As System.Windows.Forms.DataGridView
    Friend WithEvents btnResetDatabase As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents picDonation As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnRefreshFromAPI As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents webNews As System.Windows.Forms.WebBrowser
    Friend WithEvents btnRefreshAll As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnRefreshAllNews As System.Windows.Forms.Button
    Friend WithEvents dgvNews As System.Windows.Forms.DataGridView
    Friend WithEvents webAllNews As Gecko.GeckoWebBrowser
    Friend WithEvents btnBackupDatabase As System.Windows.Forms.Button
    Friend WithEvents fbdBackupPath As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents picLoading As System.Windows.Forms.PictureBox
    Friend WithEvents bgwLoadNews As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwLoadGame As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwLoadGameLocal As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwLoadGameNews As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwLoadAllGameNews As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents progBrowser As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btnSaveOptions As System.Windows.Forms.Button
    Friend WithEvents cboTheme As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboDefaultTab As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnImportDatabase As System.Windows.Forms.Button
    Friend WithEvents ofdImportDatabase As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents picTopBar As System.Windows.Forms.PictureBox
    Friend WithEvents picRightBar As System.Windows.Forms.PictureBox
    Friend WithEvents picMiddleBar As System.Windows.Forms.PictureBox
    Friend WithEvents picBottomBar As System.Windows.Forms.PictureBox
    Friend WithEvents btnImportSteamGames As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSteamWishlist As System.Windows.Forms.Button
    Friend WithEvents webSteamWishlist As System.Windows.Forms.WebBrowser
    Friend WithEvents lnkSteam As System.Windows.Forms.LinkLabel

End Class
