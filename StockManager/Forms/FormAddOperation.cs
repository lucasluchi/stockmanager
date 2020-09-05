using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Forms
{
    public partial class FormAddOperation : Form
    {
        private static bool operationOk = false;

        public FormAddOperation()
        {
            InitializeComponent();

            SetupOperation();
        }
        private void AllowOnlyReais(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumber(sender, e);

            if (e.Handled) return;

            e.Handled = true;

            TextBox textBox = (TextBox)sender;

            double valor;
            double.TryParse(textBox.Text.Substring(3, textBox.TextLength - 3), out valor);

            if (e.KeyChar == (char)8)
            {
                valor /= 10;
            }
            else
            {
                valor *= 10;
                valor += double.Parse(e.KeyChar.ToString()) / 100.0;
            }

            valor = Math.Round(valor, 2);

            textBox.Text = "R$ " + valor.ToString("N2");

            textBox.SelectionStart = textBox.TextLength + 1;
        }

        private void AllowOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }   
        }

        private void OperationCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if it's backspace let .net take control
            if (e.KeyChar != (char)8)
                e.Handled = true;

            // only update the textbox if the values are C or V
            if (e.KeyChar == 'C' || e.KeyChar == 'V' ||
                e.KeyChar == 'c' || e.KeyChar == 'v')
            {
                TextBox textBox = (TextBox)sender;
                textBox.Text = e.KeyChar.ToString().ToUpper();
                textBox.SelectionStart = textBox.TextLength + 1;
            }
        }

        // checks if all datas are correct
        private void VerifyOperation(object sender, EventArgs e)
        {
            try
            {
                // brute values = qnt * stock price
                double bruteValue = int.Parse(OperationQuantity.Text) * double.Parse(OperationPrice.Text.Substring(3, OperationPrice.TextLength - 3));
                
                // taxes = brute value * 0.000275 (B3 taxes)
                double taxValue = Math.Round((bruteValue * 0.000275), 2);

                // add fees to the brute value after calculates taxes (broker fees)
                bruteValue += double.Parse(OperationFees.Text.Substring(3, OperationFees.TextLength - 3));

                // liquid value of the operation
                double liquidValue = (OperationCV.Text == "C" ? +taxValue : -taxValue) + bruteValue;

                OperationBrute.Text = "R$ " +
                    bruteValue.ToString("N2");

                OperationTax.Text = "R$ " +
                    taxValue.ToString("N2");

                OperationLiquid.Text = "R$ " +
                    liquidValue.ToString("N2");

                // checks whether these other data are valid
                if (OperationTicker.Text != "" && (OperationCV.Text == "C" || OperationCV.Text == "V"))
                    operationOk = true;
            }
            catch (Exception ex)
            {
                operationOk = false;
            }
        }

        // initial setup for the operation's form
        private void SetupOperation()
        {
            OperationDateTime.Value = DateTime.Now;
            OperationTicker.Text = "";
            OperationQuantity.Text = "";
            OperationCV.Text = "";

            OperationPrice.Text = "R$ 0,00";
            OperationFees.Text = "R$ 0,00";

            OperationTax.Text = "";
            OperationBrute.Text = "";
            OperationLiquid.Text = "";
            OperationBroker.Text = "";
        }
    }
}
