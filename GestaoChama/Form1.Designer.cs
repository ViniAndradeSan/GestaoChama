namespace GestaoChama
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
            tabControl1 = new TabControl();
            tabClientes = new TabPage();
            listBox2 = new ListBox();
            btnCadastrarCliente = new Button();
            txtContatoCliente = new TextBox();
            label2 = new Label();
            txtNomeCliente = new TextBox();
            label1 = new Label();
            tabAtendentes = new TabPage();
            listBoxAtendentes = new ListBox();
            btnCadastrarAtendente = new Button();
            txtSetorAtendente = new TextBox();
            label4 = new Label();
            txtNomeAtendente = new TextBox();
            label3 = new Label();
            tabChamados = new TabPage();
            button2 = new Button();
            comboBox3 = new ComboBox();
            label8 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label9 = new Label();
            comboBox4 = new ComboBox();
            tabControl1.SuspendLayout();
            tabClientes.SuspendLayout();
            tabAtendentes.SuspendLayout();
            tabChamados.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabClientes);
            tabControl1.Controls.Add(tabAtendentes);
            tabControl1.Controls.Add(tabChamados);
            tabControl1.Location = new Point(-6, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(810, 459);
            tabControl1.TabIndex = 0;
            // 
            // tabClientes
            // 
            tabClientes.Controls.Add(listBox2);
            tabClientes.Controls.Add(btnCadastrarCliente);
            tabClientes.Controls.Add(txtContatoCliente);
            tabClientes.Controls.Add(label2);
            tabClientes.Controls.Add(txtNomeCliente);
            tabClientes.Controls.Add(label1);
            tabClientes.Location = new Point(4, 29);
            tabClientes.Name = "tabClientes";
            tabClientes.Size = new Size(802, 426);
            tabClientes.TabIndex = 0;
            tabClientes.Text = "Clientes";
            tabClientes.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(283, 23);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(507, 384);
            listBox2.TabIndex = 5;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(93, 143);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(94, 29);
            btnCadastrarCliente.TabIndex = 4;
            btnCadastrarCliente.Text = "Cadastrar";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += button1_Click;
            // 
            // txtContatoCliente
            // 
            txtContatoCliente.Location = new Point(105, 79);
            txtContatoCliente.Name = "txtContatoCliente";
            txtContatoCliente.Size = new Size(125, 27);
            txtContatoCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 86);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Contato";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(93, 23);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(137, 27);
            txtNomeCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // tabAtendentes
            // 
            tabAtendentes.Controls.Add(listBoxAtendentes);
            tabAtendentes.Controls.Add(btnCadastrarAtendente);
            tabAtendentes.Controls.Add(txtSetorAtendente);
            tabAtendentes.Controls.Add(label4);
            tabAtendentes.Controls.Add(txtNomeAtendente);
            tabAtendentes.Controls.Add(label3);
            tabAtendentes.Location = new Point(4, 29);
            tabAtendentes.Name = "tabAtendentes";
            tabAtendentes.Size = new Size(802, 426);
            tabAtendentes.TabIndex = 0;
            tabAtendentes.Text = "Atendentes";
            tabAtendentes.UseVisualStyleBackColor = true;
            // 
            // listBoxAtendentes
            // 
            listBoxAtendentes.FormattingEnabled = true;
            listBoxAtendentes.Location = new Point(265, 16);
            listBoxAtendentes.Name = "listBoxAtendentes";
            listBoxAtendentes.Size = new Size(525, 384);
            listBoxAtendentes.TabIndex = 5;
            // 
            // btnCadastrarAtendente
            // 
            btnCadastrarAtendente.Location = new Point(91, 141);
            btnCadastrarAtendente.Name = "btnCadastrarAtendente";
            btnCadastrarAtendente.Size = new Size(94, 29);
            btnCadastrarAtendente.TabIndex = 4;
            btnCadastrarAtendente.Text = "Cadastrar";
            btnCadastrarAtendente.UseVisualStyleBackColor = true;
            btnCadastrarAtendente.Click += btnCadastrarAtendente_Click;
            // 
            // txtSetorAtendente
            // 
            txtSetorAtendente.Location = new Point(91, 64);
            txtSetorAtendente.Name = "txtSetorAtendente";
            txtSetorAtendente.Size = new Size(125, 27);
            txtSetorAtendente.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 71);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 2;
            label4.Text = "Setor";
            // 
            // txtNomeAtendente
            // 
            txtNomeAtendente.Location = new Point(91, 16);
            txtNomeAtendente.Name = "txtNomeAtendente";
            txtNomeAtendente.Size = new Size(125, 27);
            txtNomeAtendente.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 23);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Nome";
            // 
            // tabChamados
            // 
            tabChamados.Controls.Add(comboBox4);
            tabChamados.Controls.Add(label9);
            tabChamados.Controls.Add(button2);
            tabChamados.Controls.Add(comboBox3);
            tabChamados.Controls.Add(label8);
            tabChamados.Controls.Add(listBox1);
            tabChamados.Controls.Add(button1);
            tabChamados.Controls.Add(textBox1);
            tabChamados.Controls.Add(label7);
            tabChamados.Controls.Add(comboBox2);
            tabChamados.Controls.Add(label6);
            tabChamados.Controls.Add(comboBox1);
            tabChamados.Controls.Add(label5);
            tabChamados.Location = new Point(4, 29);
            tabChamados.Name = "tabChamados";
            tabChamados.Size = new Size(802, 426);
            tabChamados.TabIndex = 0;
            tabChamados.Text = "Chamados";
            tabChamados.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(141, 282);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnAlterarStatus_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(130, 161);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(129, 28);
            comboBox3.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 164);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 8;
            label8.Text = "Alterar status";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(312, 14);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(461, 384);
            listBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(24, 282);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Abrir chamado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 59);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 4;
            label7.Text = "Descrição";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(108, 104);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 112);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 2;
            label6.Text = "Atendente";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 28);
            comboBox1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 17);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 0;
            label5.Text = "Cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 223);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 11;
            label9.Text = "Prioridade:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(108, 215);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabClientes.ResumeLayout(false);
            tabClientes.PerformLayout();
            tabAtendentes.ResumeLayout(false);
            tabAtendentes.PerformLayout();
            tabChamados.ResumeLayout(false);
            tabChamados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabClientes;
        private Button btnCadastrarCliente;
        private TextBox txtContatoCliente;
        private Label label2;
        private TextBox txtNomeCliente;
        private Label label1;
        private TabPage tabAtendentes;
        private TabPage tabChamados;
        private CheckedListBox listBoxClientes;
        private TextBox textBox2;
        private Label label4;
        private TextBox txtNomeAtendente;
        private Label label3;
        private TextBox txtSetorAtendente;
        private Button btnCadastrarAtendente;
        private ListBox listBoxAtendentes;
        private ListBox listBox2;
        private Button button2;
        private ComboBox comboBox3;
        private Label label8;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label7;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox4;
        private Label label9;
    }
}
