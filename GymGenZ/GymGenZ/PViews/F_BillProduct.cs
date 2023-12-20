using GymGenZ.PControls;
using GymGenZ.PModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymGenZ.PViews
{
    public partial class F_BillProduct : Form
    {


        private CProduct _dataProductBill = new CProduct("Data Source=C:\\Data\\GYM.db");
        private List<MPaymentProduct> _productsBill;
        public F_BillProduct()
        {

            InitializeComponent();
            loadDataToGridProductChoose();
        }
        private void loadDataToGridProductChoose()
        {
            _productsBill = _dataProductBill.LoadPaymentProduct();
            if (dataGridView1 == null)
            {
                dataGridView1 = new DataGridView();
                // Thiết lập các thuộc tính cần thiết cho dtgvChooseProduct (nếu có).
                this.Controls.Add(dataGridView1);
            }
            dataGridView1.DataSource = _productsBill;


        }
    }
}
