namespace Simulador_ISV
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tb_user = new TextBox();
            tb_pass = new TextBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            cb_remember = new CheckBox();
            btn_login = new Button();
            lkb_passRecu = new LinkLabel();
            label1 = new Label();
            btn_fb = new Button();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            btn_gg = new Button();
            lkb_registar = new LinkLabel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(641, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 602);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(109, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // tb_user
            // 
            tb_user.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user.Location = new Point(164, 100);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(368, 45);
            tb_user.TabIndex = 4;
            tb_user.TextChanged += tb_user_TextChanged;
            // 
            // tb_pass
            // 
            tb_pass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_pass.Location = new Point(164, 170);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(368, 45);
            tb_pass.TabIndex = 6;
            tb_pass.UseSystemPasswordChar = true;
            tb_pass.TextChanged += tb_pass_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(109, 170);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(39, 39);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cb_remember
            // 
            cb_remember.AutoSize = true;
            cb_remember.Location = new Point(109, 271);
            cb_remember.Name = "cb_remember";
            cb_remember.Size = new Size(135, 29);
            cb_remember.TabIndex = 8;
            cb_remember.Text = "Lembrar-me";
            cb_remember.UseVisualStyleBackColor = true;
            cb_remember.CheckedChanged += cb_remember_CheckedChanged;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.Highlight;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(404, 248);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(128, 52);
            btn_login.TabIndex = 9;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // lkb_passRecu
            // 
            lkb_passRecu.AutoSize = true;
            lkb_passRecu.LinkColor = Color.Gray;
            lkb_passRecu.Location = new Point(404, 325);
            lkb_passRecu.Name = "lkb_passRecu";
            lkb_passRecu.Size = new Size(218, 25);
            lkb_passRecu.TabIndex = 10;
            lkb_passRecu.TabStop = true;
            lkb_passRecu.Text = "Esqueceu a Palavra-Passe?";
            lkb_passRecu.LinkClicked += lkb_passRecu_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 366);
            label1.Name = "label1";
            label1.Size = new Size(495, 25);
            label1.TabIndex = 11;
            label1.Text = "---------------------------------ou---------------------------------";
            // 
            // btn_fb
            // 
            btn_fb.BackColor = Color.MidnightBlue;
            btn_fb.FlatStyle = FlatStyle.Popup;
            btn_fb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_fb.ForeColor = Color.White;
            btn_fb.Location = new Point(164, 419);
            btn_fb.Name = "btn_fb";
            btn_fb.Size = new Size(368, 50);
            btn_fb.TabIndex = 12;
            btn_fb.Text = "LOGIN COM FACEBOOK";
            btn_fb.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(118, 419);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(118, 491);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(49, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // btn_gg
            // 
            btn_gg.BackColor = Color.Crimson;
            btn_gg.FlatStyle = FlatStyle.Popup;
            btn_gg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_gg.ForeColor = Color.White;
            btn_gg.Location = new Point(164, 491);
            btn_gg.Name = "btn_gg";
            btn_gg.Size = new Size(368, 50);
            btn_gg.TabIndex = 16;
            btn_gg.Text = "LOGIN COM FACEBOOK";
            btn_gg.UseVisualStyleBackColor = false;
            // 
            // lkb_registar
            // 
            lkb_registar.AutoSize = true;
            lkb_registar.LinkColor = Color.Gray;
            lkb_registar.Location = new Point(12, 565);
            lkb_registar.Name = "lkb_registar";
            lkb_registar.Size = new Size(387, 25);
            lkb_registar.TabIndex = 18;
            lkb_registar.TabStop = true;
            lkb_registar.Text = "Ainda não tem conta? Clique aqui para Registar";
            lkb_registar.LinkClicked += lkb_registar_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(267, 33);
            label2.Name = "label2";
            label2.Size = new Size(102, 38);
            label2.TabIndex = 19;
            label2.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1440, 599);
            Controls.Add(label2);
            Controls.Add(lkb_registar);
            Controls.Add(pictureBox6);
            Controls.Add(btn_gg);
            Controls.Add(pictureBox4);
            Controls.Add(btn_fb);
            Controls.Add(label1);
            Controls.Add(lkb_passRecu);
            Controls.Add(btn_login);
            Controls.Add(cb_remember);
            Controls.Add(button1);
            Controls.Add(tb_pass);
            Controls.Add(pictureBox3);
            Controls.Add(tb_user);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            ShowIcon = false;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox tb_user;
        private TextBox tb_pass;
        private PictureBox pictureBox3;
        private Button button1;
        private CheckBox cb_remember;
        private Button btn_login;
        private LinkLabel lkb_passRecu;
        private Label label1;
        private Button btn_fb;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Button btn_gg;
        private LinkLabel lkb_registar;
        private Label label2;
    }
}
