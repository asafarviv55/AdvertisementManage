using WinFormsApp2.Data;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Validate inputs
            if (cmbCustomer.SelectedValue == null || cmbAgent.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtAdText.Text) ||
                string.IsNullOrWhiteSpace(txtPaymentAmount.Text) ||
                cmbAdType.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the required fields.");
                return;
            }

            // Create new advertisement
            var advertisement = new Advertisement
            {
                CustomerID = (int)cmbCustomer.SelectedValue,
                Text = txtAdText.Text,
                Type = cmbAdType.SelectedItem.ToString(),
                PackageType = cmbAdType.SelectedItem.ToString() == "Package" ? cmbPackageType.SelectedItem.ToString() : null,
                AgentID = (int)cmbAgent.SelectedValue,
                PaymentAmount = decimal.Parse(txtPaymentAmount.Text),
                StartDate = DateTime.Now, // Assuming start date is now
                CreatedBy = "Admin", // Replace with actual user
                CreatedOn = DateTime.Now
            };

            // Save to database
            _context.Advertisements.Add(advertisement);
            _context.SaveChanges();
            MessageBox.Show("Advertisement saved successfully!");
        }
    }
}
