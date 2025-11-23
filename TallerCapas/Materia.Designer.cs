namespace CapaPresentacion
{
    partial class Materia
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
            numClases = new NumericUpDown();
            numCreditos = new NumericUpDown();
            numLabs = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtbNombre = new TextBox();
            txtbCodigo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnRegisMat = new Button();
            pictureBox4 = new PictureBox();
            btnEditMat = new Button();
            btnElimMat = new Button();
            btnLimpiar = new Button();
            cmbMaterias = new ComboBox();
            label1 = new Label();
            btnVolverDashboard = new Button();
            ((System.ComponentModel.ISupportInitialize)numClases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCreditos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLabs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // numClases
            // 
            numClases.Location = new Point(236, 258);
            numClases.Name = "numClases";
            numClases.Size = new Size(67, 27);
            numClases.TabIndex = 60;
            // 
            // numCreditos
            // 
            numCreditos.Location = new Point(93, 219);
            numCreditos.Name = "numCreditos";
            numCreditos.Size = new Size(67, 27);
            numCreditos.TabIndex = 59;
            // 
            // numLabs
            // 
            numLabs.Location = new Point(93, 258);
            numLabs.Name = "numLabs";
            numLabs.Size = new Size(67, 27);
            numLabs.TabIndex = 58;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(169, 258);
            label10.Name = "label10";
            label10.Size = new Size(61, 23);
            label10.TabIndex = 57;
            label10.Text = "Clases:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(42, 258);
            label9.Name = "label9";
            label9.Size = new Size(48, 23);
            label9.TabIndex = 56;
            label9.Text = "Labs:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 220);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 55;
            label8.Text = "Créditos:";
            // 
            // txtbNombre
            // 
            txtbNombre.BackColor = Color.AliceBlue;
            txtbNombre.BorderStyle = BorderStyle.FixedSingle;
            txtbNombre.Location = new Point(93, 181);
            txtbNombre.Margin = new Padding(3, 4, 3, 4);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(212, 27);
            txtbNombre.TabIndex = 54;
            // 
            // txtbCodigo
            // 
            txtbCodigo.BackColor = Color.AliceBlue;
            txtbCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtbCodigo.Location = new Point(93, 142);
            txtbCodigo.Margin = new Padding(3, 4, 3, 4);
            txtbCodigo.Name = "txtbCodigo";
            txtbCodigo.Size = new Size(212, 27);
            txtbCodigo.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 181);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 52;
            label7.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 142);
            label6.Name = "label6";
            label6.Size = new Size(69, 23);
            label6.TabIndex = 51;
            label6.Text = "Código:";
            // 
            // btnRegisMat
            // 
            btnRegisMat.BackColor = Color.CornflowerBlue;
            btnRegisMat.FlatStyle = FlatStyle.Popup;
            btnRegisMat.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisMat.ForeColor = SystemColors.Window;
            btnRegisMat.Location = new Point(333, 128);
            btnRegisMat.Margin = new Padding(3, 4, 3, 4);
            btnRegisMat.Name = "btnRegisMat";
            btnRegisMat.Size = new Size(161, 53);
            btnRegisMat.TabIndex = 50;
            btnRegisMat.Text = "Registrar materia";
            btnRegisMat.UseVisualStyleBackColor = false;
            btnRegisMat.Click += btnRegisMat_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(14, 113);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(301, 241);
            pictureBox4.TabIndex = 48;
            pictureBox4.TabStop = false;
            // 
            // btnEditMat
            // 
            btnEditMat.BackColor = Color.CornflowerBlue;
            btnEditMat.FlatStyle = FlatStyle.Popup;
            btnEditMat.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditMat.ForeColor = SystemColors.Window;
            btnEditMat.Location = new Point(333, 205);
            btnEditMat.Margin = new Padding(3, 4, 3, 4);
            btnEditMat.Name = "btnEditMat";
            btnEditMat.Size = new Size(161, 53);
            btnEditMat.TabIndex = 61;
            btnEditMat.Text = "Editar Materia";
            btnEditMat.UseVisualStyleBackColor = false;
            btnEditMat.Click += btnEditMat_Click;
            // 
            // btnElimMat
            // 
            btnElimMat.BackColor = Color.CornflowerBlue;
            btnElimMat.FlatStyle = FlatStyle.Popup;
            btnElimMat.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnElimMat.ForeColor = SystemColors.Window;
            btnElimMat.Location = new Point(333, 291);
            btnElimMat.Margin = new Padding(3, 4, 3, 4);
            btnElimMat.Name = "btnElimMat";
            btnElimMat.Size = new Size(161, 53);
            btnElimMat.TabIndex = 62;
            btnElimMat.Text = "Eliminar Materia";
            btnElimMat.UseVisualStyleBackColor = false;
            btnElimMat.Click += btnElimMat_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.CornflowerBlue;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.Window;
            btnLimpiar.Location = new Point(126, 311);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 33);
            btnLimpiar.TabIndex = 63;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(14, 78);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(151, 28);
            cmbMaterias.TabIndex = 64;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(119, 38);
            label1.TabIndex = 65;
            label1.Text = "Materia";
            // 
            // btnVolverDashboard
            // 
            btnVolverDashboard.BackColor = Color.White;
            btnVolverDashboard.FlatStyle = FlatStyle.Popup;
            btnVolverDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverDashboard.ForeColor = SystemColors.WindowText;
            btnVolverDashboard.Location = new Point(333, 46);
            btnVolverDashboard.Margin = new Padding(3, 4, 3, 4);
            btnVolverDashboard.Name = "btnVolverDashboard";
            btnVolverDashboard.Size = new Size(159, 31);
            btnVolverDashboard.TabIndex = 66;
            btnVolverDashboard.Text = "Volver a Dashboard";
            btnVolverDashboard.UseVisualStyleBackColor = false;
            btnVolverDashboard.Click += btnVolverDashboard_Click;
            // 
            // Materia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 404);
            Controls.Add(btnVolverDashboard);
            Controls.Add(label1);
            Controls.Add(cmbMaterias);
            Controls.Add(btnLimpiar);
            Controls.Add(btnElimMat);
            Controls.Add(btnEditMat);
            Controls.Add(numClases);
            Controls.Add(numCreditos);
            Controls.Add(numLabs);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtbNombre);
            Controls.Add(txtbCodigo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnRegisMat);
            Controls.Add(pictureBox4);
            Name = "Materia";
            Text = "Materia";
            Load += Materia_Load;
            ((System.ComponentModel.ISupportInitialize)numClases).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCreditos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLabs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numClases;
        private NumericUpDown numCreditos;
        private NumericUpDown numLabs;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtbNombre;
        private TextBox txtbCodigo;
        private Label label7;
        private Label label6;
        private Button btnRegisMat;
        private PictureBox pictureBox4;
        private Button btnEditMat;
        private Button btnElimMat;
        private Button btnLimpiar;
        private ComboBox cmbMaterias;
        private Label label1;
        private Button btnVolverDashboard;
    }
}