using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TelaLogin : Form
    {
        estadualEntities bd = new estadualEntities();
        public static representante usuario;
        public static string senhaCriptografada;
        public static string senhaDescriptografada;
        public static string caminhoFoto;
        public static representante logado;
        public static bool registrado = false;
        public TelaLogin()
        {
            InitializeComponent();
            btnSair.Click += sair;
            btnEntrar.Click += entrar;
            btnEntrar.Enabled = false;
            lblStatusSenha.Visible = false;
            lblStatusEmail.Visible = false;
            lblStatusCredenciais.Visible = false;
        }


        private string criptografar(object sender, EventArgs e)
        {
            StringBuilder senha = new StringBuilder();
            MD5 md5 = MD5.Create();
            byte[] entrada = Encoding.ASCII.GetBytes(txtSenha.Text);
            byte[] hash = md5.ComputeHash(entrada);
            for (int i = 0; i < hash.Length; i++)
            {
                senha.Append(hash[i].ToString("X2"));
            }
            senhaCriptografada = senha.ToString();
            return senhaCriptografada;
        }

        private void entrar(object sender, EventArgs e)
        {
            senhaDescriptografada = txtSenha.Text;
            criptografar(sender, e);
            logado = bd.representantes.Where(u => u.email.Equals(txtEmail.Text) && u.senha.Equals(senhaCriptografada)).FirstOrDefault();
            lblStatusSenha.Visible = true;
            lblStatusSenha.Text = "";
            lblStatusEmail.Visible = true;
            lblStatusEmail.Text = "";

            if (!string.IsNullOrEmpty(txtSenha.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                if (logado != null)
                {
                    new TelaSplash(usuario, senhaDescriptografada).Show();
                    this.Hide();
                }
                else
                {
                    if (registrado == false)
                    {
                        lblStatusCredenciais.Visible = true;
                        lblStatusCredenciais.Text = "Atenção: Representante não cadastrado";
                    }
                    else if (!senhaCriptografada.Equals(usuario.senha) && !string.IsNullOrEmpty(senhaCriptografada))
                    {
                        lblStatusCredenciais.Visible = true;
                        lblStatusCredenciais.Text = "Senha incorreta";
                    }
                }
            }
        }

        private void sair(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void desenhaImagem()
        {
            byte[] content = File.ReadAllBytes(caminhoFoto);
            MemoryStream ms = new MemoryStream(content);
            pictureBoxRedonda1.Image = Image.FromStream(ms);
        }


        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            registrado = false;
            caminhoFoto = @"C:\Users\Hiago Campregher\Desktop\project\Project\IMAGEM\usuario.png";
            desenhaImagem();
            lblStatusEmail.Visible = false;
            Regex validaEmail = new Regex("^([a-zA_]+)([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
            + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
            + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$");

            if (!validaEmail.IsMatch(txtEmail.Text))
            {
                btnEntrar.Enabled = false;
            }
            else
            {
                btnEntrar.Enabled = true;
                bd.representantes.ToList().ForEach(u =>
                {
                    if (u.email.Equals(txtEmail.Text))
                    {
                        usuario = u;
                        registrado = true;
                    }
                });
                if (registrado)
                {
                    caminhoFoto = usuario.imagem;
                    desenhaImagem();
                }
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                entrar(sender, e);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            lblStatusEmail.Visible = false;
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblStatusEmail.Text = "Atenção: informe seu E-mail";
                lblStatusEmail.Visible = true;
                btnEntrar.Enabled = false;
            }
        }

        private void txtSenha_Validating(object sender, CancelEventArgs e)
        {
            lblStatusSenha.Visible = false;
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                lblStatusSenha.Text = "Atenção: informe sua senha";
                lblStatusSenha.Visible = true;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            lblStatusSenha.Visible = false;
        }
    }
}
