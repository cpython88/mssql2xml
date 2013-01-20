using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using System.IO;

namespace XMLConverter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.SaveFileDialog save;
		private System.Windows.Forms.TextBox database;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtquery;
		private System.Windows.Forms.TextBox txtpath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtuid;
		private System.Windows.Forms.TextBox txtpw;
		private System.Windows.Forms.DataGrid dg;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox dsname;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.dg = new System.Windows.Forms.DataGrid();
			this.button1 = new System.Windows.Forms.Button();
			this.txtpath = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.save = new System.Windows.Forms.SaveFileDialog();
			this.txtquery = new System.Windows.Forms.TextBox();
			this.database = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtuid = new System.Windows.Forms.TextBox();
			this.txtpw = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dsname = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.SuspendLayout();
			// 
			// dg
			// 
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dg.DataMember = "";
			this.dg.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg.Location = new System.Drawing.Point(8, 128);
			this.dg.Name = "dg";
			this.dg.Size = new System.Drawing.Size(468, 176);
			this.dg.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(400, 84);
			this.button1.Name = "button1";
			this.button1.TabIndex = 7;
			this.button1.Text = "To &XML";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtpath
			// 
			this.txtpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtpath.Location = new System.Drawing.Point(8, 4);
			this.txtpath.Name = "txtpath";
			this.txtpath.Size = new System.Drawing.Size(384, 20);
			this.txtpath.TabIndex = 0;
			this.txtpath.Text = "";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(400, 4);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "&Browse...";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// save
			// 
			this.save.DefaultExt = "xml";
			this.save.Filter = "XML|*.xml|All files|*.*";
			// 
			// txtquery
			// 
			this.txtquery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtquery.Location = new System.Drawing.Point(8, 68);
			this.txtquery.Multiline = true;
			this.txtquery.Name = "txtquery";
			this.txtquery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtquery.Size = new System.Drawing.Size(384, 56);
			this.txtquery.TabIndex = 6;
			this.txtquery.Text = "select * from customers";
			// 
			// database
			// 
			this.database.Location = new System.Drawing.Point(64, 36);
			this.database.Name = "database";
			this.database.TabIndex = 2;
			this.database.Text = "northwind";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "database:";
			// 
			// txtuid
			// 
			this.txtuid.Location = new System.Drawing.Point(192, 36);
			this.txtuid.Name = "txtuid";
			this.txtuid.Size = new System.Drawing.Size(64, 20);
			this.txtuid.TabIndex = 3;
			this.txtuid.Text = "sa";
			// 
			// txtpw
			// 
			this.txtpw.Location = new System.Drawing.Point(288, 38);
			this.txtpw.Name = "txtpw";
			this.txtpw.PasswordChar = '*';
			this.txtpw.Size = new System.Drawing.Size(64, 20);
			this.txtpw.TabIndex = 4;
			this.txtpw.Text = "123";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "uid:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(264, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "pw: ";
			// 
			// dsname
			// 
			this.dsname.Location = new System.Drawing.Point(400, 38);
			this.dsname.Name = "dsname";
			this.dsname.Size = new System.Drawing.Size(72, 20);
			this.dsname.TabIndex = 5;
			this.dsname.Text = "dataset name";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(356, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 12;
			this.label4.Text = "dataset";
			// 
			// Form1
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 309);
			this.Controls.Add(this.dsname);
			this.Controls.Add(this.txtuid);
			this.Controls.Add(this.txtpw);
			this.Controls.Add(this.database);
			this.Controls.Add(this.txtquery);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtpath);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MSSQL --> XML Converter";
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button2_Click(object sender, System.EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;

			if(save.ShowDialog() == DialogResult.OK) {
				txtpath.Text = save.FileName;
			}

			Cursor.Current = Cursors.Default;
		}

		private void button1_Click(object sender, System.EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;

			DataSet ds = new DataSet("SetName");
			string cs = "SERVER=.;UID="
				+txtuid.Text.Trim()
				+";PWD="
				+txtpw.Text.Trim()
				+";DATABASE=" 
				+database.Text.Trim() 
				+";";
			string query = txtquery.Text.Trim();
			SqlConnection conn = new SqlConnection(cs);
			Form2 f = new Form2();
			Regex r = new Regex(@"from\s+(\w+,?){1,2}", RegexOptions.IgnoreCase | RegexOptions.Multiline);
			MatchCollection m;
			StreamWriter sw = null;

			try {
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(query,conn);
				da.TableMappings.Add("Table","Bill");
				da.TableMappings.Add("Table1","Bill_Name");
//				ds.DataSetName = name.Text.Trim();
				da.FillSchema(ds,SchemaType.Mapped);

				ds.EnforceConstraints = true;

				DataRelation dr = new DataRelation
					("Bill", ds.Tables["Bill"].Columns["ID_BillName"], 
					ds.Tables["Bill_Name"].Columns["ID_BillName"]);
				ds.Relations.Add(dr);

//				for (int i = 0; i < ds.Tables.Count; i++) {
//					DataTable dt = ds.Tables[i];
//					m = r.Matches(txtquery.Text);
//					f.Header = m[i].Groups[0].Value;
//					f.TableName = m[i].Groups[1].Value;
//					f.ShowDialog();
//					dt.TableName = f.TableName;
//				}
				sw = new StreamWriter(txtpath.Text.Replace(".xml",".txt"),false);
				sw.Write(this.txtquery.Text);
				ds.WriteXmlSchema(txtpath.Text.Replace(".xml", ".xsd"));
				ds.WriteXml(txtpath.Text.Trim(), XmlWriteMode.WriteSchema);
				dg.DataSource = ds;
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			} finally {
				conn.Close();
				if (sw != null) { sw.Close(); }
			} 

			Cursor.Current = Cursors.Default;
		}
	}
}
