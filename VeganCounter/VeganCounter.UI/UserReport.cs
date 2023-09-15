using VeganCounter.BLL.Abstract.IServices;
using VeganCounter.UI.LoginUser;

namespace VeganCounter.UI
{
	public partial class UserReport : Form
	{
		string eMail = ActiveUser.ActiveUserEmail;

		public UserReport()
		{
			InitializeComponent();
		}

		private void btnReturnLogin_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
