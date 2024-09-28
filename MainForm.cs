
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#if TRIAL
using Microsoft.Win32;
#endif

namespace MLPlus
{
  public class MainForm : Form
  {
    private IContainer components;
    private Label labelThreshold;
    private NumericUpDown numericUpDownThreshold;
    private Button buttonSearch;
    private RichTextBox richTextBoxResult;
    private Label labelData;
    private RichTextBox richTextBoxData;
    private Label labelQuery;
    private TextBox textBoxQuery;
    private TabPage tabPageResult;
    private TabPage tabPageMain;
    private TabControl tabControl;

    #if TRIAL
    public void CheckRuns() {
		try {
			RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\OVG-Developers", true);
			
			int runs = -1;
			
			if (key != null && key.GetValue("Runs") != null) {
				runs = (int) key.GetValue("Runs");
			} else {
				key = Registry.CurrentUser.CreateSubKey("Software\\OVG-Developers");
			}
			
			runs = runs + 1;
			
			key.SetValue("Runs", runs);
			
			if (runs > 10) {
				System.Windows.Forms.MessageBox.Show("Number of runs expired.\n"
							+ "Please register the application (visit https://ovg-developers.mystrikingly.com/ for purchase).");
				
				Environment.Exit(0);
			}
		} catch (Exception e) {
			Console.WriteLine(e.Message);
		}
	}
	
	public bool IsRegistered() {
		try {
			RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\OVG-Developers");
			
			if (key != null && key.GetValue("Registered") != null) {
				return true;
			}
		} catch (Exception e) {
			Console.WriteLine(e.Message);
		}
		
		return false;
	}
    #endif
    
    public MainForm() {
    	this.InitializeComponent();
    }

    private void ButtonSearchClick(object sender, EventArgs e)
    {
      string[] strArray1 = this.textBoxQuery.Text.Split(',');
      float[] numArray1 = new float[strArray1.Length];
      for (int index = 0; index < strArray1.Length; ++index)
        numArray1[index] = float.Parse(strArray1[index]);
      float num = (float) this.numericUpDownThreshold.Value / 100f;
      string[] strArray2 = this.richTextBoxData.Text.Split('\n');
      this.richTextBoxResult.Text = "";
      foreach (string str1 in strArray2)
      {
        char[] chArray = new char[1]{ ',' };
        string[] strArray3 = str1.Split(chArray);
        for (int index = 0; index < strArray3.Length; ++index)
          strArray3[index] = strArray3[index].Trim();
        string str2 = strArray3[0];
        float[] numArray2 = new float[strArray3.Length - 1];
        for (int index = 1; index < strArray3.Length; ++index)
          numArray2[index - 1] = float.Parse(strArray3[index]);
        bool flag = true;
        for (int index = 0; index < numArray1.Length; ++index)
        {
          if ((double) Math.Abs(numArray1[index] - numArray2[index]) / (double) Math.Max(numArray1[index], numArray2[index]) > (double) num)
          {
            flag = false;
            break;
          }
        }
        if (flag)
        {
          RichTextBox richTextBoxResult = this.richTextBoxResult;
          richTextBoxResult.Text = richTextBoxResult.Text + str2 + "\n";
        }
      }
    }

    private void LabelDataClick(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
    	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
    	this.tabControl = new System.Windows.Forms.TabControl();
    	this.tabPageMain = new System.Windows.Forms.TabPage();
    	this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
    	this.labelThreshold = new System.Windows.Forms.Label();
    	this.buttonSearch = new System.Windows.Forms.Button();
    	this.richTextBoxData = new System.Windows.Forms.RichTextBox();
    	this.labelData = new System.Windows.Forms.Label();
    	this.textBoxQuery = new System.Windows.Forms.TextBox();
    	this.labelQuery = new System.Windows.Forms.Label();
    	this.tabPageResult = new System.Windows.Forms.TabPage();
    	this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
    	this.tabControl.SuspendLayout();
    	this.tabPageMain.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
    	this.tabPageResult.SuspendLayout();
    	this.SuspendLayout();
    	// 
    	// tabControl
    	// 
    	this.tabControl.Controls.Add(this.tabPageMain);
    	this.tabControl.Controls.Add(this.tabPageResult);
    	this.tabControl.Location = new System.Drawing.Point(5, 5);
    	this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    	this.tabControl.Name = "tabControl";
    	this.tabControl.SelectedIndex = 0;
    	this.tabControl.Size = new System.Drawing.Size(603, 398);
    	this.tabControl.TabIndex = 0;
    	// 
    	// tabPageMain
    	// 
    	this.tabPageMain.Controls.Add(this.numericUpDownThreshold);
    	this.tabPageMain.Controls.Add(this.labelThreshold);
    	this.tabPageMain.Controls.Add(this.buttonSearch);
    	this.tabPageMain.Controls.Add(this.richTextBoxData);
    	this.tabPageMain.Controls.Add(this.labelData);
    	this.tabPageMain.Controls.Add(this.textBoxQuery);
    	this.tabPageMain.Controls.Add(this.labelQuery);
    	this.tabPageMain.Location = new System.Drawing.Point(4, 25);
    	this.tabPageMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    	this.tabPageMain.Name = "tabPageMain";
    	this.tabPageMain.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
    	this.tabPageMain.Size = new System.Drawing.Size(595, 369);
    	this.tabPageMain.TabIndex = 0;
    	this.tabPageMain.Text = "Main";
    	this.tabPageMain.UseVisualStyleBackColor = true;
    	// 
    	// numericUpDownThreshold
    	// 
    	this.numericUpDownThreshold.Location = new System.Drawing.Point(111, 92);
    	this.numericUpDownThreshold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    	this.numericUpDownThreshold.Name = "numericUpDownThreshold";
    	this.numericUpDownThreshold.Size = new System.Drawing.Size(79, 22);
    	this.numericUpDownThreshold.TabIndex = 6;
    	// 
    	// labelThreshold
    	// 
    	this.labelThreshold.Location = new System.Drawing.Point(25, 95);
    	this.labelThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    	this.labelThreshold.Name = "labelThreshold";
    	this.labelThreshold.Size = new System.Drawing.Size(77, 27);
    	this.labelThreshold.TabIndex = 5;
    	this.labelThreshold.Text = "Threshold:";
    	// 
    	// buttonSearch
    	// 
    	this.buttonSearch.Location = new System.Drawing.Point(251, 321);
    	this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    	this.buttonSearch.Name = "buttonSearch";
    	this.buttonSearch.Size = new System.Drawing.Size(100, 28);
    	this.buttonSearch.TabIndex = 4;
    	this.buttonSearch.Text = "Search";
    	this.buttonSearch.UseVisualStyleBackColor = true;
    	this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
    	// 
    	// richTextBoxData
    	// 
    	this.richTextBoxData.Location = new System.Drawing.Point(25, 169);
    	this.richTextBoxData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    	this.richTextBoxData.Name = "richTextBoxData";
    	this.richTextBoxData.Size = new System.Drawing.Size(544, 144);
    	this.richTextBoxData.TabIndex = 3;
    	this.richTextBoxData.Text = "Potato,1.0,2.0\nOnion,3.0,4.0";
    	// 
    	// labelData
    	// 
    	this.labelData.Location = new System.Drawing.Point(25, 140);
    	this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    	this.labelData.Name = "labelData";
    	this.labelData.Size = new System.Drawing.Size(68, 25);
    	this.labelData.TabIndex = 2;
    	this.labelData.Text = "Data:";
    	this.labelData.Click += new System.EventHandler(this.LabelDataClick);
    	// 
    	// textBoxQuery
    	// 
    	this.textBoxQuery.Location = new System.Drawing.Point(25, 49);
    	this.textBoxQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    	this.textBoxQuery.Name = "textBoxQuery";
    	this.textBoxQuery.Size = new System.Drawing.Size(544, 22);
    	this.textBoxQuery.TabIndex = 1;
    	this.textBoxQuery.Text = "1.0,2.0";
    	// 
    	// labelQuery
    	// 
    	this.labelQuery.Location = new System.Drawing.Point(25, 22);
    	this.labelQuery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    	this.labelQuery.Name = "labelQuery";
    	this.labelQuery.Size = new System.Drawing.Size(112, 23);
    	this.labelQuery.TabIndex = 0;
    	this.labelQuery.Text = "Query:";
    	// 
    	// tabPageResult
    	// 
    	this.tabPageResult.Controls.Add(this.richTextBoxResult);
    	this.tabPageResult.Location = new System.Drawing.Point(4, 25);
    	this.tabPageResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    	this.tabPageResult.Name = "tabPageResult";
    	this.tabPageResult.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
    	this.tabPageResult.Size = new System.Drawing.Size(595, 369);
    	this.tabPageResult.TabIndex = 1;
    	this.tabPageResult.Text = "Result";
    	this.tabPageResult.UseVisualStyleBackColor = true;
    	// 
    	// richTextBoxResult
    	// 
    	this.richTextBoxResult.Location = new System.Drawing.Point(8, 7);
    	this.richTextBoxResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    	this.richTextBoxResult.Name = "richTextBoxResult";
    	this.richTextBoxResult.Size = new System.Drawing.Size(575, 350);
    	this.richTextBoxResult.TabIndex = 0;
    	this.richTextBoxResult.Text = "";
    	// 
    	// MainForm
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.ClientSize = new System.Drawing.Size(615, 405);
    	this.Controls.Add(this.tabControl);
    	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
    	this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    	this.MaximizeBox = false;
    	this.MinimizeBox = false;
    	this.Name = "MainForm";
    	this.Text = "ML+";
    	this.Shown += new System.EventHandler(this.MainFormShown);
    	this.tabControl.ResumeLayout(false);
    	this.tabPageMain.ResumeLayout(false);
    	this.tabPageMain.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
    	this.tabPageResult.ResumeLayout(false);
    	this.ResumeLayout(false);

    }
		void MainFormShown(object sender, EventArgs e)
		{
			#if TRIAL
			if (!IsRegistered()) {
				CheckRuns();
    		}
			#endif
		}
  }
}
