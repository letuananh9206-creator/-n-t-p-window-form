namespace baitap2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTicketId;
        private System.Windows.Forms.TextBox textBoxTicketId;
        private System.Windows.Forms.Label labelRequester;
        private System.Windows.Forms.TextBox textBoxRequester;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBoxPriority;
        private System.Windows.Forms.RadioButton radioUrgent;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioLow;
        private System.Windows.Forms.GroupBox groupBoxClassification;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.GroupBox groupBoxDevices;
        private System.Windows.Forms.CheckBox checkPhone;
        private System.Windows.Forms.CheckBox checkPrinter;
        private System.Windows.Forms.CheckBox checkLaptop;
        private System.Windows.Forms.CheckBox checkDesktop;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonReset;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTicketId = new System.Windows.Forms.Label();
            this.textBoxTicketId = new System.Windows.Forms.TextBox();
            this.labelRequester = new System.Windows.Forms.Label();
            this.textBoxRequester = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPriority = new System.Windows.Forms.GroupBox();
            this.radioUrgent = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioLow = new System.Windows.Forms.RadioButton();
            this.groupBoxClassification = new System.Windows.Forms.GroupBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.groupBoxDevices = new System.Windows.Forms.GroupBox();
            this.checkPhone = new System.Windows.Forms.CheckBox();
            this.checkPrinter = new System.Windows.Forms.CheckBox();
            this.checkLaptop = new System.Windows.Forms.CheckBox();
            this.checkDesktop = new System.Windows.Forms.CheckBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            //
            // labelTicketId
            //
            this.labelTicketId.AutoSize = true;
            this.labelTicketId.Location = new System.Drawing.Point(12, 15);
            this.labelTicketId.Name = "labelTicketId";
            this.labelTicketId.Size = new System.Drawing.Size(58, 15);
            this.labelTicketId.Text = "Mã phiếu";
            //
            // textBoxTicketId
            //
            this.textBoxTicketId.Location = new System.Drawing.Point(100, 12);
            this.textBoxTicketId.Name = "textBoxTicketId";
            this.textBoxTicketId.Size = new System.Drawing.Size(200, 23);
            //
            // labelRequester
            //
            this.labelRequester.AutoSize = true;
            this.labelRequester.Location = new System.Drawing.Point(12, 50);
            this.labelRequester.Name = "labelRequester";
            this.labelRequester.Size = new System.Drawing.Size(82, 15);
            this.labelRequester.Text = "Người yêu cầu";
            //
            // textBoxRequester
            //
            this.textBoxRequester.Location = new System.Drawing.Point(100, 47);
            this.textBoxRequester.Name = "textBoxRequester";
            this.textBoxRequester.Size = new System.Drawing.Size(200, 23);
            //
            // labelDate
            //
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 85);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(78, 15);
            this.labelDate.Text = "Ngày ghi nhận";
            //
            // dateTimePicker
            //
            this.dateTimePicker.Location = new System.Drawing.Point(100, 80);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            //
            // groupBoxPriority
            //
            this.groupBoxPriority.Location = new System.Drawing.Point(12, 120);
            this.groupBoxPriority.Name = "groupBoxPriority";
            this.groupBoxPriority.Size = new System.Drawing.Size(288, 60);
            this.groupBoxPriority.Text = "Mức độ ưu tiên";
            //
            // radioLow
            //
            this.radioLow.AutoSize = true;
            this.radioLow.Location = new System.Drawing.Point(10, 25);
            this.radioLow.Name = "radioLow";
            this.radioLow.Size = new System.Drawing.Size(46, 19);
            this.radioLow.Text = "Thấp";
            this.radioLow.Checked = true;
            //
            // radioMedium
            //
            this.radioMedium.AutoSize = true;
            this.radioMedium.Location = new System.Drawing.Point(100, 25);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(84, 19);
            this.radioMedium.Text = "Trung bình";
            //
            // radioUrgent
            //
            this.radioUrgent.AutoSize = true;
            this.radioUrgent.Location = new System.Drawing.Point(200, 25);
            this.radioUrgent.Name = "radioUrgent";
            this.radioUrgent.Size = new System.Drawing.Size(65, 19);
            this.radioUrgent.Text = "Khẩn cấp";
            //
            // groupBoxClassification
            //
            this.groupBoxClassification.Location = new System.Drawing.Point(12, 190);
            this.groupBoxClassification.Name = "groupBoxClassification";
            this.groupBoxClassification.Size = new System.Drawing.Size(288, 100);
            this.groupBoxClassification.Text = "Phân loại & Chi tiết";
            //
            // labelType
            //
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(10, 25);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(59, 15);
            this.labelType.Text = "Loại sự cố";
            //
            // comboBoxType
            //
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Location = new System.Drawing.Point(100, 22);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(170, 23);
            this.comboBoxType.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            //
            // groupBoxDevices
            //
            this.groupBoxDevices.Location = new System.Drawing.Point(320, 12);
            this.groupBoxDevices.Name = "groupBoxDevices";
            this.groupBoxDevices.Size = new System.Drawing.Size(200, 140);
            this.groupBoxDevices.Text = "Thiết bị ảnh hưởng";
            //
            // checkDesktop
            //
            this.checkDesktop.AutoSize = true;
            this.checkDesktop.Location = new System.Drawing.Point(10, 25);
            this.checkDesktop.Name = "checkDesktop";
            this.checkDesktop.Size = new System.Drawing.Size(87, 19);
            this.checkDesktop.Text = "Máy tính bàn";
            //
            // checkLaptop
            //
            this.checkLaptop.AutoSize = true;
            this.checkLaptop.Location = new System.Drawing.Point(10, 50);
            this.checkLaptop.Name = "checkLaptop";
            this.checkLaptop.Size = new System.Drawing.Size(58, 19);
            this.checkLaptop.Text = "Laptop";
            //
            // checkPrinter
            //
            this.checkPrinter.AutoSize = true;
            this.checkPrinter.Location = new System.Drawing.Point(10, 75);
            this.checkPrinter.Name = "checkPrinter";
            this.checkPrinter.Size = new System.Drawing.Size(59, 19);
            this.checkPrinter.Text = "Máy in";
            //
            // checkPhone
            //
            this.checkPhone.AutoSize = true;
            this.checkPhone.Location = new System.Drawing.Point(10, 100);
            this.checkPhone.Name = "checkPhone";
            this.checkPhone.Size = new System.Drawing.Size(70, 19);
            this.checkPhone.Text = "Điện thoại";
            //
            // pictureBox
            //
            this.pictureBox.Location = new System.Drawing.Point(320, 160);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(320, 160);
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //
            // buttonLoadImage
            //
            this.buttonLoadImage.Location = new System.Drawing.Point(320, 330);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(120, 30);
            this.buttonLoadImage.Text = "Tải ảnh lỗi";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            //
            // buttonReset
            //
            this.buttonReset.Location = new System.Drawing.Point(540, 330);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 30);
            this.buttonReset.Text = "Nhập lại";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            //
            // buttonSend
            //
            this.buttonSend.Location = new System.Drawing.Point(660, 330);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 30);
            this.buttonSend.Text = "Gửi yêu cầu";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            //
            // Add controls to group boxes
            //
            this.groupBoxPriority.Controls.Add(this.radioLow);
            this.groupBoxPriority.Controls.Add(this.radioMedium);
            this.groupBoxPriority.Controls.Add(this.radioUrgent);
            this.groupBoxClassification.Controls.Add(this.labelType);
            this.groupBoxClassification.Controls.Add(this.comboBoxType);
            this.groupBoxDevices.Controls.Add(this.checkDesktop);
            this.groupBoxDevices.Controls.Add(this.checkLaptop);
            this.groupBoxDevices.Controls.Add(this.checkPrinter);
            this.groupBoxDevices.Controls.Add(this.checkPhone);
            //
            // Form1
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTicketId);
            this.Controls.Add(this.textBoxTicketId);
            this.Controls.Add(this.labelRequester);
            this.Controls.Add(this.textBoxRequester);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.groupBoxPriority);
            this.Controls.Add(this.groupBoxClassification);
            this.Controls.Add(this.groupBoxDevices);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSend);
            this.Name = "Form1";
            this.Text = "Form Tiếp nhận & Phân loại sự cố IT";
        }

        #endregion
    }
}
