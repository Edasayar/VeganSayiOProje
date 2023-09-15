namespace VeganCounter.UI
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            btnUpdateFood = new Button();
            grpAddFood = new GroupBox();
            cmbAddFoodCategorie = new ComboBox();
            btnAddFood = new Button();
            btnAddImage = new Button();
            pbAddFoodImage = new PictureBox();
            txtAddKcalAmound = new TextBox();
            lblAdminKcal = new Label();
            txtAddCarboAmound = new TextBox();
            lblAdminCarbo = new Label();
            txtAddFatAmound = new TextBox();
            lblAdminFat = new Label();
            txtAddProteinAmound = new TextBox();
            lblAdminProtein = new Label();
            txtAddFoodDrinkName = new TextBox();
            lblAdminFood = new Label();
            lblAdminCategorie = new Label();
            dgvFoodTable = new DataGridView();
            btnExit = new Button();
            grpListMessage = new GroupBox();
            dgvMotivationPhrases = new DataGridView();
            rchMotivationPhrases = new RichTextBox();
            btnAddMotivationPhrases = new Button();
            btnUpdateMotivationPhrases = new Button();
            btnDeleteMotivationPhrases = new Button();
            grpListUser = new GroupBox();
            lblActiveUserCount = new Label();
            lblTotalUserCount = new Label();
            lblAdminActiveCountUser = new Label();
            lblAdminCaountUser = new Label();
            btnUserDelete = new Button();
            txtUserSearch = new TextBox();
            btnUserReport = new Button();
            dgvUserTable = new DataGridView();
            grpListFood = new GroupBox();
            btnDeleteFood = new Button();
            cmbSelectFoodCategorie = new ComboBox();
            grpAddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddFoodImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodTable).BeginInit();
            grpListMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMotivationPhrases).BeginInit();
            grpListUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserTable).BeginInit();
            grpListFood.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdateFood
            // 
            btnUpdateFood.BackColor = Color.White;
            btnUpdateFood.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
            btnUpdateFood.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdateFood.FlatStyle = FlatStyle.Popup;
            btnUpdateFood.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateFood.ForeColor = Color.SaddleBrown;
            btnUpdateFood.Location = new Point(356, 17);
            btnUpdateFood.Name = "btnUpdateFood";
            btnUpdateFood.Size = new Size(94, 28);
            btnUpdateFood.TabIndex = 17;
            btnUpdateFood.Text = "Güncelle";
            btnUpdateFood.UseVisualStyleBackColor = false;
            // 
            // grpAddFood
            // 
            grpAddFood.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpAddFood.BackColor = Color.Transparent;
            grpAddFood.BackgroundImage = Properties.Resources.fdgtydhtrfydrt;
            grpAddFood.BackgroundImageLayout = ImageLayout.Center;
            grpAddFood.Controls.Add(cmbAddFoodCategorie);
            grpAddFood.Controls.Add(btnAddFood);
            grpAddFood.Controls.Add(btnAddImage);
            grpAddFood.Controls.Add(pbAddFoodImage);
            grpAddFood.Controls.Add(txtAddKcalAmound);
            grpAddFood.Controls.Add(lblAdminKcal);
            grpAddFood.Controls.Add(txtAddCarboAmound);
            grpAddFood.Controls.Add(lblAdminCarbo);
            grpAddFood.Controls.Add(txtAddFatAmound);
            grpAddFood.Controls.Add(lblAdminFat);
            grpAddFood.Controls.Add(txtAddProteinAmound);
            grpAddFood.Controls.Add(lblAdminProtein);
            grpAddFood.Controls.Add(txtAddFoodDrinkName);
            grpAddFood.Controls.Add(lblAdminFood);
            grpAddFood.Controls.Add(lblAdminCategorie);
            grpAddFood.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpAddFood.ForeColor = Color.SaddleBrown;
            grpAddFood.Location = new Point(19, 18);
            grpAddFood.Name = "grpAddFood";
            grpAddFood.Size = new Size(393, 355);
            grpAddFood.TabIndex = 29;
            grpAddFood.TabStop = false;
            grpAddFood.Text = "Besin Ekle";
            // 
            // cmbAddFoodCategorie
            // 
            cmbAddFoodCategorie.FormattingEnabled = true;
            cmbAddFoodCategorie.Location = new Point(167, 19);
            cmbAddFoodCategorie.Name = "cmbAddFoodCategorie";
            cmbAddFoodCategorie.Size = new Size(215, 25);
            cmbAddFoodCategorie.TabIndex = 1;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.White;
            btnAddFood.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
            btnAddFood.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddFood.FlatStyle = FlatStyle.Popup;
            btnAddFood.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.ForeColor = Color.SaddleBrown;
            btnAddFood.Location = new Point(15, 261);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(105, 26);
            btnAddFood.TabIndex = 15;
            btnAddFood.Text = "Ekle";
            btnAddFood.UseVisualStyleBackColor = false;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = Color.White;
            btnAddImage.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
            btnAddImage.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddImage.FlatStyle = FlatStyle.Popup;
            btnAddImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddImage.ForeColor = Color.SaddleBrown;
            btnAddImage.Location = new Point(15, 227);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(106, 28);
            btnAddImage.TabIndex = 14;
            btnAddImage.Text = "Resim Ekle";
            btnAddImage.UseVisualStyleBackColor = false;
            // 
            // pbAddFoodImage
            // 
            pbAddFoodImage.BackColor = Color.White;
            pbAddFoodImage.Location = new Point(167, 206);
            pbAddFoodImage.Name = "pbAddFoodImage";
            pbAddFoodImage.Size = new Size(216, 137);
            pbAddFoodImage.TabIndex = 13;
            pbAddFoodImage.TabStop = false;
            // 
            // txtAddKcalAmound
            // 
            txtAddKcalAmound.Location = new Point(168, 175);
            txtAddKcalAmound.Name = "txtAddKcalAmound";
            txtAddKcalAmound.Size = new Size(215, 25);
            txtAddKcalAmound.TabIndex = 12;
            // 
            // lblAdminKcal
            // 
            lblAdminKcal.AutoSize = true;
            lblAdminKcal.BackColor = Color.Transparent;
            lblAdminKcal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminKcal.ForeColor = Color.SaddleBrown;
            lblAdminKcal.Location = new Point(15, 178);
            lblAdminKcal.Name = "lblAdminKcal";
            lblAdminKcal.Size = new Size(92, 20);
            lblAdminKcal.TabIndex = 11;
            lblAdminKcal.Text = "Kcal Miktarı";
            // 
            // txtAddCarboAmound
            // 
            txtAddCarboAmound.Location = new Point(167, 144);
            txtAddCarboAmound.Name = "txtAddCarboAmound";
            txtAddCarboAmound.Size = new Size(216, 25);
            txtAddCarboAmound.TabIndex = 10;
            // 
            // lblAdminCarbo
            // 
            lblAdminCarbo.AutoSize = true;
            lblAdminCarbo.BackColor = Color.Transparent;
            lblAdminCarbo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminCarbo.ForeColor = Color.SaddleBrown;
            lblAdminCarbo.Location = new Point(11, 147);
            lblAdminCarbo.Name = "lblAdminCarbo";
            lblAdminCarbo.Size = new Size(156, 20);
            lblAdminCarbo.TabIndex = 9;
            lblAdminCarbo.Text = "Karbonhidrat Miktarı";
            // 
            // txtAddFatAmound
            // 
            txtAddFatAmound.Location = new Point(167, 113);
            txtAddFatAmound.Name = "txtAddFatAmound";
            txtAddFatAmound.Size = new Size(216, 25);
            txtAddFatAmound.TabIndex = 8;
            // 
            // lblAdminFat
            // 
            lblAdminFat.AutoSize = true;
            lblAdminFat.BackColor = Color.Transparent;
            lblAdminFat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminFat.ForeColor = Color.SaddleBrown;
            lblAdminFat.Location = new Point(12, 115);
            lblAdminFat.Name = "lblAdminFat";
            lblAdminFat.Size = new Size(88, 20);
            lblAdminFat.TabIndex = 7;
            lblAdminFat.Text = "Yağ Miktarı";
            // 
            // txtAddProteinAmound
            // 
            txtAddProteinAmound.Location = new Point(168, 82);
            txtAddProteinAmound.Name = "txtAddProteinAmound";
            txtAddProteinAmound.Size = new Size(215, 25);
            txtAddProteinAmound.TabIndex = 6;
            // 
            // lblAdminProtein
            // 
            lblAdminProtein.AutoSize = true;
            lblAdminProtein.BackColor = Color.Transparent;
            lblAdminProtein.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminProtein.ForeColor = Color.SaddleBrown;
            lblAdminProtein.Location = new Point(11, 85);
            lblAdminProtein.Name = "lblAdminProtein";
            lblAdminProtein.Size = new Size(114, 20);
            lblAdminProtein.TabIndex = 5;
            lblAdminProtein.Text = "Protein Miktarı";
            // 
            // txtAddFoodDrinkName
            // 
            txtAddFoodDrinkName.Location = new Point(168, 51);
            txtAddFoodDrinkName.Name = "txtAddFoodDrinkName";
            txtAddFoodDrinkName.Size = new Size(215, 25);
            txtAddFoodDrinkName.TabIndex = 4;
            // 
            // lblAdminFood
            // 
            lblAdminFood.AutoSize = true;
            lblAdminFood.BackColor = Color.Transparent;
            lblAdminFood.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminFood.ForeColor = Color.SaddleBrown;
            lblAdminFood.Location = new Point(11, 56);
            lblAdminFood.Name = "lblAdminFood";
            lblAdminFood.Size = new Size(139, 20);
            lblAdminFood.TabIndex = 2;
            lblAdminFood.Text = "Yiyecek/İçecek Adı";
            // 
            // lblAdminCategorie
            // 
            lblAdminCategorie.AutoSize = true;
            lblAdminCategorie.BackColor = Color.Transparent;
            lblAdminCategorie.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminCategorie.ForeColor = Color.SaddleBrown;
            lblAdminCategorie.Location = new Point(11, 24);
            lblAdminCategorie.Name = "lblAdminCategorie";
            lblAdminCategorie.Size = new Size(80, 20);
            lblAdminCategorie.TabIndex = 0;
            lblAdminCategorie.Text = "Kategorisi";
            // 
            // dgvFoodTable
            // 
            dgvFoodTable.BackgroundColor = SystemColors.Window;
            dgvFoodTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodTable.Location = new Point(13, 46);
            dgvFoodTable.Name = "dgvFoodTable";
            dgvFoodTable.RowTemplate.Height = 25;
            dgvFoodTable.Size = new Size(437, 298);
            dgvFoodTable.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.SaddleBrown;
            btnExit.Location = new Point(769, 707);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 30);
            btnExit.TabIndex = 33;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // grpListMessage
            // 
            grpListMessage.BackColor = Color.Transparent;
            grpListMessage.BackgroundImage = Properties.Resources.fdgtydhtrfydrt1;
            grpListMessage.Controls.Add(dgvMotivationPhrases);
            grpListMessage.Controls.Add(rchMotivationPhrases);
            grpListMessage.Controls.Add(btnAddMotivationPhrases);
            grpListMessage.Controls.Add(btnUpdateMotivationPhrases);
            grpListMessage.Controls.Add(btnDeleteMotivationPhrases);
            grpListMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpListMessage.ForeColor = Color.SaddleBrown;
            grpListMessage.Location = new Point(519, 391);
            grpListMessage.Name = "grpListMessage";
            grpListMessage.Size = new Size(379, 306);
            grpListMessage.TabIndex = 32;
            grpListMessage.TabStop = false;
            grpListMessage.Text = "Motivasyon Mesajı";
            // 
            // dgvMotivationPhrases
            // 
            dgvMotivationPhrases.BackgroundColor = SystemColors.Window;
            dgvMotivationPhrases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMotivationPhrases.Location = new Point(8, 89);
            dgvMotivationPhrases.Name = "dgvMotivationPhrases";
            dgvMotivationPhrases.RowTemplate.Height = 25;
            dgvMotivationPhrases.Size = new Size(359, 175);
            dgvMotivationPhrases.TabIndex = 23;
            // 
            // rchMotivationPhrases
            // 
            rchMotivationPhrases.BackColor = SystemColors.Window;
            rchMotivationPhrases.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rchMotivationPhrases.Location = new Point(8, 24);
            rchMotivationPhrases.Name = "rchMotivationPhrases";
            rchMotivationPhrases.Size = new Size(292, 59);
            rchMotivationPhrases.TabIndex = 22;
            rchMotivationPhrases.Text = "";
            // 
            // btnAddMotivationPhrases
            // 
            btnAddMotivationPhrases.BackColor = Color.White;
            btnAddMotivationPhrases.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
            btnAddMotivationPhrases.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddMotivationPhrases.FlatStyle = FlatStyle.Popup;
            btnAddMotivationPhrases.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddMotivationPhrases.ForeColor = Color.SaddleBrown;
            btnAddMotivationPhrases.Location = new Point(292, 24);
            btnAddMotivationPhrases.Name = "btnAddMotivationPhrases";
            btnAddMotivationPhrases.Size = new Size(75, 59);
            btnAddMotivationPhrases.TabIndex = 20;
            btnAddMotivationPhrases.Text = "Ekle";
            btnAddMotivationPhrases.UseVisualStyleBackColor = false;
            btnAddMotivationPhrases.Click += btnAddMotivationPhrases_Click;
            // 
            // btnUpdateMotivationPhrases
            // 
            btnUpdateMotivationPhrases.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
            btnUpdateMotivationPhrases.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdateMotivationPhrases.FlatStyle = FlatStyle.Popup;
            btnUpdateMotivationPhrases.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateMotivationPhrases.Location = new Point(8, 269);
            btnUpdateMotivationPhrases.Name = "btnUpdateMotivationPhrases";
            btnUpdateMotivationPhrases.Size = new Size(101, 29);
            btnUpdateMotivationPhrases.TabIndex = 19;
            btnUpdateMotivationPhrases.Text = "Güncelle";
            btnUpdateMotivationPhrases.UseVisualStyleBackColor = true;
            btnUpdateMotivationPhrases.Click += btnUpdateMotivationPhrases_Click;
            // 
            // btnDeleteMotivationPhrases
            // 
            btnDeleteMotivationPhrases.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
            btnDeleteMotivationPhrases.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteMotivationPhrases.FlatStyle = FlatStyle.Popup;
            btnDeleteMotivationPhrases.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteMotivationPhrases.Location = new Point(250, 269);
            btnDeleteMotivationPhrases.Name = "btnDeleteMotivationPhrases";
            btnDeleteMotivationPhrases.Size = new Size(100, 29);
            btnDeleteMotivationPhrases.TabIndex = 18;
            btnDeleteMotivationPhrases.Text = "Sil";
            btnDeleteMotivationPhrases.UseVisualStyleBackColor = true;
            btnDeleteMotivationPhrases.Click += btnDeleteMotivationPhrases_Click;
            // 
            // grpListUser
            // 
            grpListUser.BackgroundImage = Properties.Resources.fdgtydhtrfydrt1;
            grpListUser.BackgroundImageLayout = ImageLayout.Center;
            grpListUser.Controls.Add(lblActiveUserCount);
            grpListUser.Controls.Add(lblTotalUserCount);
            grpListUser.Controls.Add(lblAdminActiveCountUser);
            grpListUser.Controls.Add(lblAdminCaountUser);
            grpListUser.Controls.Add(btnUserDelete);
            grpListUser.Controls.Add(txtUserSearch);
            grpListUser.Controls.Add(btnUserReport);
            grpListUser.Controls.Add(dgvUserTable);
            grpListUser.FlatStyle = FlatStyle.Popup;
            grpListUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpListUser.ForeColor = Color.SaddleBrown;
            grpListUser.Location = new Point(17, 391);
            grpListUser.Name = "grpListUser";
            grpListUser.Size = new Size(479, 306);
            grpListUser.TabIndex = 31;
            grpListUser.TabStop = false;
            grpListUser.Text = "Kullanıcı Tablosu";
            // 
            // lblActiveUserCount
            // 
            lblActiveUserCount.AutoSize = true;
            lblActiveUserCount.BackColor = Color.Transparent;
            lblActiveUserCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblActiveUserCount.ForeColor = Color.SaddleBrown;
            lblActiveUserCount.Location = new Point(171, 49);
            lblActiveUserCount.Name = "lblActiveUserCount";
            lblActiveUserCount.Size = new Size(25, 20);
            lblActiveUserCount.TabIndex = 23;
            lblActiveUserCount.Text = "....";
            // 
            // lblTotalUserCount
            // 
            lblTotalUserCount.AutoSize = true;
            lblTotalUserCount.BackColor = Color.Transparent;
            lblTotalUserCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalUserCount.ForeColor = Color.SaddleBrown;
            lblTotalUserCount.Location = new Point(173, 22);
            lblTotalUserCount.Name = "lblTotalUserCount";
            lblTotalUserCount.Size = new Size(25, 20);
            lblTotalUserCount.TabIndex = 22;
            lblTotalUserCount.Text = "....";
            // 
            // lblAdminActiveCountUser
            // 
            lblAdminActiveCountUser.AutoSize = true;
            lblAdminActiveCountUser.BackColor = Color.Transparent;
            lblAdminActiveCountUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminActiveCountUser.ForeColor = Color.SaddleBrown;
            lblAdminActiveCountUser.Location = new Point(3, 49);
            lblAdminActiveCountUser.Name = "lblAdminActiveCountUser";
            lblAdminActiveCountUser.Size = new Size(174, 20);
            lblAdminActiveCountUser.TabIndex = 21;
            lblAdminActiveCountUser.Text = "Aktif Kullanıcı Sayısı     :";
            // 
            // lblAdminCaountUser
            // 
            lblAdminCaountUser.AutoSize = true;
            lblAdminCaountUser.BackColor = Color.Transparent;
            lblAdminCaountUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminCaountUser.ForeColor = Color.SaddleBrown;
            lblAdminCaountUser.Location = new Point(3, 22);
            lblAdminCaountUser.Name = "lblAdminCaountUser";
            lblAdminCaountUser.Size = new Size(175, 20);
            lblAdminCaountUser.TabIndex = 20;
            lblAdminCaountUser.Text = "Toplam Kullanıcı Sayısı :";
            // 
            // btnUserDelete
            // 
            btnUserDelete.BackColor = Color.White;
            btnUserDelete.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
            btnUserDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnUserDelete.FlatStyle = FlatStyle.Popup;
            btnUserDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserDelete.ForeColor = Color.SaddleBrown;
            btnUserDelete.Location = new Point(337, 63);
            btnUserDelete.Name = "btnUserDelete";
            btnUserDelete.Size = new Size(124, 32);
            btnUserDelete.TabIndex = 19;
            btnUserDelete.Text = "Kullanıcı Sil";
            btnUserDelete.UseVisualStyleBackColor = false;
            btnUserDelete.Click += btnUserDelete_Click;
            // 
            // txtUserSearch
            // 
            txtUserSearch.BackColor = SystemColors.Window;
            txtUserSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserSearch.Location = new Point(0, 79);
            txtUserSearch.Name = "txtUserSearch";
            txtUserSearch.Size = new Size(315, 25);
            txtUserSearch.TabIndex = 17;
            txtUserSearch.TextChanged += txtUserSearch_TextChanged;
            // 
            // btnUserReport
            // 
            btnUserReport.BackColor = Color.White;
            btnUserReport.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
            btnUserReport.BackgroundImageLayout = ImageLayout.Stretch;
            btnUserReport.FlatStyle = FlatStyle.Popup;
            btnUserReport.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserReport.ForeColor = Color.SaddleBrown;
            btnUserReport.Location = new Point(337, 25);
            btnUserReport.Name = "btnUserReport";
            btnUserReport.Size = new Size(124, 32);
            btnUserReport.TabIndex = 18;
            btnUserReport.Text = "Kullanıcı Bilgisi";
            btnUserReport.UseVisualStyleBackColor = false;
            btnUserReport.Click += btnUserReport_Click;
            // 
            // dgvUserTable
            // 
            dgvUserTable.BackgroundColor = SystemColors.Window;
            dgvUserTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserTable.Location = new Point(6, 111);
            dgvUserTable.Name = "dgvUserTable";
            dgvUserTable.RowTemplate.Height = 25;
            dgvUserTable.Size = new Size(467, 191);
            dgvUserTable.TabIndex = 0;
            // 
            // grpListFood
            // 
            grpListFood.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpListFood.BackgroundImage = Properties.Resources.fdgtydhtrfydrt;
            grpListFood.BackgroundImageLayout = ImageLayout.Center;
            grpListFood.Controls.Add(btnUpdateFood);
            grpListFood.Controls.Add(dgvFoodTable);
            grpListFood.Controls.Add(btnDeleteFood);
            grpListFood.Controls.Add(cmbSelectFoodCategorie);
            grpListFood.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpListFood.ForeColor = Color.SaddleBrown;
            grpListFood.Location = new Point(436, 18);
            grpListFood.Name = "grpListFood";
            grpListFood.Size = new Size(462, 355);
            grpListFood.TabIndex = 30;
            grpListFood.TabStop = false;
            grpListFood.Text = "Besinler";
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.BackColor = Color.White;
            btnDeleteFood.BackgroundImage = Properties.Resources.fdgtydhtrfydrt__10___5___4_;
            btnDeleteFood.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteFood.FlatStyle = FlatStyle.Popup;
            btnDeleteFood.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteFood.ForeColor = Color.SaddleBrown;
            btnDeleteFood.Location = new Point(260, 17);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(93, 28);
            btnDeleteFood.TabIndex = 16;
            btnDeleteFood.Text = "Sil";
            btnDeleteFood.UseVisualStyleBackColor = false;
            // 
            // cmbSelectFoodCategorie
            // 
            cmbSelectFoodCategorie.FormattingEnabled = true;
            cmbSelectFoodCategorie.Location = new Point(13, 20);
            cmbSelectFoodCategorie.Name = "cmbSelectFoodCategorie";
            cmbSelectFoodCategorie.Size = new Size(242, 25);
            cmbSelectFoodCategorie.TabIndex = 0;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(913, 749);
            Controls.Add(grpAddFood);
            Controls.Add(btnExit);
            Controls.Add(grpListMessage);
            Controls.Add(grpListUser);
            Controls.Add(grpListFood);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            grpAddFood.ResumeLayout(false);
            grpAddFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddFoodImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodTable).EndInit();
            grpListMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMotivationPhrases).EndInit();
            grpListUser.ResumeLayout(false);
            grpListUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserTable).EndInit();
            grpListFood.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdateFood;
        private GroupBox grpAddFood;
        private ComboBox cmbAddFoodCategorie;
        private Button btnAddFood;
        private Button btnAddImage;
        private PictureBox pbAddFoodImage;
        private TextBox txtAddKcalAmound;
        private Label lblAdminKcal;
        private TextBox txtAddCarboAmound;
        private Label lblAdminCarbo;
        private TextBox txtAddFatAmound;
        private Label lblAdminFat;
        private TextBox txtAddProteinAmound;
        private Label lblAdminProtein;
        private TextBox txtAddFoodDrinkName;
        private Label lblAdminFood;
        private Label lblAdminCategorie;
        private DataGridView dgvFoodTable;
        private Button btnExit;
        private GroupBox grpListMessage;
        private RichTextBox rchMotivationPhrases;
        private Button btnAddMotivationPhrases;
        private Button btnUpdateMotivationPhrases;
        private Button btnDeleteMotivationPhrases;
        private GroupBox grpListUser;
        private Label lblActiveUserCount;
        private Label lblTotalUserCount;
        private Label lblAdminActiveCountUser;
        private Label lblAdminCaountUser;
        private Button btnUserDelete;
        private TextBox txtUserSearch;
        private Button btnUserReport;
        private DataGridView dgvUserTable;
        private GroupBox grpListFood;
        private Button btnDeleteFood;
        private ComboBox cmbSelectFoodCategorie;
        private DataGridView dgvMotivationPhrases;
    }
}