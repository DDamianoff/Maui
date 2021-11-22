using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ma.Controllers.Ma.Ui;
using Maui.Backend.Models.DataBase;

namespace Ma.UI.UserControls.TransactionsView
{
    public partial class TransactionsControl : MainSectionTemplate
    {
        public static TransactionController _transactioncController = new TransactionController();
        
        public TransactionsControl()
        {
            InitializeComponent();
        }

        public async void LoadDataGridViewData()
        {
            dgvTransactions.Rows.Clear();

            List<Transaction> transactionList = await Task.Run(() => _transactioncController.GetAllTransactions());

            foreach (Transaction transaction in transactionList)
            {
                int n = dgvTransactions.Rows.Add();
                // Codigo
                dgvTransactions.Rows[n].Cells[0].Value = transaction.TransactionId;
                // Producto
                dgvTransactions.Rows[n].Cells[1].Value = transaction.Product.Title;
                // Vendedor
                dgvTransactions.Rows[n].Cells[2].Value = $"{transaction.Worker.FirstName} {transaction.Worker.LastName}";
                // Cantidad
                dgvTransactions.Rows[n].Cells[3].Value = transaction.QuantityOperated;
                // Fecha
                dgvTransactions.Rows[n].Cells[4].Value = transaction.ShellDateTime;
                // Monto
                // TODO: chopear los decimales.
                dgvTransactions.Rows[n].Cells[5].Value = transaction.Amount;
                // tipo
                dgvTransactions.Rows[n].Cells[6].Value = transaction.PaymentMethod;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataGridViewData();
        }
    }
}