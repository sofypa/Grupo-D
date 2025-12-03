namespace TallerCapas
{
    partial class ResumenAcadémico
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
            ofdFoto = new OpenFileDialog();
            btnMateria = new Button();
            label1 = new Label();
            btnCerrarSesion = new Button();
            btnNotas = new Button();
            btnCategoria = new Button();
            dgvDashboard = new DataGridView();
            panelEncabezado = new Panel();
            lblBienvenida = new Label();
            panelBotones = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            lblAcciones = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblAdvertencia = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).BeginInit();
            panelEncabezado.SuspendLayout();
            panelBotones.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ofdFoto
            // 
            ofdFoto.FileName = "ofdFoto";
            // 
            // btnMateria
            // 
            btnMateria.BackColor = Color.CornflowerBlue;
            btnMateria.FlatAppearance.BorderColor = Color.Black;
            btnMateria.FlatAppearance.BorderSize = 2;
            btnMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMateria.ForeColor = Color.White;
            btnMateria.Location = new Point(27, 111);
            btnMateria.Margin = new Padding(2);
            btnMateria.Name = "btnMateria";
            btnMateria.Size = new Size(182, 40);
            btnMateria.TabIndex = 12;
            btnMateria.Text = "Gestionar Materias";
            btnMateria.UseVisualStyleBackColor = false;
            btnMateria.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(291, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 41);
            label1.TabIndex = 13;
            label1.Text = "RESUMEN ACADÉMICO";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Maroon;
            btnCerrarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            btnCerrarSesion.Location = new Point(42, 385);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(152, 43);
            btnCerrarSesion.TabIndex = 21;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnNotas
            // 
            btnNotas.BackColor = Color.CornflowerBlue;
            btnNotas.FlatAppearance.BorderColor = Color.Black;
            btnNotas.FlatAppearance.BorderSize = 2;
            btnNotas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNotas.ForeColor = Color.White;
            btnNotas.Location = new Point(27, 253);
            btnNotas.Margin = new Padding(2);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(182, 40);
            btnNotas.TabIndex = 23;
            btnNotas.Text = "Gestionar Notas";
            btnNotas.UseVisualStyleBackColor = false;
            btnNotas.Click += button1_Click_1;
            // 
            // btnCategoria
            // 
            btnCategoria.BackColor = Color.CornflowerBlue;
            btnCategoria.FlatAppearance.BorderColor = Color.Black;
            btnCategoria.FlatAppearance.BorderSize = 2;
            btnCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCategoria.ForeColor = Color.White;
            btnCategoria.Location = new Point(27, 181);
            btnCategoria.Margin = new Padding(2);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(182, 40);
            btnCategoria.TabIndex = 24;
            btnCategoria.Text = "Gestionar Categorias";
            btnCategoria.UseVisualStyleBackColor = false;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // dgvDashboard
            // 
            dgvDashboard.BackgroundColor = Color.White;
            dgvDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDashboard.Location = new Point(291, 184);
            dgvDashboard.Margin = new Padding(2);
            dgvDashboard.Name = "dgvDashboard";
            dgvDashboard.RowHeadersWidth = 62;
            dgvDashboard.Size = new Size(575, 213);
            dgvDashboard.TabIndex = 15;
            // 
            // panelEncabezado
            // 
            panelEncabezado.BackColor = Color.MidnightBlue;
            panelEncabezado.Controls.Add(lblBienvenida);
            panelEncabezado.Controls.Add(label1);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(933, 115);
            panelEncabezado.TabIndex = 26;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 10F);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(328, 76);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(117, 23);
            lblBienvenida.TabIndex = 14;
            lblBienvenida.Text = "Bienvenido(a):";
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.White;
            panelBotones.Controls.Add(panel3);
            panelBotones.Controls.Add(panel1);
            panelBotones.Controls.Add(lblAcciones);
            panelBotones.Controls.Add(btnCategoria);
            panelBotones.Controls.Add(btnNotas);
            panelBotones.Controls.Add(btnCerrarSesion);
            panelBotones.Controls.Add(btnMateria);
            panelBotones.Dock = DockStyle.Left;
            panelBotones.Location = new Point(0, 115);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(236, 477);
            panelBotones.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(12, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(213, 2);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(12, 356);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 2);
            panel1.TabIndex = 0;
            // 
            // lblAcciones
            // 
            lblAcciones.AutoSize = true;
            lblAcciones.BackColor = Color.White;
            lblAcciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAcciones.Location = new Point(19, 18);
            lblAcciones.Name = "lblAcciones";
            lblAcciones.Size = new Size(193, 28);
            lblAcciones.TabIndex = 15;
            lblAcciones.Text = "Gestión Académica";
            lblAcciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblAdvertencia);
            panel2.Controls.Add(dgvDashboard);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 592);
            panel2.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(712, 141);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 19;
            button1.Text = "Actualizar Tabla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(304, 484);
            label2.Name = "label2";
            label2.Size = new Size(556, 38);
            label2.TabIndex = 0;
            label2.Text = "Este resumen muestra el promedio por materia y la cantidad de evaluaciones registradas. \r\nPara ver el detalle y generar reportes, dirígete a Gestión de Notas.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(294, 475);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(575, 56);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.AutoSize = true;
            lblAdvertencia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdvertencia.ForeColor = Color.DarkRed;
            lblAdvertencia.Location = new Point(291, 410);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(59, 23);
            lblAdvertencia.TabIndex = 17;
            lblAdvertencia.Text = "label3";
            // 
            // ResumenAcadémico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(933, 592);
            Controls.Add(panelBotones);
            Controls.Add(panelEncabezado);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "ResumenAcadémico";
            Text = "Resumen Académico";
            Load += ResumenAcadémico_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).EndInit();
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog ofdFoto;
        private Button btnMateria;
        private Label label1;
        private Button btnCerrarSesion;
        private Button btnNotas;
        private Button btnCategoria;
        private DataGridView dgvDashboard;
        private Panel panelEncabezado;
        private Label lblBienvenida;
        private Panel panelBotones;
        private Label lblAcciones;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label lblAdvertencia;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
