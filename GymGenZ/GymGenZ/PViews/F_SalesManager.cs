using GymGenZ.PControls;
using GymGenZ.PModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GymGenZ.PViews
{
    public partial class F_SalesManager : Form
    {


        string byteImage = "";
        private CProduct _dataService;
        private CProduct _dataProduct =  new CProduct("Data Source=C:\\Data\\GYM.db");

        private List<MProduct> _products;
        private List<MPaymentProduct> _productPaymet;
        private String _idPayProduct = null;
        int IdProduct;
        string Name;
        int priceProduct;
        DateTime billDay = DateTime.Now;

        public F_SalesManager()
        { 
            InitializeComponent();
            _dataService = new CProduct("Data Source=C:\\Data\\GYM.db");
            loadDataToGridProductChoose();
            SearchProduct();

        }
        private void loadDataToGridProductChoose()
        {
            _productPaymet = _dataProduct.LoadPaymentProduct();
            if (dtgvChooseProduct == null)
            {
                dtgvChooseProduct = new DataGridView();
                // Thiết lập các thuộc tính cần thiết cho dtgvChooseProduct (nếu có).
                this.Controls.Add(dtgvChooseProduct);
            }
            dtgvChooseProduct.DataSource = _productPaymet;



        }

        public F_SalesManager(int _idProduct, string _name, int _price)
        {
            IdProduct = _idProduct;
            Name = _name;
            priceProduct = _price;

            

            Console.WriteLine(IdProduct + Name + priceProduct);

            try
            {
                MPaymentProduct newProduct = new MPaymentProduct
                {
                    
                    NameProduct = Name,
                    PriceProduct = priceProduct,
                    CountProduct = 1,
                    IDProduct = IdProduct,
                    payDay = billDay.ToString(),
                    
                };
                _dataProduct = new CProduct("Data Source=C:\\Data\\GYM.db");

                bool addedSuccessfully = _dataProduct.AddOrUpdateProductChoose(newProduct);
                if (addedSuccessfully)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToGridProductChoose();
                }
                else
                {
                    MessageBox.Show("Không thể thêm sản phẩm.\nVui lòng thử lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm sản phẩm: {ex.Message}");
            }


        }

        

        public void btnTatCa_Click(object sender, EventArgs e)
        {
            tbFind.Clear();
            SearchProduct();
        }
  
        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void SearchProduct()
        {
            pnDanhSach.Controls.Clear();
            string searchText = tbFind.Text.Trim();
            _products = _dataService.SearchCustomers(searchText);
            Console.WriteLine(_products.Count);
            
            foreach (MProduct product in _products)
            {

                itemProduct itemProduct = new itemProduct(product.id, product.nameProduct, product.price, product.count, product.image);

    
                itemProduct.TopLevel = false;


                pnDanhSach.Controls.Add(itemProduct);
                itemProduct.Show();
            }
            



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchProduct();
        }

        private void F_SalesManager_Load(object sender, EventArgs e)
        {

        }

        private void btnWheyProtein_Click(object sender, EventArgs e)
        {

            pnDanhSach.Controls.Clear();

            Console.WriteLine(_products.Count);

            foreach (MProduct product in _products)
            {

                itemProduct itemProduct = new itemProduct(product.id, product.nameProduct, product.price, product.idCateProduct, product.image);


                if (product.idCateProduct == 1) {
                    itemProduct.TopLevel = false;


                    pnDanhSach.Controls.Add(itemProduct);
                    itemProduct.Show();

                }

                
            }

          
        }

        private void btnNuocDetox_Click(object sender, EventArgs e)
        {
            pnDanhSach.Controls.Clear();

            Console.WriteLine(_products.Count);

            foreach (MProduct product in _products)
            {

                itemProduct itemProduct = new itemProduct(product.id, product.nameProduct, product.price, product.idCateProduct, product.image);


                if (product.idCateProduct == 2)
                {
                    itemProduct.TopLevel = false;


                    pnDanhSach.Controls.Add(itemProduct);
                    itemProduct.Show();

                }


            }
        }

        private void btnNuocGiaKhat_Click(object sender, EventArgs e)
        {
            tbFind.Clear();
            pnDanhSach.Controls.Clear();

            Console.WriteLine(_products.Count);

            foreach (MProduct product in _products)
            {

                itemProduct itemProduct = new itemProduct(product.id, product.nameProduct, product.price, product.idCateProduct, product.image);


                if (product.idCateProduct == 3)
                {
                    itemProduct.TopLevel = false;


                    pnDanhSach.Controls.Add(itemProduct);
                    itemProduct.Show();

                }


            }

        }

        private void btnSpKhac_Click(object sender, EventArgs e)
        {
            tbFind.Clear();
            pnDanhSach.Controls.Clear();

            Console.WriteLine(_products.Count);

            foreach (MProduct product in _products)
            {

                itemProduct itemProduct = new itemProduct(product.id, product.nameProduct, product.price, product.idCateProduct, product.image);


                if (product.idCateProduct == 4)
                {
                    itemProduct.TopLevel = false;


                    pnDanhSach.Controls.Add(itemProduct);
                    itemProduct.Show();

                }


            }
        }

        internal void AddProductToPanel(item_ChooseProduct item_ChooseProduct)
        {
            // Kiểm tra xem Panel có được khởi tạo chưa
            if (pnDanhSach != null)
            {
                // Thêm UserControl vào Panel
                pnDanhSach.Controls.Add(item_ChooseProduct);
                // Hiển thị UserControl
                item_ChooseProduct.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool deletedSuccessfully = _dataService.DeleteProduct(_idPayProduct);
            if (deletedSuccessfully)
            {
                MessageBox.Show("Xóa nhân viên thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataToGridProductChoose();
                totalAmount();

            }
            else
            {
                MessageBox.Show("Không thể xóa nhân viên.\nVui lòng thử lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private MPaymentProduct selectedProduct;

        private void dtgvChooseProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < dtgvChooseProduct.Rows.Count)
            {
                DataGridViewRow selectedRow = dtgvChooseProduct.Rows[e.RowIndex];

                // Lưu thông tin khách hàng vào biến hoặc thuộc tính
                selectedProduct = new MPaymentProduct
                {
                    CountProduct = int.Parse(selectedRow.Cells["CountProduct"].Value.ToString())
                };

                // Đặt giá trị vào các TextBox
                tbSL.Text = selectedProduct.CountProduct.ToString();

            }
        }

        private void dtgvChooseProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvChooseProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvChooseProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvChooseProduct.SelectedRows[0];
                _idPayProduct = selectedRow.Cells["id"].Value.ToString();
            }
            
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
                
            loadDataToGridProductChoose();
            totalAmount();

        }

        private void totalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dtgvChooseProduct.Rows)
            {
                if (row.Cells["PriceProduct"].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["PriceProduct"].Value);
                }
            }

            // Hiển thị tổng giá
            tbTotal.Text = $"Tổng giá: {totalAmount.ToString("c")}";
        }

        private void numricCount_ValueChanged(object sender, EventArgs e)
        {
            

        }


        private void numricCount_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            //if (selectedProduct != null)
            //{
            //    int productId = selectedProduct.id;
            //    MessageBox.Show("Check-in thành công");

            //    if (int.TryParse(selectedProduct.CountProduct.ToString(), out int currentCount))
            //    {
            //        // Tăng số lượng sản phẩm trong cơ sở dữ liệu
            //        _dataProduct.UpdateCount(productId, currentCount + 1);

            //        // Cập nhật lại dữ liệu trên DataGridView
            //        loadDataToGridProductChoose();

            //        // Hiển thị số lượng mới trong TextBox
            //        tbSL.Text = (currentCount + 1).ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Giá trị số buổi tập không hợp lệ.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Chưa chọn sản phẩm để tăng số lượng.");
            //}
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Xác nhận xóa hết dữ liệu từ Database
            bool deletedSuccessfully = _dataProduct.DeleteAllProducts();

            if (deletedSuccessfully)
            {
                MessageBox.Show("Xóa tất cả sản phẩm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại nguồn dữ liệu của DataGridView
                loadDataToGridProductChoose();

                // Hiển thị lại tổng giá sau khi xóa dữ liệu
                totalAmount();
            }
            else
            {
                MessageBox.Show("Không thể xóa tất cả sản phẩm.\nVui lòng thử lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}
