using VeganCounter.BLL.Abstract.IServices;
using VeganCounter.UI.LoginUser;

namespace VeganCounter.UI
{
	public partial class Login : Form
	{
		private readonly IAdminService _service;

		public Login(IAdminService adminService)
		{
			InitializeComponent();
			_service = adminService;
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			var login = _service.Login(txtEMail.Text, txtPassword.Text);

			if (login == null)
			{
				MessageBox.Show("Bilgilerinizi kontrol edin");
				return;
			}

			bool isAdmin = login.Data.Role == Core.Enums.Role.Admin;

			bool isStandartUser = login.Data.Role == Core.Enums.Role.StandartUser;

			ActiveUser.Role = login.Data.Role;
			ActiveUser.ActiveUserEmail = login.Data.Email;

			if (isAdmin)
			{
				Form adminForm = EfContextForm.EfContextForm.ConfigureService<Admin>();
				this.Hide();
				adminForm.ShowDialog();
				this.Close();
			}
			else
			{
				Form userForm = EfContextForm.EfContextForm.ConfigureService<User>();
				this.Hide();
				userForm.ShowDialog();
				this.Close();
			}
		}
	}
}