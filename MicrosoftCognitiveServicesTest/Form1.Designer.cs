namespace MicrosoftCognitiveServicesTest {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbx_Endpoint = new System.Windows.Forms.TextBox();
			this.tbx_Key = new System.Windows.Forms.TextBox();
			this.tbx_Output = new System.Windows.Forms.TextBox();
			this.fd_Path = new System.Windows.Forms.OpenFileDialog();
			this.tbx_Path = new System.Windows.Forms.TextBox();
			this.btn_SelectPath = new System.Windows.Forms.Button();
			this.btn_Scan = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Endpoint";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "API Key";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Output";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Image";
			// 
			// tbx_Endpoint
			// 
			this.tbx_Endpoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbx_Endpoint.Location = new System.Drawing.Point(12, 25);
			this.tbx_Endpoint.Name = "tbx_Endpoint";
			this.tbx_Endpoint.Size = new System.Drawing.Size(520, 20);
			this.tbx_Endpoint.TabIndex = 4;
			// 
			// tbx_Key
			// 
			this.tbx_Key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbx_Key.Location = new System.Drawing.Point(12, 64);
			this.tbx_Key.Name = "tbx_Key";
			this.tbx_Key.PasswordChar = '*';
			this.tbx_Key.Size = new System.Drawing.Size(520, 20);
			this.tbx_Key.TabIndex = 5;
			// 
			// tbx_Output
			// 
			this.tbx_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbx_Output.Location = new System.Drawing.Point(12, 171);
			this.tbx_Output.Multiline = true;
			this.tbx_Output.Name = "tbx_Output";
			this.tbx_Output.ReadOnly = true;
			this.tbx_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbx_Output.Size = new System.Drawing.Size(520, 267);
			this.tbx_Output.TabIndex = 6;
			// 
			// fd_Path
			// 
			this.fd_Path.FileName = "Image";
			this.fd_Path.FileOk += new System.ComponentModel.CancelEventHandler(this.Fd_Path_FileOk);
			// 
			// tbx_Path
			// 
			this.tbx_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbx_Path.Location = new System.Drawing.Point(12, 103);
			this.tbx_Path.Name = "tbx_Path";
			this.tbx_Path.ReadOnly = true;
			this.tbx_Path.Size = new System.Drawing.Size(439, 20);
			this.tbx_Path.TabIndex = 7;
			// 
			// btn_SelectPath
			// 
			this.btn_SelectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SelectPath.Location = new System.Drawing.Point(457, 101);
			this.btn_SelectPath.Name = "btn_SelectPath";
			this.btn_SelectPath.Size = new System.Drawing.Size(75, 23);
			this.btn_SelectPath.TabIndex = 8;
			this.btn_SelectPath.Text = "Select";
			this.btn_SelectPath.UseVisualStyleBackColor = true;
			this.btn_SelectPath.Click += new System.EventHandler(this.Btn_SelectPath_Click);
			// 
			// btn_Scan
			// 
			this.btn_Scan.Location = new System.Drawing.Point(12, 129);
			this.btn_Scan.Name = "btn_Scan";
			this.btn_Scan.Size = new System.Drawing.Size(75, 23);
			this.btn_Scan.TabIndex = 9;
			this.btn_Scan.Text = "Scan";
			this.btn_Scan.UseVisualStyleBackColor = true;
			this.btn_Scan.Click += new System.EventHandler(this.Btn_Scan_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 450);
			this.Controls.Add(this.btn_Scan);
			this.Controls.Add(this.btn_SelectPath);
			this.Controls.Add(this.tbx_Path);
			this.Controls.Add(this.tbx_Output);
			this.Controls.Add(this.tbx_Key);
			this.Controls.Add(this.tbx_Endpoint);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Microsoft Cognitive Services Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbx_Endpoint;
		private System.Windows.Forms.TextBox tbx_Key;
		private System.Windows.Forms.TextBox tbx_Output;
		private System.Windows.Forms.OpenFileDialog fd_Path;
		private System.Windows.Forms.TextBox tbx_Path;
		private System.Windows.Forms.Button btn_SelectPath;
		private System.Windows.Forms.Button btn_Scan;
	}
}

