namespace VeganCounter.UI
{
	partial class Login
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
			linkLblSignUp = new LinkLabel();
			btnEnter = new Button();
			txtPassword = new TextBox();
			lblLoginPassword = new Label();
			txtEMail = new TextBox();
			lblLoginEMail = new Label();
			label3 = new Label();
			label1 = new Label();
			label6 = new Label();
			label2 = new Label();
			SuspendLayout();
			// 
			// linkLblSignUp
			// 
			linkLblSignUp.AutoSize = true;
			linkLblSignUp.BackColor = Color.Transparent;
			linkLblSignUp.Location = new Point(173, 755);
			linkLblSignUp.Name = "linkLblSignUp";
			linkLblSignUp.Size = new Size(183, 20);
			linkLblSignUp.TabIndex = 33;
			linkLblSignUp.TabStop = true;
			linkLblSignUp.Text = "Haydi Kayıt Olma Zamanı!";
			// 
			// btnEnter
			// 
			btnEnter.BackColor = SystemColors.ButtonFace;
			btnEnter.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
			btnEnter.BackgroundImageLayout = ImageLayout.Stretch;
			btnEnter.FlatStyle = FlatStyle.Popup;
			btnEnter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnEnter.ForeColor = Color.SaddleBrown;
			btnEnter.Location = new Point(166, 687);
			btnEnter.Margin = new Padding(3, 4, 3, 4);
			btnEnter.Name = "btnEnter";
			btnEnter.Size = new Size(181, 47);
			btnEnter.TabIndex = 32;
			btnEnter.Text = "Giriş";
			btnEnter.UseVisualStyleBackColor = false;
			btnEnter.Click += btnEnter_Click;
			// 
			// txtPassword
			// 
			txtPassword.BackColor = SystemColors.Window;
			txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			txtPassword.Location = new Point(67, 623);
			txtPassword.Margin = new Padding(3, 4, 3, 4);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(387, 34);
			txtPassword.TabIndex = 31;
			// 
			// lblLoginPassword
			// 
			lblLoginPassword.AutoSize = true;
			lblLoginPassword.BackColor = Color.Transparent;
			lblLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblLoginPassword.ForeColor = Color.SaddleBrown;
			lblLoginPassword.Location = new Point(67, 591);
			lblLoginPassword.Name = "lblLoginPassword";
			lblLoginPassword.Size = new Size(67, 28);
			lblLoginPassword.TabIndex = 30;
			lblLoginPassword.Text = "Şifre :";
			// 
			// txtEMail
			// 
			txtEMail.BackColor = SystemColors.Window;
			txtEMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			txtEMail.Location = new Point(67, 547);
			txtEMail.Margin = new Padding(3, 4, 3, 4);
			txtEMail.Name = "txtEMail";
			txtEMail.Size = new Size(387, 34);
			txtEMail.TabIndex = 29;
			// 
			// lblLoginEMail
			// 
			lblLoginEMail.AutoSize = true;
			lblLoginEMail.BackColor = Color.Transparent;
			lblLoginEMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblLoginEMail.ForeColor = Color.SaddleBrown;
			lblLoginEMail.Location = new Point(66, 515);
			lblLoginEMail.Name = "lblLoginEMail";
			lblLoginEMail.Size = new Size(90, 28);
			lblLoginEMail.TabIndex = 28;
			lblLoginEMail.Text = "E-Mail  :";
			// 
			// label3
			// 
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.SaddleBrown;
			label3.Location = new Point(67, 329);
			label3.Name = "label3";
			label3.Size = new Size(387, 107);
			label3.TabIndex = 27;
			label3.Text = "Saglıgınızı Kontrol Altına Almaya Hazır mısınız?";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Century", 36F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(128, 64, 0);
			label1.Location = new Point(219, 105);
			label1.Name = "label1";
			label1.Size = new Size(210, 71);
			label1.TabIndex = 25;
			label1.Text = "Vegan";
			// 
			// label6
			// 
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.SaddleBrown;
			label6.Location = new Point(67, 293);
			label6.Name = "label6";
			label6.Size = new Size(387, 53);
			label6.TabIndex = 35;
			label6.Text = "Hosgeldiniz";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Brush Script MT", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(128, 64, 0);
			label2.Location = new Point(339, 167);
			label2.Name = "label2";
			label2.Size = new Size(90, 46);
			label2.TabIndex = 36;
			label2.Text = "sayıO";
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.login1_;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(531, 812);
			Controls.Add(label2);
			Controls.Add(label6);
			Controls.Add(linkLblSignUp);
			Controls.Add(btnEnter);
			Controls.Add(txtPassword);
			Controls.Add(lblLoginPassword);
			Controls.Add(txtEMail);
			Controls.Add(lblLoginEMail);
			Controls.Add(label3);
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "GİRİŞ";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private LinkLabel linkLblSignUp;
		private Button btnEnter;
		private TextBox txtPassword;
		private Label lblLoginPassword;
		private TextBox txtEMail;
		private Label lblLoginEMail;
		private Label label3;
		private Label label1;
		private Label label6;
		private Label label2;
	}
}