namespace Prueba
{
    partial class Form1
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
            colorDialog1 = new ColorDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbMaterias = new ListBox();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            txtbCodigo = new TextBox();
            txtbNombre = new TextBox();
            txtbCreditos = new TextBox();
            label8 = new Label();
            txtbLabs = new TextBox();
            label9 = new Label();
            txtbClases = new TextBox();
            label10 = new Label();
            btnEditarMateria = new Button();
            btnNuevaMateria = new Button();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            dgvPonderaciones = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnAñadir = new Button();
            btnGuardar = new Button();
            txtbCategoria = new TextBox();
            txtbPondeacion = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            pictureBox6 = new PictureBox();
            dgvNotas = new DataGridView();
            cbCategoria = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            txtbNota = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPonderaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(21, 78);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(287, 408);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Gill Sans MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 34);
            label1.TabIndex = 2;
            label1.Text = "Asignaturas y Tipos de Notas";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(314, 78);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 408);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.MidnightBlue;
            pictureBox3.Location = new Point(0, -1);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(625, 54);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 67);
            label3.Name = "label3";
            label3.Size = new Size(128, 17);
            label3.TabIndex = 6;
            label3.Text = "Seleccionar Materia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(326, 67);
            label4.Name = "label4";
            label4.Size = new Size(219, 17);
            label4.TabIndex = 7;
            label4.Text = "Configurar Notas y Ponderaciones";
            // 
            // lbMaterias
            // 
            lbMaterias.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbMaterias.BackColor = Color.AliceBlue;
            lbMaterias.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMaterias.FormattingEnabled = true;
            lbMaterias.ItemHeight = 20;
            lbMaterias.Items.AddRange(new object[] { "Animación Digital", "Herramientas de Programación Aplicada III", "Ingeniería de Sistemas Robóticos", "Ingeniería de Software II", "Metodología de la Investigación", "Circuítos Lógicos" });
            lbMaterias.Location = new Point(33, 94);
            lbMaterias.Name = "lbMaterias";
            lbMaterias.Size = new Size(264, 104);
            lbMaterias.TabIndex = 8;
            lbMaterias.SelectedIndexChanged += lbMaterias_SelectedIndexChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(33, 291);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(264, 181);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 281);
            label5.Name = "label5";
            label5.Size = new Size(151, 17);
            label5.TabIndex = 10;
            label5.Text = "Registrar Nueva Materia";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(42, 439);
            button1.Name = "button1";
            button1.Size = new Size(246, 23);
            button1.TabIndex = 11;
            button1.Text = "Registrar Materia";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 313);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 12;
            label6.Text = "Código:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 342);
            label7.Name = "label7";
            label7.Size = new Size(60, 17);
            label7.TabIndex = 13;
            label7.Text = "Nombre:";
            label7.Click += label7_Click;
            // 
            // txtbCodigo
            // 
            txtbCodigo.BackColor = Color.AliceBlue;
            txtbCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtbCodigo.Location = new Point(102, 313);
            txtbCodigo.Name = "txtbCodigo";
            txtbCodigo.Size = new Size(186, 23);
            txtbCodigo.TabIndex = 14;
            txtbCodigo.TextChanged += txtbCodigo_TextChanged;
            // 
            // txtbNombre
            // 
            txtbNombre.BackColor = Color.AliceBlue;
            txtbNombre.BorderStyle = BorderStyle.FixedSingle;
            txtbNombre.Location = new Point(102, 342);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(186, 23);
            txtbNombre.TabIndex = 15;
            txtbNombre.TextChanged += txtbNombre_TextChanged;
            // 
            // txtbCreditos
            // 
            txtbCreditos.BackColor = Color.AliceBlue;
            txtbCreditos.BorderStyle = BorderStyle.FixedSingle;
            txtbCreditos.Location = new Point(102, 371);
            txtbCreditos.Name = "txtbCreditos";
            txtbCreditos.Size = new Size(59, 23);
            txtbCreditos.TabIndex = 17;
            txtbCreditos.TextChanged += txtbCreditos_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(42, 371);
            label8.Name = "label8";
            label8.Size = new Size(60, 17);
            label8.TabIndex = 16;
            label8.Text = "Créditos:";
            // 
            // txtbLabs
            // 
            txtbLabs.BackColor = Color.AliceBlue;
            txtbLabs.BorderStyle = BorderStyle.FixedSingle;
            txtbLabs.Location = new Point(102, 400);
            txtbLabs.Name = "txtbLabs";
            txtbLabs.Size = new Size(42, 23);
            txtbLabs.TabIndex = 19;
            txtbLabs.TextChanged += txtbLabs_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(58, 400);
            label9.Name = "label9";
            label9.Size = new Size(38, 17);
            label9.TabIndex = 18;
            label9.Text = "Labs:";
            // 
            // txtbClases
            // 
            txtbClases.BackColor = Color.AliceBlue;
            txtbClases.BorderStyle = BorderStyle.FixedSingle;
            txtbClases.Location = new Point(223, 400);
            txtbClases.Name = "txtbClases";
            txtbClases.Size = new Size(42, 23);
            txtbClases.TabIndex = 21;
            txtbClases.TextChanged += txtbClases_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(169, 400);
            label10.Name = "label10";
            label10.Size = new Size(48, 17);
            label10.TabIndex = 20;
            label10.Text = "Clases:";
            // 
            // btnEditarMateria
            // 
            btnEditarMateria.BackColor = Color.AliceBlue;
            btnEditarMateria.FlatStyle = FlatStyle.Popup;
            btnEditarMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarMateria.ForeColor = SystemColors.WindowText;
            btnEditarMateria.Location = new Point(33, 231);
            btnEditarMateria.Name = "btnEditarMateria";
            btnEditarMateria.Size = new Size(128, 39);
            btnEditarMateria.TabIndex = 22;
            btnEditarMateria.Text = "Editar Materia";
            btnEditarMateria.UseVisualStyleBackColor = false;
            btnEditarMateria.Click += btnEditarMateria_Click;
            // 
            // btnNuevaMateria
            // 
            btnNuevaMateria.BackColor = Color.White;
            btnNuevaMateria.FlatStyle = FlatStyle.Popup;
            btnNuevaMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaMateria.ForeColor = SystemColors.WindowText;
            btnNuevaMateria.Location = new Point(169, 231);
            btnNuevaMateria.Name = "btnNuevaMateria";
            btnNuevaMateria.Size = new Size(128, 39);
            btnNuevaMateria.TabIndex = 23;
            btnNuevaMateria.Text = "Nueva Materia";
            btnNuevaMateria.UseVisualStyleBackColor = false;
            btnNuevaMateria.Click += btnNuevaMateria_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(334, 87);
            label11.Name = "label11";
            label11.Size = new Size(155, 17);
            label11.TabIndex = 25;
            label11.Text = "Categorías de Evaluación";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(325, 97);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(264, 166);
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // dgvPonderaciones
            // 
            dgvPonderaciones.BackgroundColor = Color.AliceBlue;
            dgvPonderaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPonderaciones.Location = new Point(337, 112);
            dgvPonderaciones.Name = "dgvPonderaciones";
            dgvPonderaciones.Size = new Size(240, 102);
            dgvPonderaciones.TabIndex = 26;
            dgvPonderaciones.CellContentClick += dgvPonderaciones_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.WindowText;
            btnEditar.Location = new Point(326, 421);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 23);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.WindowText;
            btnEliminar.Location = new Point(511, 421);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 23);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.White;
            btnAñadir.FlatStyle = FlatStyle.Popup;
            btnAñadir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.ForeColor = SystemColors.WindowText;
            btnAñadir.Location = new Point(419, 421);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(78, 23);
            btnAñadir.TabIndex = 29;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CornflowerBlue;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.Location = new Point(326, 450);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(263, 23);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtbCategoria
            // 
            txtbCategoria.BackColor = Color.AliceBlue;
            txtbCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtbCategoria.Location = new Point(375, 223);
            txtbCategoria.Name = "txtbCategoria";
            txtbCategoria.Size = new Size(77, 23);
            txtbCategoria.TabIndex = 31;
            txtbCategoria.TextChanged += txtbCategoria_TextChanged;
            // 
            // txtbPondeacion
            // 
            txtbPondeacion.BackColor = Color.AliceBlue;
            txtbPondeacion.BorderStyle = BorderStyle.FixedSingle;
            txtbPondeacion.Location = new Point(500, 223);
            txtbPondeacion.Name = "txtbPondeacion";
            txtbPondeacion.Size = new Size(77, 23);
            txtbPondeacion.TabIndex = 32;
            txtbPondeacion.TextChanged += txtbPondeacion_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(337, 226);
            label12.Name = "label12";
            label12.Size = new Size(30, 17);
            label12.TabIndex = 33;
            label12.Text = "Cat:";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(461, 226);
            label13.Name = "label13";
            label13.Size = new Size(33, 17);
            label13.TabIndex = 34;
            label13.Text = "Pon:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(335, 265);
            label14.Name = "label14";
            label14.Size = new Size(129, 17);
            label14.TabIndex = 36;
            label14.Text = "Categorías de Notas";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(326, 275);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(264, 141);
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // dgvNotas
            // 
            dgvNotas.BackgroundColor = Color.AliceBlue;
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(337, 288);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.Size = new Size(240, 87);
            dgvNotas.TabIndex = 37;
            dgvNotas.CellContentClick += dgvNotas_CellContentClick;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(375, 383);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(77, 23);
            cbCategoria.TabIndex = 38;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(339, 386);
            label15.Name = "label15";
            label15.Size = new Size(30, 17);
            label15.TabIndex = 39;
            label15.Text = "Cat:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(459, 387);
            label16.Name = "label16";
            label16.Size = new Size(40, 17);
            label16.TabIndex = 41;
            label16.Text = "Nota:";
            // 
            // txtbNota
            // 
            txtbNota.BackColor = Color.AliceBlue;
            txtbNota.BorderStyle = BorderStyle.FixedSingle;
            txtbNota.Location = new Point(500, 384);
            txtbNota.Name = "txtbNota";
            txtbNota.Size = new Size(77, 23);
            txtbNota.TabIndex = 40;
            txtbNota.TextChanged += txtbNota_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(625, 508);
            Controls.Add(label16);
            Controls.Add(txtbNota);
            Controls.Add(label15);
            Controls.Add(cbCategoria);
            Controls.Add(dgvNotas);
            Controls.Add(label14);
            Controls.Add(pictureBox6);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtbPondeacion);
            Controls.Add(txtbCategoria);
            Controls.Add(btnGuardar);
            Controls.Add(btnAñadir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dgvPonderaciones);
            Controls.Add(label11);
            Controls.Add(pictureBox5);
            Controls.Add(btnNuevaMateria);
            Controls.Add(btnEditarMateria);
            Controls.Add(txtbClases);
            Controls.Add(label10);
            Controls.Add(txtbLabs);
            Controls.Add(label9);
            Controls.Add(txtbCreditos);
            Controls.Add(label8);
            Controls.Add(txtbNombre);
            Controls.Add(txtbCodigo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(lbMaterias);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "S";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPonderaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private PictureBox pictureBox2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lbMaterias;
        private PictureBox pictureBox4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Label label7;
        private TextBox txtbCodigo;
        private TextBox txtbNombre;
        private TextBox txtbCreditos;
        private Label label8;
        private TextBox txtbLabs;
        private Label label9;
        private TextBox txtbClases;
        private Label label10;
        private Button btnEditarMateria;
        private Button btnNuevaMateria;
        private Label label11;
        private PictureBox pictureBox5;
        private DataGridView dgvPonderaciones;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnAñadir;
        private Button btnGuardar;
        private TextBox txtbCategoria;
        private TextBox txtbPondeacion;
        private Label label12;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox6;
        private DataGridView dgvNotas;
        private ComboBox cbCategoria;
        private Label label15;
        private Label label16;
        private TextBox txtbNota;
    }
}
