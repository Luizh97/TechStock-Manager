namespace TechStoch_TrabalhoDb
{
    public partial class Form1 : Form
    {
        
        Database db = new Database();

        public Form1()
        {
            
            InitializeComponent();
           
            AtualizarComboBox();
            AtualizarGrid();
            dgvProdutos.ReadOnly = true;
            cmbFornecedores.DataSource = db.ListarFornecedores();
            cmbFornecedores.DisplayMember = "nome"; 
            cmbFornecedores.ValueMember = "id_fornecedor";
        }

        
        private void AtualizarGrid()
        {
            int idFornAtual = Convert.ToInt32(cmbFornecedores.SelectedValue);
            dgvProdutos.DataSource = db.FiltrarPorFornecedor(idFornAtual);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string categoria = txtCategoria.Text;
                double preco = double.Parse(txtPreco.Text);
                int estoque = int.Parse(txtEstoque.Text);
                int idFornecedor = Convert.ToInt32(cmbFornecedores.SelectedValue);

                db.SalvarProduto(nome, categoria, preco, estoque, idFornecedor);
                MessageBox.Show("Produto cadastrado com sucesso!");

                AtualizarGrid();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.CurrentRow != null)
                {
                    
                    int idSelecionado = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["ID"].Value);

                    DialogResult confirma = MessageBox.Show("Deseja mesmo excluir este item?", "Atenção", MessageBoxButtons.YesNo);

                    if (confirma == DialogResult.Yes)
                    {
                        db.ExcluirProduto(idSelecionado);
                        MessageBox.Show("Produto apagado com sucesso!");

                        
                        if (cmbFornecedores.SelectedValue != null)
                        {
                            int idForn = Convert.ToInt32(cmbFornecedores.SelectedValue);
                            
                            dgvProdutos.DataSource = db.FiltrarPorFornecedor(idForn);
                        }
                        else
                        {
                            
                            dgvProdutos.DataSource = db.ListarProdutos();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um produto na tabela primeiro!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["id"].Value);
                    db.AtualizarProduto(id, txtNome.Text, txtCategoria.Text, double.Parse(txtPreco.Text));
                    AtualizarGrid();
                    MessageBox.Show("Alterado com sucesso!");
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            string termo = txtBusca.Text.Trim();

            if (string.IsNullOrEmpty(termo))
            {

                if (cmbFornecedores.SelectedValue != null)
                {
                    int idForn = Convert.ToInt32(cmbFornecedores.SelectedValue);
                    dgvProdutos.DataSource = db.FiltrarPorFornecedor(idForn);
                }
                else
                {
                    dgvProdutos.DataSource = db.ListarProdutos();
                }
            }
            else
            {
      
                dgvProdutos.DataSource = db.FiltrarProdutos(termo);
            }
        }

        private void cmbFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbFornecedores.SelectedValue != null && cmbFornecedores.SelectedValue is int || cmbFornecedores.SelectedValue is long)
                {
                    int idForn = Convert.ToInt32(cmbFornecedores.SelectedValue);
                    dgvProdutos.DataSource = db.FiltrarPorFornecedor(idForn);
                }
            }
            catch { }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = db.ListarProdutos();
        }

        private void AtualizarComboBox()
        {
            cmbFornecedores.DataSource = db.ListarFornecedores();
            cmbFornecedores.DisplayMember = "nome";
            cmbFornecedores.ValueMember = "id_fornecedor";
        }
    }
}