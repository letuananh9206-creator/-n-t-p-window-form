namespace baitap3
{
    using System.Globalization;
    public partial class Form1 : Form
    {
        private List<Item> items = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            var code = txtCode.Text.Trim();
            var name = txtName.Text.Trim();
            var unit = cbUnit.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Mã vật tư không được để trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (items.Any(i => i.Code.Equals(code, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã vật tư đã tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out var price))
            {
                MessageBox.Show("Đơn giá không hợp lệ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new Item { Code = code, Name = name, Unit = unit, Price = price };
            items.Add(item);
            AddListViewItem(item);
            ClearInput();
        }

        private void AddListViewItem(Item item)
        {
            var lvi = new ListViewItem(item.Code);
            lvi.SubItems.Add(item.Name);
            lvi.SubItems.Add(item.Unit);
            lvi.SubItems.Add(item.Price.ToString(CultureInfo.CurrentCulture));
            listViewItems.Items.Add(lvi);
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sel = listViewItems.SelectedItems[0];
            var originalCode = sel.Text;
            var code = txtCode.Text.Trim();
            var name = txtName.Text.Trim();
            var unit = cbUnit.SelectedItem?.ToString() ?? string.Empty;
            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out var price))
            {
                MessageBox.Show("Đơn giá không hợp lệ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If code changed, ensure uniqueness
            if (!originalCode.Equals(code, StringComparison.OrdinalIgnoreCase)
                && items.Any(i => i.Code.Equals(code, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã vật tư đã tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = items.FirstOrDefault(i => i.Code.Equals(originalCode, StringComparison.OrdinalIgnoreCase));
            if (item == null) return;
            item.Code = code;
            item.Name = name;
            item.Unit = unit;
            item.Price = price;

            // update listview
            sel.Text = item.Code;
            sel.SubItems[1].Text = item.Name;
            sel.SubItems[2].Text = item.Unit;
            sel.SubItems[3].Text = item.Price.ToString(CultureInfo.CurrentCulture);
            ClearInput();
        }

        private void BtnDeleteRow_Click(object? sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var res = MessageBox.Show("Bạn có chắc muốn xóa dòng được chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;

            var sel = listViewItems.SelectedItems[0];
            var code = sel.Text;
            // remove from items
            var item = items.FirstOrDefault(i => i.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
            if (item != null) items.Remove(item);
            listViewItems.Items.Remove(sel);
            ClearInput();
        }

        private void BtnClearAll_Click(object? sender, EventArgs e)
        {
            items.Clear();
            listViewItems.Items.Clear();
            ClearInput();
        }

        private void ListViewItems_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0) return;
            var sel = listViewItems.SelectedItems[0];
            txtCode.Text = sel.SubItems[0].Text;
            txtName.Text = sel.SubItems[1].Text;
            var unit = sel.SubItems[2].Text;
            cbUnit.SelectedItem = unit;
            txtPrice.Text = sel.SubItems[3].Text;
        }

        private void ClearInput()
        {
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            cbUnit.SelectedIndex = -1;
            txtPrice.Text = string.Empty;
            listViewItems.SelectedItems.Clear();
        }

        private class Item
        {
            public string Code { get; set; } = string.Empty;
            public string Name { get; set; } = string.Empty;
            public string Unit { get; set; } = string.Empty;
            public decimal Price { get; set; }
        }
    }
}
