using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtID.Clear();
            txtProduto.Clear();
            txtPreco.Clear();
            txtQntd.Clear();
            txtID.Focus();
        }
        private void btnAdc_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("ID Não pode ser vazio, por favor preencher o ID");
                txtID.Focus();
                return;
            }
        if (txtProduto.Text == "")
            {
                MessageBox.Show("PRODUTO Não pode ser vazio, por favor preencher o PRODUTO");
                txtProduto.Focus();
                return;
            }
        if (txtQntd.Text == "")
            {
                MessageBox.Show("QUANTIDADE Não pode ser vazio, por favor preencher o QUANTIDADE");
                txtQntd.Focus();
                return;
            }
        if (txtPreco.Text == "")
            {
                MessageBox.Show("PREÇO Não pode ser vazio, por favor preencher o PREÇO");
                txtPreco.Focus();
                return;
            }
       
            string[] produtos = new string[4];
            produtos[0] = txtID.Text;
            produtos[1] = txtProduto.Text;
            produtos[2] = txtQntd.Text;
            produtos[3] = txtPreco.Text;

            ListViewItem L = new ListViewItem(produtos);
           listView1.Items.Add(L);
            limpar();
 }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        }
    }
}
