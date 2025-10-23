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
            button4 = new Button();
            label1 = new Label();
            labelUser = new Label();
            dgvDashboard = new DataGridView();
            comboGrupo = new ComboBox();
            groupBox2 = new GroupBox();
            button5 = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ofdFoto
            // 
            ofdFoto.FileName = "ofdFoto";
            ofdFoto.FileOk += openFileDialog1_FileOk;
            // 
            // button4
            // 
            button4.Location = new Point(322, 180);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(205, 29);
            button4.TabIndex = 12;
            button4.Text = "Gestionar Materias y Notas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelUser.Location = new Point(547, 37);
            labelUser.Margin = new Padding(2, 0, 2, 0);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(138, 28);
            labelUser.TabIndex = 14;
            labelUser.Text = "Sofía Escudero";
            labelUser.Click += label2_Click;
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
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(788, 573);
            Controls.Add(btnActualizar);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(dgvDashboard);
            Controls.Add(labelUser);
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
        private Button button4;
        private Label label1;
        private Label labelUser;
        private DataGridView dgvDashboard;
        private ComboBox comboGrupo;
        private GroupBox groupBox2;
        private Button button5;
        private Button btnActualizar;
    }
}
