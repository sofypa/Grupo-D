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
            button1 = new Button();
            button2 = new Button();
            ofdFoto = new OpenFileDialog();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            labelUser = new Label();
            dgvDashboard = new DataGridView();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            comboGrupo = new ComboBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(231, 27);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(144, 36);
            button1.TabIndex = 0;
            button1.Text = "Agregar Materia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(231, 70);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(148, 37);
            button2.TabIndex = 1;
            button2.Text = "Modificar Materia";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ofdFoto
            // 
            ofdFoto.FileName = "ofdFoto";
            ofdFoto.FileOk += openFileDialog1_FileOk;
            // 
            // button3
            // 
            button3.Location = new Point(25, 70);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(140, 37);
            button3.TabIndex = 11;
            button3.Text = "Modificar Nota";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(25, 24);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(140, 36);
            button4.TabIndex = 12;
            button4.Text = "Agregar Nota";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 16);
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
            labelUser.Location = new Point(530, 29);
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
            dgvDashboard.Location = new Point(42, 232);
            dgvDashboard.Margin = new Padding(2);
            dgvDashboard.Name = "dgvDashboard";
            dgvDashboard.RowHeadersWidth = 62;
            dgvDashboard.Size = new Size(690, 213);
            dgvDashboard.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(771, 95);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(418, 122);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 119);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 17;
            label2.Text = "Materias Cursando:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 162);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 18;
            label3.Text = "Materias en Riesgo:";
            label3.Click += label3_Click;
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
            groupBox2.Location = new Point(42, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 86);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtrar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1270, 573);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(dgvDashboard);
            Controls.Add(labelUser);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += FrmDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button button1;
        private Button button2;
        private OpenFileDialog ofdFoto;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label labelUser;
        private DataGridView dgvDashboard;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboGrupo;
        private GroupBox groupBox2;
    }
}
