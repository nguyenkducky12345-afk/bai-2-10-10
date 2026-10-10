namespace bai_2_10_10
{
    public partial class Form1 : Form
    {
        private sealed class ServiceItem
        {
            public ServiceItem(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; }
            public decimal Price { get; }

            public override string ToString() => $"{Name} - {Price:N0} đ";
        }

        private readonly Dictionary<string, List<ServiceItem>> servicesByCategory = new()
        {
            ["Khám bệnh"] =
            [
                new ServiceItem("Khám tổng quát", 150000),
                new ServiceItem("Khám chuyên khoa", 250000),
                new ServiceItem("Khám sức khỏe định kỳ", 350000)
            ],
            ["Xét nghiệm"] =
            [
                new ServiceItem("Xét nghiệm máu", 120000),
                new ServiceItem("Xét nghiệm nước tiểu", 80000),
                new ServiceItem("Xét nghiệm đường huyết", 100000)
            ],
            ["Chụp X-Quang"] =
            [
                new ServiceItem("X-Quang phổi", 180000),
                new ServiceItem("X-Quang cột sống", 250000),
                new ServiceItem("X-Quang khớp", 220000)
            ],
            ["Vắc-xin"] =
            [
                new ServiceItem("Vắc-xin cúm", 200000),
                new ServiceItem("Vắc-xin viêm gan B", 250000),
                new ServiceItem("Vắc-xin uốn ván", 150000)
            ]
        };

        public Form1()
        {
            InitializeComponent();
            cboCategory.Items.AddRange(servicesByCategory.Keys.ToArray());
            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }
            UpdateTotals();
        }

        private void cboCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();
            if (cboCategory.SelectedItem is string category && servicesByCategory.TryGetValue(category, out var services))
            {
                foreach (var service in services)
                {
                    lstAvailableServices.Items.Add(service);
                }
            }
        }

        private void btnSelect_Click(object? sender, EventArgs e)
        {
            MoveSelectedServiceToOrder();
        }

        private void lstAvailableServices_DoubleClick(object? sender, EventArgs e)
        {
            MoveSelectedServiceToOrder();
        }

        private void MoveSelectedServiceToOrder()
        {
            if (lstAvailableServices.SelectedItem is not ServiceItem service)
            {
                return;
            }

            if (!lstSelectedServices.Items.Contains(service))
            {
                lstSelectedServices.Items.Add(service);
            }

            lstAvailableServices.Items.Remove(service);
            UpdateTotals();
        }

        private void btnRemove_Click(object? sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem is not ServiceItem service)
            {
                return;
            }

            lstSelectedServices.Items.Remove(service);
            AddServiceBackToAvailableList(service);
            UpdateTotals();
        }

        private void btnClearAll_Click(object? sender, EventArgs e)
        {
            var selectedServices = lstSelectedServices.Items.Cast<ServiceItem>().ToList();
            lstSelectedServices.Items.Clear();
            foreach (var service in selectedServices)
            {
                AddServiceBackToAvailableList(service);
            }

            UpdateTotals();
        }

        private void AddServiceBackToAvailableList(ServiceItem service)
        {
            if (cboCategory.SelectedItem is string category &&
                servicesByCategory.TryGetValue(category, out var services) &&
                services.Contains(service) &&
                !lstAvailableServices.Items.Contains(service))
            {
                lstAvailableServices.Items.Add(service);
            }
        }

        private void lstSelectedServices_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void nudDiscountRate_ValueChanged(object? sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            decimal subtotal = lstSelectedServices.Items.Cast<ServiceItem>().Sum(service => service.Price);
            decimal discount = subtotal * nudDiscountRate.Value / 100;
            decimal total = subtotal - discount;

            lblSubtotal.Text = $"{subtotal:N0} đ";
            lblDiscount.Text = $"{discount:N0} đ";
            lblTotal.Text = $"{total:N0} đ";
        }
    }
}
