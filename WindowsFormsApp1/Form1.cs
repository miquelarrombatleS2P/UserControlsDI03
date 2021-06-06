using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UserControlProduct;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControlProducts1.ProductModelId = int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            UserControlProducts control = new UserControlProducts();
            control.ProductModelId = randomNum();
            control.BorderStyle = BorderStyle.FixedSingle;
            UserControlProducts control2 = new UserControlProducts();
            control2.ProductModelId = randomNum();
            control2.BorderStyle = BorderStyle.FixedSingle;

            List<int> idProducts = new List<int>();

            idProducts.Add(control.ProductModelId);
            idProducts.Add(control2.ProductModelId);

            List<int> senseDuplicats = duplicates(idProducts);

            foreach (int item in senseDuplicats)
            {
                UserControlProducts controll = new UserControlProducts();
                controll.ProductModelId = item;
                controll.BorderStyle = BorderStyle.FixedSingle;

                productsRandomFlowLayoutPanel1.Controls.Add(controll);
                productsRandomFlowLayoutPanel1.ScrollControlIntoView(controll);
            }
            
        }

        public int randomNum()
        {
            Random rnd = new Random();
            int idProduct = rnd.Next(DataAccess.GetMinProductModel(), DataAccess.GetMaxProductModel());

            int productModelId = DataAccess.GetProductModelToRandom(idProduct);

            if (DataAccess.GetProductModelIsExists(productModelId) == 0)
            {
                MessageBox.Show("Not exist productModelID");
            }

            return productModelId;
        }

        private static List<int> duplicates(List<int> products)
        {
            List<int> output = new List<int>();
            foreach (int item in products)
            {
                bool add = true;

                foreach (var itemOut in output)
                {
                    if (item == itemOut)
                    {
                        add = false;

                    }
                }
                if (add)
                {
                    output.Add(item);
                }
                
            }
            return output;
        }

    }

}
