/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 12/29/2007
 * Time: 1:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace SumoGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSearchByWord = new System.Windows.Forms.Button();
			this.btnSearchByTerm = new System.Windows.Forms.Button();
			this.txtWord = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTerm = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabSumo = new System.Windows.Forms.TabControl();
			this.pageManifest = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.lblStatsRelations = new System.Windows.Forms.Label();
			this.lblStatsRules = new System.Windows.Forms.Label();
			this.lblStatsAxioms = new System.Windows.Forms.Label();
			this.lblStatsTerms = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnExport = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbExportFormat = new System.Windows.Forms.ComboBox();
			this.btnBrowseExport = new System.Windows.Forms.Button();
			this.txtExportFile = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblLoadConstituent = new System.Windows.Forms.Label();
			this.btnLoadConstituent = new System.Windows.Forms.Button();
			this.btnBrowseAddConstituent = new System.Windows.Forms.Button();
			this.txtConstituentFileName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lstConstituents = new System.Windows.Forms.ListBox();
			this.pageBrowse = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.tabResults = new System.Windows.Forms.TabControl();
			this.pageAppearances = new System.Windows.Forms.TabPage();
			this.txtFormulaHuman = new System.Windows.Forms.TextBox();
			this.txtAppearance = new System.Windows.Forms.TextBox();
			this.lstAppearances = new System.Windows.Forms.ListView();
			this.pageWords = new System.Windows.Forms.TabPage();
			this.lstWords = new System.Windows.Forms.ListView();
			this.pageSenses = new System.Windows.Forms.TabPage();
			this.lstSenses = new System.Windows.Forms.ListView();
			this.pageAskTell = new System.Windows.Forms.TabPage();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.txtAskTellResults = new System.Windows.Forms.TextBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.txtTimeout = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtMaxAnswers = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnAsk = new System.Windows.Forms.Button();
			this.btnTell = new System.Windows.Forms.Button();
			this.txtAskTell = new System.Windows.Forms.TextBox();
			this.tabConsole = new System.Windows.Forms.TabPage();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.txtConsoleOutput = new System.Windows.Forms.TextBox();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnEvaluateCode = new System.Windows.Forms.Button();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openKBsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbKBs = new System.Windows.Forms.ComboBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1.SuspendLayout();
			this.tabSumo.SuspendLayout();
			this.pageManifest.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.pageBrowse.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tabResults.SuspendLayout();
			this.pageAppearances.SuspendLayout();
			this.pageWords.SuspendLayout();
			this.pageSenses.SuspendLayout();
			this.pageAskTell.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.tabConsole.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSearchByWord);
			this.groupBox1.Controls.Add(this.btnSearchByTerm);
			this.groupBox1.Controls.Add(this.txtWord);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtTerm);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(708, 78);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search";
			// 
			// btnSearchByWord
			// 
			this.btnSearchByWord.Enabled = false;
			this.btnSearchByWord.Location = new System.Drawing.Point(333, 46);
			this.btnSearchByWord.Name = "btnSearchByWord";
			this.btnSearchByWord.Size = new System.Drawing.Size(75, 23);
			this.btnSearchByWord.TabIndex = 6;
			this.btnSearchByWord.Text = "Show";
			this.btnSearchByWord.UseVisualStyleBackColor = true;
			this.btnSearchByWord.Click += new System.EventHandler(this.BtnSearchByWordClick);
			// 
			// btnSearchByTerm
			// 
			this.btnSearchByTerm.Enabled = false;
			this.btnSearchByTerm.Location = new System.Drawing.Point(333, 19);
			this.btnSearchByTerm.Name = "btnSearchByTerm";
			this.btnSearchByTerm.Size = new System.Drawing.Size(75, 23);
			this.btnSearchByTerm.TabIndex = 5;
			this.btnSearchByTerm.Text = "Show";
			this.btnSearchByTerm.UseVisualStyleBackColor = true;
			this.btnSearchByTerm.Click += new System.EventHandler(this.BtnSearchByTermClick);
			// 
			// txtWord
			// 
			this.txtWord.Location = new System.Drawing.Point(72, 48);
			this.txtWord.Name = "txtWord";
			this.txtWord.Size = new System.Drawing.Size(253, 20);
			this.txtWord.TabIndex = 3;
			this.txtWord.TextChanged += new System.EventHandler(this.TxtWordTextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Enter Word";
			// 
			// txtTerm
			// 
			this.txtTerm.Location = new System.Drawing.Point(72, 21);
			this.txtTerm.Name = "txtTerm";
			this.txtTerm.Size = new System.Drawing.Size(253, 20);
			this.txtTerm.TabIndex = 1;
			this.txtTerm.TextChanged += new System.EventHandler(this.TxtTermTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Term";
			// 
			// tabSumo
			// 
			this.tabSumo.Controls.Add(this.pageManifest);
			this.tabSumo.Controls.Add(this.pageBrowse);
			this.tabSumo.Controls.Add(this.pageAskTell);
			this.tabSumo.Controls.Add(this.tabConsole);
			this.tabSumo.Location = new System.Drawing.Point(12, 55);
			this.tabSumo.Name = "tabSumo";
			this.tabSumo.SelectedIndex = 0;
			this.tabSumo.Size = new System.Drawing.Size(728, 413);
			this.tabSumo.TabIndex = 0;
			// 
			// pageManifest
			// 
			this.pageManifest.Controls.Add(this.groupBox6);
			this.pageManifest.Controls.Add(this.groupBox4);
			this.pageManifest.Controls.Add(this.groupBox3);
			this.pageManifest.Controls.Add(this.groupBox2);
			this.pageManifest.Location = new System.Drawing.Point(4, 22);
			this.pageManifest.Name = "pageManifest";
			this.pageManifest.Size = new System.Drawing.Size(720, 387);
			this.pageManifest.TabIndex = 2;
			this.pageManifest.Text = "Manifest";
			this.pageManifest.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.lblStatsRelations);
			this.groupBox6.Controls.Add(this.lblStatsRules);
			this.groupBox6.Controls.Add(this.lblStatsAxioms);
			this.groupBox6.Controls.Add(this.lblStatsTerms);
			this.groupBox6.Location = new System.Drawing.Point(3, 247);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(714, 137);
			this.groupBox6.TabIndex = 3;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Statistics";
			// 
			// lblStatsRelations
			// 
			this.lblStatsRelations.Location = new System.Drawing.Point(7, 101);
			this.lblStatsRelations.Name = "lblStatsRelations";
			this.lblStatsRelations.Size = new System.Drawing.Size(166, 23);
			this.lblStatsRelations.TabIndex = 3;
			this.lblStatsRelations.Text = "Total Relations :";
			// 
			// lblStatsRules
			// 
			this.lblStatsRules.Location = new System.Drawing.Point(7, 74);
			this.lblStatsRules.Name = "lblStatsRules";
			this.lblStatsRules.Size = new System.Drawing.Size(166, 23);
			this.lblStatsRules.TabIndex = 2;
			this.lblStatsRules.Text = "Total Rules :";
			// 
			// lblStatsAxioms
			// 
			this.lblStatsAxioms.Location = new System.Drawing.Point(7, 47);
			this.lblStatsAxioms.Name = "lblStatsAxioms";
			this.lblStatsAxioms.Size = new System.Drawing.Size(166, 23);
			this.lblStatsAxioms.TabIndex = 1;
			this.lblStatsAxioms.Text = "Total Axioms :";
			// 
			// lblStatsTerms
			// 
			this.lblStatsTerms.Location = new System.Drawing.Point(7, 20);
			this.lblStatsTerms.Name = "lblStatsTerms";
			this.lblStatsTerms.Size = new System.Drawing.Size(166, 23);
			this.lblStatsTerms.TabIndex = 0;
			this.lblStatsTerms.Text = "Total Terms :";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnExport);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.cmbExportFormat);
			this.groupBox4.Controls.Add(this.btnBrowseExport);
			this.groupBox4.Controls.Add(this.txtExportFile);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Location = new System.Drawing.Point(372, 124);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(345, 117);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Export";
			// 
			// btnExport
			// 
			this.btnExport.Enabled = false;
			this.btnExport.Location = new System.Drawing.Point(61, 80);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 5;
			this.btnExport.Text = "Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.BtnExportClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 54);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "Format";
			// 
			// cmbExportFormat
			// 
			this.cmbExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbExportFormat.FormattingEnabled = true;
			this.cmbExportFormat.Items.AddRange(new object[] {
									"KIF",
									"OWL",
									"Prolog",
									"TPTP"});
			this.cmbExportFormat.Location = new System.Drawing.Point(60, 52);
			this.cmbExportFormat.Name = "cmbExportFormat";
			this.cmbExportFormat.Size = new System.Drawing.Size(81, 21);
			this.cmbExportFormat.TabIndex = 3;
			this.cmbExportFormat.SelectedIndexChanged += new System.EventHandler(this.CmbExportFormatSelectedIndexChanged);
			// 
			// btnBrowseExport
			// 
			this.btnBrowseExport.Location = new System.Drawing.Point(240, 25);
			this.btnBrowseExport.Name = "btnBrowseExport";
			this.btnBrowseExport.Size = new System.Drawing.Size(68, 23);
			this.btnBrowseExport.TabIndex = 2;
			this.btnBrowseExport.Text = "Browse";
			this.btnBrowseExport.UseVisualStyleBackColor = true;
			this.btnBrowseExport.Click += new System.EventHandler(this.BtnBrowseExportClick);
			// 
			// txtExportFile
			// 
			this.txtExportFile.Location = new System.Drawing.Point(61, 26);
			this.txtExportFile.Name = "txtExportFile";
			this.txtExportFile.Size = new System.Drawing.Size(173, 20);
			this.txtExportFile.TabIndex = 1;
			this.txtExportFile.TextChanged += new System.EventHandler(this.TxtExportFileTextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Save To";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblLoadConstituent);
			this.groupBox3.Controls.Add(this.btnLoadConstituent);
			this.groupBox3.Controls.Add(this.btnBrowseAddConstituent);
			this.groupBox3.Controls.Add(this.txtConstituentFileName);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Location = new System.Drawing.Point(3, 124);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(363, 117);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Add New Constituent";
			// 
			// lblLoadConstituent
			// 
			this.lblLoadConstituent.Location = new System.Drawing.Point(62, 88);
			this.lblLoadConstituent.Name = "lblLoadConstituent";
			this.lblLoadConstituent.Size = new System.Drawing.Size(100, 23);
			this.lblLoadConstituent.TabIndex = 4;
			this.lblLoadConstituent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnLoadConstituent
			// 
			this.btnLoadConstituent.Enabled = false;
			this.btnLoadConstituent.Location = new System.Drawing.Point(62, 54);
			this.btnLoadConstituent.Name = "btnLoadConstituent";
			this.btnLoadConstituent.Size = new System.Drawing.Size(75, 23);
			this.btnLoadConstituent.TabIndex = 3;
			this.btnLoadConstituent.Text = "Load";
			this.btnLoadConstituent.UseVisualStyleBackColor = true;
			this.btnLoadConstituent.Click += new System.EventHandler(this.BtnLoadConstituentClick);
			// 
			// btnBrowseAddConstituent
			// 
			this.btnBrowseAddConstituent.Location = new System.Drawing.Point(237, 24);
			this.btnBrowseAddConstituent.Name = "btnBrowseAddConstituent";
			this.btnBrowseAddConstituent.Size = new System.Drawing.Size(72, 23);
			this.btnBrowseAddConstituent.TabIndex = 2;
			this.btnBrowseAddConstituent.Text = "Browse";
			this.btnBrowseAddConstituent.UseVisualStyleBackColor = true;
			this.btnBrowseAddConstituent.Click += new System.EventHandler(this.BtnBrowseAddConstituentClick);
			// 
			// txtConstituentFileName
			// 
			this.txtConstituentFileName.Location = new System.Drawing.Point(62, 25);
			this.txtConstituentFileName.Name = "txtConstituentFileName";
			this.txtConstituentFileName.Size = new System.Drawing.Size(163, 20);
			this.txtConstituentFileName.TabIndex = 1;
			this.txtConstituentFileName.TextChanged += new System.EventHandler(this.TxtConstituentFileNameTextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Select File";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lstConstituents);
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(714, 115);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Constituents";
			// 
			// lstConstituents
			// 
			this.lstConstituents.FormattingEnabled = true;
			this.lstConstituents.Location = new System.Drawing.Point(7, 20);
			this.lstConstituents.Name = "lstConstituents";
			this.lstConstituents.Size = new System.Drawing.Size(401, 82);
			this.lstConstituents.TabIndex = 0;
			// 
			// pageBrowse
			// 
			this.pageBrowse.Controls.Add(this.groupBox5);
			this.pageBrowse.Controls.Add(this.groupBox1);
			this.pageBrowse.Location = new System.Drawing.Point(4, 22);
			this.pageBrowse.Name = "pageBrowse";
			this.pageBrowse.Padding = new System.Windows.Forms.Padding(3);
			this.pageBrowse.Size = new System.Drawing.Size(720, 387);
			this.pageBrowse.TabIndex = 0;
			this.pageBrowse.Text = "Browse";
			this.pageBrowse.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.tabResults);
			this.groupBox5.Location = new System.Drawing.Point(6, 90);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(708, 291);
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Query Results";
			// 
			// tabResults
			// 
			this.tabResults.Controls.Add(this.pageAppearances);
			this.tabResults.Controls.Add(this.pageWords);
			this.tabResults.Controls.Add(this.pageSenses);
			this.tabResults.Location = new System.Drawing.Point(6, 19);
			this.tabResults.Name = "tabResults";
			this.tabResults.SelectedIndex = 0;
			this.tabResults.Size = new System.Drawing.Size(696, 266);
			this.tabResults.TabIndex = 0;
			// 
			// pageAppearances
			// 
			this.pageAppearances.Controls.Add(this.txtFormulaHuman);
			this.pageAppearances.Controls.Add(this.txtAppearance);
			this.pageAppearances.Controls.Add(this.lstAppearances);
			this.pageAppearances.Location = new System.Drawing.Point(4, 22);
			this.pageAppearances.Name = "pageAppearances";
			this.pageAppearances.Padding = new System.Windows.Forms.Padding(3);
			this.pageAppearances.Size = new System.Drawing.Size(688, 240);
			this.pageAppearances.TabIndex = 0;
			this.pageAppearances.Text = "Appearances";
			this.pageAppearances.UseVisualStyleBackColor = true;
			// 
			// txtFormulaHuman
			// 
			this.txtFormulaHuman.Location = new System.Drawing.Point(410, 128);
			this.txtFormulaHuman.Multiline = true;
			this.txtFormulaHuman.Name = "txtFormulaHuman";
			this.txtFormulaHuman.ReadOnly = true;
			this.txtFormulaHuman.Size = new System.Drawing.Size(272, 106);
			this.txtFormulaHuman.TabIndex = 2;
			// 
			// txtAppearance
			// 
			this.txtAppearance.Location = new System.Drawing.Point(410, 7);
			this.txtAppearance.Multiline = true;
			this.txtAppearance.Name = "txtAppearance";
			this.txtAppearance.ReadOnly = true;
			this.txtAppearance.Size = new System.Drawing.Size(272, 114);
			this.txtAppearance.TabIndex = 1;
			// 
			// lstAppearances
			// 
			this.lstAppearances.AllowColumnReorder = true;
			this.lstAppearances.Location = new System.Drawing.Point(4, 7);
			this.lstAppearances.MultiSelect = false;
			this.lstAppearances.Name = "lstAppearances";
			this.lstAppearances.Size = new System.Drawing.Size(394, 227);
			this.lstAppearances.TabIndex = 0;
			this.lstAppearances.UseCompatibleStateImageBehavior = false;
			this.lstAppearances.View = System.Windows.Forms.View.Details;
			this.lstAppearances.SelectedIndexChanged += new System.EventHandler(this.LstAppearancesSelectedIndexChanged);
			// 
			// pageWords
			// 
			this.pageWords.Controls.Add(this.lstWords);
			this.pageWords.Location = new System.Drawing.Point(4, 22);
			this.pageWords.Name = "pageWords";
			this.pageWords.Padding = new System.Windows.Forms.Padding(3);
			this.pageWords.Size = new System.Drawing.Size(688, 240);
			this.pageWords.TabIndex = 1;
			this.pageWords.Text = "Words";
			this.pageWords.UseVisualStyleBackColor = true;
			// 
			// lstWords
			// 
			this.lstWords.Location = new System.Drawing.Point(4, 4);
			this.lstWords.Name = "lstWords";
			this.lstWords.Size = new System.Drawing.Size(678, 230);
			this.lstWords.TabIndex = 0;
			this.lstWords.UseCompatibleStateImageBehavior = false;
			this.lstWords.View = System.Windows.Forms.View.Details;
			// 
			// pageSenses
			// 
			this.pageSenses.Controls.Add(this.lstSenses);
			this.pageSenses.Location = new System.Drawing.Point(4, 22);
			this.pageSenses.Name = "pageSenses";
			this.pageSenses.Size = new System.Drawing.Size(688, 240);
			this.pageSenses.TabIndex = 2;
			this.pageSenses.Text = "Senses";
			this.pageSenses.UseVisualStyleBackColor = true;
			// 
			// lstSenses
			// 
			this.lstSenses.Location = new System.Drawing.Point(3, 3);
			this.lstSenses.Name = "lstSenses";
			this.lstSenses.Size = new System.Drawing.Size(312, 234);
			this.lstSenses.TabIndex = 0;
			this.lstSenses.UseCompatibleStateImageBehavior = false;
			this.lstSenses.View = System.Windows.Forms.View.Details;
			// 
			// pageAskTell
			// 
			this.pageAskTell.Controls.Add(this.groupBox8);
			this.pageAskTell.Controls.Add(this.groupBox7);
			this.pageAskTell.Location = new System.Drawing.Point(4, 22);
			this.pageAskTell.Name = "pageAskTell";
			this.pageAskTell.Padding = new System.Windows.Forms.Padding(3);
			this.pageAskTell.Size = new System.Drawing.Size(720, 387);
			this.pageAskTell.TabIndex = 1;
			this.pageAskTell.Text = "Ask / Tell";
			this.pageAskTell.UseVisualStyleBackColor = true;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.txtAskTellResults);
			this.groupBox8.Location = new System.Drawing.Point(7, 193);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(707, 191);
			this.groupBox8.TabIndex = 1;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Query Results";
			// 
			// txtAskTellResults
			// 
			this.txtAskTellResults.Location = new System.Drawing.Point(6, 19);
			this.txtAskTellResults.Multiline = true;
			this.txtAskTellResults.Name = "txtAskTellResults";
			this.txtAskTellResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtAskTellResults.Size = new System.Drawing.Size(695, 166);
			this.txtAskTellResults.TabIndex = 0;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.txtTimeout);
			this.groupBox7.Controls.Add(this.label8);
			this.groupBox7.Controls.Add(this.txtMaxAnswers);
			this.groupBox7.Controls.Add(this.label7);
			this.groupBox7.Controls.Add(this.btnAsk);
			this.groupBox7.Controls.Add(this.btnTell);
			this.groupBox7.Controls.Add(this.txtAskTell);
			this.groupBox7.Location = new System.Drawing.Point(7, 6);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(707, 181);
			this.groupBox7.TabIndex = 0;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Query";
			// 
			// txtTimeout
			// 
			this.txtTimeout.Location = new System.Drawing.Point(458, 43);
			this.txtTimeout.Name = "txtTimeout";
			this.txtTimeout.Size = new System.Drawing.Size(81, 20);
			this.txtTimeout.TabIndex = 6;
			this.txtTimeout.Text = "30";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(352, 46);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 5;
			this.label8.Text = "Timeout (secs)";
			// 
			// txtMaxAnswers
			// 
			this.txtMaxAnswers.Location = new System.Drawing.Point(458, 16);
			this.txtMaxAnswers.Name = "txtMaxAnswers";
			this.txtMaxAnswers.Size = new System.Drawing.Size(81, 20);
			this.txtMaxAnswers.TabIndex = 4;
			this.txtMaxAnswers.Text = "1";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(352, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 3;
			this.label7.Text = "Maximum Answers";
			// 
			// btnAsk
			// 
			this.btnAsk.Location = new System.Drawing.Point(352, 123);
			this.btnAsk.Name = "btnAsk";
			this.btnAsk.Size = new System.Drawing.Size(75, 23);
			this.btnAsk.TabIndex = 2;
			this.btnAsk.Text = "Ask";
			this.btnAsk.UseVisualStyleBackColor = true;
			this.btnAsk.Click += new System.EventHandler(this.BtnAskClick);
			// 
			// btnTell
			// 
			this.btnTell.Location = new System.Drawing.Point(351, 152);
			this.btnTell.Name = "btnTell";
			this.btnTell.Size = new System.Drawing.Size(75, 23);
			this.btnTell.TabIndex = 1;
			this.btnTell.Text = "Tell";
			this.btnTell.UseVisualStyleBackColor = true;
			this.btnTell.Click += new System.EventHandler(this.BtnTellClick);
			// 
			// txtAskTell
			// 
			this.txtAskTell.Location = new System.Drawing.Point(6, 19);
			this.txtAskTell.Multiline = true;
			this.txtAskTell.Name = "txtAskTell";
			this.txtAskTell.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtAskTell.Size = new System.Drawing.Size(339, 156);
			this.txtAskTell.TabIndex = 0;
			this.txtAskTell.Text = "(instance ?X Relation)";
			this.txtAskTell.TextChanged += new System.EventHandler(this.TxtAskTellTextChanged);
			// 
			// tabConsole
			// 
			this.tabConsole.Controls.Add(this.groupBox10);
			this.tabConsole.Controls.Add(this.groupBox9);
			this.tabConsole.Location = new System.Drawing.Point(4, 22);
			this.tabConsole.Name = "tabConsole";
			this.tabConsole.Size = new System.Drawing.Size(720, 387);
			this.tabConsole.TabIndex = 3;
			this.tabConsole.Text = "Console";
			this.tabConsole.UseVisualStyleBackColor = true;
			this.tabConsole.Click += new System.EventHandler(this.TabConsoleClick);
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.txtConsoleOutput);
			this.groupBox10.Location = new System.Drawing.Point(7, 184);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(710, 200);
			this.groupBox10.TabIndex = 3;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Output";
			// 
			// txtConsoleOutput
			// 
			this.txtConsoleOutput.Location = new System.Drawing.Point(6, 19);
			this.txtConsoleOutput.Multiline = true;
			this.txtConsoleOutput.Name = "txtConsoleOutput";
			this.txtConsoleOutput.ReadOnly = true;
			this.txtConsoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtConsoleOutput.Size = new System.Drawing.Size(698, 175);
			this.txtConsoleOutput.TabIndex = 0;
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.label9);
			this.groupBox9.Controls.Add(this.btnEvaluateCode);
			this.groupBox9.Controls.Add(this.txtCode);
			this.groupBox9.Location = new System.Drawing.Point(7, 3);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(710, 175);
			this.groupBox9.TabIndex = 2;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Code";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(413, 19);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(225, 23);
			this.label9.TabIndex = 3;
			this.label9.Text = "Boo : http://boo.codehaus.org";
			// 
			// btnEvaluateCode
			// 
			this.btnEvaluateCode.Location = new System.Drawing.Point(412, 146);
			this.btnEvaluateCode.Name = "btnEvaluateCode";
			this.btnEvaluateCode.Size = new System.Drawing.Size(75, 23);
			this.btnEvaluateCode.TabIndex = 2;
			this.btnEvaluateCode.Text = "Evaluate";
			this.btnEvaluateCode.UseVisualStyleBackColor = true;
			this.btnEvaluateCode.Click += new System.EventHandler(this.BtnEvaluateCodeClick);
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(6, 19);
			this.txtCode.Multiline = true;
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(400, 150);
			this.txtCode.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.editToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(752, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.openKBsToolStripMenuItem,
									this.preferencesToolStripMenuItem,
									this.toolStripMenuItem1,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openKBsToolStripMenuItem
			// 
			this.openKBsToolStripMenuItem.Name = "openKBsToolStripMenuItem";
			this.openKBsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.openKBsToolStripMenuItem.Text = "&Open KBs";
			this.openKBsToolStripMenuItem.Click += new System.EventHandler(this.OpenKBsToolStripMenuItemClick);
			// 
			// preferencesToolStripMenuItem
			// 
			this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.preferencesToolStripMenuItem.Text = "&Preferences";
			this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Knowledge Base";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbKBs
			// 
			this.cmbKBs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKBs.FormattingEnabled = true;
			this.cmbKBs.Location = new System.Drawing.Point(102, 31);
			this.cmbKBs.Name = "cmbKBs";
			this.cmbKBs.Size = new System.Drawing.Size(121, 21);
			this.cmbKBs.TabIndex = 3;
			this.cmbKBs.TabStop = false;
			this.cmbKBs.SelectedIndexChanged += new System.EventHandler(this.CmbKBsSelectedIndexChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.statusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 471);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(752, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(38, 17);
			this.statusLabel.Text = "Ready";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 493);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.cmbKBs);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tabSumo);
			this.Controls.Add(this.menuStrip1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "SumoGUI";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabSumo.ResumeLayout(false);
			this.pageManifest.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.pageBrowse.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.tabResults.ResumeLayout(false);
			this.pageAppearances.ResumeLayout(false);
			this.pageAppearances.PerformLayout();
			this.pageWords.ResumeLayout(false);
			this.pageSenses.ResumeLayout(false);
			this.pageAskTell.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.tabConsole.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnEvaluateCode;
		private System.Windows.Forms.TextBox txtConsoleOutput;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.TabPage tabConsole;
		private System.Windows.Forms.ListView lstSenses;
		private System.Windows.Forms.TabPage pageSenses;
		private System.Windows.Forms.TextBox txtMaxAnswers;
		private System.Windows.Forms.TextBox txtTimeout;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtAskTellResults;
		private System.Windows.Forms.Button btnTell;
		private System.Windows.Forms.Button btnAsk;
		private System.Windows.Forms.TextBox txtAskTell;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.TextBox txtFormulaHuman;
		private System.Windows.Forms.Label lblStatsTerms;
		private System.Windows.Forms.Label lblStatsAxioms;
		private System.Windows.Forms.Label lblStatsRules;
		private System.Windows.Forms.Label lblStatsRelations;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.ListView lstWords;
		private System.Windows.Forms.TabPage pageWords;
		private System.Windows.Forms.TextBox txtAppearance;
		private System.Windows.Forms.ListView lstAppearances;
		private System.Windows.Forms.TabControl tabResults;
		private System.Windows.Forms.TabPage pageAppearances;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btnSearchByTerm;
		private System.Windows.Forms.Button btnSearchByWord;
		private System.Windows.Forms.Button btnBrowseAddConstituent;
		private System.Windows.Forms.ComboBox cmbExportFormat;
		private System.Windows.Forms.TextBox txtExportFile;
		private System.Windows.Forms.Button btnBrowseExport;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabControl tabSumo;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Label lblLoadConstituent;
		private System.Windows.Forms.Button btnLoadConstituent;
		private System.Windows.Forms.ComboBox cmbKBs;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox lstConstituents;
		private System.Windows.Forms.TextBox txtConstituentFileName;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
		private System.Windows.Forms.TabPage pageBrowse;
		private System.Windows.Forms.TabPage pageManifest;
		private System.Windows.Forms.TabPage pageAskTell;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openKBsToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTerm;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtWord;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}
