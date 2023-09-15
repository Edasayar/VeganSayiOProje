namespace VeganCounter.UI
{
	partial class SingUp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtUserName = new TextBox();
			cmbGender = new ComboBox();
			btnCancel = new Button();
			lblSingUpPassword2 = new Label();
			lblLblSingUpGender = new Label();
			lblSingUpUserName = new Label();
			lblLblSingUpBirthdayDate = new Label();
			dtpBirthDay = new DateTimePicker();
			lblSingUpEmail = new Label();
			txtEMail = new TextBox();
			lblSingUpPassword1 = new Label();
			btnSignIn = new Button();
			txtPassword1 = new TextBox();
			txtPassword2 = new TextBox();
			label2 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// txtUserName
			// 
			txtUserName.BackColor = SystemColors.Window;
			txtUserName.BorderStyle = BorderStyle.FixedSingle;
			txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			txtUserName.Location = new Point(72, 251);
			txtUserName.Margin = new Padding(3, 4, 3, 4);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(389, 34);
			txtUserName.TabIndex = 53;
			// 
			// cmbGender
			// 
			cmbGender.FormattingEnabled = true;
			cmbGender.Location = new Point(72, 499);
			cmbGender.Margin = new Padding(3, 4, 3, 4);
			cmbGender.Name = "cmbGender";
			cmbGender.Size = new Size(389, 28);
			cmbGender.TabIndex = 52;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.White;
			btnCancel.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
			btnCancel.BackgroundImageLayout = ImageLayout.Stretch;
			btnCancel.FlatStyle = FlatStyle.Popup;
			btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnCancel.ForeColor = Color.SaddleBrown;
			btnCancel.Location = new Point(326, 729);
			btnCancel.Margin = new Padding(3, 4, 3, 4);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(136, 40);
			btnCancel.TabIndex = 44;
			btnCancel.Text = "İptal Et";
			btnCancel.UseVisualStyleBackColor = false;
			// 
			// lblSingUpPassword2
			// 
			lblSingUpPassword2.AutoSize = true;
			lblSingUpPassword2.BackColor = Color.Transparent;
			lblSingUpPassword2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblSingUpPassword2.ForeColor = Color.SaddleBrown;
			lblSingUpPassword2.Location = new Point(70, 615);
			lblSingUpPassword2.Name = "lblSingUpPassword2";
			lblSingUpPassword2.Size = new Size(121, 28);
			lblSingUpPassword2.TabIndex = 50;
			lblSingUpPassword2.Text = "Şifre Tekrar";
			// 
			// lblLblSingUpGender
			// 
			lblLblSingUpGender.AutoSize = true;
			lblLblSingUpGender.BackColor = Color.Transparent;
			lblLblSingUpGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblLblSingUpGender.ForeColor = Color.SaddleBrown;
			lblLblSingUpGender.Location = new Point(77, 467);
			lblLblSingUpGender.Name = "lblLblSingUpGender";
			lblLblSingUpGender.Size = new Size(87, 28);
			lblLblSingUpGender.TabIndex = 49;
			lblLblSingUpGender.Text = "Cinsiyet";
			// 
			// lblSingUpUserName
			// 
			lblSingUpUserName.AutoSize = true;
			lblSingUpUserName.BackColor = Color.Transparent;
			lblSingUpUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblSingUpUserName.ForeColor = Color.SaddleBrown;
			lblSingUpUserName.Location = new Point(72, 217);
			lblSingUpUserName.Name = "lblSingUpUserName";
			lblSingUpUserName.Size = new Size(132, 28);
			lblSingUpUserName.TabIndex = 39;
			lblSingUpUserName.Text = "Kullanıcı Adı";
			// 
			// lblLblSingUpBirthdayDate
			// 
			lblLblSingUpBirthdayDate.AutoSize = true;
			lblLblSingUpBirthdayDate.BackColor = Color.Transparent;
			lblLblSingUpBirthdayDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblLblSingUpBirthdayDate.ForeColor = Color.SaddleBrown;
			lblLblSingUpBirthdayDate.Location = new Point(73, 389);
			lblLblSingUpBirthdayDate.Name = "lblLblSingUpBirthdayDate";
			lblLblSingUpBirthdayDate.Size = new Size(140, 28);
			lblLblSingUpBirthdayDate.TabIndex = 48;
			lblLblSingUpBirthdayDate.Text = "Doğum Tarihi";
			// 
			// dtpBirthDay
			// 
			dtpBirthDay.Location = new Point(72, 421);
			dtpBirthDay.Margin = new Padding(3, 4, 3, 4);
			dtpBirthDay.Name = "dtpBirthDay";
			dtpBirthDay.Size = new Size(389, 27);
			dtpBirthDay.TabIndex = 47;
			// 
			// lblSingUpEmail
			// 
			lblSingUpEmail.AutoSize = true;
			lblSingUpEmail.BackColor = Color.Transparent;
			lblSingUpEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblSingUpEmail.ForeColor = Color.SaddleBrown;
			lblSingUpEmail.Location = new Point(70, 301);
			lblSingUpEmail.Name = "lblSingUpEmail";
			lblSingUpEmail.Size = new Size(73, 28);
			lblSingUpEmail.TabIndex = 41;
			lblSingUpEmail.Text = "E-Mail";
			// 
			// txtEMail
			// 
			txtEMail.BorderStyle = BorderStyle.FixedSingle;
			txtEMail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			txtEMail.Location = new Point(72, 333);
			txtEMail.Margin = new Padding(3, 4, 3, 4);
			txtEMail.Name = "txtEMail";
			txtEMail.Size = new Size(389, 34);
			txtEMail.TabIndex = 42;
			// 
			// lblSingUpPassword1
			// 
			lblSingUpPassword1.AutoSize = true;
			lblSingUpPassword1.BackColor = Color.Transparent;
			lblSingUpPassword1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblSingUpPassword1.ForeColor = Color.SaddleBrown;
			lblSingUpPassword1.Location = new Point(72, 539);
			lblSingUpPassword1.Name = "lblSingUpPassword1";
			lblSingUpPassword1.Size = new Size(56, 28);
			lblSingUpPassword1.TabIndex = 45;
			lblSingUpPassword1.Text = "Şifre";
			// 
			// btnSignIn
			// 
			btnSignIn.BackColor = Color.White;
			btnSignIn.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
			btnSignIn.BackgroundImageLayout = ImageLayout.Stretch;
			btnSignIn.FlatStyle = FlatStyle.Popup;
			btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnSignIn.ForeColor = Color.SaddleBrown;
			btnSignIn.Location = new Point(73, 729);
			btnSignIn.Margin = new Padding(3, 4, 3, 4);
			btnSignIn.Name = "btnSignIn";
			btnSignIn.Size = new Size(136, 40);
			btnSignIn.TabIndex = 43;
			btnSignIn.Text = "Kayıt Ol";
			btnSignIn.UseVisualStyleBackColor = false;
			// 
			// txtPassword1
			// 
			txtPassword1.BorderStyle = BorderStyle.FixedSingle;
			txtPassword1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			txtPassword1.Location = new Point(72, 568);
			txtPassword1.Margin = new Padding(3, 4, 3, 4);
			txtPassword1.Name = "txtPassword1";
			txtPassword1.Size = new Size(389, 34);
			txtPassword1.TabIndex = 54;
			// 
			// txtPassword2
			// 
			txtPassword2.BorderStyle = BorderStyle.FixedSingle;
			txtPassword2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			txtPassword2.Location = new Point(72, 647);
			txtPassword2.Margin = new Padding(3, 4, 3, 4);
			txtPassword2.Name = "txtPassword2";
			txtPassword2.Size = new Size(389, 34);
			txtPassword2.TabIndex = 54;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Brush Script MT", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(128, 64, 0);
			label2.Location = new Point(357, 96);
			label2.Name = "label2";
			label2.Size = new Size(90, 46);
			label2.TabIndex = 56;
			label2.Text = "sayıO";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Century", 36F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(128, 64, 0);
			label1.Location = new Point(237, 34);
			label1.Name = "label1";
			label1.Size = new Size(210, 71);
			label1.TabIndex = 55;
			label1.Text = "Vegan";
			// 
			// SingUp
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.signupp;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(531, 812);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtPassword2);
			Controls.Add(txtPassword1);
			Controls.Add(txtUserName);
			Controls.Add(cmbGender);
			Controls.Add(btnCancel);
			Controls.Add(lblSingUpPassword2);
			Controls.Add(lblLblSingUpGender);
			Controls.Add(lblSingUpUserName);
			Controls.Add(lblLblSingUpBirthdayDate);
			Controls.Add(dtpBirthDay);
			Controls.Add(lblSingUpEmail);
			Controls.Add(txtEMail);
			Controls.Add(lblSingUpPassword1);
			Controls.Add(btnSignIn);
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SingUp";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "YENİ KULLANICI KAYDI";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtUserName;
		private ComboBox cmbGender;
		private Button btnCancel;
		private Label lblSingUpPassword2;
		private Label lblLblSingUpGender;
		private Label lblSingUpUserName;
		private Label lblLblSingUpBirthdayDate;
		private DateTimePicker dtpBirthDay;
		private Label lblSingUpEmail;
		private TextBox txtEMail;
		private Label lblSingUpPassword1;
		private Button btnSignIn;
		private TextBox txtPassword1;
		private TextBox txtPassword2;
		private Label label2;
		private Label label1;
	}
}