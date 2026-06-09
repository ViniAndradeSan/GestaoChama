using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;

namespace GestaoChama
{
    public partial class Form1 : Form
    {
        private List<Cliente> clientes = new List<Cliente>();
        private List<Atendente> atendentes = new List<Atendente>();
        private List<Chamado> chamados = new List<Chamado>();

        public Form1()
        {
            InitializeComponent();

            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox3.Items.Add("Em Andamento");
            comboBox3.Items.Add("Resolvido");
            comboBox4.Items.Add("Urgente");
            comboBox4.Items.Add("Alta");
            comboBox4.Items.Add("Média");
            comboBox4.Items.Add("Baixa");
            comboBox4.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCliente.Text.Trim();
            string contato = txtContatoCliente.Text.Trim();

            if (nome == "" || contato == "")
            {
                MessageBox.Show("Preencha nome e contato.");
                return;
            }

            Cliente cliente = new Cliente(nome, contato);
            clientes.Add(cliente);

            listBox2.DataSource = null;
            listBox2.DataSource = clientes;

            comboBox1.DataSource = null;
            comboBox1.DataSource = new List<Cliente>(clientes);

            txtNomeCliente.Clear();
            txtContatoCliente.Clear();
        }

        private void btnCadastrarAtendente_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAtendente.Text.Trim();
            string setor = txtSetorAtendente.Text.Trim();

            if (nome == "" || setor == "")
            {
                MessageBox.Show("Preencha nome e setor.");
                return;
            }

            Atendente atendente = new Atendente(nome, setor);
            atendentes.Add(atendente);

            listBoxAtendentes.DataSource = null;
            listBoxAtendentes.DataSource = atendentes;

            comboBox2.DataSource = null;
            comboBox2.DataSource = new List<Atendente>(atendentes);

            txtNomeAtendente.Clear();
            txtSetorAtendente.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Selecione um atendente.");
                return;
            }

            string descricao = textBox1.Text.Trim();
            if (descricao.Length < 5)
            {
                MessageBox.Show("A descrição deve ter pelo menos 5 caracteres.");
                return;
            }

            if (comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Selecione a prioridade.");
                return;
            }

            Cliente cliente = (Cliente)comboBox1.SelectedItem;
            Atendente atendente = (Atendente)comboBox2.SelectedItem;
            string prioridade = comboBox4.SelectedItem.ToString();

            Chamado chamado = new Chamado(cliente, atendente, descricao, prioridade);
            chamados.Add(chamado);

            AtualizarListaChamados();

            textBox1.Clear();
        }

        private void btnAlterarStatus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um chamado.");
                return;
            }

            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Selecione um status.");
                return;
            }

            Chamado chamado = (Chamado)listBox1.SelectedItem;

            chamado.Status = comboBox3.SelectedItem.ToString();

            AtualizarListaChamados();
        }

        private void AtualizarListaChamados()
        {
            var ordem = new List<string>
    {
        "Urgente",
        "Alta",
        "Média",
        "Baixa"
    };

            listBox1.DataSource = null;
            listBox1.DataSource = chamados
                .OrderBy(c => ordem.IndexOf(c.Prioridade))
                .ToList();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}