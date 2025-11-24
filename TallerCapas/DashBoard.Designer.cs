namespace TallerCapas
{
    partial class DashBoard
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
            dgvDashboard = new DataGridView();
            comboGrupo = new ComboBox();
            groupBox2 = new GroupBox();
            button5 = new Button();
            btnActualizar = new Button();
            btnNotas = new Button();
            btnCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ofdFoto
            // 
            ofdFoto.FileName = "ofdFoto";
            ofdFoto.FileOk += openFileDialog1_FileOk;
            // 
            // btnMateria
            // 
            btnMateria.Location = new Point(324, 143);
            btnMateria.Margin = new Padding(2);
            btnMateria.Name = "btnMateria";
            btnMateria.Size = new Size(205, 43);
            btnMateria.TabIndex = 12;
            btnMateria.Text = "Gestionar Materias";
            btnMateria.UseVisualStyleBackColor = true;
            btnMateria.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(500, 41);
            label1.TabIndex = 13;
            label1.Text = "DASHBOARD DE CALIFICACIONES";
            label1.Click += label1_Click;
            // 
            // dgvDashboard
            // 
            dgvDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDashboard.Location = new Point(44, 255);
            dgvDashboard.Margin = new Padding(2);
            dgvDashboard.Name = "dgvDashboard";
            dgvDashboard.RowHeadersWidth = 62;
            dgvDashboard.Size = new Size(690, 213);
            dgvDashboard.TabIndex = 15;
            // 
            // comboGrupo
            // 
            comboGrupo.FormattingEnabled = true;
            comboGrupo.Location = new Point(15, 37);
            comboGrupo.Name = "comboGrupo";
            comboGrupo.Size = new Size(174, 28);
            comboGrupo.TabIndex = 19;
            comboGrupo.SelectedIndexChanged += comboGrupo_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboGrupo);
            groupBox2.Location = new Point(44, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 86);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtrar";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.WindowFrame;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(597, 180);
            button5.Name = "button5";
            button5.Size = new Size(125, 29);
            button5.TabIndex = 21;
            button5.Text = "Cerrar sesión";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(597, 145);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 29);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnNotas
            // 
            btnNotas.Location = new Point(324, 186);
            btnNotas.Margin = new Padding(2);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(205, 43);
            btnNotas.TabIndex = 23;
            btnNotas.Text = "Gestionar Notas";
            btnNotas.UseVisualStyleBackColor = true;
            btnNotas.Click += button1_Click_1;
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(44, 472);
            btnCategoria.Margin = new Padding(2);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(205, 29);
            btnCategoria.TabIndex = 24;
            btnCategoria.Text = "Categorias";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(788, 573);
            Controls.Add(btnCategoria);
            Controls.Add(btnNotas);
            Controls.Add(btnActualizar);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(btnMateria);
            Controls.Add(dgvDashboard);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "DashBoard";
            Text = "Form1";
            Load += FrmDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog ofdFoto;
        private Button btnMateria;
        private Label label1;
        private DataGridView dgvDashboard;
        private ComboBox comboGrupo;
        private GroupBox groupBox2;
        private Button button5;
        private Button btnActualizar;
        private Button btnNotas;
        private Button btnCategoria;
    }
}
