/*
 * Created by SharpDevelop.
 * User: Mirzakhmet
 * Date: 2/27/2022
 * Time: 11:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MLPlus
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
			this.tabControl.Location = new System.Drawing.Point(4, 4);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(452, 323);
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
			this.tabPageMain.Location = new System.Drawing.Point(4, 22);
			this.tabPageMain.Name = "tabPageMain";
			this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMain.Size = new System.Drawing.Size(444, 297);
			this.tabPageMain.TabIndex = 0;
			this.tabPageMain.Text = "Main";
			this.tabPageMain.UseVisualStyleBackColor = true;
			// 
			// numericUpDownThreshold
			// 
			this.numericUpDownThreshold.Location = new System.Drawing.Point(83, 75);
			this.numericUpDownThreshold.Name = "numericUpDownThreshold";
			this.numericUpDownThreshold.Size = new System.Drawing.Size(59, 20);
			this.numericUpDownThreshold.TabIndex = 6;
			// 
			// labelThreshold
			// 
			this.labelThreshold.Location = new System.Drawing.Point(19, 77);
			this.labelThreshold.Name = "labelThreshold";
			this.labelThreshold.Size = new System.Drawing.Size(58, 22);
			this.labelThreshold.TabIndex = 5;
			this.labelThreshold.Text = "Threshold:";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(188, 261);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 4;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
			// 
			// richTextBoxData
			// 
			this.richTextBoxData.Location = new System.Drawing.Point(19, 137);
			this.richTextBoxData.Name = "richTextBoxData";
			this.richTextBoxData.Size = new System.Drawing.Size(409, 118);
			this.richTextBoxData.TabIndex = 3;
			this.richTextBoxData.Text = "Potato,1.0,2.0\nOnion,3.0,4.0";
			// 
			// labelData
			// 
			this.labelData.Location = new System.Drawing.Point(19, 114);
			this.labelData.Name = "labelData";
			this.labelData.Size = new System.Drawing.Size(51, 20);
			this.labelData.TabIndex = 2;
			this.labelData.Text = "Data:";
			this.labelData.Click += new System.EventHandler(this.LabelDataClick);
			// 
			// textBoxQuery
			// 
			this.textBoxQuery.Location = new System.Drawing.Point(19, 40);
			this.textBoxQuery.Name = "textBoxQuery";
			this.textBoxQuery.Size = new System.Drawing.Size(409, 20);
			this.textBoxQuery.TabIndex = 1;
			this.textBoxQuery.Text = "1.0,2.0";
			// 
			// labelQuery
			// 
			this.labelQuery.Location = new System.Drawing.Point(19, 18);
			this.labelQuery.Name = "labelQuery";
			this.labelQuery.Size = new System.Drawing.Size(84, 19);
			this.labelQuery.TabIndex = 0;
			this.labelQuery.Text = "Query:";
			// 
			// tabPageResult
			// 
			this.tabPageResult.Controls.Add(this.richTextBoxResult);
			this.tabPageResult.Location = new System.Drawing.Point(4, 22);
			this.tabPageResult.Name = "tabPageResult";
			this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageResult.Size = new System.Drawing.Size(444, 297);
			this.tabPageResult.TabIndex = 1;
			this.tabPageResult.Text = "Result";
			this.tabPageResult.UseVisualStyleBackColor = true;
			// 
			// richTextBoxResult
			// 
			this.richTextBoxResult.Location = new System.Drawing.Point(6, 6);
			this.richTextBoxResult.Name = "richTextBoxResult";
			this.richTextBoxResult.Size = new System.Drawing.Size(432, 285);
			this.richTextBoxResult.TabIndex = 0;
			this.richTextBoxResult.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 329);
			this.Controls.Add(this.tabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "ML+";
			this.tabControl.ResumeLayout(false);
			this.tabPageMain.ResumeLayout(false);
			this.tabPageMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
			this.tabPageResult.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelThreshold;
		private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.RichTextBox richTextBoxResult;
		private System.Windows.Forms.Label labelData;
		private System.Windows.Forms.RichTextBox richTextBoxData;
		private System.Windows.Forms.Label labelQuery;
		private System.Windows.Forms.TextBox textBoxQuery;
		private System.Windows.Forms.TabPage tabPageResult;
		private System.Windows.Forms.TabPage tabPageMain;
		private System.Windows.Forms.TabControl tabControl;
	}
}
