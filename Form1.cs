using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Nazmi Bunjaku
//ID: 622146
//Date: 2/27/2019
//Goal: To calculate the sales tax rate for Lorain County

namespace Homework_Project_7___Nazmi_Bunjaku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double SaleAmount; //Variable that is set with the variable double, which sets numeric variables holding numbers with decimal points
        double TaxAmount;   //Variable that is set with the variable double, which sets numeric variables holding numbers with decimal points
        double TotalAmount; //Variable that is set with the variable double, which sets numeric variables holding numbers with decimal points

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {

            SaleAmount = Convert.ToDouble(Sales_Box.Text);  //Converts the user's input to a decimal
            TaxAmount = SaleAmount * .0675;     //The actual calculation the program does
            TaxAmount = Math.Round(TaxAmount,2);    //Rounds the TaxAmount decimal to 2 decimal places
            TotalAmount = SaleAmount + TaxAmount;   //Adds the SalesAmount and the TaxAmount
            TotalAmount = Math.Round(TotalAmount,2);    //Rounds the TotalAmount to 2 decimal places
            Tax_Box.Text = Convert.ToString(TaxAmount);   //Converts TaxValue string to TaxAmount 
            Total_Box.Text = Convert.ToString(TotalAmount);   //Converts the TotalAmount 
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Sales_Box.Text = "";
            Tax_Box.Text = "";
            Total_Box.Text = "";
        }

        private class TotalAmountText
        {
            internal static string Text;
        }

        private class EnterValueTextBox
        {
            internal static readonly object Text;
        }

        private void Total_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class TaxValueText
    {
        internal static string Text;
    }
}
