namespace Simulador_ISV
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            btn_Register = new Button();
            button1 = new Button();
            tb_emailR = new TextBox();
            pictureBox3 = new PictureBox();
            tb_userR = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tb_pass2R = new TextBox();
            pictureBox4 = new PictureBox();
            tb_passR = new TextBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            cb_termos = new CheckBox();
            lkb_Termos = new LinkLabel();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btn_Register
            // 
            btn_Register.BackColor = SystemColors.Highlight;
            btn_Register.FlatStyle = FlatStyle.Flat;
            btn_Register.ForeColor = Color.White;
            btn_Register.Location = new Point(48, 455);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(514, 52);
            btn_Register.TabIndex = 26;
            btn_Register.Text = "REGISTAR";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(589, 20);
            button1.Name = "button1";
            button1.Size = new Size(39, 39);
            button1.TabIndex = 24;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tb_emailR
            // 
            tb_emailR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_emailR.Location = new Point(150, 165);
            tb_emailR.Name = "tb_emailR";
            tb_emailR.Size = new Size(368, 45);
            tb_emailR.TabIndex = 23;
            tb_emailR.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(95, 238);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // tb_userR
            // 
            tb_userR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_userR.Location = new Point(150, 95);
            tb_userR.Name = "tb_userR";
            tb_userR.Size = new Size(368, 45);
            tb_userR.TabIndex = 21;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(95, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(634, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 602);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // tb_pass2R
            // 
            tb_pass2R.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_pass2R.Location = new Point(150, 308);
            tb_pass2R.Name = "tb_pass2R";
            tb_pass2R.Size = new Size(368, 45);
            tb_pass2R.TabIndex = 30;
            tb_pass2R.UseSystemPasswordChar = true;
            tb_pass2R.TextChanged += tb_pass2R_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(95, 308);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // tb_passR
            // 
            tb_passR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_passR.Location = new Point(150, 238);
            tb_passR.Name = "tb_passR";
            tb_passR.Size = new Size(368, 45);
            tb_passR.TabIndex = 28;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(95, 165);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(49, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, 28);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 31;
            label2.Text = "REGISTAR";
            // 
            // cb_termos
            // 
            cb_termos.AutoSize = true;
            cb_termos.Location = new Point(138, 388);
            cb_termos.Name = "cb_termos";
            cb_termos.Size = new Size(181, 29);
            cb_termos.TabIndex = 32;
            cb_termos.Text = "Concordo com os";
            cb_termos.UseVisualStyleBackColor = true;
            // 
            // lkb_Termos
            // 
            lkb_Termos.AutoSize = true;
            lkb_Termos.Location = new Point(312, 388);
            lkb_Termos.Name = "lkb_Termos";
            lkb_Termos.Size = new Size(171, 25);
            lkb_Termos.TabIndex = 33;
            lkb_Termos.TabStop = true;
            lkb_Termos.Text = "Termos e Condições";
            lkb_Termos.LinkClicked += lkb_Termos_LinkClicked;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.BackgroundImage = (Image)resources.GetObject("btn_back.BackgroundImage");
            btn_back.BackgroundImageLayout = ImageLayout.Stretch;
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(53, 54);
            btn_back.TabIndex = 34;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 594);
            Controls.Add(btn_back);
            Controls.Add(lkb_Termos);
            Controls.Add(cb_termos);
            Controls.Add(label2);
            Controls.Add(tb_pass2R);
            Controls.Add(pictureBox4);
            Controls.Add(tb_passR);
            Controls.Add(pictureBox5);
            Controls.Add(btn_Register);
            Controls.Add(button1);
            Controls.Add(tb_emailR);
            Controls.Add(pictureBox3);
            Controls.Add(tb_userR);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Register;
        private Button button1;
        private TextBox tb_emailR;
        private PictureBox pictureBox3;
        private TextBox tb_userR;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox tb_pass2R;
        private PictureBox pictureBox4;
        private TextBox tb_passR;
        private PictureBox pictureBox5;
        private Label label2;
        private CheckBox cb_termos;
        private LinkLabel lkb_Termos;
        private Button btn_back;
    }
}