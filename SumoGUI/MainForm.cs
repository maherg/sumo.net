/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 12/29/2007
 * Time: 1:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;
using SumoNET;
using Boo.Lang.Interpreter;
using Boo.Lang.Compiler;

namespace SumoGUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static string _kbDir;
		public static KnowledgeBase _kb;
		private ArrayList _appearances;
		private ArrayList _words;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}	
		
		void MainFormLoad(object sender, EventArgs e)
		{
			DisableFormControls();
			lstAppearances.Columns.Add("Source", -2, HorizontalAlignment.Left);
			lstAppearances.Columns.Add("Argument No.", -2, HorizontalAlignment.Left);
			lstWords.Columns.Add("Synset ID", -2, HorizontalAlignment.Left);
			lstWords.Columns.Add("Word", -2, HorizontalAlignment.Left);
			lstSenses.Columns.Add("Word", -2 , HorizontalAlignment.Left);
			lstSenses.Columns.Add("Type", -2 , HorizontalAlignment.Left);
			lstSenses.Columns.Add("Synset ID", -2, HorizontalAlignment.Left);
			lstSenses.Columns.Add("SUMO", -2 , HorizontalAlignment.Left);
			tabResults.TabPages.Clear();
		}
		
		void BtnLoadConstituentClick(object sender, EventArgs e)
		{
			statusLabel.Text = "Loading new constituent...";
			DisableFormControls();
			_kb.Constituents.Add(txtConstituentFileName.Text);
			SUMO.WriteConfiguration();
			if(SUMO.Preferences["cache"].ToLower() == "yes".ToLower())
			{
				_kb.Cache();
			}
			_kb.LoadInferenceEngine();
			PopulateManifest();
			EnableFormControls();
			MessageBox.Show("Constituent Added !");
			statusLabel.Text = "Ready";
		}
		
		void OpenKBsToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				_kbDir = folderBrowserDialog1.SelectedPath;
//				ThreadStart ths = new ThreadStart(InitSumo);
//				Thread th = new Thread(ths);
//				th.Start();
				InitSumo();
			}
		}
		
		void InitSumo()
		{
			statusLabel.Text = "Initializing SUMO";
			DisableFormControls();
			SUMO.Init(_kbDir);
			cmbKBs.Items.Clear();
			foreach(KnowledgeBase kb in SUMO.KnowledgeBases)
			{
				cmbKBs.Items.Add(kb.Name);
			}
			if(cmbKBs.Items.Count > 0)
			{
				cmbKBs.SelectedIndex = 0;
				string kbName = cmbKBs.Items[cmbKBs.SelectedIndex].ToString();
				_kb = SUMO.KnowledgeBases[kbName];
				PopulateManifest();
				EnableFormControls();
				statusLabel.Text = "Ready";
			}
			else
			{
				statusLabel.Text = "No KnowledgeBases Found";
			}
		}
		
		void DisableFormControls()
		{
			tabSumo.Enabled = false;
		}
		
		void EnableFormControls()
		{
			tabSumo.Enabled = true;
		}
		
		void PopulateManifest()
		{
			SetKBStats();
			lstConstituents.Items.Clear();
			foreach(Constituent c in _kb.Constituents)
			{
				lstConstituents.Items.Add(c.Path);
			}
			lstConstituents.Refresh();
			txtConstituentFileName.Text = "";
		}
		
		void SetKBStats()
		{
			lblStatsTerms.Text = "Total Terms : " + _kb.Terms.Count.ToString();
			lblStatsAxioms.Text = "Total Axioms : " + _kb.Axioms.Count.ToString();
			lblStatsRules.Text = "Total Rules : " + _kb.Rules.Count.ToString();
			lblStatsRelations.Text = "Total Relations : " + _kb.Relations.Count.ToString();
		}
		
		void CmbKBsSelectedIndexChanged(object sender, EventArgs e)
		{
			string kbName = cmbKBs.Items[cmbKBs.SelectedIndex].ToString();
			_kb = SUMO.KnowledgeBases[kbName];
			PopulateManifest();
		}
		
		void BtnBrowseExportClick(object sender, EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string filename = saveFileDialog1.FileName;
				txtExportFile.Text = filename;
			}
		}
		
		void TxtExportFileTextChanged(object sender, EventArgs e)
		{
			if(txtExportFile.Text != "" && cmbExportFormat.SelectedIndex >= 0)
			{
				btnExport.Enabled = true;
			}
			else
			{
				btnExport.Enabled = false;
			}
		}
		
		void CmbExportFormatSelectedIndexChanged(object sender, EventArgs e)
		{
			if(txtExportFile.Text != "" && cmbExportFormat.SelectedIndex >= 0)
			{
				btnExport.Enabled = true;
			}
			else
			{
				btnExport.Enabled = false;
			}
		}
		
		void BtnExportClick(object sender, EventArgs e)
		{
			string filename = txtExportFile.Text;
			string format = cmbExportFormat.Items[cmbExportFormat.SelectedIndex].ToString();
			DisableFormControls();
			switch(format)
			{
				case "OWL":
					statusLabel.Text = "Saving As OWL...";
					_kb.SaveAsOwl(filename);
					break;
				case "KIF":
					statusLabel.Text = "Saving As KIF...";
					_kb.SaveAsKIF(filename);
					break;
				case "TPTP":
					statusLabel.Text = "Saving As TPTP...";
					_kb.SaveAsTptp(filename);
					break;
				case "Prolog":
					statusLabel.Text = "Saving As Prolog...";
					_kb.SaveAsProlog(filename);
					break;
				default:
					return;
			}
			MessageBox.Show("Export Complete !");
			EnableFormControls();
			statusLabel.Text = "Ready";
		}
		
		void TxtConstituentFileNameTextChanged(object sender, EventArgs e)
		{
			if(txtConstituentFileName.Text == "")
			{
				btnLoadConstituent.Enabled = false;
			}
			else
			{
				btnLoadConstituent.Enabled = true;
			}
		}
		
		void BtnBrowseAddConstituentClick(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string consFile = openFileDialog1.FileName;
				txtConstituentFileName.Text = consFile;
			}
		}
		
		void BtnSearchByTermClick(object sender, EventArgs e)
		{
			DisableFormControls();
			//AddRemove Tab pages
			tabResults.TabPages.Clear();
			tabResults.TabPages.Add(pageAppearances);
			tabResults.TabPages.Add(pageWords);
			pageAppearances.Visible = true;
			pageWords.Visible = true;
			Term term = _kb.Terms[txtTerm.Text];
			if(term == null)
			{
				// Show Nearest Relations
				pageAppearances.Visible = false;
				pageWords.Visible = false;
				// 
			}
			else
			{
				// Show appearances
				pageAppearances.Visible = true;
				pageWords.Visible = true;
				//
				lstAppearances.Items.Clear();
				_appearances = new ArrayList();
				Hashtable apps = term.Appearances;
				foreach(int arg in apps.Keys)
				{
					ArrayList list = (ArrayList)apps[arg];
					foreach(Formula f in list)
					{
						string loc = f.SourceFile.Substring(f.SourceFile.LastIndexOf(Path.DirectorySeparatorChar) + 1) + " (" + f.StartLine + "-" + f.EndLine + ")";
						ListViewItem item = new ListViewItem(loc);
						item.SubItems.Add(arg.ToString());
						lstAppearances.Items.Add(item);
						_appearances.Add(f);
					}
				}
				// Show synsets
				lstWords.Items.Clear();
				_words = term.Words;
				foreach(Word w in _words)
				{
					ListViewItem item = new ListViewItem(w.Synset.ID);
					item.SubItems.Add(w.Text.Replace('_', ' '));
					lstWords.Items.Add(item);
				}
			}
			EnableFormControls();
		}
		
		void BtnSearchByWordClick(object sender, EventArgs e)
		{
			DisableFormControls();
			//AddRemove Tab pages
			tabResults.TabPages.Clear();
			tabResults.TabPages.Add(pageSenses);
			lstSenses.Items.Clear();
			string mixedCase = txtWord.Text;
			string input = mixedCase.Replace(' ', '_').ToLower();
			
			Hashtable table = SUMO.WordNet.GetSensesFromWord(mixedCase);
			foreach(string w in table.Keys)
			{
				foreach(string s in (ArrayList)table[w])
				{
					foreach(string term in SUMO.WordNet.GetSUMOTerm(new Synset(s)))
					{
						string currentTerm = term;
						currentTerm = currentTerm.Replace("&", "");
						currentTerm = currentTerm.Replace("%", "");
						currentTerm = currentTerm.Replace("+", "");
						currentTerm = currentTerm.Replace("=", "");
						currentTerm = currentTerm.Replace("@", "");
						ListViewItem item = new ListViewItem(w.Replace("_", " "));
						item.SubItems.Add(PosToString((SpeechTypes)Int32.Parse(s[0].ToString())));
						item.SubItems.Add(s.Substring(1));
						item.SubItems.Add(currentTerm);
						lstSenses.Items.Add(item);
					}
				}
			}
			EnableFormControls();
		}
		
		string PosToString(SpeechTypes pos)
		{
			switch(pos)
			{
				case SpeechTypes.Noun:
					return "Noun";
				case SpeechTypes.Verb:
					return "Verb";
				case SpeechTypes.Adjective:
					return "Adjective";
				case SpeechTypes.Adverb:
					return "Adverb";
				default:
					return "Unknown";
			}
		}
		
		void TxtTermTextChanged(object sender, EventArgs e)
		{
			if(txtTerm.Text == "")
			{
				btnSearchByTerm.Enabled = false;
			}
			else
			{
				btnSearchByTerm.Enabled = true;
			}
		}
		
		void TxtWordTextChanged(object sender, EventArgs e)
		{
			if(txtWord.Text != "")
			{
				btnSearchByWord.Enabled = true;
			}
			else
			{
				btnSearchByWord.Enabled = false;
			}
		}
		
		void CmbWordTypeSelectedIndexChanged(object sender, EventArgs e)
		{
			if(txtWord.Text != "")
			{
				btnSearchByWord.Enabled = true;
			}
			else
			{
				btnSearchByWord.Enabled = false;
			}
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void PreferencesToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void LstAppearancesSelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstAppearances.SelectedIndices.Count == 0) return;
			int index = lstAppearances.SelectedIndices[0];
			Formula f = (Formula)_appearances[index];
			txtAppearance.Text = f.Text;
			
		}
		
		bool ParseAskTell()
		{
			txtAskTellResults.Text = "";
			string msg = Formula.Parse(txtAskTell.Text);
			if(msg == null)
			{
				return true;
			}
			else
			{
				txtAskTellResults.Text += msg;
				return false;
			}
		}
		
		void BtnAskClick(object sender, EventArgs e)
		{
			if(!ParseAskTell()) return;
			KnowledgeInterchangeFormat kif = new KnowledgeInterchangeFormat();
			kif.Parse(txtAskTell.Text);
			int maxAnswers = Int32.Parse(txtMaxAnswers.Text);
			int timeout = Int32.Parse(txtTimeout.Text);
			txtAskTellResults.Text = _kb.Ask(txtAskTell.Text, timeout, maxAnswers).Replace("\n", "\r\n");
		}
		
		void BtnTellClick(object sender, EventArgs e)
		{
			if(!ParseAskTell()) return;
		}
		
		void TxtAskTellTextChanged(object sender, EventArgs e)
		{
			if(txtAskTell.Text == "")
			{
				btnAsk.Enabled = false;
				btnTell.Enabled = false;
			}
			else
			{
				btnAsk.Enabled = true;
				btnTell.Enabled = true;
			}
		}
		
		void TabConsoleClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnEvaluateCodeClick(object sender, EventArgs e)
		{
			InteractiveInterpreter ii = new InteractiveInterpreter();
			ii.References.Add(System.Reflection.Assembly.GetExecutingAssembly());
			ii.Ducky = true;
			ii.SetValue("console", "");
			CompilerContext cx = ii.Eval(txtCode.Text);
			if(cx.Errors.Count > 0)
			{
				txtConsoleOutput.Text = cx.Errors.ToString();
			}
			else
			{
				txtConsoleOutput.Text = ii.GetValue("console").ToString();
			}
		}
	}
}
