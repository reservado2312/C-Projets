namespace Funcinario
{
    partial class frmFuncionarios
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            statusStrip1 = new StatusStrip();
            lblStatusServidorDados = new ToolStripStatusLabel();
            lblRelogio = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblId = new ToolStripStatusLabel();
            btnLimapar = new ToolStripStatusLabel();
            btnCadastrar = new Button();
            lblNome = new Label();
            tbxNome = new TextBox();
            tbxEmail = new TextBox();
            lblEmail = new Label();
            tbxCpf = new TextBox();
            lblCpf = new Label();
            tbxEndereco = new TextBox();
            lblEndereco = new Label();
            lblTitulo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timerVerificaConexaoDb = new System.Windows.Forms.Timer(components);
            btnMostrarTodos = new Button();
            dgvFuncionarios = new DataGridView();
            btnPesquisar = new Button();
            btnAtualizar = new Button();
            lblPesquisa = new Label();
            btnDeletar = new Button();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.DarkGray;
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusServidorDados, lblRelogio, toolStripStatusLabel1, lblId, btnLimapar });
            statusStrip1.Location = new Point(0, 939);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 22, 0);
            statusStrip1.Size = new Size(791, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusServidorDados
            // 
            lblStatusServidorDados.Name = "lblStatusServidorDados";
            lblStatusServidorDados.Size = new Size(110, 17);
            lblStatusServidorDados.Text = "Banco de Dados:.....";
            // 
            // lblRelogio
            // 
            lblRelogio.Name = "lblRelogio";
            lblRelogio.Size = new Size(49, 17);
            lblRelogio.Text = "00:00:00";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(86, 17);
            toolStripStatusLabel1.Text = "Funcionario id:";
            toolStripStatusLabel1.Visible = false;
            // 
            // lblId
            // 
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 17);
            // 
            // btnLimapar
            // 
            btnLimapar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimapar.Name = "btnLimapar";
            btnLimapar.Size = new Size(91, 17);
            btnLimapar.Text = "Limpar Campos";
            btnLimapar.Click += btnLimapar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(14, 436);
            btnCadastrar.Margin = new Padding(5);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(162, 38);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblNome.Location = new Point(14, 99);
            lblNome.Margin = new Padding(5, 0, 5, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(73, 30);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // tbxNome
            // 
            tbxNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbxNome.Location = new Point(14, 129);
            tbxNome.Margin = new Padding(5);
            tbxNome.MaxLength = 100;
            tbxNome.Name = "tbxNome";
            tbxNome.PlaceholderText = "Insira seu nome completo";
            tbxNome.Size = new Size(766, 29);
            tbxNome.TabIndex = 1;
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbxEmail.Location = new Point(14, 219);
            tbxEmail.Margin = new Padding(5);
            tbxEmail.MaxLength = 100;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Insira seu Email";
            tbxEmail.Size = new Size(766, 29);
            tbxEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblEmail.Location = new Point(14, 189);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(66, 30);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // tbxCpf
            // 
            tbxCpf.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbxCpf.Location = new Point(14, 308);
            tbxCpf.Margin = new Padding(5);
            tbxCpf.MaxLength = 11;
            tbxCpf.Name = "tbxCpf";
            tbxCpf.PlaceholderText = "Insira seu CPF";
            tbxCpf.Size = new Size(766, 29);
            tbxCpf.TabIndex = 3;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblCpf.Location = new Point(14, 278);
            lblCpf.Margin = new Padding(5, 0, 5, 0);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(50, 30);
            lblCpf.TabIndex = 7;
            lblCpf.Text = "CPF";
            // 
            // tbxEndereco
            // 
            tbxEndereco.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbxEndereco.Location = new Point(14, 391);
            tbxEndereco.Margin = new Padding(5);
            tbxEndereco.MaxLength = 200;
            tbxEndereco.Name = "tbxEndereco";
            tbxEndereco.PlaceholderText = "Insira seu endereço";
            tbxEndereco.Size = new Size(766, 29);
            tbxEndereco.TabIndex = 4;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblEndereco.Location = new Point(14, 361);
            lblEndereco.Margin = new Padding(5, 0, 5, 0);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(103, 30);
            lblEndereco.TabIndex = 9;
            lblEndereco.Text = "Endereço";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.CausesValidation = false;
            lblTitulo.Font = new Font("Skranji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(205, 26);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(417, 44);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Cadastro de funcionarios";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // timerVerificaConexaoDb
            // 
            timerVerificaConexaoDb.Enabled = true;
            timerVerificaConexaoDb.Interval = 30000;
            timerVerificaConexaoDb.Tick += timerVerificaConexaoDb_Tick;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(570, 487);
            btnMostrarTodos.Margin = new Padding(5);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(212, 29);
            btnMostrarTodos.TabIndex = 12;
            btnMostrarTodos.Text = "Atualiza Lista";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnTeste_Click;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Dock = DockStyle.Bottom;
            dgvFuncionarios.Location = new Point(0, 523);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.ReadOnly = true;
            dgvFuncionarios.Size = new Size(791, 416);
            dgvFuncionarios.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(182, 436);
            btnPesquisar.Margin = new Padding(5);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(197, 38);
            btnPesquisar.TabIndex = 15;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(383, 436);
            btnAtualizar.Margin = new Padding(5);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(197, 38);
            btnAtualizar.TabIndex = 16;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblPesquisa.Location = new Point(14, 491);
            lblPesquisa.Margin = new Padding(5, 0, 5, 0);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(353, 30);
            lblPesquisa.TabIndex = 17;
            lblPesquisa.Text = "Todos os Funcionarios cadastrados";
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(585, 436);
            btnDeletar.Margin = new Padding(5);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(197, 38);
            btnDeletar.TabIndex = 18;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // frmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(791, 961);
            Controls.Add(btnDeletar);
            Controls.Add(lblPesquisa);
            Controls.Add(btnAtualizar);
            Controls.Add(btnPesquisar);
            Controls.Add(dgvFuncionarios);
            Controls.Add(btnMostrarTodos);
            Controls.Add(lblTitulo);
            Controls.Add(tbxEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(tbxCpf);
            Controls.Add(lblCpf);
            Controls.Add(tbxEmail);
            Controls.Add(lblEmail);
            Controls.Add(tbxNome);
            Controls.Add(lblNome);
            Controls.Add(btnCadastrar);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximumSize = new Size(1407, 1000);
            MinimumSize = new Size(600, 1000);
            Name = "frmFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Funcionarios";
            Load += frmFuncionarios_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusServidorDados;
        private ToolStripStatusLabel lblRelogio;
        private Button btnCadastrar;
        private Label lblNome;
        private TextBox tbxNome;
        private TextBox tbxEmail;
        private Label lblEmail;
        private TextBox tbxCpf;
        private Label lblCpf;
        private TextBox tbxEndereco;
        private Label lblEndereco;
        private Label lblTitulo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerVerificaConexaoDb;
        private Button btnMostrarTodos;
        private DataGridView dgvFuncionarios;
        private Button btnPesquisar;
        private Button btnAtualizar;
        private Label lblPesquisa;
        private Button btnDeletar;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblId;
        private ToolStripStatusLabel btnLimapar;
    }
}
