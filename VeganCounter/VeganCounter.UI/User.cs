using AutoMapper;
using VeganCounter.BLL.Abstract.IServices;
using VeganCounter.BLL.Concrete.Services;
using VeganCounter.DAL.Abstract;
using VeganCounter.DAL.Concrete.Repositories;

namespace VeganCounter.UI
{
	public partial class User : Form
	{
		public User()
		{
			InitializeComponent();
		}

		private void btnUserExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnUserProfil_Click(object sender, EventArgs e)
		{
			UserProfil userProfil = new UserProfil();
			userProfil.ShowDialog();
		}

		private void btnUserReport_Click(object sender, EventArgs e)
		{
			UserReport userReport = new UserReport();
			userReport.ShowDialog();
		}

		private void btnAddMeal_Click(object sender, EventArgs e)
		{
			UserAddMeal userAddMeal = new UserAddMeal();
			userAddMeal.ShowDialog();
		}
	}
}
