using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace StoredProcedureSqlServerCCharp
{
    public partial class Form1 : Form
    {
        DataGridViewRow _Row;
        SqlCommand cmd;

        SqlConnection con = new SqlConnection();
        private SqlDataAdapter adapt;

        public int ID { get; set; }
        public object DataAdmissao { get; private set; }

        public Form1()
        {
            InitializeComponent();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            var funcionario = new Funcionario();
            dataGridView1.DataSource = funcionario.Buscar(txtBUSCAR.Text);
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_Row != dataGridView1.CurrentRow)
                MostrarFuncionario();
        }

        public void MostrarFuncionario()
        {
            txtNome.Text = dataGridView1.CurrentRow.Cells["Nome"].Value?.ToString();
            mskCPF.Text = dataGridView1.CurrentRow.Cells["CPF"].Value?.ToString();
            txtEndereco.Text = dataGridView1.CurrentRow.Cells["Endereco"].Value?.ToString();
            mskTelefone.Text = dataGridView1.CurrentRow.Cells["Telefone"].Value?.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value?.ToString();
            txtConjuge.Text = dataGridView1.CurrentRow.Cells["Conjuge"].Value?.ToString();
            txtFilhos.Text = dataGridView1.CurrentRow.Cells["Filhos"].Value?.ToString();
            mskDataAdmissao.Text = dataGridView1.CurrentRow.Cells["DataAdmissao"].Value?.ToString();
            txtEstadoCivil.Text = dataGridView1.CurrentRow.Cells["EstadoCivil"].Value?.ToString();
            _Row = dataGridView1.CurrentRow;
        }

        private void btnNOVO_Click(object sender, EventArgs e)
        {
            LimparForm();
            txtBUSCAR.Focus();
        }

        public void LimparForm()
        {
            mskCPF.Clear();
            txtBUSCAR.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtConjuge.Clear();
            txtFilhos.Clear();
            mskDataAdmissao.Clear();
            txtEstadoCivil.Clear();
            txtBUSCAR.Focus();
        }


        public void btnEXCLUIR_Click(object sender, EventArgs e)
        {
            // Verifique se alguma linha está selecionada no DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Obtém o valor da coluna ID da linha selecionada
                int ID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                if (MessageBox.Show("Deseja excluir este funcionário?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection("Data Source=CARLOS\\SQLEXPRESS;Initial Catalog=CrudFuncionario;Integrated Security=True"))
                    {
                        con.Open();

                        using (SqlCommand command = new SqlCommand("pr_ExcluirFuncionario", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@ID", ID);

                            try
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("Funcionário excluído com sucesso!");
                                LimparDados();
                                ExibirDados();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao excluir funcionário: " + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário na lista antes de excluir.");
            }
        }
        public void ExibirDados()
        {
            using (SqlConnection con = new SqlConnection("Data Source=CARLOS\\SQLEXPRESS;Initial Catalog=CrudFuncionario;Integrated Security=True"))
            {
                con.Open();

                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Funcionario", con);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados dos funcionários: " + ex.Message);
                }
            }
            // A conexão será fechada automaticamente quando sair deste bloco usando "using".
        }
        private void LimparDados()
        {
            mskCPF.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskTelefone.Text = "";
            txtEmail.Text = "";
            txtConjuge.Text = "";
            txtFilhos.Text = "";
            mskDataAdmissao.Text = "";
            txtEstadoCivil.Text = "";
        }


        // Evento de clique na grade dgvAgenda (para carregar dados nos campos)
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                mskCPF.Text = selectedRow.Cells["CampoCPFNomeDaTabela"].Value.ToString();
                txtNome.Text = selectedRow.Cells["CampoNomeNaTabela"].Value.ToString();
                txtEndereco.Text = selectedRow.Cells["CampoEnderecoNaTabela"].Value.ToString();
                mskTelefone.Text = selectedRow.Cells["CampoTelefoneNaTabela"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["CampoEmailNaTabela"].Value.ToString();
                txtConjuge.Text = selectedRow.Cells["CampoConjugeNaTabela"].Value.ToString();
                txtFilhos.Text = selectedRow.Cells["CampoFilhosNaTabela"].Value.ToString();
                mskDataAdmissao.Text = selectedRow.Cells["CampoDataAdmissaoNaTabela"].Value.ToString();
                txtEstadoCivil.Text = selectedRow.Cells["CampoEstadoCivilNaTabela"].Value.ToString();
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém o valor da coluna "ID" da linha selecionada
                ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            }
            else
            {
                ID = -1; // Define ID como -1 se nenhuma linha estiver selecionada.
            }

            MostrarFuncionario();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Programa CRUD Agora?",
                "FUNCIONÁRIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtNome.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source=CARLOS\\SQLEXPRESS;Initial Catalog=CrudFuncionario;Integrated Security=True";

            string Nome = txtNome.Text;
            string CPF = mskCPF.Text;
            string Endereco = txtEndereco.Text;
            string Email = txtEmail.Text;
            string Conjuge = txtConjuge.Text;
            string EstadoCivil = txtEstadoCivil.Text;
            string DataAdmissao = mskDataAdmissao.Text;
            string Telefone = mskTelefone.Text;
            int Filhos = 0; // Defina zero como valor padrão

            // Verifique se o campo "Filhos" não está vazio
            if (!string.IsNullOrEmpty(txtFilhos.Text))
            {
                if (int.TryParse(txtFilhos.Text, out Filhos))
                {
                    // A conversão foi bem-sucedida, e o valor está em 'Filhos'
                }
                else
                {
                    // Tratar o caso em que a conversão falhou, por exemplo, exibir uma mensagem de erro ao usuário.
                    MessageBox.Show("O valor em txtFilhos não é um número inteiro válido.");
                    return; // Sai do método para evitar continuar com dados inválidos
                }
            }

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand command = new SqlCommand("pr_SalvarFuncionario", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Nome", Nome);
                        command.Parameters.AddWithValue("@CPF", CPF);
                        command.Parameters.AddWithValue("@Endereco", Endereco);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Conjuge", Conjuge);
                        command.Parameters.AddWithValue("@Filhos", Filhos);
                        command.Parameters.AddWithValue("@DataAdmissao", DataAdmissao);
                        command.Parameters.AddWithValue("@Telefone", Telefone);
                        command.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);

                        connection.Open();
                        string result = (string)command.ExecuteScalar();

                        if (result == "CPF cadastrado já na base")
                        {
                            MessageBox.Show("CPF já cadastrado na base de dados. Não é possível salvar o mesmo CPF novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (result == "Funcionário salvo com sucesso")
                        {
                            MessageBox.Show("Funcionário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro desconhecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Salvar o funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private bool CPFJaCadastrado(string cpf, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Funcionario WHERE CPF = @CPF", connection))
                {
                    command.Parameters.AddWithValue("@CPF", cpf);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private bool CPFExiste(string cpf, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT 1 FROM Funcionario WHERE CPF = @CPF", connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@CPF", cpf);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Verifique se alguma linha está selecionada no DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Obtém o valor da coluna ID da linha selecionada
                int ID = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Preencha os campos com os novos valores, você pode usar os controles apropriados
                string Nome = txtNome.Text;
                string Endereco = txtEndereco.Text;
                string Email = txtEmail.Text;
                string Conjuge = txtConjuge.Text;
                string EstadoCivil = txtEstadoCivil.Text;
                string DataAdmissao = mskDataAdmissao.Text;
                string Telefone = mskTelefone.Text;
                int Filhos = 0;

                // Verifique se o campo "Filhos" não está vazio
                if (!string.IsNullOrEmpty(txtFilhos.Text))
                {
                    if (int.TryParse(txtFilhos.Text, out Filhos))
                    {
                        // A conversão foi bem-sucedida, e o valor está em 'novoFilhos'
                    }
                    else
                    {
                        // Tratar o caso em que a conversão falhou, por exemplo, exibir uma mensagem de erro ao usuário.
                        MessageBox.Show("O valor em txtNovoFilhos não é um número inteiro válido.");
                        return; // Sai do método para evitar continuar com dados inválidos
                    }
                }

                using (SqlConnection con = new SqlConnection("Data Source=CARLOS\\SQLEXPRESS;Initial Catalog=CrudFuncionario;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand("pr_AtualizarFuncionario", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Nome", Nome);
                        command.Parameters.AddWithValue("@Endereco", Endereco);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Conjuge", Conjuge);
                        command.Parameters.AddWithValue("@Filhos", Filhos);
                        command.Parameters.AddWithValue("@DataAdmissao", DataAdmissao);
                        command.Parameters.AddWithValue("@Telefone", Telefone);
                        command.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Funcionário atualizado com sucesso!");
                            LimparDados();
                            ExibirDados();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao atualizar funcionário: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário na lista antes de atualizar.");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBUSCAR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
