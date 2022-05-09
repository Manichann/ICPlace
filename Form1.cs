namespace IC
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Manichanh" && txtPass.Text == "282002")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ຊື່ຜູ້ໃຊ້ ຫຼື ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ, ກະລຸນາລອງໃໝ່ອີກຄັ້ງ", "Log in");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please come again later, Thank You", "IC Place", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}