/*
 * Created by SharpDevelop.
 * User: Mirzakhmet
 * Date: 2/27/2022
 * Time: 11:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MLPlus
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		void ButtonSearchClick(object sender, EventArgs e)
		{
			string[] a = textBoxQuery.Text.Split(new char[] { ',' });
			float[] b = new float[a.Length];
			
			for (int i = 0; i < a.Length; ++i) {
				b[i] = float.Parse(a[i]);
			}
			
			float p = (float) numericUpDownThreshold.Value;
			
			p /= 100;
			
			string[] c = richTextBoxData.Text.Split(new char[] { '\n' });
			
			richTextBoxResult.Text = "";
			
			foreach (string d in c) {
				string[] g = d.Split(new char[] { ',' });
				
				for (int i = 0; i < g.Length; ++i) {
					g[i] = g[i].Trim();
				}
				
				string name = g[0];
				
				float[] f = new float[g.Length - 1];
				
				for (int i = 1; i < g.Length; ++i) {
					f[i - 1] = float.Parse(g[i]);
				}
				
				bool found = true;
				
				for (int i = 0; i < b.Length; ++i) {
					if ((Math.Abs(b[i] - f[i]) / Math.Max(b[i], f[i])) > p) {
						found = false;
						
						break;
					}
				}
				
				if (found) {
					richTextBoxResult.Text += name + "\n";
				}
			}
		}
		
		void LabelDataClick(object sender, EventArgs e)
		{
			
		}
	}
}
