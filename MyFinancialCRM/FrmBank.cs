using MyFinancialCRM.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancialCRM
{
    public partial class FrmBank : Form
    {
        public FrmBank()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Banka Bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";

            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            lblVakifBankBalance.Text = vakifBankBalance.ToString() + " ₺";

            var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();
            lblIsBankBalance.Text = isBankBalance.ToString() + " ₺";

            // Banka Hareketleri

            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " - " + bankProcess1.Amount + " - " + bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " - " + bankProcess2.Amount + " - " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " - " + bankProcess3.Amount + " - " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(42).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " - " + bankProcess4.Amount + " - " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " - " + bankProcess5.Amount + " - " + bankProcess5.ProcessDate;
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

        private void button7_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FrmSettings());
        }
    }
}