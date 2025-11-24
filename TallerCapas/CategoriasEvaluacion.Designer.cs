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
            btnGuardar = new Button();
            btnAñadir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            dgvCategorias = new DataGridView();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            cmbMateria = new ComboBox();
            numPon = new NumericUpDown();
            cmbCat = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Gill Sans MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 12);
            label1.Name = "label1";
            label1.Size = new Size(407, 42);
            label1.TabIndex = 5;
            label1.Text = "Categorías y Ponderaciones";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.MidnightBlue;
            pictureBox3.Location = new Point(-1, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(714, 72);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(203, 307);
            label13.Name = "label13";
            label13.Size = new Size(43, 23);
            label13.TabIndex = 45;
            label13.Text = "Pon:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(62, 307);
            label12.Name = "label12";
            label12.Size = new Size(40, 23);
            label12.TabIndex = 44;
            label12.Text = "Cat:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CornflowerBlue;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.Location = new Point(153, 397);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(301, 31);
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
            btnAñadir.Location = new Point(259, 359);
            btnAñadir.Margin = new Padding(3, 4, 3, 4);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(89, 31);
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
            btnEliminar.Location = new Point(365, 359);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 31);
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
            btnEditar.Location = new Point(153, 359);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(89, 31);
            btnEditar.TabIndex = 38;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.BackgroundColor = Color.AliceBlue;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(63, 155);
            dgvCategorias.Margin = new Padding(3, 4, 3, 4);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(487, 136);
            dgvCategorias.TabIndex = 37;
            dgvCategorias.SelectionChanged += dgvCategorias_SelectionChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(58, 121);
            label11.Name = "label11";
            label11.Size = new Size(201, 23);
            label11.TabIndex = 36;
            label11.Text = "Categorías de Evaluación";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(48, 135);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(515, 313);
            pictureBox5.TabIndex = 35;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(3, 75);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(51, 31);
            button1.TabIndex = 46;
            button1.Text = "Atrás";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(399, 303);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(151, 28);
            cmbMateria.TabIndex = 48;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // numPon
            // 
            numPon.Location = new Point(252, 306);
            numPon.Name = "numPon";
            numPon.Size = new Size(88, 27);
            numPon.TabIndex = 49;
            // 
            // cmbCat
            // 
            cmbCat.FormattingEnabled = true;
            cmbCat.Location = new Point(99, 303);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(105, 28);
            cmbCat.TabIndex = 50;
            // 
            // CategoriasEvaluacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(616, 500);
            Controls.Add(cmbCat);
            Controls.Add(numPon);
            Controls.Add(cmbMateria);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(btnGuardar);
            Controls.Add(btnAñadir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dgvCategorias);
            Controls.Add(label11);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoriasEvaluacion";
            Text = "CategoriasEvaluacion";
            Load += CategoriasEvaluacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox3;
        private Label label13;
        private Label label12;
        private Button btnGuardar;
        private Button btnAñadir;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvCategorias;
        private Label label11;
        private PictureBox pictureBox5;
        private Button button1;
        private ComboBox cmbMateria;
        private NumericUpDown numPon;
        private ComboBox cmbCat;
    }
}