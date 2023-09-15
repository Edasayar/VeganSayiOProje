namespace VeganCounter.UI
{
	partial class User
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
			lblUserName = new Label();
			lblMainUserName = new Label();
			lblMainProtein = new Label();
			lblMainFat = new Label();
			lblMainCarbo = new Label();
			lblDailyUserProtein = new Label();
			lblDailyMotivation = new Label();
			lblDailyUserFat = new Label();
			lblDailyUserCarbo = new Label();
			btnAddMeal = new Button();
			dgvDailyMeal = new DataGridView();
			btnUserExit = new Button();
			btnUserReport = new Button();
			btnUserProfil = new Button();
			mcUser = new MonthCalendar();
			circularProgressBarDAilyKcal = new CircularProgressBar.CircularProgressBar();
			label2 = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvDailyMeal).BeginInit();
			SuspendLayout();
			// 
			// lblUserName
			// 
			lblUserName.AutoSize = true;
			lblUserName.BackColor = Color.Transparent;
			lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblUserName.ForeColor = Color.SaddleBrown;
			lblUserName.Location = new Point(146, 21);
			lblUserName.Name = "lblUserName";
			lblUserName.Size = new Size(27, 28);
			lblUserName.TabIndex = 76;
			lblUserName.Text = "...";
			// 
			// lblMainUserName
			// 
			lblMainUserName.AutoSize = true;
			lblMainUserName.BackColor = Color.Transparent;
			lblMainUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblMainUserName.ForeColor = Color.SaddleBrown;
			lblMainUserName.Location = new Point(8, 21);
			lblMainUserName.Name = "lblMainUserName";
			lblMainUserName.Size = new Size(143, 28);
			lblMainUserName.TabIndex = 75;
			lblMainUserName.Text = "Kullanıcı Adı :";
			// 
			// lblMainProtein
			// 
			lblMainProtein.AutoSize = true;
			lblMainProtein.BackColor = Color.Transparent;
			lblMainProtein.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblMainProtein.ForeColor = Color.SaddleBrown;
			lblMainProtein.Location = new Point(71, 544);
			lblMainProtein.Name = "lblMainProtein";
			lblMainProtein.Size = new Size(98, 28);
			lblMainProtein.TabIndex = 59;
			lblMainProtein.Text = "Protein  :";
			// 
			// lblMainFat
			// 
			lblMainFat.AutoSize = true;
			lblMainFat.BackColor = Color.Transparent;
			lblMainFat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblMainFat.ForeColor = Color.SaddleBrown;
			lblMainFat.Location = new Point(102, 608);
			lblMainFat.Name = "lblMainFat";
			lblMainFat.Size = new Size(62, 28);
			lblMainFat.TabIndex = 62;
			lblMainFat.Text = "Yağ  :";
			// 
			// lblMainCarbo
			// 
			lblMainCarbo.AutoSize = true;
			lblMainCarbo.BackColor = Color.Transparent;
			lblMainCarbo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblMainCarbo.ForeColor = Color.SaddleBrown;
			lblMainCarbo.Location = new Point(24, 577);
			lblMainCarbo.Name = "lblMainCarbo";
			lblMainCarbo.Size = new Size(148, 28);
			lblMainCarbo.TabIndex = 63;
			lblMainCarbo.Text = "Karbonhidrat :";
			// 
			// lblDailyUserProtein
			// 
			lblDailyUserProtein.AutoSize = true;
			lblDailyUserProtein.BackColor = Color.Transparent;
			lblDailyUserProtein.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblDailyUserProtein.ForeColor = Color.SaddleBrown;
			lblDailyUserProtein.Location = new Point(179, 544);
			lblDailyUserProtein.Name = "lblDailyUserProtein";
			lblDailyUserProtein.Size = new Size(37, 28);
			lblDailyUserProtein.TabIndex = 60;
			lblDailyUserProtein.Text = ".....";
			// 
			// lblDailyMotivation
			// 
			lblDailyMotivation.BackColor = Color.Transparent;
			lblDailyMotivation.Font = new Font("Lucida Handwriting", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblDailyMotivation.ForeColor = Color.SaddleBrown;
			lblDailyMotivation.Location = new Point(597, 321);
			lblDailyMotivation.Name = "lblDailyMotivation";
			lblDailyMotivation.Size = new Size(270, 173);
			lblDailyMotivation.TabIndex = 74;
			lblDailyMotivation.Text = "Motivasyon mesajı..";
			// 
			// lblDailyUserFat
			// 
			lblDailyUserFat.AutoSize = true;
			lblDailyUserFat.BackColor = Color.Transparent;
			lblDailyUserFat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblDailyUserFat.ForeColor = Color.SaddleBrown;
			lblDailyUserFat.Location = new Point(179, 608);
			lblDailyUserFat.Name = "lblDailyUserFat";
			lblDailyUserFat.Size = new Size(37, 28);
			lblDailyUserFat.TabIndex = 64;
			lblDailyUserFat.Text = ".....";
			// 
			// lblDailyUserCarbo
			// 
			lblDailyUserCarbo.AutoSize = true;
			lblDailyUserCarbo.BackColor = Color.Transparent;
			lblDailyUserCarbo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblDailyUserCarbo.ForeColor = Color.SaddleBrown;
			lblDailyUserCarbo.Location = new Point(179, 577);
			lblDailyUserCarbo.Name = "lblDailyUserCarbo";
			lblDailyUserCarbo.Size = new Size(37, 28);
			lblDailyUserCarbo.TabIndex = 65;
			lblDailyUserCarbo.Text = ".....";
			// 
			// btnAddMeal
			// 
			btnAddMeal.BackColor = SystemColors.ButtonFace;
			btnAddMeal.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
			btnAddMeal.BackgroundImageLayout = ImageLayout.Stretch;
			btnAddMeal.FlatStyle = FlatStyle.Popup;
			btnAddMeal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnAddMeal.ForeColor = Color.SaddleBrown;
			btnAddMeal.Location = new Point(290, 544);
			btnAddMeal.Margin = new Padding(3, 4, 3, 4);
			btnAddMeal.Name = "btnAddMeal";
			btnAddMeal.Size = new Size(578, 44);
			btnAddMeal.TabIndex = 71;
			btnAddMeal.Text = "Öğün Ekle";
			btnAddMeal.UseVisualStyleBackColor = false;
			btnAddMeal.Click += btnAddMeal_Click;
			// 
			// dgvDailyMeal
			// 
			dgvDailyMeal.BackgroundColor = SystemColors.Window;
			dgvDailyMeal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDailyMeal.Location = new Point(290, 596);
			dgvDailyMeal.Margin = new Padding(3, 4, 3, 4);
			dgvDailyMeal.Name = "dgvDailyMeal";
			dgvDailyMeal.RowHeadersWidth = 51;
			dgvDailyMeal.RowTemplate.Height = 25;
			dgvDailyMeal.Size = new Size(578, 317);
			dgvDailyMeal.TabIndex = 70;
			// 
			// btnUserExit
			// 
			btnUserExit.BackColor = SystemColors.ButtonFace;
			btnUserExit.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
			btnUserExit.BackgroundImageLayout = ImageLayout.Stretch;
			btnUserExit.FlatStyle = FlatStyle.Popup;
			btnUserExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnUserExit.ForeColor = Color.SaddleBrown;
			btnUserExit.Location = new Point(663, 939);
			btnUserExit.Margin = new Padding(3, 4, 3, 4);
			btnUserExit.Name = "btnUserExit";
			btnUserExit.Size = new Size(206, 44);
			btnUserExit.TabIndex = 68;
			btnUserExit.Text = "Çıkış";
			btnUserExit.UseVisualStyleBackColor = false;
			btnUserExit.Click += btnUserExit_Click;
			// 
			// btnUserReport
			// 
			btnUserReport.BackColor = SystemColors.ControlLight;
			btnUserReport.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
			btnUserReport.BackgroundImageLayout = ImageLayout.Stretch;
			btnUserReport.FlatStyle = FlatStyle.Popup;
			btnUserReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnUserReport.ForeColor = Color.SaddleBrown;
			btnUserReport.Location = new Point(334, 939);
			btnUserReport.Margin = new Padding(3, 4, 3, 4);
			btnUserReport.Name = "btnUserReport";
			btnUserReport.Size = new Size(206, 44);
			btnUserReport.TabIndex = 67;
			btnUserReport.Text = "Raporlar";
			btnUserReport.UseVisualStyleBackColor = false;
			btnUserReport.Click += btnUserReport_Click;
			// 
			// btnUserProfil
			// 
			btnUserProfil.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
			btnUserProfil.BackgroundImageLayout = ImageLayout.Stretch;
			btnUserProfil.FlatStyle = FlatStyle.Popup;
			btnUserProfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnUserProfil.ForeColor = Color.SaddleBrown;
			btnUserProfil.Location = new Point(14, 939);
			btnUserProfil.Margin = new Padding(3, 4, 3, 4);
			btnUserProfil.Name = "btnUserProfil";
			btnUserProfil.Size = new Size(206, 44);
			btnUserProfil.TabIndex = 66;
			btnUserProfil.Text = "Profil";
			btnUserProfil.UseVisualStyleBackColor = true;
			btnUserProfil.Click += btnUserProfil_Click;
			// 
			// mcUser
			// 
			mcUser.BackColor = SystemColors.Window;
			mcUser.Location = new Point(14, 697);
			mcUser.Margin = new Padding(9, 13, 9, 13);
			mcUser.Name = "mcUser";
			mcUser.TabIndex = 61;
			// 
			// circularProgressBarDAilyKcal
			// 
			circularProgressBarDAilyKcal.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			circularProgressBarDAilyKcal.AnimationSpeed = 500;
			circularProgressBarDAilyKcal.BackColor = Color.Transparent;
			circularProgressBarDAilyKcal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			circularProgressBarDAilyKcal.ForeColor = Color.Transparent;
			circularProgressBarDAilyKcal.InnerColor = Color.Transparent;
			circularProgressBarDAilyKcal.InnerMargin = 2;
			circularProgressBarDAilyKcal.InnerWidth = -1;
			circularProgressBarDAilyKcal.Location = new Point(303, 21);
			circularProgressBarDAilyKcal.Margin = new Padding(3, 4, 3, 4);
			circularProgressBarDAilyKcal.MarqueeAnimationSpeed = 2000;
			circularProgressBarDAilyKcal.Name = "circularProgressBarDAilyKcal";
			circularProgressBarDAilyKcal.OuterColor = SystemColors.ButtonFace;
			circularProgressBarDAilyKcal.OuterMargin = -25;
			circularProgressBarDAilyKcal.OuterWidth = 26;
			circularProgressBarDAilyKcal.ProgressColor = Color.IndianRed;
			circularProgressBarDAilyKcal.ProgressWidth = 25;
			circularProgressBarDAilyKcal.SecondaryFont = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
			circularProgressBarDAilyKcal.Size = new Size(317, 364);
			circularProgressBarDAilyKcal.StartAngle = 270;
			circularProgressBarDAilyKcal.SubscriptColor = Color.DimGray;
			circularProgressBarDAilyKcal.SubscriptMargin = new Padding(10, -35, 0, 0);
			circularProgressBarDAilyKcal.SubscriptText = "";
			circularProgressBarDAilyKcal.SuperscriptColor = Color.DimGray;
			circularProgressBarDAilyKcal.SuperscriptMargin = new Padding(10, 35, 0, 0);
			circularProgressBarDAilyKcal.SuperscriptText = "Kcal";
			circularProgressBarDAilyKcal.TabIndex = 80;
			circularProgressBarDAilyKcal.Text = "1600 Kcal";
			circularProgressBarDAilyKcal.TextMargin = new Padding(8, 8, 0, 0);
			circularProgressBarDAilyKcal.Value = 68;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Brush Script MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(128, 64, 0);
			label2.Location = new Point(816, 51);
			label2.Name = "label2";
			label2.Size = new Size(55, 28);
			label2.TabIndex = 82;
			label2.Text = "sayıO";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Century", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(128, 64, 0);
			label1.Location = new Point(739, 11);
			label1.Name = "label1";
			label1.Size = new Size(134, 44);
			label1.TabIndex = 81;
			label1.Text = "Vegan";
			// 
			// User
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(882, 999);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lblDailyMotivation);
			Controls.Add(circularProgressBarDAilyKcal);
			Controls.Add(lblUserName);
			Controls.Add(lblMainUserName);
			Controls.Add(lblMainProtein);
			Controls.Add(lblMainFat);
			Controls.Add(lblMainCarbo);
			Controls.Add(lblDailyUserProtein);
			Controls.Add(lblDailyUserFat);
			Controls.Add(lblDailyUserCarbo);
			Controls.Add(btnAddMeal);
			Controls.Add(dgvDailyMeal);
			Controls.Add(btnUserExit);
			Controls.Add(btnUserReport);
			Controls.Add(btnUserProfil);
			Controls.Add(mcUser);
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "User";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ANA SAYFA";
			((System.ComponentModel.ISupportInitialize)dgvDailyMeal).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblUserName;
		private Label lblMainUserName;
		private Label lblMainProtein;
		private Label lblMainFat;
		private Label lblMainCarbo;
		private Label lblDailyUserProtein;
		private Label lblDailyMotivation;
		private Label lblDailyUserFat;
		private Label lblDailyUserCarbo;
		private Button btnAddMeal;
		private DataGridView dgvDailyMeal;
		private Button btnUserExit;
		private Button btnUserReport;
		private Button btnUserProfil;
		private MonthCalendar mcUser;
		private CircularProgressBar.CircularProgressBar circularProgressBarDAilyKcal;
		private Label label2;
		private Label label1;
	}
}