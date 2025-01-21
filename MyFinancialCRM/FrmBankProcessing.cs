using MyFinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCRM
{
    public partial class FrmBankProcessing : Form
    {
        public FrmBankProcessing()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBankProcessing_Load(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankProcessId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı Şekilde Silindi", "Banka İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
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
        private void btnFrmCategory_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmCategory());
        }
        private void btnFrmBilling_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmBilling());
        }
        private void btnFrmSpending_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmSpending());
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
