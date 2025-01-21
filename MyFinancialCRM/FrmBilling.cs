using MyFinancialCRM.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCRM
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnListBill_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Şekilde Eklendi", "Ödeme Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Şekilde Silindi", "Ödeme Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            var updateValue = db.Bills.Find(id);
            updateValue.BillTitle = title;
            updateValue.BillAmount = amount;
            updateValue.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Şekilde Güncellendi", "Ödeme Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmSettings());
        }
    }
}