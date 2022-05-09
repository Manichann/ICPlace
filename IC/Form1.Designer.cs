namespace IC
{
    partial class frmHome
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Chocolate;
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn.Location = new System.Drawing.Point(138, 187);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(105, 37);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "ເຂົ້າສູ່ລະບົບ";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Chocolate;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(114, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "ອອກຈາກໂປຣແກຣມ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnName.ForeColor = System.Drawing.Color.Transparent;
            this.btnName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnName.Location = new System.Drawing.Point(53, 84);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(88, 32);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "ຊື່ຜູ້ໃຊ້";
            this.btnName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnName.UseVisualStyleBackColor = false;
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPass.ForeColor = System.Drawing.Color.Transparent;
            this.btnPass.Location = new System.Drawing.Point(53, 122);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(88, 31);
            this.btnPass.TabIndex = 3;
            this.btnPass.Text = "ລະຫັດຜ່ານ";
            this.btnPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPass.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtName.Location = new System.Drawing.Point(147, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 30);
            this.txtName.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtPass.Location = new System.Drawing.Point(147, 124);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(140, 30);
            this.txtPass.TabIndex = 5;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(376, 311);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogIn);
            this.Font = new System.Drawing.Font("Saysettha OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHome";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogIn;
        private Button btnClose;
        private Button btnName;
        private Button btnPass;
        private TextBox txtName;
        private TextBox txtPass;
    }
}