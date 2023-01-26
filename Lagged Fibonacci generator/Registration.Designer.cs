namespace Lagged_Fibonacci_generator
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.Close = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.PW = new System.Windows.Forms.Label();
            this.NN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sign_up = new System.Windows.Forms.Button();
            this.Sign_in = new System.Windows.Forms.Button();
            this.Sign_Up_Label = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Nickname = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Close.BackColor = System.Drawing.Color.White;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = global::Lagged_Fibonacci_generator.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(755, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(45, 45);
            this.Close.TabIndex = 42;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Hide
            // 
            this.Hide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Hide.Image = global::Lagged_Fibonacci_generator.Properties.Resources.show;
            this.Hide.Location = new System.Drawing.Point(685, 225);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(40, 40);
            this.Hide.TabIndex = 41;
            this.Hide.UseVisualStyleBackColor = false;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // PW
            // 
            this.PW.AutoSize = true;
            this.PW.BackColor = System.Drawing.Color.White;
            this.PW.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PW.Location = new System.Drawing.Point(471, 205);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(79, 21);
            this.PW.TabIndex = 40;
            this.PW.Text = "password";
            // 
            // NN
            // 
            this.NN.AutoSize = true;
            this.NN.BackColor = System.Drawing.Color.White;
            this.NN.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NN.Location = new System.Drawing.Point(471, 135);
            this.NN.Name = "NN";
            this.NN.Size = new System.Drawing.Size(79, 21);
            this.NN.TabIndex = 39;
            this.NN.Text = "nickname";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "have an account?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 49);
            this.label1.TabIndex = 37;
            this.label1.Text = "Welcome, Friend!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sign_up
            // 
            this.Sign_up.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sign_up.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Sign_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.Sign_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign_up.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_up.ForeColor = System.Drawing.Color.White;
            this.Sign_up.Location = new System.Drawing.Point(525, 300);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(150, 40);
            this.Sign_up.TabIndex = 36;
            this.Sign_up.Text = "SIGN UP";
            this.Sign_up.UseVisualStyleBackColor = false;
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // Sign_in
            // 
            this.Sign_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.Sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign_in.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_in.ForeColor = System.Drawing.Color.White;
            this.Sign_in.Location = new System.Drawing.Point(125, 225);
            this.Sign_in.Name = "Sign_in";
            this.Sign_in.Size = new System.Drawing.Size(150, 40);
            this.Sign_in.TabIndex = 35;
            this.Sign_in.Text = "SIGN IN";
            this.Sign_in.UseVisualStyleBackColor = false;
            this.Sign_in.Click += new System.EventHandler(this.Sign_in_Click);
            // 
            // Sign_Up_Label
            // 
            this.Sign_Up_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sign_Up_Label.BackColor = System.Drawing.Color.White;
            this.Sign_Up_Label.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_Up_Label.Location = new System.Drawing.Point(406, 79);
            this.Sign_Up_Label.Name = "Sign_Up_Label";
            this.Sign_Up_Label.Size = new System.Drawing.Size(382, 49);
            this.Sign_Up_Label.TabIndex = 33;
            this.Sign_Up_Label.Text = "Sign up";
            this.Sign_Up_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(475, 225);
            this.Password.MaxLength = 15;
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(211, 40);
            this.Password.TabIndex = 2;
            this.Password.WordWrap = false;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // Nickname
            // 
            this.Nickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Nickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nickname.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nickname.Location = new System.Drawing.Point(475, 155);
            this.Nickname.MaxLength = 20;
            this.Nickname.Multiline = true;
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(250, 40);
            this.Nickname.TabIndex = 1;
            this.Nickname.WordWrap = false;
            this.Nickname.TextChanged += new System.EventHandler(this.Nickname_TextChanged);
            this.Nickname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nickname_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(395, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(405, 400);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(43)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            this.AcceptButton = this.Sign_up;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.NN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sign_up);
            this.Controls.Add(this.Sign_in);
            this.Controls.Add(this.Sign_Up_Label);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Nickname);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Label PW;
        private System.Windows.Forms.Label NN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sign_up;
        private System.Windows.Forms.Button Sign_in;
        private System.Windows.Forms.Label Sign_Up_Label;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Nickname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}