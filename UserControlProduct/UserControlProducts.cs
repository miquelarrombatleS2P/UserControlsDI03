using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlProduct
{
    public partial class UserControlProducts : UserControl
    {
        Product product = new Product();
        public UserControlProducts()
        {
            InitializeComponent();
        }

        private int _ProductModelID;

        public int ProductModelId {
            get { return _ProductModelID; }
            set
            {
                if (_ProductModelID == 0)
                {
                    _ProductModelID = 1;
                }
                _ProductModelID = value;
                //MessageBox.Show(_ProductModelID.ToString());
                UpdateInfo(_ProductModelID);
            }
        }
        public void UpdateInfo(int productModelID)
        {
            if (productModelID == 0)
            {
                productModelID = 1;
            }

            sizeFlowLayoutPanel.Controls.Clear();
            colorFlowLayoutPanel.Controls.Clear();
                
            ProductPhoto productPhoto = DataAccess.GetProductWithImage(productModelID);
            //  MessageBox.Show(productPhoto.ToString());
           
            byte[] photo = productPhoto.LargePhoto;
            MemoryStream ms = new MemoryStream(photo);
            Image image = Image.FromStream(ms);
            productPictureBox.Image = image;

            nameTextBox.Text = productPhoto.Name;
            IdTextBox1.Text = productPhoto.ProductId.ToString();
            UpdateSizeAndColor(productModelID); 

        }
        public void UpdateSizeAndColor(int productModelID)
        {
            List<Product> products = DataAccess.GetProduct(productModelID);
            List<string> sizeDuplicates = new List<string>();
            List<string> colorDuplicates = new List<string>();

            int locateSize = 25;
            int locateColor = 20;

            foreach (Product product in products)
            {
                sizeDuplicates.Add(product.Size);
                colorDuplicates.Add(product.Color);

            }
            List<string> sizeList = sizeDuplicates.Distinct().ToList();
            List<string> colorList = colorDuplicates.Distinct().ToList();

            foreach (var item in sizeList)
            {
                Button sizeButton = new Button();
                this.sizeFlowLayoutPanel.Controls.Add(sizeButton);
                sizeButton.Name = item;
                sizeButton.Text = item;
                sizeButton.Location = new Point(locateSize += 70, 165);
                sizeButton.Size = new Size(45, 45);
                sizeButton.Click += sizeButton_Click;


                if (sizeList[0] == item)
                {
                    sizeButton.BackColor = Color.Red;
                    string texto = sizeButton.Text;
                    product.Size = texto;
                }
            }


            foreach (var item in colorList)
            {

                Button colorButton = new Button();
                this.colorFlowLayoutPanel.Controls.Add(colorButton);
                colorButton.Name = item;
                colorButton.Text = item;
                colorButton.Location = new Point(locateColor += 75, 218);
                colorButton.Size = new Size(75, 45);
                colorButton.Click += colorButton_Click;


                if (colorList[0] == item)
                {
                    colorButton.BackColor = Color.Red;
                    string texto = colorButton.Text;
                    product.Color = texto;
                }

            }

        }
        private void sizeButton_Click(object sender, EventArgs e)
        {
            foreach (Button item in sizeFlowLayoutPanel.Controls)
            {
                item.BackColor = Color.LightGray;
            }

            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            string texto = btn.Text;
            product.Size = texto;

            searchProduct();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            foreach (Button item in colorFlowLayoutPanel.Controls)
            {
                item.BackColor = Color.LightGray;
            }

            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            string texto = btn.Text;
            product.Color = texto;

            searchProduct();
        }

        public void searchProduct()
        {
            List<Product> productReset = DataAccess.GetProductSizeWithColor(product.Size, product.Color, _ProductModelID);
            int productID = 1;
            foreach (Product product in productReset)
            {
                productID = int.Parse(product.productID);
                IdTextBox1.Text = product.productID.ToString();
                nameTextBox.Text = product.Name;

            }

            ProductPhoto productPhoto = DataAccess.GetProductWithImageSelectedSizeAndColor(productID);
            byte[] photo = productPhoto.LargePhoto;
            MemoryStream ms = new MemoryStream(photo);
            Image image = Image.FromStream(ms);
            productPictureBox.Image = image;
            
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
