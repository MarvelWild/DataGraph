namespace DataGraph
{
	partial class FormMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			splitContainer1 = new SplitContainer();
			splitContainer2 = new SplitContainer();
			groupBox1 = new GroupBox();
			btnSave = new Button();
			txtVertexDescription = new RichTextBox();
			label2 = new Label();
			label1 = new Label();
			txtVertexName = new TextBox();
			splitContainer3 = new SplitContainer();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
			splitContainer3.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(splitContainer2);
			splitContainer1.Size = new Size(1014, 494);
			splitContainer1.SplitterDistance = 118;
			splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.Location = new Point(0, 0);
			splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.BackColor = SystemColors.ActiveBorder;
			splitContainer2.Panel1.Controls.Add(groupBox1);
			splitContainer2.Size = new Size(892, 494);
			splitContainer2.SplitterDistance = 493;
			splitContainer2.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnSave);
			groupBox1.Controls.Add(txtVertexDescription);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(txtVertexName);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(493, 494);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Vertex";
			// 
			// btnSave
			// 
			btnSave.Location = new Point(412, 465);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 3;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			// 
			// txtVertexDescription
			// 
			txtVertexDescription.Location = new Point(88, 55);
			txtVertexDescription.Name = "txtVertexDescription";
			txtVertexDescription.Size = new Size(399, 193);
			txtVertexDescription.TabIndex = 2;
			txtVertexDescription.Text = "";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 55);
			label2.Name = "label2";
			label2.Size = new Size(67, 15);
			label2.TabIndex = 1;
			label2.Text = "Description";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(15, 25);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 1;
			label1.Text = "Name";
			// 
			// txtVertexName
			// 
			txtVertexName.Location = new Point(59, 22);
			txtVertexName.Name = "txtVertexName";
			txtVertexName.Size = new Size(428, 23);
			txtVertexName.TabIndex = 0;
			// 
			// splitContainer3
			// 
			splitContainer3.Dock = DockStyle.Bottom;
			splitContainer3.Location = new Point(0, 494);
			splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel2
			// 
			splitContainer3.Panel2.BackColor = SystemColors.AppWorkspace;
			splitContainer3.Size = new Size(1014, 134);
			splitContainer3.SplitterDistance = 338;
			splitContainer3.TabIndex = 1;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1014, 628);
			Controls.Add(splitContainer1);
			Controls.Add(splitContainer3);
			KeyPreview = true;
			Name = "FormMain";
			Text = "DataGraph";
			Load += FormMain_Load;
			KeyDown += FormMain_KeyDown;
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
			splitContainer3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private SplitContainer splitContainer2;
		private SplitContainer splitContainer3;
		private GroupBox groupBox1;
		private Label label1;
		private TextBox txtVertexName;
		private Label label2;
		private RichTextBox txtVertexDescription;
		private Button btnSave;
	}
}
