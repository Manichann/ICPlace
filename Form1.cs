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
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please come again later, Thank You", "IC Place", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}