namespace IC
{
    public partial class frmHome : Form
    {
        int i = 1;
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (i <= 3)
            {
                if (txtName.Text == "" && txtPass.Text == "")
                {
                    MessageBox.Show("ກະລຸນາປ້ອນຊື່ ແລະ ລະຫັດຜ່ານ", "Error");
                }

                else if (txtName.Text == "Manichanh" && txtPass.Text == "282002")
                {
                    form2 Form2 = new form2();
                    Form2.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("ຊື່ຜູ້ໃຊ້ ຫຼື ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ, ກະລຸນາລອງໃໝ່ອີກຄັ້ງ", "Error");
                }
            }
            else if (i == 4)
            {
                MessageBox.Show("ບໍ່ສາມາດປ້ອນໄດ້, ກະລຸນາລໍຖ້າ ", "Error");
                txtName.Enabled = false;
                txtPass.Enabled = false;
                this.Close();
            }
            i++;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please come again later, Thank You", "IC Place", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}