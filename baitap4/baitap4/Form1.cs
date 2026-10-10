using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace baitap4
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel tlpSeats;
        private Label lblSelectedCountLabel;
        private Label lblSelectedCountValue;
        private Label lblSubtotalLabel;
        private Label lblSubtotalValue;
        private ComboBox cbTimeSlot;
        private Button btnConfirm;
        private Button btnCancelAll;

        private const int Rows = 4;
        private const int Cols = 5;

        // prices in VND
        private readonly Dictionary<string, int> slotPrices = new()
        {
            { "Sáng", 100_000 },
            { "Tối", 150_000 }
        };

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            InitializeDynamicLayout();
        }

        private void InitializeDynamicLayout()
        {
            // Create TableLayoutPanel for seats
            tlpSeats = new TableLayoutPanel
            {
                RowCount = Rows,
                ColumnCount = Cols,
                Dock = DockStyle.Left,
                Width = 500,
                AutoSize = false,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            for (int r = 0; r < Rows; r++)
            {
                tlpSeats.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / Rows));
            }

            for (int c = 0; c < Cols; c++)
            {
                tlpSeats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / Cols));
            }

            // Right side panel for controls
            var pnlRight = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            lblSelectedCountLabel = new Label { Text = "Số vị trí đang chọn:", AutoSize = true, Top = 10, Left = 10 };
            lblSelectedCountValue = new Label { Text = "0", AutoSize = true, Top = lblSelectedCountLabel.Bottom + 6, Left = 10, Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold) };

            lblSubtotalLabel = new Label { Text = "Tạm tính tiền:", AutoSize = true, Top = lblSelectedCountValue.Bottom + 12, Left = 10 };
            lblSubtotalValue = new Label { Text = "0 đ", AutoSize = true, Top = lblSubtotalLabel.Bottom + 6, Left = 10, Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold) };

            cbTimeSlot = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Top = lblSubtotalValue.Bottom + 12, Left = 10, Width = 150 };
            cbTimeSlot.Items.AddRange(slotPrices.Keys.ToArray());
            cbTimeSlot.SelectedIndex = 0;
            cbTimeSlot.SelectedIndexChanged += (s, e) => UpdateStats();

            btnConfirm = new Button { Text = "Xác nhận đặt", Top = cbTimeSlot.Bottom + 20, Left = 10, Width = 120 };
            btnConfirm.Click += BtnConfirm_Click;

            btnCancelAll = new Button { Text = "Hủy chọn tất cả", Top = btnConfirm.Bottom + 10, Left = 10, Width = 120 };
            btnCancelAll.Click += BtnCancelAll_Click;

            pnlRight.Controls.Add(lblSelectedCountLabel);
            pnlRight.Controls.Add(lblSelectedCountValue);
            pnlRight.Controls.Add(lblSubtotalLabel);
            pnlRight.Controls.Add(lblSubtotalValue);
            pnlRight.Controls.Add(cbTimeSlot);
            pnlRight.Controls.Add(btnConfirm);
            pnlRight.Controls.Add(btnCancelAll);

            Controls.Add(pnlRight);
            Controls.Add(tlpSeats);

            // Create 20 buttons
            int seatIndex = 1;
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    var btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(8),
                        Text = seatIndex.ToString(),
                        Tag = 0 // 0 = empty, 1 = selected, 2 = booked
                    };

                    btn.Click += SeatButton_Click;

                    // Example: mark a few seats as already booked
                    if (seatIndex == 4 || seatIndex == 8)
                    {
                        btn.Tag = 2;
                        btn.BackColor = Color.LightCoral;
                        btn.Enabled = true; // still enabled but will not toggle
                    }
                    else
                    {
                        btn.BackColor = Color.WhiteSmoke;
                    }

                    tlpSeats.Controls.Add(btn, c, r);
                    seatIndex++;
                }
            }

            UpdateStats();
        }

        private void SeatButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            var state = Convert.ToInt32(btn.Tag);
            if (state == 2)
            {
                // already booked/locked, ignore clicks
                return;
            }

            if (state == 0)
            {
                // select
                btn.Tag = 1;
                btn.BackColor = Color.LightGreen;
            }
            else if (state == 1)
            {
                // deselect
                btn.Tag = 0;
                btn.BackColor = Color.WhiteSmoke;
            }

            UpdateStats();
        }

        private void BtnConfirm_Click(object? sender, EventArgs e)
        {
            // mark selected seats as booked
            foreach (Control ctl in tlpSeats.Controls)
            {
                if (ctl is Button btn)
                {
                    var state = Convert.ToInt32(btn.Tag);
                    if (state == 1)
                    {
                        btn.Tag = 2;
                        btn.BackColor = Color.LightCoral;
                    }
                }
            }

            UpdateStats();
        }

        private void BtnCancelAll_Click(object? sender, EventArgs e)
        {
            // deselect all selected (but don't un-book booked ones)
            foreach (Control ctl in tlpSeats.Controls)
            {
                if (ctl is Button btn)
                {
                    var state = Convert.ToInt32(btn.Tag);
                    if (state == 1)
                    {
                        btn.Tag = 0;
                        btn.BackColor = Color.WhiteSmoke;
                    }
                }
            }

            UpdateStats();
        }

        private void UpdateStats()
        {
            int selectedCount = 0;
            foreach (Control ctl in tlpSeats.Controls)
            {
                if (ctl is Button btn)
                {
                    if (Convert.ToInt32(btn.Tag) == 1) selectedCount++;
                }
            }

            lblSelectedCountValue.Text = selectedCount.ToString();

            var selectedSlot = cbTimeSlot.SelectedItem as string ?? "Sáng";
            var price = slotPrices.ContainsKey(selectedSlot) ? slotPrices[selectedSlot] : 0;
            var subtotal = selectedCount * price;
            lblSubtotalValue.Text = subtotal.ToString("N0") + " đ";
        }
    }
}
