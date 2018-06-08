using AgendadeContatos.DAO;
using AgendadeContatos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendadeContatos
{
    public partial class FrmContato : Form
    {
        public FrmContato()
        {
            InitializeComponent();
        }
        Contato contato = new Contato();
        ContatoDAO contatoDAO = new ContatoDAO();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbData_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void mskDtNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            contato.Nome = txtNome.Text;
            contato.Endereco = txtEndereco.Text;
            contato.Bairro = txtBairro.Text;
            contato.Cidade = int.Parse(cbCidade.SelectedValue.ToString());
            contato.Telefone = mskTelefone.Text;
            contato.Celular = mskCelular.Text;
            contato.Email = txtEmail.Text;
            if (rbMasculino.Checked)
            {
                contato.Sexo = 'M';
            }
            else
            {
                contato.Sexo = 'F';
            }
            contato.Data_nasc = DateTime.Parse(mskDtNasc.Text);
            contato.Obs = txtObservacao.Text;
            contatoDAO.Inserir(contato);
        }

        private void FrmContato_Load(object sender, EventArgs e)
        {
            cbCidade.DataSource = contatoDAO.PreencheComboCidade();
            cbCidade.DisplayMember = "Nome";
            cbCidade.ValueMember = "Codigo_Cidade";
        }
    }
}
