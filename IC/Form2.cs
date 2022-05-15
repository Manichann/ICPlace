using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str, str1;
            str = "";

            if (radioButton1.Checked == true)
            {
                str = "ທ້າວ" + txtName.Text;
            }
            else
            {
                str = "ນາງ" + txtName.Text;
            }
            str += "\r\n\nວັນ/ເດືອນ/ປີ: " + cmdDate.SelectedItem.ToString() + txtYear.Text;
            str += "\r\n\nທີ່ຢູ່: " + txtAddress.Text;
            str += "\r\n\nອີເມລ: " + txtEmail.Text;
            str += "\r\n\nເບີໂທ: " + txtPhone.Text;
            txtOutData.Text = str;
            str1 = "";
            double FO1, FO2, FO3, FO4, FO5, DR1, DR2, DR3, SUM;
            if (F1.Checked == true)
            {
                str1 += "\r\n\nHam Burger   ລາຄາ 25,000 ກີບ";
                FO1 = 25000;
            }
            else
            {
                FO1 = 0;
            }
            if(F2.Checked == true)
            {
                str1 += "\r\n\nChicken Burger   ລາຄາ 25,000 ກີບ";
                FO2 = 25000;
            }
            else
            {
                FO2 = 0;
            }
            if(F3.Checked == true)
            {
                str1 += "\r\n\nCheese Burger   ລາຄາ 30,000 ກີບ";
                FO3 = 30000;
            }
            else
            {
                FO3 = 0;
            }
            if(F4.Checked == true)
            {
                str1 += "\r\n\nFried Chicken   ລາຄາ 30,000 ກີບ";
                FO4 = 30000;
            }
            else
            {
                FO4 = 0;
            }
            if(F5.Checked == true)
            {
                str1 += "\r\n\nFrench Fries   ລາຄາ 20,000 ກີບ";
                FO5 = 20000;
            }
            else
            {
                FO5 = 0;
            }
            if(D1.Checked == true)
            {
                str1 += "\r\n\nCoca Cola   ລາຄາ 10,000 ກີບ";
                DR1 = 10000;
            }
            else
            {
                DR1 = 0;
            }
            if(D2.Checked == true)
            {
                str1 += "\r\n\nWater   ລາຄາ 5,000 ກີບ";
                DR2 = 5000;
            }
            else
            {
                DR2 = 0;
            }
            if(D3.Checked == true)
            {
                str1 += "\r\n\nSmoothie   ລາຄາ 20,000 ກີບ";
                DR3 = 20000;
            }
            else
            {
                DR3 = 0;
            }
            txtOrder.Text = str1;
            SUM = FO1 + FO2 + FO3 + FO4 + FO5 + DR1 + DR2 + DR3;
            txtsum.Text = (SUM + " ກີບ");
            MessageBox.Show("ບັນທຶກລາຍການ ແລະ ລວມເງິນທັງໝົດ  " + txtsum.Text, "IC Place", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            cmdDate.ResetText();
            cmdMonth.ResetText();
            txtYear.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtOutData.Clear();
            txtOrder.Clear();
            txtsum.Clear();
            F1.Checked = false;
            F2.Checked = false;
            F3.Checked = false;
            F4.Checked = false;
            F5.Checked = false;
            D1.Checked = false;
            D2.Checked = false;
            D3.Checked = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmHome form1 = new frmHome();
            form1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ຂອບໃຈທີ່ໃຊ້ບໍລິການ ແລ້ວກັບມາໃໝ່ໃນໂອການໜ້າທີ່ ຮ້ານ IC Place", "IC Place", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
