using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class CoffeShop : Form
    {
        private int quantity = 0;
        private int order = 0;
        private int total = 0;
        string name = "";
        string adress = "";
        int contact = 0;
        string price = "";
        public CoffeShop()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CusNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Customer Name");
                CusNameTextBox.Focus();
                return;
            }
            else
            {
                 name = CusNameTextBox.Text;
                //RichTextBox.Text = name;
            }

            if (ContactTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Contact No.");
                ContactTextBox.Focus();
                return;
            }
            else
            {
                contact = Convert.ToInt32(ContactTextBox.Text);
               // RichTextBox.Text = contact.ToString();
            }
            if (AdressTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Your Address");
                AdressTextBox.Focus();
                return;
            }
            else
            {
                adress = AdressTextBox.Text;
                //RichTextBox.Text =adress;
            }
            if (PriceComboBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Your Order");
                PriceComboBox.Focus();
                return;
            }
            else
            {
                price = PriceComboBox.Text;

            }

            if (OrderComboBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Your Order");
                OrderComboBox.Focus();
                return;
            }
            if (QuantityNumericUpDown.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Quantity");
                QuantityNumericUpDown.Focus();
                return;
            }
            else
            {
                quantity = Convert.ToInt32(QuantityNumericUpDown.Text);
                order = Convert.ToInt32(OrderComboBox.Text);
                total = quantity * order;
                
                RichTextBox.Text ="Name:"+name +"\n"+"Contact No:"+ contact +"\n"+"Adress:" + adress +"\n" +"Order:"+price+"\n"+"Quantity:"+quantity+"\n"+"Total Price:"+ total.ToString();
            }


        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
