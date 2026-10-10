using System;
using System.Windows.Forms;
using System.Drawing;

namespace baitap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGridColumns();
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            UpdateStatusTotals();
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            dataGridView1.CellValidating += DataGridView1_CellValidating;
            dataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
            dataGridView1.UserAddedRow += DataGridView1_UserAddedRow;
        }

        private void InitializeGridColumns()
        {
            dataGridView1.Columns.Clear();
            var colName = new DataGridViewTextBoxColumn() { Name = "ItemName", HeaderText = "Item Name", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            var colQty = new DataGridViewTextBoxColumn() { Name = "Quantity", HeaderText = "Quantity", Width = 80 };
            var colWeight = new DataGridViewTextBoxColumn() { Name = "Weight", HeaderText = "Weight (kg)", Width = 90 };
            var colUnit = new DataGridViewTextBoxColumn() { Name = "UnitPrice", HeaderText = "Unit Price", Width = 100 };
            var colTotal = new DataGridViewTextBoxColumn() { Name = "TotalPrice", HeaderText = "Total", Width = 120, ReadOnly = true };

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colQty, colWeight, colUnit, colTotal });
            // default some formatting
            dataGridView1.Columns[3].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "C2";
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("G");
        }

        private void DataGridView1_CellValidating(object? sender, DataGridViewCellValidatingEventArgs e)
        {
            var grid = dataGridView1;
            if (e.RowIndex < 0) return;
            var colName = grid.Columns[e.ColumnIndex].Name;
            if (colName == "Quantity" || colName == "Weight")
            {
                var text = e.FormattedValue?.ToString() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(text))
                {
                    // allow empty (user may be editing) but clear error
                    grid.Rows[e.RowIndex].ErrorText = string.Empty;
                    return;
                }
                if (!double.TryParse(text, out var val) || val <= 0)
                {
                    e.Cancel = true;
                    var msg = "Value must be a number greater than 0";
                    grid.Rows[e.RowIndex].ErrorText = msg;
                    errorProvider1.SetError(grid, msg);
                }
                else
                {
                    grid.Rows[e.RowIndex].ErrorText = string.Empty;
                    errorProvider1.SetError(grid, string.Empty);
                }
            }
        }

        private void DataGridView1_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            // clear any row error after edit
            if (e.RowIndex < 0) return;
            dataGridView1.Rows[e.RowIndex].ErrorText = string.Empty;
            errorProvider1.SetError(dataGridView1, string.Empty);
            RecalculateRowTotal(e.RowIndex);
            UpdateStatusTotals();
        }

        private void RecalculateRowTotal(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dataGridView1.Rows.Count) return;
            var row = dataGridView1.Rows[rowIndex];
            if (row.IsNewRow) return;
            decimal qty = 0m;
            decimal unit = 0m;
            if (row.Cells["Quantity"].Value != null && decimal.TryParse(row.Cells["Quantity"].Value.ToString(), out var q)) qty = q;
            if (row.Cells["UnitPrice"].Value != null && decimal.TryParse(row.Cells["UnitPrice"].Value.ToString(), out var u)) unit = u;
            var total = qty * unit;
            row.Cells["TotalPrice"].Value = total;
        }

        private void DataGridView1_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = dataGridView1.Columns[e.ColumnIndex].Name;
            if (col == "Quantity" || col == "UnitPrice" || col == "Weight")
            {
                RecalculateRowTotal(e.RowIndex);
                UpdateStatusTotals();
            }
        }

        private void DataGridView1_RowsRemoved(object? sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateStatusTotals();
        }

        private void DataGridView1_UserAddedRow(object? sender, DataGridViewRowEventArgs e)
        {
            UpdateStatusTotals();
        }

        private void UpdateStatusTotals()
        {
            int totalQty = 0;
            double totalWeight = 0.0;
            decimal totalAmount = 0m;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["Quantity"].Value != null && int.TryParse(row.Cells["Quantity"].Value.ToString(), out var q)) totalQty += q;
                if (row.Cells["Weight"].Value != null && double.TryParse(row.Cells["Weight"].Value.ToString(), out var w)) totalWeight += w;
                if (row.Cells["TotalPrice"].Value != null && decimal.TryParse(row.Cells["TotalPrice"].Value.ToString(), out var t)) totalAmount += t;
            }
            toolStripStatusLabelTotals.Text = $"Total qty: {totalQty}    Total weight: {totalWeight:N2} kg    Total: {totalAmount:C2}";
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                // add new row
                dataGridView1.Rows.Add();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                // delete selected rows
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dataGridView1.Rows.Remove(row);
                }
                e.Handled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // also respect F2/Delete when grid has focus
            if (keyData == Keys.F2)
            {
                dataGridView1.Rows.Add();
                return true;
            }
            if (keyData == Keys.Delete)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dataGridView1.Rows.Remove(row);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
