namespace CapaPresentacion
{
    partial class Notas
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
            numNota = new NumericUpDown();
            lbl12 = new Label();
            lblCategoria = new Label();
            cbCategoriaG = new ComboBox();
            label14 = new Label();
            btnVolverDashboard = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            btnElimMat = new Button();
            btnEditMat = new Button();
            btnRegisMat = new Button();
            dgvNotas = new DataGridView();
            cmbMaterias = new ComboBox();
            lblMateria = new Label();
            lblComentario = new Label();
            txtComentario = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnLimpiar = new Button();
            lblPromedio = new Label();
            btnAtras = new Button();
            pictureBox6 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            cmbFiltroMateria = new ComboBox();
            label5 = new Label();
            cmbFiltroCateg = new ComboBox();
            btnFiltrar = new Button();
            btnPDFNotas = new Button();
            ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // numNota
            // 
            numNota.Location = new Point(256, 223);
            numNota.Name = "numNota";
            numNota.Size = new Size(103, 27);
            numNota.TabIndex = 54;
            // 
            // lbl12
            // 
            lbl12.AutoSize = true;
            lbl12.BackColor = Color.White;
            lbl12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl12.Location = new Point(142, 227);
            lbl12.Name = "lbl12";
            lbl12.Size = new Size(100, 23);
            lbl12.TabIndex = 53;
            lbl12.Text = "Calificación:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.White;
            lblCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(154, 185);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 23);
            lblCategoria.TabIndex = 52;
            lblCategoria.Text = "Categoría:";
            // 
            // cbCategoriaG
            // 
            cbCategoriaG.FormattingEnabled = true;
            cbCategoriaG.Location = new Point(256, 180);
            cbCategoriaG.Margin = new Padding(3, 4, 3, 4);
            cbCategoriaG.Name = "cbCategoriaG";
            cbCategoriaG.Size = new Size(182, 28);
            cbCategoriaG.TabIndex = 51;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(129, 106);
            label14.Name = "label14";
            label14.Size = new Size(134, 23);
            label14.TabIndex = 49;
            label14.Text = "Registrar Notas";
            // 
            // btnVolverDashboard
            // 
            btnVolverDashboard.BackColor = Color.White;
            btnVolverDashboard.FlatStyle = FlatStyle.Popup;
            btnVolverDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverDashboard.ForeColor = SystemColors.WindowText;
            btnVolverDashboard.Location = new Point(625, 24);
            btnVolverDashboard.Margin = new Padding(3, 4, 3, 4);
            btnVolverDashboard.Name = "btnVolverDashboard";
            btnVolverDashboard.Size = new Size(159, 31);
            btnVolverDashboard.TabIndex = 57;
            btnVolverDashboard.Text = "Volver a Dashboard";
            btnVolverDashboard.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Gill Sans MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(261, 42);
            label1.TabIndex = 55;
            label1.Text = "Gestión de Notas";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.MidnightBlue;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(801, 72);
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // btnElimMat
            // 
            btnElimMat.BackColor = Color.CornflowerBlue;
            btnElimMat.FlatStyle = FlatStyle.Popup;
            btnElimMat.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnElimMat.ForeColor = SystemColors.Window;
            btnElimMat.Location = new Point(537, 278);
            btnElimMat.Margin = new Padding(3, 4, 3, 4);
            btnElimMat.Name = "btnElimMat";
            btnElimMat.Size = new Size(151, 41);
            btnElimMat.TabIndex = 65;
            btnElimMat.Text = "Eliminar Nota";
            btnElimMat.UseVisualStyleBackColor = false;
            btnElimMat.Click += btnElimMat_Click;
            // 
            // btnEditMat
            // 
            btnEditMat.BackColor = Color.CornflowerBlue;
            btnEditMat.FlatStyle = FlatStyle.Popup;
            btnEditMat.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditMat.ForeColor = SystemColors.Window;
            btnEditMat.Location = new Point(537, 215);
            btnEditMat.Margin = new Padding(3, 4, 3, 4);
            btnEditMat.Name = "btnEditMat";
            btnEditMat.Size = new Size(151, 41);
            btnEditMat.TabIndex = 64;
            btnEditMat.Text = "Editar Nota";
            btnEditMat.UseVisualStyleBackColor = false;
            btnEditMat.Click += btnEditMat_Click;
            // 
            // btnRegisMat
            // 
            btnRegisMat.BackColor = Color.CornflowerBlue;
            btnRegisMat.FlatStyle = FlatStyle.Popup;
            btnRegisMat.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisMat.ForeColor = SystemColors.Window;
            btnRegisMat.Location = new Point(537, 158);
            btnRegisMat.Margin = new Padding(3, 4, 3, 4);
            btnRegisMat.Name = "btnRegisMat";
            btnRegisMat.Size = new Size(151, 41);
            btnRegisMat.TabIndex = 63;
            btnRegisMat.Text = "Registrar Nota";
            btnRegisMat.UseVisualStyleBackColor = false;
            btnRegisMat.Click += btnRegisMat_Click;
            // 
            // dgvNotas
            // 
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(60, 548);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.RowHeadersWidth = 51;
            dgvNotas.Size = new Size(678, 198);
            dgvNotas.TabIndex = 67;
            dgvNotas.CellClick += dgvNotas_CellClick;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(256, 137);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(182, 28);
            cmbMaterias.TabIndex = 68;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.BackColor = Color.White;
            lblMateria.Font = new Font("Segoe UI", 9.75F);
            lblMateria.Location = new Point(170, 142);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(72, 23);
            lblMateria.TabIndex = 69;
            lblMateria.Text = "Materia:";
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.BackColor = Color.White;
            lblComentario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComentario.Location = new Point(138, 269);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(104, 23);
            lblComentario.TabIndex = 70;
            lblComentario.Text = "Comentario:";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(256, 269);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(182, 27);
            txtComentario.TabIndex = 71;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Location = new Point(60, 420);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(678, 10);
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CornflowerBlue;
            label3.Font = new Font("Gill Sans MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(296, 407);
            label3.Name = "label3";
            label3.Size = new Size(223, 33);
            label3.TabIndex = 74;
            label3.Text = "Notas de la Materia";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.CornflowerBlue;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.Window;
            btnLimpiar.Location = new Point(234, 323);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(125, 27);
            btnLimpiar.TabIndex = 75;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPromedio.Location = new Point(70, 768);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(226, 29);
            lblPromedio.TabIndex = 76;
            lblPromedio.Text = "Promedio calculado: ...";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(12, 78);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(96, 29);
            btnAtras.TabIndex = 77;
            btnAtras.Text = "ir atrás";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(119, 120);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(370, 250);
            pictureBox6.TabIndex = 48;
            pictureBox6.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 455);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 80;
            label2.Text = "Filtros de la tabla";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(60, 469);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(678, 54);
            pictureBox2.TabIndex = 79;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 490);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 84;
            label4.Text = "Materia:";
            // 
            // cmbFiltroMateria
            // 
            cmbFiltroMateria.FormattingEnabled = true;
            cmbFiltroMateria.Location = new Point(139, 485);
            cmbFiltroMateria.Name = "cmbFiltroMateria";
            cmbFiltroMateria.Size = new Size(182, 28);
            cmbFiltroMateria.TabIndex = 83;
            cmbFiltroMateria.SelectedIndexChanged += cmbFiltroMateria_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(342, 490);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 82;
            label5.Text = "Categoría:";
            // 
            // cmbFiltroCateg
            // 
            cmbFiltroCateg.FormattingEnabled = true;
            cmbFiltroCateg.Location = new Point(425, 485);
            cmbFiltroCateg.Margin = new Padding(3, 4, 3, 4);
            cmbFiltroCateg.Name = "cmbFiltroCateg";
            cmbFiltroCateg.Size = new Size(182, 28);
            cmbFiltroCateg.TabIndex = 81;
            cmbFiltroCateg.SelectedIndexChanged += cmbFiltroCateg_SelectedIndexChanged;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.White;
            btnFiltrar.FlatStyle = FlatStyle.Popup;
            btnFiltrar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.Black;
            btnFiltrar.Location = new Point(629, 483);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(90, 27);
            btnFiltrar.TabIndex = 85;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnPDFNotas
            // 
            btnPDFNotas.BackColor = Color.CornflowerBlue;
            btnPDFNotas.FlatStyle = FlatStyle.Popup;
            btnPDFNotas.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPDFNotas.ForeColor = SystemColors.Window;
            btnPDFNotas.Location = new Point(338, 817);
            btnPDFNotas.Margin = new Padding(3, 4, 3, 4);
            btnPDFNotas.Name = "btnPDFNotas";
            btnPDFNotas.Size = new Size(151, 41);
            btnPDFNotas.TabIndex = 86;
            btnPDFNotas.Text = "PDF de Notas";
            btnPDFNotas.UseVisualStyleBackColor = false;
            // 
            // Notas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(796, 888);
            Controls.Add(btnPDFNotas);
            Controls.Add(btnFiltrar);
            Controls.Add(label4);
            Controls.Add(cmbFiltroMateria);
            Controls.Add(label5);
            Controls.Add(cmbFiltroCateg);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(btnAtras);
            Controls.Add(lblPromedio);
            Controls.Add(btnLimpiar);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(txtComentario);
            Controls.Add(lblComentario);
            Controls.Add(lblMateria);
            Controls.Add(cmbMaterias);
            Controls.Add(dgvNotas);
            Controls.Add(btnElimMat);
            Controls.Add(btnEditMat);
            Controls.Add(btnRegisMat);
            Controls.Add(btnVolverDashboard);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(numNota);
            Controls.Add(lbl12);
            Controls.Add(lblCategoria);
            Controls.Add(cbCategoriaG);
            Controls.Add(label14);
            Controls.Add(pictureBox6);
            Name = "Notas";
            Text = "Notas";
            Load += Notas_Load;
            ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numNota;
        private Label lbl12;
        private Label lblCategoria;
        private ComboBox cbCategoriaG;
        private Label label14;
        private Button btnVolverDashboard;
        private Label label1;
        private PictureBox pictureBox3;
        private Button btnElimMat;
        private Button btnEditMat;
        private Button btnRegisMat;
        private DataGridView dgvNotas;
        private ComboBox cmbMaterias;
        private Label lblMateria;
        private Label lblComentario;
        private TextBox txtComentario;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnLimpiar;
        private Label lblPromedio;
        private Button btnAtras;
        private PictureBox pictureBox6;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label4;
        private ComboBox cmbFiltroMateria;
        private Label label5;
        private ComboBox cmbFiltroCateg;
        private Button btnFiltrar;
        private Button btnPDFNotas;
    }
}