using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LuckyCafeOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                String name=txtName.Text;
                if (name == "")
                {
                    MessageBox.Show("Name is Empty");
                    this.Close();

                }
               
                    int quantity = int.Parse(txtQuantity.Text);
                if (quantity<0)
                    {
                        MessageBox.Show("not eligible this number");
                        this.Close();

                    }
                String drinkType = "";
                double price = 0;

                if (radbtnTea.Checked)
                {
                    drinkType = "Tea";
                    price = 1;
                }
                else if (radbtnCoffee.Checked)
                {
                    drinkType = "Coffee";
                    price= 2;
                }
                else if (radbtnJuice.Checked)
                {
                    drinkType = "Juice";
                    price = 3;
                }
                else
                {
                    MessageBox.Show("You can't chooce a drink");
                    this .Close();
                }
                listBoxOrder.Items.Clear();
                
                Random random = new Random();

                bool luckyPrice = false;

             
                for (int i = 1; i <= quantity; i++)
                {
                    int luckyNumber = random.Next(50);

                    
                    if (luckyNumber == 7 || luckyNumber == 17)
                    {
                        luckyPrice = true;
                    }

                    // Add Order to ListBox
                    listBoxOrder.Items.Add(i + ": " +name + " - " + drinkType+" - Lucky: " + luckyNumber + " - $" + price.ToString("0.0")
                    );
                }

                
                double total = price * quantity;

                
                double discount = 0;

                if (checkBoxStudentMember.Checked)
                {
                    discount = total * 0.10;
                }

                double finalTotal = total - discount;

               
                listBoxOrder.Items.Add("");
                if (checkBoxStudentMember.Checked)
                {
                    listBoxOrder.Items.Add("Member Discount: 10%");
                }
                else
                {
                    listBoxOrder.Items.Add("Member Discount: 0%");
                }

                listBoxOrder.Items.Add("Total Before Discount: $" +
                    total.ToString("F2"));

                listBoxOrder.Items.Add("Total After Discount: $" +
                    finalTotal.ToString("0.0"));

                
                string luckyMessage;

                if (luckyPrice)
                {
                    lbLuckymessage.ForeColor= Color.Orange;
                    luckyMessage = "You got a Free Cookie!";
                }
                else
                {
                    lbLuckymessage.ForeColor = Color.Black;
                    luckyMessage = "No cookie this time.";
                }

                listBoxOrder.Items.Add("Lucky Message: " + luckyMessage);

             
                lbTotalPrice.Text = "Total Price: $" +
                    finalTotal.ToString("0.0");

                lbLuckymessage.Text = "Lucky Message: " + luckyMessage;
           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String empty = "";
            if (listBoxOrder.Items.Count==0)            
            {
                MessageBox.Show("No order to save");
            }
            else
            {
                
                    try
                    {
                    StreamWriter writer = File.AppendText("orders.txt");

                    
                    for (int i = 0; i < listBoxOrder.Items.Count; i++)
                    {
                        writer.WriteLine(listBoxOrder.Items[i].ToString());
                    }

                    
                    writer.WriteLine(lbTotalPrice.Text);

                    
                    writer.WriteLine(lbLuckymessage.Text);
                    writer.WriteLine("\n");
                    writer.Close();

                   
                    MessageBox.Show("Order saved.");



                }
                catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists("orders.txt"))
            {
                MessageBox.Show("No file found.");
                return;
            }

           
            listBoxOrder.Items.Clear();

           
            StreamReader reader = File.OpenText("orders.txt");

            
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                listBoxOrder.Items.Add(line);
            }

            
            reader.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtQuantity.Clear();
            lbLuckymessage.Text = "";
            lbTotalPrice.Text = "";
            listBoxOrder.Items.Clear();
            checkBoxStudentMember.Checked= false;
            radbtnCoffee.Checked = false;
            radbtnJuice.Checked = false;
            radbtnTea.Checked = false;
            txtName.Focus();
        }
    }
}
