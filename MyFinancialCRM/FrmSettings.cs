using MyFinancialCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCRM
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void NavigateToForm(Form form)
        {
            form.Show();
            this.Hide();
        }
        private void btnFrmBank_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmBank());
        }
        private void btnFrmBilling_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmBilling());
        }
        private void btnFrmSpending_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmSpending());
        }

        private void btnFrmBankProcessing_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmBankProcessing());
        }

        private void btnFrmDashboard_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmDashboard());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFrmCategory_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmCategory());
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();


        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            var user = db.Users.FirstOrDefault(x => x.Username == userName);
            if (user != null)
            {
                user.Password = password;
                db.SaveChanges();
                MessageBox.Show("Şifre Başarılya Güncellendi");
            }

        }
    }
}
