
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

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
      ComponentResourceManager resources = new ComponentResourceManager(typeof (MainForm));
      this.tabControl = new TabControl();
      this.tabPageMain = new TabPage();
      this.numericUpDownThreshold = new NumericUpDown();
      this.labelThreshold = new Label();
      this.buttonSearch = new Button();
      this.richTextBoxData = new RichTextBox();
      this.labelData = new Label();
      this.textBoxQuery = new TextBox();
      this.labelQuery = new Label();
      this.tabPageResult = new TabPage();
      this.richTextBoxResult = new RichTextBox();
      this.tabControl.SuspendLayout();
      this.tabPageMain.SuspendLayout();
      this.numericUpDownThreshold.BeginInit();
      this.tabPageResult.SuspendLayout();
      this.SuspendLayout();
      this.tabControl.Controls.Add((Control) this.tabPageMain);
      this.tabControl.Controls.Add((Control) this.tabPageResult);
      this.tabControl.Location = new Point(4, 4);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new Size(452, 323);
      this.tabControl.TabIndex = 0;
      this.tabPageMain.Controls.Add((Control) this.numericUpDownThreshold);
      this.tabPageMain.Controls.Add((Control) this.labelThreshold);
      this.tabPageMain.Controls.Add((Control) this.buttonSearch);
      this.tabPageMain.Controls.Add((Control) this.richTextBoxData);
      this.tabPageMain.Controls.Add((Control) this.labelData);
      this.tabPageMain.Controls.Add((Control) this.textBoxQuery);
      this.tabPageMain.Controls.Add((Control) this.labelQuery);
      this.tabPageMain.Location = new Point(4, 22);
      this.tabPageMain.Name = "tabPageMain";
      this.tabPageMain.Padding = new Padding(3);
      this.tabPageMain.Size = new Size(444, 297);
      this.tabPageMain.TabIndex = 0;
      this.tabPageMain.Text = "Main";
      this.tabPageMain.UseVisualStyleBackColor = true;
      this.numericUpDownThreshold.Location = new Point(83, 75);
      this.numericUpDownThreshold.Name = "numericUpDownThreshold";
      this.numericUpDownThreshold.Size = new Size(59, 20);
      this.numericUpDownThreshold.TabIndex = 6;
      this.labelThreshold.Location = new Point(19, 77);
      this.labelThreshold.Name = "labelThreshold";
      this.labelThreshold.Size = new Size(58, 22);
      this.labelThreshold.TabIndex = 5;
      this.labelThreshold.Text = "Threshold:";
      this.buttonSearch.Location = new Point(188, 261);
      this.buttonSearch.Name = "buttonSearch";
      this.buttonSearch.Size = new Size(75, 23);
      this.buttonSearch.TabIndex = 4;
      this.buttonSearch.Text = "Search";
      this.buttonSearch.UseVisualStyleBackColor = true;
      this.buttonSearch.Click += new EventHandler(this.ButtonSearchClick);
      this.richTextBoxData.Location = new Point(19, 137);
      this.richTextBoxData.Name = "richTextBoxData";
      this.richTextBoxData.Size = new Size(409, 118);
      this.richTextBoxData.TabIndex = 3;
      this.richTextBoxData.Text = "Potato,1.0,2.0\nOnion,3.0,4.0";
      this.labelData.Location = new Point(19, 114);
      this.labelData.Name = "labelData";
      this.labelData.Size = new Size(51, 20);
      this.labelData.TabIndex = 2;
      this.labelData.Text = "Data:";
      this.labelData.Click += new EventHandler(this.LabelDataClick);
      this.textBoxQuery.Location = new Point(19, 40);
      this.textBoxQuery.Name = "textBoxQuery";
      this.textBoxQuery.Size = new Size(409, 20);
      this.textBoxQuery.TabIndex = 1;
      this.textBoxQuery.Text = "1.0,2.0";
      this.labelQuery.Location = new Point(19, 18);
      this.labelQuery.Name = "labelQuery";
      this.labelQuery.Size = new Size(84, 19);
      this.labelQuery.TabIndex = 0;
      this.labelQuery.Text = "Query:";
      this.tabPageResult.Controls.Add((Control) this.richTextBoxResult);
      this.tabPageResult.Location = new Point(4, 22);
      this.tabPageResult.Name = "tabPageResult";
      this.tabPageResult.Padding = new Padding(3);
      this.tabPageResult.Size = new Size(444, 297);
      this.tabPageResult.TabIndex = 1;
      this.tabPageResult.Text = "Result";
      this.tabPageResult.UseVisualStyleBackColor = true;
      this.richTextBoxResult.Location = new Point(6, 6);
      this.richTextBoxResult.Name = "richTextBoxResult";
      this.richTextBoxResult.Size = new Size(432, 285);
      this.richTextBoxResult.TabIndex = 0;
      this.richTextBoxResult.Text = "";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(461, 329);
      this.Controls.Add((Control) this.tabControl);
      this.Icon = (Icon) resources.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "ML+";
      this.tabControl.ResumeLayout(false);
      this.tabPageMain.ResumeLayout(false);
      this.tabPageMain.PerformLayout();
      this.numericUpDownThreshold.EndInit();
      this.tabPageResult.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
