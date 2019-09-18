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
        List<string> boxes = new List<string> { };
       
        int s = 0;
        string customerIndex = "";
        string addressIndex = "";
        string priceIndex = "";
        int totalIndex = 0;
        private int quantity = 0;
        private int order = 0;
        int contacts = 0;
        
   
        
        public CoffeShop()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

                Input();
            try
            {
                quantity = Convert.ToInt32(QuantityNumericUpDown.Text);
                order = Convert.ToInt32(OrderComboBox.Text);
                totalIndex = quantity * order;
                RichTextBox.Text = "Name:" + customerIndex + "\n" + "Contact No:" + contacts + "\n" + "Adress:" + addressIndex + "\n" + "Order:" + priceIndex + "\n" + "Quantity:" + quantity + "\n" + "Total Price:" + totalIndex.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!!!");
            }

            finally
            {
                Reset();
            }

        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)

        {
        }
        private void Reset()
        {
            CusNameTextBox.Text = "";
            ContactTextBox.Text = "";
            AdressTextBox.Text = "";
            PriceComboBox.Text = "";
            OrderComboBox.Text = "";
            QuantityNumericUpDown.Text = "";

        }


        private void ShowButton_Click(object sender, EventArgs e)
        {
            List<string> name = new List<string> { };
            try
            {
                name.Add(CusNameTextBox.Text);
                Input();
                quantity = Convert.ToInt32(QuantityNumericUpDown.Text);
                order = Convert.ToInt32(OrderComboBox.Text);
                totalIndex = quantity * order;
                RichTextBox.Text +="\n\n"+ "Name:" + customerIndex + "\n" + "Contact No:" + contacts + "\n" + "Adress:" + addressIndex + "\n" + "Order:" + priceIndex + "\n" + "Quantity:" + quantity + "\n" + "Total Price:" + totalIndex.ToString()+"\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!!!");

            }
            finally
            {
                Reset();
            }

        }

        private void Input()
        {
            if (CusNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Customer Name");
                CusNameTextBox.Focus();
                return;
            }
            else
            {
                customerIndex = CusNameTextBox.Text;

            }

            if (ContactTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Contact No.");
                ContactTextBox.Focus();
                return;
            }
            else
            {
                
               contacts =Convert.ToInt32( ContactTextBox.Text);
                
            }
            if (AdressTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Your Address");
                AdressTextBox.Focus();
                return;
            }
            else
            {
                addressIndex = AdressTextBox.Text;
               
            }
            if (PriceComboBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Your Info");
                PriceComboBox.Focus();
                return;
            }
            else
            {
                priceIndex = PriceComboBox.Text;

            }

            if (String.IsNullOrEmpty(OrderComboBox.Text) || String.IsNullOrEmpty(QuantityNumericUpDown.Text))
            {
                MessageBox.Show("Order Item and Order Quantity Field Required");
            }
            
       
        

    }

        private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
