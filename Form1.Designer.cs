namespace TechStoch_TrabalhoDb
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
            dgvProdutos = new DataGridView();
            btnSalvar = new Button();
            txtNome = new TextBox();
            txtCategoria = new TextBox();
            txtPreco = new TextBox();
            btnExcluir = new Button();
            button1 = new Button();
            Preço = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEstoque = new TextBox();
            txtBusca = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbFornecedores = new ComboBox();
            btnVerTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(26, 51);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 62;
            dgvProdutos.Size = new Size(1336, 320);
            dgvProdutos.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(26, 711);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(230, 34);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar Produto";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(26, 431);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(230, 31);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(26, 502);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(230, 31);
            txtCategoria.TabIndex = 3;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(26, 574);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(230, 31);
            txtPreco.TabIndex = 4;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(656, 808);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(161, 34);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir Produto";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(26, 772);
            button1.Name = "button1";
            button1.Size = new Size(230, 34);
            button1.TabIndex = 6;
            button1.Text = "Atualizar Produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // Preço
            // 
            Preço.AutoSize = true;
            Preço.Location = new Point(26, 546);
            Preço.Name = "Preço";
            Preço.Size = new Size(56, 25);
            Preço.TabIndex = 7;
            Preço.Text = "Preço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 403);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 8;
            label1.Text = "Nome Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 474);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 9;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 608);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 10;
            label3.Text = "Estoque";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(26, 636);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(230, 31);
            txtEstoque.TabIndex = 11;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(1079, 431);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(256, 31);
            txtBusca.TabIndex = 12;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1079, 403);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 13;
            label4.Text = "Buscar por Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(558, 9);
            label5.Name = "label5";
            label5.Size = new Size(383, 25);
            label5.TabIndex = 14;
            label5.Text = "Sistema de cadastro de produtos da TechStock";
            // 
            // cmbFornecedores
            // 
            cmbFornecedores.FormattingEnabled = true;
            cmbFornecedores.Location = new Point(26, 6);
            cmbFornecedores.Name = "cmbFornecedores";
            cmbFornecedores.Size = new Size(182, 33);
            cmbFornecedores.TabIndex = 15;
            cmbFornecedores.SelectedIndexChanged += cmbFornecedores_SelectedIndexChanged;
            // 
            // btnVerTodos
            // 
            btnVerTodos.Location = new Point(1079, 537);
            btnVerTodos.Name = "btnVerTodos";
            btnVerTodos.Size = new Size(256, 34);
            btnVerTodos.TabIndex = 17;
            btnVerTodos.Text = "Ver todo estoque";
            btnVerTodos.UseVisualStyleBackColor = true;
            btnVerTodos.Click += btnVerTodos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 876);
            Controls.Add(btnVerTodos);
            Controls.Add(cmbFornecedores);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBusca);
            Controls.Add(txtEstoque);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Preço);
            Controls.Add(button1);
            Controls.Add(btnExcluir);
            Controls.Add(txtPreco);
            Controls.Add(txtCategoria);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Controls.Add(dgvProdutos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProdutos;
        private Button btnSalvar;
        private TextBox txtNome;
        private TextBox txtCategoria;
        private TextBox txtPreco;
        private Button btnExcluir;
        private Button button1;
        private Label Preço;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEstoque;
        private TextBox txtBusca;
        private Label label4;
        private Label label5;
        private ComboBox cmbFornecedores;
        private Button btnVerTodos;
    }
}
