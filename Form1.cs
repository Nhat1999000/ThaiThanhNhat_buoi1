namespace ThaiThanhNhat_buoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double RoundToTwoDecimalPlaces(double value)
        {
            return Math.Round(value, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            if (double.TryParse(txta.Text, out double a) &&
                double.TryParse(txtb.Text, out double b) &&
                double.TryParse(txtc.Text, out double c))
            {
                // Tính delta
                double delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    double x1 = RoundToTwoDecimalPlaces(-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = RoundToTwoDecimalPlaces(-b - Math.Sqrt(delta)) / (2 * a);
                    txtkq.Text = $"Phương trình có hai nghiệm phân biệt:\n X1 = {x1}\n X2 = {x2}";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    txtkq.Text = $"Phương trình có nghiệm kép:\n X = {x}";
                }
                else
                {
                    txtkq.Text = "Phương trình vô nghiệm.";
                }
            }
            else
            {
                txtkq.Text = "Vui lòng nhập đúng các hệ số.";
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Xóa trắng các TextBox và Label
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtkq.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng
            Application.Exit();
        }
    }
}
