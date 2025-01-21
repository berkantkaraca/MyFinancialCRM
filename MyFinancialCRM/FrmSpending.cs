using MyFinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCRM
{
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpending_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void NavigateToForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void btnFrmCategory_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmCategory());
        }
        private void btnFrmBank_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmBank());
        }
        private void btnFrmBilling_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmBilling());
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

        private void button7_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmSettings());
        }
    }
}
