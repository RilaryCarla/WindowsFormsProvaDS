namespace WindowsFormsProvaDS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.vendas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlterar = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalVendA = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.bttnFinalizar = new System.Windows.Forms.Button();
            this.lblVenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendas
            // 
            this.vendas.AutoSize = true;
            this.vendas.Location = new System.Drawing.Point(51, 53);
            this.vendas.Name = "vendas";
            this.vendas.Size = new System.Drawing.Size(38, 13);
            this.vendas.TabIndex = 0;
            this.vendas.Text = "Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Uni.";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(116, 107);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(244, 20);
            this.txtProduto.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(116, 160);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 5;
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(116, 210);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtUnitario.TabIndex = 6;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(255, 158);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(105, 23);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(255, 208);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(105, 23);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.ValorU});
            this.dataGridView.Location = new System.Drawing.Point(36, 256);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(343, 250);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorU
            // 
            this.ValorU.HeaderText = "ValorU";
            this.ValorU.Name = "ValorU";
            this.ValorU.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alterar QTD do item selecionado";
            // 
            // txtAlterar
            // 
            this.txtAlterar.Location = new System.Drawing.Point(199, 529);
            this.txtAlterar.Name = "txtAlterar";
            this.txtAlterar.Size = new System.Drawing.Size(133, 20);
            this.txtAlterar.TabIndex = 11;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(338, 527);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total da Venda";
            // 
            // lblTotalVendA
            // 
            this.lblTotalVendA.AutoSize = true;
            this.lblTotalVendA.Location = new System.Drawing.Point(119, 576);
            this.lblTotalVendA.Name = "lblTotalVendA";
            this.lblTotalVendA.Size = new System.Drawing.Size(13, 13);
            this.lblTotalVendA.TabIndex = 14;
            this.lblTotalVendA.Text = "0";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(154, 571);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(244, 571);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(104, 23);
            this.btnVenda.TabIndex = 16;
            this.btnVenda.Text = "Cancelar Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // bttnFinalizar
            // 
            this.bttnFinalizar.Location = new System.Drawing.Point(368, 571);
            this.bttnFinalizar.Name = "bttnFinalizar";
            this.bttnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.bttnFinalizar.TabIndex = 17;
            this.bttnFinalizar.Text = "Finalizar";
            this.bttnFinalizar.UseVisualStyleBackColor = true;
            this.bttnFinalizar.Click += new System.EventHandler(this.bttnFinalizar_Click);
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Location = new System.Drawing.Point(116, 52);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(13, 13);
            this.lblVenda.TabIndex = 18;
            this.lblVenda.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 643);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.bttnFinalizar);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblTotalVendA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtAlterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtUnitario);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vendas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlterar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalVendA;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button bttnFinalizar;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorU;
    }
}

