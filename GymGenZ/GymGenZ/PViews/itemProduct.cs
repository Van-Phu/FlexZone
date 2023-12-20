using GymGenZ.PControls;
using GymGenZ.PModels;
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
using System.Windows.Forms.Design;
using System.Xml.Linq;

namespace GymGenZ.PViews
{
    public partial class itemProduct : Form
    {


        private CProduct _dataService;
        private List<MProduct> _products;
        private List<MProduct> _productss;
        CProduct productManager = new CProduct("Data Source=C:\\data\\GYM.db");




        string _name;
        int _price;
        int _idProduct;
        int _idCateProduct;
        string _img;
        public itemProduct()
        {
            InitializeComponent();
        }

        public itemProduct(int idProduct, string productName, int productPrice, int cateProduct, string img)
        {
            InitializeComponent();
            _idProduct = idProduct;
            _name = productName;
            _price = productPrice;
            _idCateProduct = cateProduct;
            _img = img;
            bool check = checkNull();
            if (!string.IsNullOrEmpty(_img))
            {
                picItemProduct.Image = ByteToImg(_img);
            }
            
            else if (check == false)
            {
                return;
            }

            lbNameProduct.Text = _name;
            lbPrice.Text = _price.ToString();

            

        }

        private Image ByteToImg(string byteString)
        {
            try
            {
                byte[] imgBytes = Convert.FromBase64String(byteString);
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting image: {ex.Message}");
                return null;
            }

        }
        private bool checkNull()
        {
            if (picItemProduct.Image == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemClick();
        }

        private void lbNameProduct_Click(object sender, EventArgs e)
        {
            itemClick();
        }

        private void lbPrice_Click(object sender, EventArgs e)
        {
            itemClick();
        }




        private void itemClick()
        {
            Tuple<int, string, int> productInfo = productManager.GetProductInfo(_idProduct);
            Console.WriteLine("Ho" + _idProduct);

            if (productInfo != null)
            {
                int productId = productInfo.Item1;
                string productName = productInfo.Item2;
                int productPrice = productInfo.Item3;

                F_SalesManager f = new F_SalesManager(productId, productName, productPrice);

            }
            else
            {
                
                MessageBox.Show("Không thể lấy thông tin sản phẩm.");
            }
        }


    }
}
