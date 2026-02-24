using Microsoft.Data.Sqlite;
using System.Data;

public class Database
{
    
    private string connectionString = "Data Source=TechStock.db";

    public void SalvarProduto(string nome, string categoria, double preco, int estoque, int idFornecedor)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            
            string sql = "INSERT INTO Produtos (nome, categoria, preco_venda, qtd_estoque, id_fornecedor) VALUES (@nome, @categoria, @preco, @estoque, @idFornecedor)";

            using (var command = new SqliteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@categoria", categoria);
                command.Parameters.AddWithValue("@preco", preco);
                command.Parameters.AddWithValue("@estoque", estoque);
                command.Parameters.AddWithValue("@idFornecedor", idFornecedor);
                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable ListarProdutos()
    {
        DataTable dt = new DataTable();
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            
            string sql = "SELECT id_produto as 'ID', nome as 'Nome da Peça', categoria as 'Categoria', preco_venda as 'Preço (R$)', qtd_estoque as 'Estoque' FROM Produtos";
            using (var command = new SqliteCommand(sql, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
        }
        return dt;
    }

    
    public void AtualizarProduto(int id, string nome, string categoria, double preco)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string sql = "UPDATE Produtos SET nome = @nome, categoria = @categoria, preco_venda = @preco WHERE id_produto = @id";

            using (var command = new SqliteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@categoria", categoria);
                command.Parameters.AddWithValue("@preco", preco);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }

    
    public void ExcluirProduto(int id)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string sql = "DELETE FROM Produtos WHERE id_produto = @id";

            using (var command = new SqliteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable FiltrarProdutos(string termo)
    {
        DataTable dt = new DataTable();
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            string sql = "SELECT * FROM Produtos WHERE nome LIKE @termo";

            using (var command = new SqliteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@termo", "%" + termo + "%");
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
        }
        return dt;
    }

    public DataTable ListarFornecedores()
    {
        DataTable dt = new DataTable();
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT id_fornecedor, nome FROM Fornecedores";
            using (var command = new SqliteCommand(sql, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
        }
        return dt;
    }

    public DataTable FiltrarPorFornecedor(int idFornecedor)
    {
        DataTable dt = new DataTable();
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();


            string sql = @"SELECT 
                        id_produto AS 'ID', 
                        nome AS 'Produto', 
                        categoria AS 'Categoria', 
                        preco_venda AS 'Preço',
                        qtd_estoque AS 'Estoque',
                        id_fornecedor AS 'Fornecedor'
                       FROM Produtos 
                       WHERE id_fornecedor = @id";

            using (var command = new SqliteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", idFornecedor);
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
        }
        return dt;
    }


}