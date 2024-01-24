using MySql.Data.MySqlClient;
using System.Data;

namespace Funcinario
{
    public partial class frmFuncionarios : Form
    {
        DataTable dt = new DataTable();
        public frmFuncionarios()
        {
            InitializeComponent();
            Initializar();
        }

        private void Initializar()
        {
            dt = ListarFuncionarios.GetFuncionarios();
            dgvFuncionarios.DataSource = dt;
            ConfiguraDgv();
        }

        private void ConfiguraDgv()
        {
            dgvFuncionarios.DefaultCellStyle.Font = new Font("Arial", 9);

            dgvFuncionarios.RowHeadersWidth = 25;

            dgvFuncionarios.Columns["id"].HeaderText = "ID";
            dgvFuncionarios.Columns["id"].Visible = false;

            dgvFuncionarios.Columns["nome"].HeaderText = "Nome";
            dgvFuncionarios.Columns["nome"].Width = 250;
            dgvFuncionarios.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["nome"].HeaderCell.Style.BackColor = Color.Black;
            dgvFuncionarios.Columns["nome"].HeaderCell.Style.SelectionBackColor = Color.Black;

            dgvFuncionarios.Columns["email"].HeaderText = "Email";
            dgvFuncionarios.Columns["email"].Width = 200;
            dgvFuncionarios.Columns["email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFuncionarios.Columns["cpf"].HeaderText = "CPF";
            dgvFuncionarios.Columns["cpf"].Width = 100;
            dgvFuncionarios.Columns["cpf"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFuncionarios.Columns["endereco"].HeaderText = "endereco";
            dgvFuncionarios.Columns["endereco"].Width = 300;
            dgvFuncionarios.Columns["endereco"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFuncionarios.Columns["endereco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Opa");
            Initializar();

        }

        private bool textBoxVazias()
        {
            //Verifica se tem algum TextBox Vazio e se tiver retorna verdade
            //Pretendo melhorar esse codigo para que ele possa te por no campo que esta vazio
            foreach (Control c in this.Controls)
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox?.Text))
                        return true;
                }
            return false;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Teste");         
                if (!textBoxVazias())
                {
                    cadastroFuncionarios cadFuncionario = new cadastroFuncionarios();
                    cadFuncionario.Nome = tbxNome.Text;
                    cadFuncionario.Email = tbxEmail.Text;
                    cadFuncionario.Cpf = tbxCpf.Text;
                    cadFuncionario.Endereco = tbxEndereco.Text;
                    if (cadFuncionario.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O Funcionario {cadFuncionario.Nome} foi cadastrado com sucesso!");
                        tbxNome.Clear();
                        tbxEmail.Clear();
                        tbxCpf.Clear();
                        tbxEndereco.Clear();
                        ConfiguraDgv();
                    }
                    else
                    {
                        MessageBox.Show("Não foi posível cadastrar esse funcionario!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencha todos os campos corretamente!! ");
                    tbxNome.Clear();
                    tbxEmail.Clear();
                    tbxCpf.Clear();
                    tbxEndereco.Clear();
                    tbxNome.Focus();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar funcionario: " + ex.Message);
            }
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            verificaStatusBancoDados();
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;

        }

        private void verificaStatusBancoDados()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.meuServidor);
                MySqlConexaoBanco.Open();
                MySqlConexaoBanco.Close();
                lblStatusServidorDados.Text = "Status Banco de dados: Conectado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Banco de dados Erro: " + ex.Message);
                lblStatusServidorDados.Text = "Status Banco de dados: Falha na conexão";
                btnCadastrar.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerVerificaConexaoDb_Tick(object sender, EventArgs e)
        {
            verificaStatusBancoDados();
            ConfiguraDgv();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tbxCpf.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Cpf = tbxCpf.Text;


                    MySqlDataReader reader = cadFuncionarios.localizarFuncionario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblId.Text = reader["id"].ToString();
                            tbxNome.Text = reader["nome"].ToString();
                            tbxCpf.Text = reader["cpf"].ToString();
                            tbxEmail.Text = reader["email"].ToString();
                            tbxEndereco.Text = reader["endereco"].ToString();
                            btnAtualizar.Enabled = true;
                            btnDeletar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Funcinario não encontrado! 1");
                            tbxNome.Clear();
                            tbxEmail.Clear();
                            tbxCpf.Clear();
                            tbxEndereco.Clear();
                            tbxCpf.Focus();
                            lblId.Text = "";
                            btnAtualizar.Enabled = false;
                            btnDeletar.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcinario não encontrado! 2");
                        tbxNome.Clear();
                        tbxEmail.Clear();
                        tbxCpf.Clear();
                        tbxEndereco.Clear();
                        tbxCpf.Focus();
                        lblId.Text = "";
                        btnAtualizar.Enabled = false;
                        btnDeletar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Favor Preencher o campo cpf");
                    tbxNome.Clear();
                    tbxEmail.Clear();
                    tbxCpf.Clear();
                    tbxEndereco.Clear();
                    tbxCpf.Focus();
                    lblId.Text = "";
                    btnAtualizar.Enabled = false;
                    btnDeletar.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao encotrar funcionario: " + ex.Message);
                btnAtualizar.Enabled = false;
                btnDeletar.Enabled = false;
            }
        }

        private void btnLimapar_Click(object sender, EventArgs e)
        {
            tbxNome.Clear();
            tbxEmail.Clear();
            tbxCpf.Clear();
            tbxEndereco.Clear();
            lblId.Text = "";
            tbxNome.Focus();
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCadastrar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
            try
            {
                if (!textBoxVazias())
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Email = tbxEmail.Text;
                    cadFuncionarios.Endereco = tbxEndereco.Text;
                    cadFuncionarios.Id = Convert.ToInt32(lblId.Text);
                    if (cadFuncionarios.atualizarFuncionario())
                    {
                        MessageBox.Show("Dados Atualizados com sucesso");
                        tbxNome.Clear();
                        tbxEmail.Clear();
                        tbxCpf.Clear();
                        tbxEndereco.Clear();
                        lblId.Text = "";
                        tbxNome.Focus();
                        ConfiguraDgv();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel atualizar as informações do Funcionario: " + tbxNome.Text);
                        tbxNome.Clear();
                        tbxEmail.Clear();
                        tbxCpf.Clear();
                        tbxEndereco.Clear();
                        lblId.Text = "";
                        tbxCpf.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Favor Localizar o funcionario que deseja atulizar as informações ");
                    tbxCpf.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao atualizar funcionario: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try 
            {                
                if (!textBoxVazias())
                {
                    // Exibe uma caixa de mensagem de confirmação
                    DialogResult resultado = MessageBox.Show("Atenção voce esta prestes a apagar esse funcionario, tem certeza que deseja fazer isso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verifica o resultado da caixa de mensagem
                    if (resultado == DialogResult.Yes)
                    {
                        // Aqui você pode colocar o código a ser executado se o usuário escolher "SIM".
                        cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                        cadFuncionarios.Id = Convert.ToInt32(lblId.Text);
                        if (cadFuncionarios.apagaFuncionario())
                        {
                            MessageBox.Show("Dados Deletados com sucesso! ");
                            tbxNome.Clear();
                            tbxEmail.Clear();
                            tbxCpf.Clear();
                            tbxEndereco.Clear();
                            lblId.Text = "";
                            tbxNome.Focus();
                            ConfiguraDgv();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel deletar as informações do Funcionario: " + tbxNome.Text);
                            tbxNome.Clear();
                            tbxEmail.Clear();
                            tbxCpf.Clear();
                            tbxEndereco.Clear();
                            lblId.Text = "";
                            tbxCpf.Focus();
                        }
                    }
                    else
                    {
                        // Aqui você pode colocar o código a ser executado se o usuário escolher "NÃO" ou fechar a caixa de mensagem.
                        MessageBox.Show("Operação cancelada");
                    }
                }
                else
                {
                    MessageBox.Show("Favor Localizar o funcionario que deseja atulizar as informações ");
                    tbxCpf.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao atualizar funcionario: " + ex.Message);
            }
}
    }
}
