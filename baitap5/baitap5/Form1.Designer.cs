namespace baitap5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label labelShipping;
        private System.Windows.Forms.ComboBox comboBoxShipping;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotals;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;

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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            groupBoxCustomer = new GroupBox();
            labelCustomer = new Label();
            textBoxCustomer = new TextBox();
            labelShipping = new Label();
            comboBoxShipping = new ComboBox();
            groupBoxGrid = new GroupBox();
            dataGridView1 = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelTime = new ToolStripStatusLabel();
            toolStripStatusLabelTotals = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxCustomer.SuspendLayout();
            groupBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxCustomer);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxGrid);
            splitContainer1.Size = new Size(800, 424);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxCustomer
            // 
            groupBoxCustomer.Controls.Add(labelCustomer);
            groupBoxCustomer.Controls.Add(textBoxCustomer);
            groupBoxCustomer.Controls.Add(labelShipping);
            groupBoxCustomer.Controls.Add(comboBoxShipping);
            groupBoxCustomer.Dock = DockStyle.Fill;
            groupBoxCustomer.Location = new Point(0, 0);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Size = new Size(260, 424);
            groupBoxCustomer.TabIndex = 0;
            groupBoxCustomer.TabStop = false;
            groupBoxCustomer.Text = "Customer & Shipping";
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(12, 28);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(75, 20);
            labelCustomer.TabIndex = 0;
            labelCustomer.Text = "Customer:";
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.Location = new Point(12, 46);
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.Size = new Size(232, 27);
            textBoxCustomer.TabIndex = 1;
            // 
            // labelShipping
            // 
            labelShipping.AutoSize = true;
            labelShipping.Location = new Point(12, 82);
            labelShipping.Name = "labelShipping";
            labelShipping.Size = new Size(127, 20);
            labelShipping.TabIndex = 2;
            labelShipping.Text = "Shipping method:";
            // 
            // comboBoxShipping
            // 
            comboBoxShipping.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxShipping.FormattingEnabled = true;
            comboBoxShipping.Items.AddRange(new object[] { "Standard", "Express", "Overnight" });
            comboBoxShipping.Location = new Point(12, 100);
            comboBoxShipping.Name = "comboBoxShipping";
            comboBoxShipping.Size = new Size(232, 28);
            comboBoxShipping.TabIndex = 3;
            // 
            // groupBoxGrid
            // 
            groupBoxGrid.Controls.Add(dataGridView1);
            groupBoxGrid.Dock = DockStyle.Fill;
            groupBoxGrid.Location = new Point(0, 0);
            groupBoxGrid.Name = "groupBoxGrid";
            groupBoxGrid.Size = new Size(536, 424);
            groupBoxGrid.TabIndex = 0;
            groupBoxGrid.TabStop = false;
            groupBoxGrid.Text = "Order Items";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(530, 398);
            dataGridView1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTime, toolStripStatusLabelTotals });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTime
            // 
            toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            toolStripStatusLabelTime.Size = new Size(176, 20);
            toolStripStatusLabelTime.Text = "toolStripStatusLabelTime";
            // 
            // toolStripStatusLabelTotals
            // 
            toolStripStatusLabelTotals.Name = "toolStripStatusLabelTotals";
            toolStripStatusLabelTotals.Size = new Size(570, 20);
            toolStripStatusLabelTotals.Spring = true;
            toolStripStatusLabelTotals.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Delivery Order Dashboard";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxCustomer.ResumeLayout(false);
            groupBoxCustomer.PerformLayout();
            groupBoxGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
