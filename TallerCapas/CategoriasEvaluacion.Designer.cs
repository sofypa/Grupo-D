namespace CapaPresentacion
{
    partial class CategoriasEvaluacion
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
            pictureBox3 = new PictureBox();
            label13 = new Label();
            label12 = new Label();
            txtPon = new TextBox();
            txtCat = new TextBox();
            btnGuardar = new Button();
            btnAñadir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            dgvCategorias = new DataGridView();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            txtIDMateria = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Gill Sans MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(329, 34);
            label1.TabIndex = 5;
            label1.Text = "Categorías y Ponderaciones";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.MidnightBlue;
            pictureBox3.Location = new Point(-1, -1);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(625, 54);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(178, 230);
            label13.Name = "label13";
            label13.Size = new Size(33, 17);
            label13.TabIndex = 45;
            label13.Text = "Pon:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(54, 230);
            label12.Name = "label12";
            label12.Size = new Size(30, 17);
            label12.TabIndex = 44;
            label12.Text = "Cat:";
            // 
            // txtPon
            // 
            txtPon.BackColor = Color.AliceBlue;
            txtPon.BorderStyle = BorderStyle.FixedSingle;
            txtPon.Location = new Point(217, 227);
            txtPon.Name = "txtPon";
            txtPon.Size = new Size(77, 23);
            txtPon.TabIndex = 43;
            // 
            // txtCat
            // 
            txtCat.BackColor = Color.AliceBlue;
            txtCat.BorderStyle = BorderStyle.FixedSingle;
            txtCat.Location = new Point(92, 227);
            txtCat.Name = "txtCat";
            txtCat.Size = new Size(77, 23);
            txtCat.TabIndex = 42;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CornflowerBlue;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.Location = new Point(134, 298);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(263, 23);
            btnGuardar.TabIndex = 41;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.White;
            btnAñadir.FlatStyle = FlatStyle.Popup;
            btnAñadir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.ForeColor = SystemColors.WindowText;
            btnAñadir.Location = new Point(227, 269);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(78, 23);
            btnAñadir.TabIndex = 40;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.WindowText;
            btnEliminar.Location = new Point(319, 269);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 23);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.WindowText;
            btnEditar.Location = new Point(134, 269);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 23);
            btnEditar.TabIndex = 38;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.BackgroundColor = Color.AliceBlue;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(55, 116);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(426, 102);
            dgvCategorias.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(51, 91);
            label11.Name = "label11";
            label11.Size = new Size(155, 17);
            label11.TabIndex = 36;
            label11.Text = "Categorías de Evaluación";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(42, 101);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(451, 235);
            pictureBox5.TabIndex = 35;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(3, 56);
            button1.Name = "button1";
            button1.Size = new Size(45, 23);
            button1.TabIndex = 46;
            button1.Text = "Atrás";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtIDMateria
            // 
            txtIDMateria.AutoSize = true;
            txtIDMateria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIDMateria.Location = new Point(305, 230);
            txtIDMateria.Name = "txtIDMateria";
            txtIDMateria.Size = new Size(77, 17);
            txtIDMateria.TabIndex = 47;
            txtIDMateria.Text = "ID Materia:";
            // 
            // CategoriasEvaluacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(539, 375);
            Controls.Add(txtIDMateria);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtPon);
            Controls.Add(txtCat);
            Controls.Add(btnGuardar);
            Controls.Add(btnAñadir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dgvCategorias);
            Controls.Add(label11);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Name = "CategoriasEvaluacion";
            Text = "CategoriasEvaluacion";
            Load += CategoriasEvaluacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox3;
        private Label label13;
        private Label label12;
        private TextBox txtPon;
        private TextBox txtCat;
        private Button btnGuardar;
        private Button btnAñadir;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvCategorias;
        private Label label11;
        private PictureBox pictureBox5;
        private Button button1;
        private Label txtIDMateria;
    }
}