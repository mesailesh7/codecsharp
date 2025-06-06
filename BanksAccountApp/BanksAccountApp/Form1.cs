namespace BanksAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount();
            bankAccount.Owner = "Sunny";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Balance = 10000000;


            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Owner = "Suraj";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 50000000;


            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Owner = "Sunita";
            bankAccount3.AccountNumber = Guid.NewGuid();
            bankAccount3.Balance = 100000000;

            BankAccount bankAccount4 = new BankAccount();
            bankAccount4.Owner = "Dhana";
            bankAccount4.AccountNumber = Guid.NewGuid();
            bankAccount4.Balance = 100000000;



            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);
            bankAccounts.Add(bankAccount4);



            BankAccountsGrid.DataSource = bankAccounts;







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AmountNum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
