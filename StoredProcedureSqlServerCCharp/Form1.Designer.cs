namespace StoredProcedureSqlServerCCharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnNOVO = new Button();
            btnSALVAR = new Button();
            btnEXCLUIR = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            txtNome = new TextBox();
            txtBUSCAR = new TextBox();
            txtEndereco = new TextBox();
            txtFilhos = new TextBox();
            txtConjuge = new TextBox();
            txtEmail = new TextBox();
            mskTelefone = new MaskedTextBox();
            label10 = new Label();
            mskCPF = new MaskedTextBox();
            txtEstadoCivil = new TextBox();
            label14 = new Label();
            btnBUSCAR = new Button();
            mskDataAdmissao = new MaskedTextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNOVO
            // 
            btnNOVO.BackColor = Color.Teal;
            btnNOVO.ForeColor = Color.White;
            btnNOVO.Location = new Point(250, 296);
            btnNOVO.Name = "btnNOVO";
            btnNOVO.Size = new Size(70, 42);
            btnNOVO.TabIndex = 1;
            btnNOVO.Text = "NOVO";
            btnNOVO.UseVisualStyleBackColor = false;
            btnNOVO.Click += btnNOVO_Click;
            // 
            // btnSALVAR
            // 
            btnSALVAR.BackColor = Color.Teal;
            btnSALVAR.ForeColor = Color.White;
            btnSALVAR.Location = new Point(326, 295);
            btnSALVAR.Name = "btnSALVAR";
            btnSALVAR.Size = new Size(69, 42);
            btnSALVAR.TabIndex = 2;
            btnSALVAR.Text = "SALVAR";
            btnSALVAR.UseVisualStyleBackColor = false;
            btnSALVAR.Click += button3_Click;
            // 
            // btnEXCLUIR
            // 
            btnEXCLUIR.BackColor = Color.Teal;
            btnEXCLUIR.ForeColor = Color.White;
            btnEXCLUIR.Location = new Point(476, 296);
            btnEXCLUIR.Name = "btnEXCLUIR";
            btnEXCLUIR.Size = new Size(70, 42);
            btnEXCLUIR.TabIndex = 4;
            btnEXCLUIR.Text = "EXCLUIR";
            btnEXCLUIR.UseVisualStyleBackColor = false;
            btnEXCLUIR.Click += btnEXCLUIR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 48);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 111);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 140);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(38, 169);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 226);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 9;
            label5.Text = "Conjuge";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.ForeColor = Color.White;
            label6.Location = new Point(34, 255);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 10;
            label6.Text = "Filhos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.ForeColor = Color.White;
            label7.Location = new Point(5, 286);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 11;
            label7.Text = "Data de Admissão";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(86, 13);
            label9.Name = "label9";
            label9.Size = new Size(319, 24);
            label9.TabIndex = 13;
            label9.Text = "CRUD TABELA FUNCIONÁRIOS";
            label9.Click += label9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(250, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(296, 182);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.PaleTurquoise;
            txtNome.Location = new Point(80, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(158, 23);
            txtNome.TabIndex = 15;
            // 
            // txtBUSCAR
            // 
            txtBUSCAR.BackColor = Color.PaleTurquoise;
            txtBUSCAR.Location = new Point(349, 55);
            txtBUSCAR.Name = "txtBUSCAR";
            txtBUSCAR.Size = new Size(171, 23);
            txtBUSCAR.TabIndex = 16;
            txtBUSCAR.TextChanged += txtBUSCAR_TextChanged;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.PaleTurquoise;
            txtEndereco.Location = new Point(79, 103);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(159, 23);
            txtEndereco.TabIndex = 17;
            // 
            // txtFilhos
            // 
            txtFilhos.BackColor = Color.PaleTurquoise;
            txtFilhos.Location = new Point(80, 252);
            txtFilhos.Name = "txtFilhos";
            txtFilhos.Size = new Size(42, 23);
            txtFilhos.TabIndex = 18;
            // 
            // txtConjuge
            // 
            txtConjuge.BackColor = Color.PaleTurquoise;
            txtConjuge.Location = new Point(80, 223);
            txtConjuge.Name = "txtConjuge";
            txtConjuge.Size = new Size(158, 23);
            txtConjuge.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.PaleTurquoise;
            txtEmail.Location = new Point(80, 161);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 23);
            txtEmail.TabIndex = 20;
            // 
            // mskTelefone
            // 
            mskTelefone.BackColor = Color.PaleTurquoise;
            mskTelefone.Location = new Point(80, 132);
            mskTelefone.Mask = "(00)00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(85, 23);
            mskTelefone.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Black;
            label10.ForeColor = Color.White;
            label10.Location = new Point(45, 82);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 23;
            label10.Text = "CPF";
            // 
            // mskCPF
            // 
            mskCPF.BackColor = Color.PaleTurquoise;
            mskCPF.Location = new Point(80, 74);
            mskCPF.Mask = "000,000,000-00";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(85, 23);
            mskCPF.TabIndex = 24;
            // 
            // txtEstadoCivil
            // 
            txtEstadoCivil.BackColor = Color.PaleTurquoise;
            txtEstadoCivil.Location = new Point(80, 190);
            txtEstadoCivil.Name = "txtEstadoCivil";
            txtEstadoCivil.Size = new Size(85, 23);
            txtEstadoCivil.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Black;
            label14.ForeColor = Color.White;
            label14.Location = new Point(5, 198);
            label14.Name = "label14";
            label14.Size = new Size(68, 15);
            label14.TabIndex = 29;
            label14.Text = "Estado Civil";
            // 
            // btnBUSCAR
            // 
            btnBUSCAR.BackColor = Color.Teal;
            btnBUSCAR.ForeColor = Color.White;
            btnBUSCAR.Location = new Point(283, 53);
            btnBUSCAR.Name = "btnBUSCAR";
            btnBUSCAR.Size = new Size(60, 28);
            btnBUSCAR.TabIndex = 30;
            btnBUSCAR.Text = "BUSCAR";
            btnBUSCAR.UseVisualStyleBackColor = false;
            btnBUSCAR.Click += btnBUSCAR_Click;
            // 
            // mskDataAdmissao
            // 
            mskDataAdmissao.BackColor = Color.PaleTurquoise;
            mskDataAdmissao.Location = new Point(113, 286);
            mskDataAdmissao.Mask = "00/00/0000";
            mskDataAdmissao.Name = "mskDataAdmissao";
            mskDataAdmissao.Size = new Size(69, 23);
            mskDataAdmissao.TabIndex = 31;
            mskDataAdmissao.ValidatingType = typeof(DateTime);
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(401, 296);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(69, 42);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "ALTERAR";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(558, 365);
            Controls.Add(btnUpdate);
            Controls.Add(mskDataAdmissao);
            Controls.Add(btnBUSCAR);
            Controls.Add(label14);
            Controls.Add(txtEstadoCivil);
            Controls.Add(mskCPF);
            Controls.Add(label10);
            Controls.Add(mskTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtConjuge);
            Controls.Add(txtFilhos);
            Controls.Add(txtEndereco);
            Controls.Add(txtBUSCAR);
            Controls.Add(txtNome);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEXCLUIR);
            Controls.Add(btnSALVAR);
            Controls.Add(btnNOVO);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrudFuncionários";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNOVO;
        private Button btnSALVAR;
        private Button btnEXCLUIR;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private DataGridView dataGridView1;
        private TextBox txtNome;
        private TextBox txtBUSCAR;
        private TextBox txtEndereco;
        private TextBox txtFilhos;
        private TextBox txtConjuge;
        private TextBox txtEmail;
        private MaskedTextBox mskTelefone;
        private Label label10;
        private MaskedTextBox mskCPF;
        private TextBox txtEstadoCivil;
        private Label label14;
        private Button btnBUSCAR;
        private MaskedTextBox mskDataAdmissao;
        private Button btnUpdate;
    }
}