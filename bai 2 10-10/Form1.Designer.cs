namespace bai_2_10_10
{
    partial class Form1
    {
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblAvailable;
        private Label lblSelected;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private Label lblSubtotalTitle;
        private Label lblDiscountTitle;
        private Label lblTotalTitle;
        private Label lblSubtotal;
        private Label lblDiscount;
        private Label lblTotal;
        private Label lblDiscountRateTitle;
        private NumericUpDown nudDiscountRate;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblAvailable = new Label();
            lblSelected = new Label();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            lblSubtotalTitle = new Label();
            lblDiscountTitle = new Label();
            lblTotalTitle = new Label();
            lblSubtotal = new Label();
            lblDiscount = new Label();
            lblTotal = new Label();
            lblDiscountRateTitle = new Label();
            nudDiscountRate = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudDiscountRate).BeginInit();
            SuspendLayout();

            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(28, 25);
            lblCategory.Text = "Loại dịch vụ:";
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(130, 21);
            cboCategory.Size = new Size(260, 28);
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;

            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(28, 75);
            lblAvailable.Text = "Dịch vụ có thể chọn";
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(455, 75);
            lblSelected.Text = "Dịch vụ đã chọn";
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.ItemHeight = 25;
            lstAvailableServices.Location = new Point(28, 105);
            lstAvailableServices.Size = new Size(365, 204);
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.ItemHeight = 25;
            lstSelectedServices.Location = new Point(455, 105);
            lstSelectedServices.Size = new Size(365, 204);
            lstSelectedServices.SelectedIndexChanged += lstSelectedServices_SelectedIndexChanged;

            btnSelect.Location = new Point(400, 125);
            btnSelect.Size = new Size(45, 38);
            btnSelect.Text = ">";
            btnSelect.Click += btnSelect_Click;
            btnRemove.Location = new Point(400, 170);
            btnRemove.Size = new Size(45, 38);
            btnRemove.Text = "<";
            btnRemove.Click += btnRemove_Click;
            btnClearAll.Location = new Point(400, 215);
            btnClearAll.Size = new Size(45, 38);
            btnClearAll.Text = "<<";
            btnClearAll.Click += btnClearAll_Click;

            lblSubtotalTitle.AutoSize = true;
            lblSubtotalTitle.Location = new Point(455, 340);
            lblSubtotalTitle.Text = "Tổng tiền chưa giảm:";
            lblSubtotal = CreateValueLabel(new Point(665, 336));
            lblDiscountRateTitle.AutoSize = true;
            lblDiscountRateTitle.Location = new Point(455, 378);
            lblDiscountRateTitle.Text = "Tỷ lệ chiết khấu (%):";
            nudDiscountRate.Location = new Point(665, 374);
            nudDiscountRate.Size = new Size(155, 27);
            nudDiscountRate.DecimalPlaces = 2;
            nudDiscountRate.Maximum = 100;
            nudDiscountRate.Increment = 1;
            nudDiscountRate.ValueChanged += nudDiscountRate_ValueChanged;
            lblDiscountTitle.AutoSize = true;
            lblDiscountTitle.Location = new Point(455, 416);
            lblDiscountTitle.Text = "Tiền chiết khấu:";
            lblDiscount = CreateValueLabel(new Point(665, 412));
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Location = new Point(455, 454);
            lblTotalTitle.Text = "Thành tiền thanh toán:";
            lblTotal = CreateValueLabel(new Point(665, 450));
            lblTotal.Font = new Font(Font, FontStyle.Bold);

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 520);
            Controls.AddRange(new Control[] { lblCategory, cboCategory, lblAvailable, lblSelected,
                lstAvailableServices, lstSelectedServices, btnSelect, btnRemove, btnClearAll,
                lblSubtotalTitle, lblSubtotal, lblDiscountRateTitle, nudDiscountRate,
                lblDiscountTitle, lblDiscount, lblTotalTitle, lblTotal });
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng tính tiền dịch vụ và chiết khấu đơn hàng";
            ((System.ComponentModel.ISupportInitialize)nudDiscountRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private static Label CreateValueLabel(Point location)
        {
            return new Label
            {
                AutoSize = true,
                Location = location,
                Text = "0 đ"
            };
        }

        #endregion
    }
}
