using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProvaDS
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {   //add conteudo no GridView
            double total = double.Parse(lblTotalVendA.Text);
            int qtd = int.Parse(txtQuantidade.Text);
            double valor = double.Parse(txtUnitario.Text);
            dataGridView.Rows.Add(txtProduto.Text, txtQuantidade.Text, txtUnitario.Text);

            //Limpar caixas de texto
            txtProduto.Clear();
            txtQuantidade.Clear();
            txtUnitario.Clear();

            total += valor * qtd;
            lblTotalVendA.Text = total.ToString();

            //EXIBIR MENSAGEM DE INCLUSÃO COM SUCESSO
            MessageBox.Show("Produto Cadastrado com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //Mostrar total de vendas
            lblVenda.Text = dataGridView.RowCount.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Verificar se linha é existente no grid
            if (dataGridView.Rows.Count > 0)
            {
                double antigo = double.Parse(dataGridView.CurrentRow.Cells[1].Value.ToString()) * double.Parse(dataGridView.CurrentRow.Cells[2].Value.ToString());
                double total = double.Parse(lblTotalVendA.Text);
                lblTotalVendA.Text = (total - antigo).ToString();
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);

            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica a exisencia de linhas no GridView
            if (dataGridView.RowCount > 0)
            {
                //Move o conteúdo da primeira célula da linha selecionada para a caixa de texto
                txtAlterar.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlterar.Text != "")
            {
                double novo = double.Parse(dataGridView.CurrentRow.Cells[1].Value.ToString()) * double.Parse(dataGridView.CurrentRow.Cells[2].Value.ToString());
                dataGridView.CurrentRow.Cells[1].Value = txtAlterar.Text;
                double antigo = double.Parse(dataGridView.CurrentRow.Cells[1].Value.ToString()) * double.Parse(dataGridView.CurrentRow.Cells[2].Value.ToString());

                double total = double.Parse(lblTotalVendA.Text);
                lblTotalVendA.Text = ((total - novo) + antigo).ToString();

                dataGridView.CurrentRow.Cells[1].Value = txtAlterar.Text;

                

                //Exibe mensagem de alteração com sucesso
                MessageBox.Show("Produto alterado com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void bttnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount > 0)
            {
                dataGridView.Rows.Clear();
                lblVenda.Text = "";
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {   
            

            if (dataGridView.RowCount > 0)
            {
                dataGridView.Rows.Clear();
                lblTotalVendA.Text = "";
            }
        }
    }
}
