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
            label16 = new Label();
            label15 = new Label();
            cbCategoria = new ComboBox();
            label14 = new Label();
            pictureBox6 = new PictureBox();
            btnVolverDashboard = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            btnElimMat = new Button();
            btnEditMat = new Button();
            btnRegisMat = new Button();
            dataGridView1 = new DataGridView();
            cmbMaterias = new ComboBox();
            lblMateria = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnGuardar = new Button();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numNota
            // 
            numNota.Location = new Point(256, 223);
            numNota.Name = "numNota";
            numNota.Size = new Size(103, 27);
            numNota.TabIndex = 54;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(142, 227);
            label16.Name = "label16";
            label16.Size = new Size(100, 23);
            label16.TabIndex = 53;
            label16.Text = "Calificación:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(154, 185);
            label15.Name = "label15";
            label15.Size = new Size(88, 23);
            label15.TabIndex = 52;
            label15.Text = "Categoría:";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(256, 180);
            cbCategoria.Margin = new Padding(3, 4, 3, 4);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(182, 28);
            cbCategoria.TabIndex = 51;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(129, 106);
            label14.Name = "label14";
            label14.Size = new Size(171, 23);
            label14.TabIndex = 49;
            label14.Text = "Categorías de Notas";
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 466);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 198);
            dataGridView1.TabIndex = 67;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 269);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 70;
            label2.Text = "Comentario:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 269);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 71;
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
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CornflowerBlue;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.Location = new Point(234, 323);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 27);
            btnGuardar.TabIndex = 75;
            btnGuardar.Text = "Limpiar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 706);
            label4.Name = "label4";
            label4.Size = new Size(226, 29);
            label4.TabIndex = 76;
            label4.Text = "Promedio calculado: ...";
            // 
            // button1
            // 
            button1.Location = new Point(12, 78);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 77;
            button1.Text = "ir atrás";
            button1.UseVisualStyleBackColor = true;
            // 
            // Notas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(796, 764);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lblMateria);
            Controls.Add(cmbMaterias);
            Controls.Add(dataGridView1);
            Controls.Add(btnElimMat);
            Controls.Add(btnEditMat);
            Controls.Add(btnRegisMat);
            Controls.Add(btnVolverDashboard);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(numNota);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(cbCategoria);
            Controls.Add(label14);
            Controls.Add(pictureBox6);
            Name = "Notas";
            Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numNota;
        private Label label16;
        private Label label15;
        private ComboBox cbCategoria;
        private Label label14;
        private PictureBox pictureBox6;
        private Button btnVolverDashboard;
        private Label label1;
        private PictureBox pictureBox3;
        private Button btnElimMat;
        private Button btnEditMat;
        private Button btnRegisMat;
        private DataGridView dataGridView1;
        private ComboBox cmbMaterias;
        private Label lblMateria;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnGuardar;
        private Label label4;
        private Button button1;
    }
}