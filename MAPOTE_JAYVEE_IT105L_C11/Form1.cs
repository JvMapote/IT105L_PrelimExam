using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    /* 
    * FullName: Jayvee N. Mapote
    * Section: C11
    * Course: IT105L
    * Laboratory Prelim Exam
    */

namespace MAPOTE_JAYVEE_IT105L_C11
{
    public partial class formPrelimExam : Form
    {
        int itemsOrdered;
        const int numberOfProducts = 15;
        Product[] products = new Product[numberOfProducts];

        public void Addfunction() 
        {
            for (int i = 0; i < numberOfProducts; i++)
            {
                domainProducts.Items.Add(products[i].Description);
            }
            domainProducts.SelectedIndex = 0;
        }

        public void AddOrder() 
        {
            products[domainProducts.SelectedIndex].NumberOrdered++;
            itemsOrdered++;
            Ordered_Items.Text = "Items Ordered: " + itemsOrdered.ToString();
        }

        public void NewOrder()
        {
            itemsOrdered = 0;
            Ordered_Items.Text = "Items Ordered: 0";

            for (int i = 0; i < numberOfProducts; i++)
            {
                products[i].NumberOrdered = 0;
            }

            domainProducts.SelectedIndex = 0;
            List_Products1.Items.Clear();
            Total_Cost.Text = "Total Cost";
        }

        private void formPrelimExam_Load(object sender, EventArgs e)
        {
            //With Sides (Pakaged Price)
            products[0] = new Product("Fried Chicken(W/side) ₱70", 70);
            products[1] = new Product("Kare Kare(W/side) ₱85", 85);
            products[2] = new Product("Seafood Paella(W/side) ₱75", 75);
            products[3] = new Product("Breakfast Omelet(W/side) ₱60", 60);
            products[4] = new Product("Caesar Salad(W/side) ₱65", 65);
            //Without Sides (Price without the Sides)
            products[5] = new Product("Fried Chicken(WO/side) ₱60", 60);
            products[6] = new Product("Kare Kare(WO/side) ₱75", 75);
            products[7] = new Product("Seafood Paella(WO/side) ₱65", 65);
            products[8] = new Product("Breakfast Omelet(WO/side) ₱50", 50);
            products[9] = new Product("Caesar Salad(WO/side) ₱55", 55);
            //Drinks
            products[10] = new Product("Coke ₱20", 20);
            products[11] = new Product("Juice ₱35", 35);
            products[12] = new Product("Lemonade ₱50", 50);
            products[13] = new Product("Coffee ₱35", 35);
            products[14] = new Product("Tea ₱50", 50);

            Addfunction();
        }

        private void New_Order_Click(object sender, EventArgs e)
        {
            NewOrder();
        }

        private void Add_Order_Click(object sender, EventArgs e)
        {
            AddOrder();
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabpageControl.SelectedIndex)
            {
                case 1:
                    if (itemsOrdered == 0)
                    {
                        MessageBox.Show("No items were ordered", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabpageControl.SelectedIndex = 0;
                    }
                    else 
                    {
                        double totalCost = 0;
                        List_Products1.Items.Clear();
                        for(int i = 0; i < numberOfProducts; i++)
                        {
                            if (products[i].NumberOrdered != 0)
                            {
                                List_Products1.Items.Add(products[i].NumberOrdered.ToString() + " " + products[i].Description);
                                totalCost += products[i].Cost * products[i].NumberOrdered;
                            }
                        }
                        Total_Cost.Text = "Total Cost: ₱" + String.Format("{0:f2}", totalCost);
                    }
                    break;
            }
        }

        public formPrelimExam()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }
    }
}
