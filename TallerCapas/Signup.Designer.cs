namespace CapaPresentacion
{
    partial class Sign_up
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
            label1 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            botonSignup = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            txtCedula = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(188, 128);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(188, 151);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(235, 27);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Location = new Point(188, 217);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 5;
            label3.Text = "Correo Electronico";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(188, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(451, 27);
            txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Location = new Point(188, 304);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 7;
            label4.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 327);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(451, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // botonSignup
            // 
            botonSignup.BackColor = Color.FromArgb(128, 64, 0);
            botonSignup.FlatStyle = FlatStyle.Flat;
            botonSignup.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonSignup.ForeColor = Color.White;
            botonSignup.Location = new Point(326, 379);
            botonSignup.Name = "botonSignup";
            botonSignup.Size = new Size(188, 50);
            botonSignup.TabIndex = 9;
            botonSignup.Text = "CREAR CUENTA";
            botonSignup.UseVisualStyleBackColor = false;
            botonSignup.Click += botonSignup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Enabled = false;
            label5.Font = new Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(128, 64, 0);
            label5.Location = new Point(330, 44);
            label5.Name = "label5";
            label5.Size = new Size(153, 61);
            label5.TabIndex = 10;
            label5.Text = "SIGN UP";
            label5.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(122, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(591, 493);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Location = new Point(137, 487);
            label6.Name = "label6";
            label6.Size = new Size(189, 20);
            label6.TabIndex = 12;
            label6.Text = "Regresar al inicio de sesión";
            label6.Click += label6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(485, 128);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 13;
            label2.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(485, 151);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(154, 27);
            txtCedula.TabIndex = 14;
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 595);
            Controls.Add(txtCedula);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(botonSignup);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Sign_up";
            Text = "Sign_up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPassword;
        private Button botonSignup;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label2;
        private TextBox txtCedula;
    }
}