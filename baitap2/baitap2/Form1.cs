using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // set default values
            if (comboBoxType.Items.Count > 0)
                comboBoxType.SelectedIndex = 0;
        }

        private void buttonLoadImage_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            ofd.Title = "Chọn ảnh lỗi";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // dispose previous image if any to avoid file lock
                    if (pictureBox.Image != null)
                    {
                        var old = pictureBox.Image;
                        pictureBox.Image = null;
                        old.Dispose();
                    }

                    pictureBox.Image = Image.FromFile(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSend_Click(object? sender, EventArgs e)
        {
            string ticketId = textBoxTicketId.Text.Trim();
            string requester = textBoxRequester.Text.Trim();
            string date = dateTimePicker.Value.ToString("g");
            string priority = radioLow.Checked ? "Thấp" : radioMedium.Checked ? "Trung bình" : "Khẩn cấp";
            string type = comboBoxType.SelectedItem?.ToString() ?? string.Empty;
            var devices = new[] {
                (checkDesktop, "Máy tính bàn"),
                (checkLaptop, "Laptop"),
                (checkPrinter, "Máy in"),
                (checkPhone, "Điện thoại")
            };
            string devicesAffected = string.Join(", ", devices.Where(d => d.Item1.Checked).Select(d => d.Item2));
            if (string.IsNullOrEmpty(devicesAffected)) devicesAffected = "(Không chọn)";
            string hasImage = pictureBox.Image != null ? "Có" : "Không";

            string summary = $"Mã phiếu: {ticketId}\nNgười yêu cầu: {requester}\nNgày ghi nhận: {date}\nMức độ: {priority}\nLoại sự cố: {type}\nThiết bị ảnh hưởng: {devicesAffected}\nẢnh lỗi: {hasImage}";

            MessageBox.Show(summary, "Tóm tắt yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReset_Click(object? sender, EventArgs e)
        {
            textBoxTicketId.Text = string.Empty;
            textBoxRequester.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
            radioLow.Checked = true;
            if (comboBoxType.Items.Count > 0) comboBoxType.SelectedIndex = 0;
            checkDesktop.Checked = false;
            checkLaptop.Checked = false;
            checkPrinter.Checked = false;
            checkPhone.Checked = false;
            if (pictureBox.Image != null)
            {
                var old = pictureBox.Image;
                pictureBox.Image = null;
                old.Dispose();
            }
        }
    }
}
