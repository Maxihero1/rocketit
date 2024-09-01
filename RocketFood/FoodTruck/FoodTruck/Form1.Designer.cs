namespace FoodTruck
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
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            btnSignIn_Click = new Button();
            btnCerrar_Click = new Button();
            btnMin_Click = new Button();
            UpBar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpBar).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.ForeColor = SystemColors.MenuText;
            textBox2.Location = new Point(453, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 27);
            textBox2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 502);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(492, 122);
            label1.Name = "label1";
            label1.Size = new Size(210, 34);
            label1.TabIndex = 5;
            label1.Text = "Ready to login";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(453, 180);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(453, 246);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.ForeColor = SystemColors.MenuText;
            textBox3.Location = new Point(453, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 27);
            textBox3.TabIndex = 7;
            textBox3.UseSystemPasswordChar = true;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // btnSignIn_Click
            // 
            btnSignIn_Click.BackColor = Color.Black;
            btnSignIn_Click.Cursor = Cursors.Hand;
            btnSignIn_Click.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnSignIn_Click.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            btnSignIn_Click.FlatStyle = FlatStyle.Flat;
            btnSignIn_Click.ForeColor = Color.White;
            btnSignIn_Click.Location = new Point(486, 331);
            btnSignIn_Click.Name = "btnSignIn_Click";
            btnSignIn_Click.Size = new Size(217, 32);
            btnSignIn_Click.TabIndex = 9;
            btnSignIn_Click.Text = "Sign In";
            btnSignIn_Click.UseVisualStyleBackColor = false;
            // 
            // btnCerrar_Click
            // 
            btnCerrar_Click.BackColor = Color.Transparent;
            btnCerrar_Click.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar_Click.Cursor = Cursors.Hand;
            btnCerrar_Click.FlatAppearance.BorderSize = 0;
            btnCerrar_Click.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnCerrar_Click.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCerrar_Click.FlatStyle = FlatStyle.Flat;
            btnCerrar_Click.Image = (Image)resources.GetObject("btnCerrar_Click.Image");
            btnCerrar_Click.Location = new Point(784, 4);
            btnCerrar_Click.Name = "btnCerrar_Click";
            btnCerrar_Click.Size = new Size(20, 20);
            btnCerrar_Click.TabIndex = 10;
            btnCerrar_Click.UseVisualStyleBackColor = false;
            btnCerrar_Click.Click += btnCerrar_Click_Click;
            // 
            // btnMin_Click
            // 
            btnMin_Click.BackColor = Color.Transparent;
            btnMin_Click.BackgroundImageLayout = ImageLayout.Zoom;
            btnMin_Click.Cursor = Cursors.Hand;
            btnMin_Click.FlatAppearance.BorderSize = 0;
            btnMin_Click.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnMin_Click.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMin_Click.FlatStyle = FlatStyle.Flat;
            btnMin_Click.Image = (Image)resources.GetObject("btnMin_Click.Image");
            btnMin_Click.Location = new Point(745, 4);
            btnMin_Click.Name = "btnMin_Click";
            btnMin_Click.Size = new Size(20, 20);
            btnMin_Click.TabIndex = 12;
            btnMin_Click.UseVisualStyleBackColor = false;
            btnMin_Click.Click += btnMin_Click_Click;
            // 
            // UpBar
            // 
            UpBar.BackColor = Color.Transparent;
            UpBar.Location = new Point(-1, -4);
            UpBar.Name = "UpBar";
            UpBar.Size = new Size(813, 34);
            UpBar.TabIndex = 13;
            UpBar.TabStop = false;
            UpBar.MouseDown += UpBar_MouseDown;
            UpBar.MouseMove += UpBar_MouseMove;
            UpBar.MouseUp += UpBar_MouseUp;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(807, 493);
            Controls.Add(btnMin_Click);
            Controls.Add(btnCerrar_Click);
            Controls.Add(btnSignIn_Click);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(UpBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Button btnSignIn_Click;
        private Button btnCerrar_Click;
        private Button btnMin_Click;
        private PictureBox UpBar;
    }
}
