﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pc_CPU = New System.Diagnostics.PerformanceCounter()
        Me.pc_RAM = New System.Diagnostics.PerformanceCounter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerScan = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New Ookii.Dialogs.VistaOpenFileDialog()
        Me.VistaFolderBrowserDialog1 = New Ookii.Dialogs.VistaFolderBrowserDialog()
        Me.NetworkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AscThemeContainer1 = New StrelyCleanner.ascThemeContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AscTabControl1 = New StrelyCleanner.ascTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lbl_Antivirus = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_Firewall = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBoxAds = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SelectScanPanel = New System.Windows.Forms.Panel()
        Me.CleanVirusPanel = New System.Windows.Forms.Panel()
        Me.AnimaStatusBar1 = New StrelyCleanner.AnimaStatusBar()
        Me.Timestamp = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Bouton1 = New StrelyCleanner.Bouton()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Progress4 = New StrelyCleanner.Progress()
        Me.Progress3 = New StrelyCleanner.Progress()
        Me.Progress2 = New StrelyCleanner.Progress()
        Me.Progress1 = New StrelyCleanner.Progress()
        Me.PanelBoxVir = New System.Windows.Forms.Panel()
        Me.LogInContextMenu2 = New StrelyCleanner.LogInContextMenu()
        Me.SelectALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenInFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ThirteenButton1 = New StrelyCleanner.ThirteenButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.XylosButton1 = New StrelyCleanner.XylosButton()
        Me.AnimaButton1 = New StrelyCleanner.AnimaButton()
        Me.AnimaButton2 = New StrelyCleanner.AnimaButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.AnimaExperimentalListView1 = New StrelyCleanner.AnimaExperimentalListView()
        Me.LogInContextMenu1 = New StrelyCleanner.LogInContextMenu()
        Me.KILLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscButton_Big2 = New StrelyCleanner.ascButton_Big()
        Me.AscButton_Big1 = New StrelyCleanner.ascButton_Big()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AnimaProgressBar1 = New StrelyCleanner.AnimaProgressBar()
        Me.AscSwitch1 = New StrelyCleanner.ascSwitch()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_ram = New System.Windows.Forms.Label()
        Me.lbl_cpu = New System.Windows.Forms.Label()
        Me.pb_RAM = New StrelyCleanner.ascProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pb_CPU = New StrelyCleanner.ascProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.chkProcesses = New StrelyCleanner.ascCheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkSystemFiles = New StrelyCleanner.ascCheckBox()
        Me.chkStartup = New StrelyCleanner.ascCheckBox()
        Me.chkRegistry = New StrelyCleanner.ascCheckBox()
        Me.panItems = New System.Windows.Forms.Panel()
        Me.panItemDetail = New System.Windows.Forms.Panel()
        Me.btnExplorer = New StrelyCleanner.StrafeButton()
        Me.btnDestroy = New StrelyCleanner.StrafeButton()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.exeIcon = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.AnimaExperimentalControlBox1 = New StrelyCleanner.AnimaExperimentalControlBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PingCheckBox2 = New StrelyCleanner.BoosterCheckBox()
        Me.AnimaGroupBox2 = New StrelyCleanner.AnimaGroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DynamicCheckBox2 = New StrelyCleanner.BoosterCheckBox()
        Me.StaticCheckBox1 = New StrelyCleanner.BoosterCheckBox()
        Me.AnimaGroupBox1 = New StrelyCleanner.AnimaGroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ThirteenTextBox1 = New StrelyCleanner.ThirteenTextBox()
        Me.BoosterButton1 = New StrelyCleanner.BoosterButton()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.AnimaGroupBox3 = New StrelyCleanner.AnimaGroupBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.AnimaTextBox1 = New StrelyCleanner.AnimaTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.XylosSeparator2 = New StrelyCleanner.XylosSeparator()
        Me.XylosSeparator1 = New StrelyCleanner.XylosSeparator()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BoosterToolTip1 = New StrelyCleanner.BoosterToolTip()
        CType(Me.pc_CPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc_RAM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AscThemeContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.AscTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxAds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SelectScanPanel.SuspendLayout()
        Me.CleanVirusPanel.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogInContextMenu2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.LogInContextMenu1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.panItemDetail.SuspendLayout()
        CType(Me.exeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pc_CPU
        '
        Me.pc_CPU.CategoryName = "Processor"
        Me.pc_CPU.CounterName = "% Processor Time"
        Me.pc_CPU.InstanceName = "_Total"
        '
        'pc_RAM
        '
        Me.pc_RAM.CategoryName = "Memory"
        Me.pc_RAM.CounterName = "% Committed Bytes In Use"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'imgIcons
        '
        Me.imgIcons.ImageStream = CType(resources.GetObject("imgIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIcons.Images.SetKeyName(0, "application-128.png")
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        Me.Timer5.Interval = 1
        '
        'TimerScan
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = Nothing
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.ReadOnlyChecked = True
        Me.OpenFileDialog1.ShowReadOnly = True
        '
        'NetworkTimer
        '
        Me.NetworkTimer.Enabled = True
        Me.NetworkTimer.Interval = 1
        '
        'AscThemeContainer1
        '
        Me.AscThemeContainer1.BackColor = System.Drawing.Color.White
        Me.AscThemeContainer1.Controls.Add(Me.Panel1)
        Me.AscThemeContainer1.Controls.Add(Me.PanelBarraTitulo)
        Me.AscThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AscThemeContainer1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.AscThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.AscThemeContainer1.Name = "AscThemeContainer1"
        Me.AscThemeContainer1.Size = New System.Drawing.Size(753, 562)
        Me.AscThemeContainer1.TabIndex = 0
        Me.AscThemeContainer1.Text = "Strely Avanced"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.AscTabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(753, 521)
        Me.Panel1.TabIndex = 20
        '
        'AscTabControl1
        '
        Me.AscTabControl1.Controls.Add(Me.TabPage1)
        Me.AscTabControl1.Controls.Add(Me.TabPage2)
        Me.AscTabControl1.Controls.Add(Me.TabPage3)
        Me.AscTabControl1.Controls.Add(Me.TabPage4)
        Me.AscTabControl1.Controls.Add(Me.TabPage6)
        Me.AscTabControl1.Controls.Add(Me.TabPage5)
        Me.AscTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AscTabControl1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.AscTabControl1.ItemSize = New System.Drawing.Size(0, 34)
        Me.AscTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.AscTabControl1.Name = "AscTabControl1"
        Me.AscTabControl1.Padding = New System.Drawing.Point(24, 0)
        Me.AscTabControl1.SelectedIndex = 0
        Me.AscTabControl1.Size = New System.Drawing.Size(751, 519)
        Me.AscTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.PictureBox4)
        Me.TabPage1.Controls.Add(Me.lbl_Antivirus)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.lbl_Firewall)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(743, 477)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "HOME"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(10, 372)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'lbl_Antivirus
        '
        Me.lbl_Antivirus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Antivirus.AutoSize = True
        Me.lbl_Antivirus.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Antivirus.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lbl_Antivirus.Location = New System.Drawing.Point(53, 382)
        Me.lbl_Antivirus.Name = "lbl_Antivirus"
        Me.lbl_Antivirus.Size = New System.Drawing.Size(57, 15)
        Me.lbl_Antivirus.TabIndex = 8
        Me.lbl_Antivirus.Text = "AntiVirus"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(10, 323)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'lbl_Firewall
        '
        Me.lbl_Firewall.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Firewall.AutoSize = True
        Me.lbl_Firewall.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Firewall.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lbl_Firewall.Location = New System.Drawing.Point(53, 332)
        Me.lbl_Firewall.Name = "lbl_Firewall"
        Me.lbl_Firewall.Size = New System.Drawing.Size(48, 15)
        Me.lbl_Firewall.TabIndex = 6
        Me.lbl_Firewall.Text = "Firewall"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBoxAds)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(737, 166)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(0, -3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(44, 24)
        Me.Panel3.TabIndex = 0
        '
        'PictureBoxAds
        '
        Me.PictureBoxAds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxAds.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxAds.Name = "PictureBoxAds"
        Me.PictureBoxAds.Size = New System.Drawing.Size(737, 166)
        Me.PictureBoxAds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxAds.TabIndex = 1
        Me.PictureBoxAds.TabStop = False
        Me.BoosterToolTip1.SetToolTip(Me.PictureBoxAds, "Contact E-mail or Whatsapp to place your advertisement. (Only Paypal payment meth" & _
        "od)")
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.SelectScanPanel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(743, 477)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SCAN"
        '
        'SelectScanPanel
        '
        Me.SelectScanPanel.BackColor = System.Drawing.Color.White
        Me.SelectScanPanel.Controls.Add(Me.CleanVirusPanel)
        Me.SelectScanPanel.Controls.Add(Me.Panel5)
        Me.SelectScanPanel.Controls.Add(Me.AnimaButton1)
        Me.SelectScanPanel.Controls.Add(Me.AnimaButton2)
        Me.SelectScanPanel.Controls.Add(Me.PictureBox5)
        Me.SelectScanPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectScanPanel.Location = New System.Drawing.Point(3, 3)
        Me.SelectScanPanel.Name = "SelectScanPanel"
        Me.SelectScanPanel.Size = New System.Drawing.Size(737, 471)
        Me.SelectScanPanel.TabIndex = 4
        '
        'CleanVirusPanel
        '
        Me.CleanVirusPanel.Controls.Add(Me.AnimaStatusBar1)
        Me.CleanVirusPanel.Controls.Add(Me.Timestamp)
        Me.CleanVirusPanel.Controls.Add(Me.Label12)
        Me.CleanVirusPanel.Controls.Add(Me.Label11)
        Me.CleanVirusPanel.Controls.Add(Me.Label10)
        Me.CleanVirusPanel.Controls.Add(Me.PictureBox7)
        Me.CleanVirusPanel.Controls.Add(Me.PictureBox6)
        Me.CleanVirusPanel.Controls.Add(Me.Bouton1)
        Me.CleanVirusPanel.Controls.Add(Me.StatusLabel)
        Me.CleanVirusPanel.Controls.Add(Me.Label9)
        Me.CleanVirusPanel.Controls.Add(Me.Progress4)
        Me.CleanVirusPanel.Controls.Add(Me.Progress3)
        Me.CleanVirusPanel.Controls.Add(Me.Progress2)
        Me.CleanVirusPanel.Controls.Add(Me.Progress1)
        Me.CleanVirusPanel.Controls.Add(Me.PanelBoxVir)
        Me.CleanVirusPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CleanVirusPanel.Location = New System.Drawing.Point(0, 471)
        Me.CleanVirusPanel.Name = "CleanVirusPanel"
        Me.CleanVirusPanel.Size = New System.Drawing.Size(737, 0)
        Me.CleanVirusPanel.TabIndex = 5
        '
        'AnimaStatusBar1
        '
        Me.AnimaStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AnimaStatusBar1.Location = New System.Drawing.Point(0, -19)
        Me.AnimaStatusBar1.Name = "AnimaStatusBar1"
        Me.AnimaStatusBar1.Size = New System.Drawing.Size(737, 19)
        Me.AnimaStatusBar1.TabIndex = 18
        Me.AnimaStatusBar1.Text = "Using USB File Resc 17.2.0.1 Analysis Engine (Private Version)"
        Me.AnimaStatusBar1.Type = StrelyCleanner.AnimaStatusBar.Types.Basic
        '
        'Timestamp
        '
        Me.Timestamp.AutoSize = True
        Me.Timestamp.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Timestamp.Location = New System.Drawing.Point(292, 8)
        Me.Timestamp.Name = "Timestamp"
        Me.Timestamp.Size = New System.Drawing.Size(94, 18)
        Me.Timestamp.TabIndex = 17
        Me.Timestamp.Text = "Calculated..."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(224, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Option Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(188, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Task:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Location = New System.Drawing.Point(188, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Elapsed Time:"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(42, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(140, 101)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        Me.BoosterToolTip1.SetToolTip(Me.PictureBox6, "Back")
        '
        'Bouton1
        '
        Me.Bouton1.Customization = "tZ01//////8="
        Me.Bouton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Bouton1.Image = Nothing
        Me.Bouton1.Location = New System.Drawing.Point(622, 8)
        Me.Bouton1.Name = "Bouton1"
        Me.Bouton1.NoRounding = False
        Me.Bouton1.Size = New System.Drawing.Size(101, 35)
        Me.Bouton1.TabIndex = 11
        Me.Bouton1.Text = "Clean"
        Me.Bouton1.Transparent = False
        Me.Bouton1.Visible = False
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(253, 74)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(85, 18)
        Me.StatusLabel.TabIndex = 9
        Me.StatusLabel.Text = "Scanning..."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(189, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Status : "
        '
        'Progress4
        '
        Me.Progress4.HideLoading = False
        Me.Progress4.Location = New System.Drawing.Point(607, 110)
        Me.Progress4.Maximum = 100
        Me.Progress4.Minimum = 0
        Me.Progress4.Name = "Progress4"
        Me.Progress4.Size = New System.Drawing.Size(126, 32)
        Me.Progress4.TabIndex = 7
        Me.Progress4.Text = "Progress4"
        Me.Progress4.Value = 0
        '
        'Progress3
        '
        Me.Progress3.HideLoading = False
        Me.Progress3.Location = New System.Drawing.Point(309, 110)
        Me.Progress3.Maximum = 100
        Me.Progress3.Minimum = 0
        Me.Progress3.Name = "Progress3"
        Me.Progress3.Size = New System.Drawing.Size(298, 32)
        Me.Progress3.TabIndex = 6
        Me.Progress3.Text = "Progress3"
        Me.Progress3.Value = 0
        '
        'Progress2
        '
        Me.Progress2.HideLoading = False
        Me.Progress2.Location = New System.Drawing.Point(155, 110)
        Me.Progress2.Maximum = 100
        Me.Progress2.Minimum = 0
        Me.Progress2.Name = "Progress2"
        Me.Progress2.Size = New System.Drawing.Size(158, 32)
        Me.Progress2.TabIndex = 5
        Me.Progress2.Text = "Progress2"
        Me.Progress2.Value = 0
        '
        'Progress1
        '
        Me.Progress1.HideLoading = False
        Me.Progress1.Location = New System.Drawing.Point(0, 110)
        Me.Progress1.Maximum = 100
        Me.Progress1.Minimum = 0
        Me.Progress1.Name = "Progress1"
        Me.Progress1.Size = New System.Drawing.Size(158, 32)
        Me.Progress1.TabIndex = 4
        Me.Progress1.Text = "Progress1"
        Me.Progress1.Value = 0
        '
        'PanelBoxVir
        '
        Me.PanelBoxVir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelBoxVir.AutoScroll = True
        Me.PanelBoxVir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelBoxVir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelBoxVir.ContextMenuStrip = Me.LogInContextMenu2
        Me.PanelBoxVir.Location = New System.Drawing.Point(13, 161)
        Me.PanelBoxVir.Name = "PanelBoxVir"
        Me.PanelBoxVir.Size = New System.Drawing.Size(710, 271)
        Me.PanelBoxVir.TabIndex = 3
        Me.BoosterToolTip1.SetToolTip(Me.PanelBoxVir, "You can Select the Contextual Tool, Pressing ""Right Click"".")
        Me.PanelBoxVir.Visible = False
        '
        'LogInContextMenu2
        '
        Me.LogInContextMenu2.FontColour = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInContextMenu2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInContextMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectALLToolStripMenuItem, Me.ToolStripSeparator1, Me.OpenInFolderToolStripMenuItem})
        Me.LogInContextMenu2.Name = "LogInContextMenu2"
        Me.LogInContextMenu2.ShowImageMargin = False
        Me.LogInContextMenu2.Size = New System.Drawing.Size(128, 54)
        '
        'SelectALLToolStripMenuItem
        '
        Me.SelectALLToolStripMenuItem.Name = "SelectALLToolStripMenuItem"
        Me.SelectALLToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SelectALLToolStripMenuItem.Text = "Select ALL"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(124, 6)
        '
        'OpenInFolderToolStripMenuItem
        '
        Me.OpenInFolderToolStripMenuItem.Name = "OpenInFolderToolStripMenuItem"
        Me.OpenInFolderToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.OpenInFolderToolStripMenuItem.Text = "Open in Folder"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel10)
        Me.Panel5.Controls.Add(Me.PictureBox14)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.ThirteenButton1)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.XylosButton1)
        Me.Panel5.Location = New System.Drawing.Point(3, 228)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(727, 168)
        Me.Panel5.TabIndex = 6
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel10.BackgroundImage = CType(resources.GetObject("Panel10.BackgroundImage"), System.Drawing.Image)
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel10.Controls.Add(Me.PictureBox13)
        Me.Panel10.Location = New System.Drawing.Point(20, 28)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(42, 43)
        Me.Panel10.TabIndex = 5
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(42, 43)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 3
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(20, 66)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(42, 31)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 7
        Me.PictureBox14.TabStop = False
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(68, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(435, 45)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "A Scanner designed exclusively for USB devices, Memories, among others. able to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
    "fully optimize, disinfect and Repair your pocket device remove all" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kinds of thr" & _
    "eats and Protect yourself."
        '
        'ThirteenButton1
        '
        Me.ThirteenButton1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton1.ColorScheme = StrelyCleanner.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ThirteenButton1.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton1.Location = New System.Drawing.Point(604, 52)
        Me.ThirteenButton1.Name = "ThirteenButton1"
        Me.ThirteenButton1.Size = New System.Drawing.Size(102, 45)
        Me.ThirteenButton1.TabIndex = 6
        Me.ThirteenButton1.Text = "Start"
        Me.ThirteenButton1.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label20.Location = New System.Drawing.Point(68, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 18)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "USB SCANNER"
        '
        'XylosButton1
        '
        Me.XylosButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.XylosButton1.BackColorA = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.XylosButton1.Enabled = False
        Me.XylosButton1.EnabledCalc = False
        Me.XylosButton1.Location = New System.Drawing.Point(10, 18)
        Me.XylosButton1.Name = "XylosButton1"
        Me.XylosButton1.Size = New System.Drawing.Size(710, 120)
        Me.XylosButton1.TabIndex = 0
        '
        'AnimaButton1
        '
        Me.AnimaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AnimaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.AnimaButton1.ImageLocation = New System.Drawing.Point(30, 6)
        Me.AnimaButton1.ImageSize = New System.Drawing.Size(14, 14)
        Me.AnimaButton1.Location = New System.Drawing.Point(644, 45)
        Me.AnimaButton1.Name = "AnimaButton1"
        Me.AnimaButton1.Size = New System.Drawing.Size(79, 36)
        Me.AnimaButton1.TabIndex = 1
        Me.AnimaButton1.Text = "Start"
        Me.AnimaButton1.UseVisualStyleBackColor = True
        '
        'AnimaButton2
        '
        Me.AnimaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AnimaButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.AnimaButton2.ImageLocation = New System.Drawing.Point(30, 6)
        Me.AnimaButton2.ImageSize = New System.Drawing.Size(14, 14)
        Me.AnimaButton2.Location = New System.Drawing.Point(644, 151)
        Me.AnimaButton2.Name = "AnimaButton2"
        Me.AnimaButton2.Size = New System.Drawing.Size(79, 36)
        Me.AnimaButton2.TabIndex = 2
        Me.AnimaButton2.Text = "Start"
        Me.AnimaButton2.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(728, 219)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Panel4)
        Me.TabPage3.Controls.Add(Me.AscButton_Big1)
        Me.TabPage3.Controls.Add(Me.Panel7)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(743, 477)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "BOOSTER"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel4.Controls.Add(Me.AnimaExperimentalListView1)
        Me.Panel4.Controls.Add(Me.AscButton_Big2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 452)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(743, 25)
        Me.Panel4.TabIndex = 11
        Me.BoosterToolTip1.SetToolTip(Me.Panel4, "You can Select the Contextual Tool, Pressing ""Right Click"".")
        '
        'AnimaExperimentalListView1
        '
        Me.AnimaExperimentalListView1.Columns = New String() {"ID", "Process", "Caption", "Memory", "Diferencial"}
        Me.AnimaExperimentalListView1.ColumnWidth = 120
        Me.AnimaExperimentalListView1.ContextMenuStrip = Me.LogInContextMenu1
        Me.AnimaExperimentalListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AnimaExperimentalListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.AnimaExperimentalListView1.Grid = False
        Me.AnimaExperimentalListView1.HandleItemsForeColor = False
        Me.AnimaExperimentalListView1.Highlight = -1
        Me.AnimaExperimentalListView1.Items = New System.Windows.Forms.ListViewItem(-1) {}
        Me.AnimaExperimentalListView1.ItemSize = 16
        Me.AnimaExperimentalListView1.Location = New System.Drawing.Point(0, 25)
        Me.AnimaExperimentalListView1.Multiselect = False
        Me.AnimaExperimentalListView1.Name = "AnimaExperimentalListView1"
        Me.AnimaExperimentalListView1.SelectedIndex = -1
        Me.AnimaExperimentalListView1.SelectedIndexes = CType(resources.GetObject("AnimaExperimentalListView1.SelectedIndexes"), System.Collections.Generic.List(Of Integer))
        Me.AnimaExperimentalListView1.Size = New System.Drawing.Size(725, 450)
        Me.AnimaExperimentalListView1.TabIndex = 10
        Me.AnimaExperimentalListView1.Text = "AnimaExperimentalListView1"
        '
        'LogInContextMenu1
        '
        Me.LogInContextMenu1.FontColour = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInContextMenu1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KILLToolStripMenuItem})
        Me.LogInContextMenu1.Name = "LogInContextMenu1"
        Me.LogInContextMenu1.ShowImageMargin = False
        Me.LogInContextMenu1.Size = New System.Drawing.Size(72, 26)
        '
        'KILLToolStripMenuItem
        '
        Me.KILLToolStripMenuItem.Name = "KILLToolStripMenuItem"
        Me.KILLToolStripMenuItem.Size = New System.Drawing.Size(71, 22)
        Me.KILLToolStripMenuItem.Text = "KILL"
        '
        'AscButton_Big2
        '
        Me.AscButton_Big2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AscButton_Big2.Dock = System.Windows.Forms.DockStyle.Top
        Me.AscButton_Big2.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.AscButton_Big2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.AscButton_Big2.GlowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.AscButton_Big2.Image = Nothing
        Me.AscButton_Big2.Location = New System.Drawing.Point(0, 0)
        Me.AscButton_Big2.Name = "AscButton_Big2"
        Me.AscButton_Big2.Size = New System.Drawing.Size(743, 25)
        Me.AscButton_Big2.TabIndex = 0
        Me.AscButton_Big2.Text = "Show"
        '
        'AscButton_Big1
        '
        Me.AscButton_Big1.Cursor = System.Windows.Forms.Cursors.Default
        Me.AscButton_Big1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AscButton_Big1.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.AscButton_Big1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.AscButton_Big1.GlowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.AscButton_Big1.Image = CType(resources.GetObject("AscButton_Big1.Image"), System.Drawing.Image)
        Me.AscButton_Big1.Location = New System.Drawing.Point(0, 95)
        Me.AscButton_Big1.Name = "AscButton_Big1"
        Me.AscButton_Big1.Size = New System.Drawing.Size(743, 54)
        Me.AscButton_Big1.TabIndex = 9
        Me.AscButton_Big1.Text = "Optimize System"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.AnimaProgressBar1)
        Me.Panel7.Controls.Add(Me.AscSwitch1)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.lbl_ram)
        Me.Panel7.Controls.Add(Me.lbl_cpu)
        Me.Panel7.Controls.Add(Me.pb_RAM)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.pb_CPU)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(743, 95)
        Me.Panel7.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SlateGray
        Me.Label13.Location = New System.Drawing.Point(7, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 15)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Estimated Refresh Rate"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(7, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Estimated RAM :"
        '
        'AnimaProgressBar1
        '
        Me.AnimaProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnimaProgressBar1.BorderColors = System.Drawing.Color.Lime
        Me.AnimaProgressBar1.Location = New System.Drawing.Point(577, 54)
        Me.AnimaProgressBar1.Maximum = 200
        Me.AnimaProgressBar1.Name = "AnimaProgressBar1"
        Me.AnimaProgressBar1.Size = New System.Drawing.Size(148, 22)
        Me.AnimaProgressBar1.TabIndex = 12
        '
        'AscSwitch1
        '
        Me.AscSwitch1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AscSwitch1.Checked = False
        Me.AscSwitch1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AscSwitch1.Location = New System.Drawing.Point(694, 15)
        Me.AscSwitch1.Name = "AscSwitch1"
        Me.AscSwitch1.Size = New System.Drawing.Size(42, 17)
        Me.AscSwitch1.TabIndex = 7
        Me.AscSwitch1.Text = "AscSwitch1"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(574, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "RealTime Optimizer"
        '
        'lbl_ram
        '
        Me.lbl_ram.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ram.AutoSize = True
        Me.lbl_ram.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ram.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_ram.Location = New System.Drawing.Point(513, 61)
        Me.lbl_ram.Name = "lbl_ram"
        Me.lbl_ram.Size = New System.Drawing.Size(38, 15)
        Me.lbl_ram.TabIndex = 6
        Me.lbl_ram.Text = "vRam"
        '
        'lbl_cpu
        '
        Me.lbl_cpu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_cpu.AutoSize = True
        Me.lbl_cpu.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpu.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_cpu.Location = New System.Drawing.Point(513, 32)
        Me.lbl_cpu.Name = "lbl_cpu"
        Me.lbl_cpu.Size = New System.Drawing.Size(35, 15)
        Me.lbl_cpu.TabIndex = 5
        Me.lbl_cpu.Text = "vCpu"
        '
        'pb_RAM
        '
        Me.pb_RAM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_RAM.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.pb_RAM.Location = New System.Drawing.Point(111, 66)
        Me.pb_RAM.Maximum = 100
        Me.pb_RAM.Name = "pb_RAM"
        Me.pb_RAM.Size = New System.Drawing.Size(396, 10)
        Me.pb_RAM.TabIndex = 4
        Me.pb_RAM.Text = "AscProgressBar2"
        Me.pb_RAM.Value = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(7, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Estimated CPU :"
        '
        'pb_CPU
        '
        Me.pb_CPU.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_CPU.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.pb_CPU.Location = New System.Drawing.Point(111, 37)
        Me.pb_CPU.Maximum = 100
        Me.pb_CPU.Name = "pb_CPU"
        Me.pb_CPU.Size = New System.Drawing.Size(396, 10)
        Me.pb_CPU.TabIndex = 0
        Me.pb_CPU.Text = "AscProgressBar1"
        Me.pb_CPU.Value = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 153)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(741, 293)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.chkProcesses)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.chkSystemFiles)
        Me.TabPage4.Controls.Add(Me.chkStartup)
        Me.TabPage4.Controls.Add(Me.chkRegistry)
        Me.TabPage4.Controls.Add(Me.panItems)
        Me.TabPage4.Controls.Add(Me.panItemDetail)
        Me.TabPage4.ImageKey = "(none)"
        Me.TabPage4.Location = New System.Drawing.Point(4, 38)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(743, 477)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "STARTUP MANAGER"
        '
        'chkProcesses
        '
        Me.chkProcesses.Checked = False
        Me.chkProcesses.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.chkProcesses.Location = New System.Drawing.Point(258, 176)
        Me.chkProcesses.Name = "chkProcesses"
        Me.chkProcesses.Size = New System.Drawing.Size(82, 17)
        Me.chkProcesses.TabIndex = 20
        Me.chkProcesses.Text = "Services"
        Me.chkProcesses.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(655, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 27)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkSystemFiles
        '
        Me.chkSystemFiles.Checked = True
        Me.chkSystemFiles.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.chkSystemFiles.Location = New System.Drawing.Point(183, 176)
        Me.chkSystemFiles.Name = "chkSystemFiles"
        Me.chkSystemFiles.Size = New System.Drawing.Size(88, 17)
        Me.chkSystemFiles.TabIndex = 23
        Me.chkSystemFiles.Text = "System"
        '
        'chkStartup
        '
        Me.chkStartup.Checked = True
        Me.chkStartup.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.chkStartup.Location = New System.Drawing.Point(97, 176)
        Me.chkStartup.Name = "chkStartup"
        Me.chkStartup.Size = New System.Drawing.Size(80, 17)
        Me.chkStartup.TabIndex = 22
        Me.chkStartup.Text = "Startup"
        '
        'chkRegistry
        '
        Me.chkRegistry.Checked = True
        Me.chkRegistry.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.chkRegistry.Location = New System.Drawing.Point(8, 176)
        Me.chkRegistry.Name = "chkRegistry"
        Me.chkRegistry.Size = New System.Drawing.Size(83, 17)
        Me.chkRegistry.TabIndex = 21
        Me.chkRegistry.Text = "Registry"
        '
        'panItems
        '
        Me.panItems.AutoScroll = True
        Me.panItems.BackColor = System.Drawing.Color.Transparent
        Me.panItems.ForeColor = System.Drawing.Color.Lime
        Me.panItems.Location = New System.Drawing.Point(8, 22)
        Me.panItems.Name = "panItems"
        Me.panItems.Size = New System.Drawing.Size(727, 148)
        Me.panItems.TabIndex = 19
        '
        'panItemDetail
        '
        Me.panItemDetail.AutoScroll = True
        Me.panItemDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.panItemDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panItemDetail.Controls.Add(Me.btnExplorer)
        Me.panItemDetail.Controls.Add(Me.btnDestroy)
        Me.panItemDetail.Controls.Add(Me.lblType)
        Me.panItemDetail.Controls.Add(Me.lblID)
        Me.panItemDetail.Controls.Add(Me.lblLocation)
        Me.panItemDetail.Controls.Add(Me.lblItem)
        Me.panItemDetail.Controls.Add(Me.exeIcon)
        Me.panItemDetail.Controls.Add(Me.Button2)
        Me.panItemDetail.ForeColor = System.Drawing.Color.Lime
        Me.panItemDetail.Location = New System.Drawing.Point(7, 240)
        Me.panItemDetail.Name = "panItemDetail"
        Me.panItemDetail.Size = New System.Drawing.Size(728, 229)
        Me.panItemDetail.TabIndex = 18
        Me.panItemDetail.Visible = False
        '
        'btnExplorer
        '
        Me.btnExplorer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExplorer.EnabledCalc = True
        Me.btnExplorer.Location = New System.Drawing.Point(483, 178)
        Me.btnExplorer.Name = "btnExplorer"
        Me.btnExplorer.Size = New System.Drawing.Size(111, 35)
        Me.btnExplorer.TabIndex = 33
        Me.btnExplorer.Text = "Explore"
        '
        'btnDestroy
        '
        Me.btnDestroy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDestroy.EnabledCalc = True
        Me.btnDestroy.Location = New System.Drawing.Point(600, 178)
        Me.btnDestroy.Name = "btnDestroy"
        Me.btnDestroy.Size = New System.Drawing.Size(111, 35)
        Me.btnDestroy.TabIndex = 32
        Me.btnDestroy.Text = "Destroy Key"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.White
        Me.lblType.Location = New System.Drawing.Point(8, 151)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(39, 17)
        Me.lblType.TabIndex = 31
        Me.lblType.Text = "Type"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(8, 13)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(23, 18)
        Me.lblID.TabIndex = 30
        Me.lblID.Text = "ID"
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblLocation.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocation.ForeColor = System.Drawing.Color.Lime
        Me.lblLocation.Location = New System.Drawing.Point(89, 97)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(622, 16)
        Me.lblLocation.TabIndex = 29
        '
        'lblItem
        '
        Me.lblItem.BackColor = System.Drawing.Color.Transparent
        Me.lblItem.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblItem.ForeColor = System.Drawing.Color.Lime
        Me.lblItem.Location = New System.Drawing.Point(89, 52)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(622, 16)
        Me.lblItem.TabIndex = 28
        '
        'exeIcon
        '
        Me.exeIcon.Location = New System.Drawing.Point(11, 52)
        Me.exeIcon.Name = "exeIcon"
        Me.exeIcon.Size = New System.Drawing.Size(72, 72)
        Me.exeIcon.TabIndex = 24
        Me.exeIcon.TabStop = False
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(726, 227)
        Me.Button2.TabIndex = 23
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.AnimaExperimentalControlBox1)
        Me.TabPage6.Controls.Add(Me.Panel8)
        Me.TabPage6.Controls.Add(Me.Panel6)
        Me.TabPage6.Controls.Add(Me.Label8)
        Me.TabPage6.Controls.Add(Me.ThirteenTextBox1)
        Me.TabPage6.Controls.Add(Me.BoosterButton1)
        Me.TabPage6.Controls.Add(Me.Panel9)
        Me.TabPage6.Location = New System.Drawing.Point(4, 38)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(743, 477)
        Me.TabPage6.TabIndex = 4
        Me.TabPage6.Text = "WIFI"
        '
        'AnimaExperimentalControlBox1
        '
        Me.AnimaExperimentalControlBox1.AnimaGroupBoxContainer = Nothing
        Me.AnimaExperimentalControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AnimaExperimentalControlBox1.ComboHeight = 24
        Me.AnimaExperimentalControlBox1.CurrentLocation = New System.Drawing.Point(0, 0)
        Me.AnimaExperimentalControlBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AnimaExperimentalControlBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.AnimaExperimentalControlBox1.Items = New String() {"Adapters Report", "ARP (.Net Scanner)", "ARP (CMD Scanner)"}
        Me.AnimaExperimentalControlBox1.ItemSize = 24
        Me.AnimaExperimentalControlBox1.Location = New System.Drawing.Point(92, 64)
        Me.AnimaExperimentalControlBox1.Name = "AnimaExperimentalControlBox1"
        Me.AnimaExperimentalControlBox1.SelectedIndex = 0
        Me.AnimaExperimentalControlBox1.SelectedItem = Nothing
        Me.AnimaExperimentalControlBox1.Size = New System.Drawing.Size(182, 25)
        Me.AnimaExperimentalControlBox1.TabIndex = 15
        Me.AnimaExperimentalControlBox1.Text = "AnimaExperimentalControlBox1"
        Me.AnimaExperimentalControlBox1.TextHeight = 4
        Me.BoosterToolTip1.SetToolTip(Me.AnimaExperimentalControlBox1, "Some types of scans are repeated, but it is because the method of obtaining it is" & _
        " different.")
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.PingCheckBox2)
        Me.Panel8.Controls.Add(Me.AnimaGroupBox2)
        Me.Panel8.Location = New System.Drawing.Point(422, 30)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(150, 101)
        Me.Panel8.TabIndex = 14
        Me.Panel8.Visible = False
        '
        'PingCheckBox2
        '
        Me.PingCheckBox2.AutoSize = True
        Me.PingCheckBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.PingCheckBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PingCheckBox2.Location = New System.Drawing.Point(14, 35)
        Me.PingCheckBox2.Name = "PingCheckBox2"
        Me.PingCheckBox2.Size = New System.Drawing.Size(115, 19)
        Me.PingCheckBox2.TabIndex = 10
        Me.PingCheckBox2.Text = "Check Ping Alive"
        Me.BoosterToolTip1.SetToolTip(Me.PingCheckBox2, "Activating this option may take a while to scan.")
        Me.PingCheckBox2.UseVisualStyleBackColor = False
        '
        'AnimaGroupBox2
        '
        Me.AnimaGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AnimaGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnimaGroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.AnimaGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.AnimaGroupBox2.Name = "AnimaGroupBox2"
        Me.AnimaGroupBox2.Size = New System.Drawing.Size(148, 99)
        Me.AnimaGroupBox2.TabIndex = 11
        Me.AnimaGroupBox2.Text = "Options"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.DynamicCheckBox2)
        Me.Panel6.Controls.Add(Me.StaticCheckBox1)
        Me.Panel6.Controls.Add(Me.AnimaGroupBox1)
        Me.Panel6.Location = New System.Drawing.Point(296, 30)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(108, 101)
        Me.Panel6.TabIndex = 13
        Me.Panel6.Visible = False
        '
        'DynamicCheckBox2
        '
        Me.DynamicCheckBox2.AutoSize = True
        Me.DynamicCheckBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.DynamicCheckBox2.Checked = True
        Me.DynamicCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DynamicCheckBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DynamicCheckBox2.Location = New System.Drawing.Point(14, 69)
        Me.DynamicCheckBox2.Name = "DynamicCheckBox2"
        Me.DynamicCheckBox2.Size = New System.Drawing.Size(79, 19)
        Me.DynamicCheckBox2.TabIndex = 13
        Me.DynamicCheckBox2.Text = "Dynamic  "
        Me.DynamicCheckBox2.UseVisualStyleBackColor = False
        '
        'StaticCheckBox1
        '
        Me.StaticCheckBox1.AutoSize = True
        Me.StaticCheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.StaticCheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StaticCheckBox1.Location = New System.Drawing.Point(14, 35)
        Me.StaticCheckBox1.Name = "StaticCheckBox1"
        Me.StaticCheckBox1.Size = New System.Drawing.Size(61, 19)
        Me.StaticCheckBox1.TabIndex = 10
        Me.StaticCheckBox1.Text = "Static  "
        Me.StaticCheckBox1.UseVisualStyleBackColor = False
        '
        'AnimaGroupBox1
        '
        Me.AnimaGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AnimaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnimaGroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.AnimaGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.AnimaGroupBox1.Name = "AnimaGroupBox1"
        Me.AnimaGroupBox1.Size = New System.Drawing.Size(106, 99)
        Me.AnimaGroupBox1.TabIndex = 11
        Me.AnimaGroupBox1.Text = "Types"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(4, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(476, 14)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "A Tool with which you can see useful information from your network."
        '
        'ThirteenTextBox1
        '
        Me.ThirteenTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThirteenTextBox1.BackColor = System.Drawing.Color.Black
        Me.ThirteenTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ThirteenTextBox1.ColorScheme = StrelyCleanner.ThirteenTextBox.ColorSchemes.Custom
        Me.ThirteenTextBox1.CustomBackColor = System.Drawing.Color.Black
        Me.ThirteenTextBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThirteenTextBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenTextBox1.Location = New System.Drawing.Point(17, 137)
        Me.ThirteenTextBox1.Multiline = True
        Me.ThirteenTextBox1.Name = "ThirteenTextBox1"
        Me.ThirteenTextBox1.ReadOnly = True
        Me.ThirteenTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ThirteenTextBox1.Size = New System.Drawing.Size(703, 333)
        Me.ThirteenTextBox1.TabIndex = 2
        '
        'BoosterButton1
        '
        Me.BoosterButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BoosterButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BoosterButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BoosterButton1.Location = New System.Drawing.Point(592, 46)
        Me.BoosterButton1.Name = "BoosterButton1"
        Me.BoosterButton1.Size = New System.Drawing.Size(118, 73)
        Me.BoosterButton1.TabIndex = 1
        Me.BoosterButton1.Text = "Scan"
        Me.BoosterButton1.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label19)
        Me.Panel9.Controls.Add(Me.AnimaGroupBox3)
        Me.Panel9.Location = New System.Drawing.Point(17, 30)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(264, 100)
        Me.Panel9.TabIndex = 17
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(4, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 15)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Scan Type :"
        '
        'AnimaGroupBox3
        '
        Me.AnimaGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AnimaGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnimaGroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.AnimaGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.AnimaGroupBox3.Name = "AnimaGroupBox3"
        Me.AnimaGroupBox3.Size = New System.Drawing.Size(262, 98)
        Me.AnimaGroupBox3.TabIndex = 11
        Me.AnimaGroupBox3.Text = "Misc"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Controls.Add(Me.PictureBox12)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.AnimaTextBox1)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.Button4)
        Me.TabPage5.Controls.Add(Me.XylosSeparator2)
        Me.TabPage5.Controls.Add(Me.XylosSeparator1)
        Me.TabPage5.Controls.Add(Me.PictureBox11)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.PictureBox8)
        Me.TabPage5.Controls.Add(Me.PictureBox9)
        Me.TabPage5.Controls.Add(Me.PictureBox10)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.Button3)
        Me.TabPage5.Controls.Add(Me.Button5)
        Me.TabPage5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TabPage5.Location = New System.Drawing.Point(4, 38)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(743, 477)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "About ..."
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.SlateGray
        Me.Label17.Location = New System.Drawing.Point(467, 329)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(231, 15)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "S4Lsalsoft | All rights reserved"
        '
        'PictureBox12
        '
        Me.PictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(390, 428)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(114, 38)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 63
        Me.PictureBox12.TabStop = False
        Me.BoosterToolTip1.SetToolTip(Me.PictureBox12, "By Donating, you are Helping the Development of ""StrelyCleaner"" and its Developer" & _
        "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Thank you! Thank you so much.")
        '
        'Label18
        '
        Me.Label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.SlateGray
        Me.Label18.Location = New System.Drawing.Point(397, 388)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(301, 60)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = """We earn a living with what we receive." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  but we make life with what we give ..." & _
    " """ & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                         - John Maxwell -"
        '
        'AnimaTextBox1
        '
        Me.AnimaTextBox1.Dark = False
        Me.AnimaTextBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnimaTextBox1.Location = New System.Drawing.Point(45, 162)
        Me.AnimaTextBox1.MaxLength = 32767
        Me.AnimaTextBox1.MultiLine = True
        Me.AnimaTextBox1.Name = "AnimaTextBox1"
        Me.AnimaTextBox1.Numeric = False
        Me.AnimaTextBox1.ReadOnly = True
        Me.AnimaTextBox1.Size = New System.Drawing.Size(643, 49)
        Me.AnimaTextBox1.TabIndex = 61
        Me.AnimaTextBox1.Text = "      E-mail: S4Lsalsoft@gmail.com    |    Whatsapp: +58(412)-303-6808           " & _
    "                              -Please only communicate if you need help.        " & _
    ""
        Me.AnimaTextBox1.UseSystemPasswordChar = False
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.SlateGray
        Me.Label16.Location = New System.Drawing.Point(42, 140)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(140, 15)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Contact / Support :"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(30, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(684, 88)
        Me.Button4.TabIndex = 59
        Me.Button4.UseVisualStyleBackColor = True
        '
        'XylosSeparator2
        '
        Me.XylosSeparator2.Location = New System.Drawing.Point(7, 237)
        Me.XylosSeparator2.Name = "XylosSeparator2"
        Me.XylosSeparator2.Size = New System.Drawing.Size(729, 2)
        Me.XylosSeparator2.TabIndex = 57
        Me.XylosSeparator2.Text = "XylosSeparator2"
        '
        'XylosSeparator1
        '
        Me.XylosSeparator1.Location = New System.Drawing.Point(7, 371)
        Me.XylosSeparator1.Name = "XylosSeparator1"
        Me.XylosSeparator1.Size = New System.Drawing.Size(729, 2)
        Me.XylosSeparator1.TabIndex = 56
        Me.XylosSeparator1.Text = "XylosSeparator1"
        '
        'PictureBox11
        '
        Me.PictureBox11.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(743, 129)
        Me.PictureBox11.TabIndex = 55
        Me.PictureBox11.TabStop = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SlateGray
        Me.Label15.Location = New System.Drawing.Point(55, 269)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(630, 60)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "This program is TOTALLY FREE! (Freeware/Donationware). I, the creator, do this fo" & _
    "r Hobby." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " If you liked the program, you can share it with your friends ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tha" & _
    "nk you for using Strely! "
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Location = New System.Drawing.Point(146, 416)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(48, 47)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 53
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox9.Location = New System.Drawing.Point(79, 416)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(48, 47)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 52
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Location = New System.Drawing.Point(10, 416)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(48, 47)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 51
        Me.PictureBox10.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.SlateGray
        Me.Label14.Location = New System.Drawing.Point(7, 385)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 18)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Share this app in:"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(30, 255)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(684, 102)
        Me.Button3.TabIndex = 58
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(390, 382)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(324, 84)
        Me.Button5.TabIndex = 65
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PanelBarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBarraTitulo.Controls.Add(Me.Label7)
        Me.PanelBarraTitulo.Controls.Add(Me.PictureBox2)
        Me.PanelBarraTitulo.Controls.Add(Me.Label1)
        Me.PanelBarraTitulo.Controls.Add(Me.Label3)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(753, 41)
        Me.PanelBarraTitulo.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(667, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "v1.3.0 Realse"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 40)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(144, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "[Multi-Tools Portable]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Azure
        Me.Label3.Location = New System.Drawing.Point(28, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 33)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Strely Pro"
        '
        'BoosterToolTip1
        '
        Me.BoosterToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BoosterToolTip1.OwnerDraw = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(753, 562)
        Me.Controls.Add(Me.AscThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Strely Pro Cleanner"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.pc_CPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc_RAM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AscThemeContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.AscTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBoxAds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.SelectScanPanel.ResumeLayout(False)
        Me.CleanVirusPanel.ResumeLayout(False)
        Me.CleanVirusPanel.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogInContextMenu2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.LogInContextMenu1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.panItemDetail.ResumeLayout(False)
        Me.panItemDetail.PerformLayout()
        CType(Me.exeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AscThemeContainer1 As StrelyCleanner.ascThemeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AscTabControl1 As StrelyCleanner.ascTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PanelBarraTitulo As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BoosterToolTip1 As StrelyCleanner.BoosterToolTip
    Friend WithEvents pc_CPU As System.Diagnostics.PerformanceCounter
    Friend WithEvents pc_RAM As System.Diagnostics.PerformanceCounter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_cpu As System.Windows.Forms.Label
    Friend WithEvents pb_RAM As StrelyCleanner.ascProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pb_CPU As StrelyCleanner.ascProgressBar
    Friend WithEvents lbl_ram As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AscSwitch1 As StrelyCleanner.ascSwitch
    Friend WithEvents AscButton_Big1 As StrelyCleanner.ascButton_Big
    Friend WithEvents AnimaExperimentalListView1 As StrelyCleanner.AnimaExperimentalListView
    Friend WithEvents imgIcons As System.Windows.Forms.ImageList
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents AscButton_Big2 As StrelyCleanner.ascButton_Big
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents AnimaProgressBar1 As StrelyCleanner.AnimaProgressBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Antivirus As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Firewall As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents panItemDetail As System.Windows.Forms.Panel
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents exeIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents panItems As System.Windows.Forms.Panel
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents chkProcesses As StrelyCleanner.ascCheckBox
    Friend WithEvents chkSystemFiles As StrelyCleanner.ascCheckBox
    Friend WithEvents chkStartup As StrelyCleanner.ascCheckBox
    Friend WithEvents chkRegistry As StrelyCleanner.ascCheckBox
    Friend WithEvents btnDestroy As StrelyCleanner.StrafeButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExplorer As StrelyCleanner.StrafeButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents BoosterButton1 As StrelyCleanner.BoosterButton
    Friend WithEvents ThirteenTextBox1 As StrelyCleanner.ThirteenTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents AnimaButton1 As StrelyCleanner.AnimaButton
    Friend WithEvents AnimaButton2 As StrelyCleanner.AnimaButton
    Friend WithEvents PanelBoxVir As System.Windows.Forms.Panel
    Friend WithEvents CleanVirusPanel As System.Windows.Forms.Panel
    Friend WithEvents SelectScanPanel As System.Windows.Forms.Panel
    Friend WithEvents Progress4 As StrelyCleanner.Progress
    Friend WithEvents Progress3 As StrelyCleanner.Progress
    Friend WithEvents Progress2 As StrelyCleanner.Progress
    Friend WithEvents Progress1 As StrelyCleanner.Progress
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TimerScan As System.Windows.Forms.Timer
    Friend WithEvents Bouton1 As StrelyCleanner.Bouton
    Friend WithEvents PictureBoxAds As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Timestamp As System.Windows.Forms.Label
    Friend WithEvents AnimaStatusBar1 As StrelyCleanner.AnimaStatusBar
    Friend WithEvents OpenFileDialog1 As Ookii.Dialogs.VistaOpenFileDialog
    Friend WithEvents VistaFolderBrowserDialog1 As Ookii.Dialogs.VistaFolderBrowserDialog
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents AnimaTextBox1 As StrelyCleanner.AnimaTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents XylosSeparator2 As StrelyCleanner.XylosSeparator
    Friend WithEvents XylosSeparator1 As StrelyCleanner.XylosSeparator
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LogInContextMenu1 As StrelyCleanner.LogInContextMenu
    Friend WithEvents KILLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents StaticCheckBox1 As StrelyCleanner.BoosterCheckBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents DynamicCheckBox2 As StrelyCleanner.BoosterCheckBox
    Friend WithEvents AnimaGroupBox1 As StrelyCleanner.AnimaGroupBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents PingCheckBox2 As StrelyCleanner.BoosterCheckBox
    Friend WithEvents AnimaGroupBox2 As StrelyCleanner.AnimaGroupBox
    Friend WithEvents AnimaExperimentalControlBox1 As StrelyCleanner.AnimaExperimentalControlBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents AnimaGroupBox3 As StrelyCleanner.AnimaGroupBox
    Friend WithEvents NetworkTimer As System.Windows.Forms.Timer
    Friend WithEvents XylosButton1 As StrelyCleanner.XylosButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents ThirteenButton1 As StrelyCleanner.ThirteenButton
    Friend WithEvents LogInContextMenu2 As StrelyCleanner.LogInContextMenu
    Friend WithEvents SelectALLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenInFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox

End Class
