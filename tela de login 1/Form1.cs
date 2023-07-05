using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tela_de_login_1
{
    public partial class Form1 : Form
    {
        private List<Usuario> usuarios;

        public Form1()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();


            usuarios.Add(new Usuario("lucas@gmail.com", "150804"));
            usuarios.Add(new Usuario("bruno@gmail.com", "98765"));
            usuarios.Add(new Usuario("vitor@gmail.com","246810"));
            usuarios.Add(new Usuario("matheus@gmail.com", "147258"));
            usuarios.Add(new Usuario("thiago@gmail.com", "789456"));
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string nomeDeUsuario = TxtCampoEmail.Text;
            string senha = TxtCampoSenha.Text;

            if (ValidarCredenciais(nomeDeUsuario, senha))
            {
                MessageBox.Show("Login bem-sucedido!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("email ou senha incorretos!");
            }
        }

        private bool ValidarCredenciais(string nomeDeUsuario, string senha)
        {
            return usuarios.Any(u => u.NomeDeUsuario == nomeDeUsuario && u.Senha == senha);
        }

        private void LimparCampos()
        {
            TxtCampoEmail.Text = string.Empty;
            TxtCampoSenha.Text = string.Empty;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Usuario
    {
        public string NomeDeUsuario { get; set; }
        public string Senha { get; set; }

        public Usuario(string nomeDeUsuario, string senha)
        {
            NomeDeUsuario = nomeDeUsuario;
            Senha = senha;
        }
    }
}