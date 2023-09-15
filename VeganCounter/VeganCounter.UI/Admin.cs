using VeganCounter.BLL.Abstract.IServices;
using VeganCounter.Models.VMs.DailyMessageVMs;
using VeganCounter.Models.VMs.StandartUserVMs;

namespace VeganCounter.UI
{
    public partial class Admin : Form
    {
        private static IDailyMessageService _dailyMessageService;
        private static IStandartUserService _standartUserService;

        public Admin(IDailyMessageService dailyMessageService, IStandartUserService standartUserService)
        {
            InitializeComponent();

            _dailyMessageService = dailyMessageService;
            _standartUserService = standartUserService;
        }

        private void ListedFill()
        {
            dgvMotivationPhrases.DataSource = _dailyMessageService.GetAll().Data;
            dgvUserTable.DataSource = _standartUserService.GetAll().Data;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ListedFill();
        }

        private void btnAddMotivationPhrases_Click(object sender, EventArgs e)
        {
            string messageText = rchMotivationPhrases.Text;

            DailyMessageCreateVm createVm = new DailyMessageCreateVm
            {
                MessageText = messageText,
            };

            _dailyMessageService.Create(createVm);

            rchMotivationPhrases.Text = null;

            ListedFill();
        }

        private void btnDeleteMotivationPhrases_Click(object sender, EventArgs e)
        {
            if (dgvMotivationPhrases.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz mesajı seçin.");
                return;
            }

            DailyMessageVm selectedMessage = dgvMotivationPhrases.SelectedRows[0].DataBoundItem as DailyMessageVm;

            _dailyMessageService.Delete(selectedMessage.Id);

            ListedFill();
        }

        private void btnUpdateMotivationPhrases_Click(object sender, EventArgs e)
        {
            DailyMessageVm selectedMessage = dgvMotivationPhrases.SelectedRows[0].DataBoundItem as DailyMessageVm;

            string updatedText = rchMotivationPhrases.Text;

            selectedMessage.MessageText = updatedText;

            DailyMessageUpdateVm updateVm = new DailyMessageUpdateVm
            {
                Id = selectedMessage.Id,
                MessageText = updatedText
            };

            var updateResult = _dailyMessageService.Update(updateVm);

            rchMotivationPhrases.Text = null;

            ListedFill();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (dgvUserTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz mesajı seçin.");
                return;
            }

            StandartUserBaseVm selectedStandartUser = dgvUserTable.SelectedRows[0].DataBoundItem as StandartUserBaseVm;

            _standartUserService.Delete(selectedStandartUser.Id);

            ListedFill();
        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvFoodTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUserReport_Click(object sender, EventArgs e)
        {
            AdminReport adminReport = new AdminReport();
            adminReport.ShowDialog();
        }
    }
}
