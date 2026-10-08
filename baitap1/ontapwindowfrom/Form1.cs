using System;
using System.Windows.Forms;

namespace ontapwindowfrom
{
    public partial class Form1 : Form
    {
        // Controls declared in designer but partial class needs fields
        private TextBox txtUnitPrice;
        private Label lblUnitPrice;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private TextBox txtDiscount;
        private Label lblDiscount;
        private Label lblTotal;
        private Button btnCalculate;
        private Button btnReset;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá và số lượng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out var unitPrice))
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return;
            }

            if (!decimal.TryParse(txtQuantity.Text, out var quantity))
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            decimal discount = 0m;
            if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                if (!decimal.TryParse(txtDiscount.Text, out discount))
                {
                    MessageBox.Show("Mã giảm giá không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiscount.Focus();
                    return;
                }
            }

            if (discount < 0 || discount > 100)
            {
                MessageBox.Show("% giảm phải nằm trong khoảng 0 - 100.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }

            var total = (unitPrice * quantity) * (100 - discount) / 100m;

            lblTotal.Text = $"Tổng tiền thanh toán: {total:C}";
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            lblTotal.Text = "Tổng tiền thanh toán: 0";
            txtUnitPrice.Focus();
        }
    }
}
