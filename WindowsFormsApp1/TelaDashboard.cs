using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TelaDashboard : Form
    {
        estadualEntities bd = new estadualEntities();
        public representante usuario;
        public static string senhaDescriptografada;
        public static string senhaCriptografada;
        public static string senhaAntiga;
        public List<string> cidades = new List<string>();
        public List<string> paises = new List<string>();
        public List<string> estados = new List<string>();
        public static bool nomeValido = true;
        public static bool telefoneValido = true;
        public static bool celularValido = true;
        public static bool emailValido = true;
        public static bool senhaValido = true;
        public static bool cepValido = true;
        public static bool bairroValido = true;
        public static bool enderecoValido = true;
        public static bool cbxEstadoValido = true;
        public static bool cbxCidadeValido = true;

        public TelaDashboard()
        {
            InitializeComponent();
        }
        public TelaDashboard(representante usuarioLogado, string senhaDescoberta)
        {
            InitializeComponent();
            this.usuario = usuarioLogado;
            senhaDescriptografada = senhaDescoberta;
            desenhaImagem();
        }

        private void desenhaImagem()
        {
            byte[] content = File.ReadAllBytes(usuario.imagem);
            MemoryStream ms = new MemoryStream(content);
            pictureBoxRedonda1.Image = Image.FromStream(ms);
            pictureBoxRedonda2.Image = Image.FromStream(ms);
        }

        private void TelaDashboard_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxRedonda1, $"{usuario.nome}");
            listBox1.Visible = false;
            listBox1.Items.Add("Perfil");
            listBox1.Items.Add("Configurações");
            listBox1.Items.Add("Sair");
        }

        private void carregaCbxPais()
        {
            bd.representantes.ToList().ForEach(u =>
            {
                if (!paises.Contains(u.pais))
                {
                    paises.Add(u.pais);
                    cbxPais.Items.Add(u.pais);
                }
            });
        }

        private void TelaDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxRedonda1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }

        private void sair(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void montar()
        {
            carregaCbxPais();
            lblBairro.Visible = true;
            lblCelular.Visible = true;
            lblCep.Visible = true;
            lblCidade.Visible = true;
            lblDataDeNascimento.Visible = true;
            lblEmail.Visible = true;
            lblEndereco.Visible = true;
            lblNome.Visible = true;
            lblEstado.Visible = true;
            lblPaís.Visible = true;
            lblSenha.Visible = true;
            lblPerfil.Visible = true;
            lblTelefone.Visible = true;
            lblErro.Visible = true;
            btnAlterarFoto.Visible = true;
            btnSalvar.Visible = true;
            pictureBoxRedonda2.Visible = true;
            cbAdministrador.Visible = true;
            if (usuario.status.Equals(true))
            {
                cbAdministrador.Checked = true;
                cbAdministrador.Enabled = true;
            }
            cbxPais.Visible = true;
            cbxCidade.Visible = true;
            cbxEstado.Visible = true;
            txtCelular.Visible = true;
            txtCEP.Visible = true;
            txtDataDeNascimento.Visible = true;
            txtEmail.Visible = true;
            txtEndereco.Visible = true;
            txtNome.Visible = true;
            txtBairro.Visible = true;
            txtSenha.Visible = true;
            txtTelefone.Visible = true;
            txtBairro.Text = usuario.bairro;
            txtCelular.Text = usuario.celular;
            txtCEP.Text = usuario.cep;
            txtDataDeNascimento.Text = usuario.dataNascimento;
            txtEmail.Text = usuario.email;
            txtEndereco.Text = usuario.endereco;
            txtNome.Text = usuario.nome;
            txtSenha.Text = senhaDescriptografada;
            txtTelefone.Text = usuario.telefone;
            cbxPais.Text = usuario.pais;
            cbxEstado.Text = usuario.estado;
            cbxCidade.Text = usuario.cidade;
            pictureBoxRedonda22.Visible = true;
            pictureBoxRedonda23.Visible = true;
            pictureBoxRedonda24.Visible = true;
            pictureBoxRedonda16.Visible = true;
            pictureBoxRedonda15.Visible = true;
            pictureBoxRedonda16.Visible = true;
            pictureBoxRedonda17.Visible = true;
            pictureBoxRedonda18.Visible = true;
            pictureBoxRedonda19.Visible = true;
            pictureBoxRedonda20.Visible = true;
            pictureBoxRedonda21.Visible = true;
            pictureBoxRedonda22.Visible = true;
            pictureBoxRedonda23.Visible = true;
            pictureBoxRedonda24.Visible = true;
            pictureBoxRedonda25.Visible = true;
            pictureBoxRedonda26.Visible = true;
        }
        private void desmontar()
        {
            txtConfirmarSenha.Visible = false;
            lblConfirmarSenha.Visible = false;
            lblBairro.Visible = false;
            lblCelular.Visible = false;
            lblCep.Visible = false;
            lblCidade.Visible = false;
            lblDataDeNascimento.Visible = false;
            lblEmail.Visible = false;
            lblEndereco.Visible = false;
            lblNome.Visible = false;
            lblEstado.Visible = false;
            lblPaís.Visible = false;
            lblSenha.Visible = false;
            lblPerfil.Visible = false;
            lblTelefone.Visible = false;
            btnAlterarFoto.Visible = false;
            btnSalvar.Visible = false;
            pictureBoxRedonda2.Visible = false;
            cbAdministrador.Visible = false;
            cbxPais.Visible = false;
            cbxCidade.Visible = false;
            cbxEstado.Visible = false;
            txtCelular.Visible = false;
            txtCEP.Visible = false;
            txtDataDeNascimento.Visible = false;
            txtEmail.Visible = false;
            txtEndereco.Visible = false;
            txtNome.Visible = false;
            txtBairro.Visible = false;
            txtSenha.Visible = false;
            txtTelefone.Visible = false;
            pictureBoxRedonda10.Visible = false;
            pictureBoxRedonda15.Visible = false;
            pictureBoxRedonda16.Visible = false;
            pictureBoxRedonda17.Visible = false;
            pictureBoxRedonda18.Visible = false;
            pictureBoxRedonda19.Visible = false;
            pictureBoxRedonda20.Visible = false;
            pictureBoxRedonda21.Visible = false;
            pictureBoxRedonda22.Visible = false;
            pictureBoxRedonda23.Visible = false;
            pictureBoxRedonda24.Visible = false;
            pictureBoxRedonda25.Visible = false;
            pictureBoxRedonda26.Visible = false;
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selecionado = listBox1.SelectedIndex;
            listBox1.Visible = false;
            if (selecionado == 0)
            {
                lblTelaAtual.Visible = false;
                montar();
            }
            if (selecionado == 1)
            {
                desmontar();
            }
            if (selecionado == 2)
            {
                new TelaLogin().Show();
                this.Hide();
            }

        }

        private void btnAlterarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Selecione uma imagem...";
            openFileDialog1.Filter = "png|*.png| jpg|*.jpg| jpeg|*.jpeg";
            openFileDialog1.Title = "Open image file";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                usuario.imagem = openFileDialog1.FileName;
                desenhaImagem();
            }
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBairro.Text) || string.IsNullOrEmpty(txtCelular.Text) || string.IsNullOrEmpty(txtCEP.Text) || string.IsNullOrEmpty(txtDataDeNascimento.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtEndereco.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrEmpty(cbxCidade.Text) || string.IsNullOrEmpty(cbxEstado.Text) || string.IsNullOrEmpty(cbxPais.Text))
            {
                lblErro.Text = "Preencha os campos obrigatórios";
            }
            else
            {
                MessageBox.Show($"{cbxEstadoValido} e {cbxCidadeValido}");
                if (nomeValido == true && telefoneValido == true && celularValido == true && emailValido == true && senhaValido == true && cepValido == true && bairroValido == true && enderecoValido == true && cbxCidadeValido == true && cbxEstadoValido == true)
                {
                    representante alterar = new representante();
                    criptografar(sender, e);
                    alterar = bd.representantes.Single(u => u.id.Equals(usuario.id));
                    alterar.bairro = txtBairro.Text;
                    alterar.celular = txtCelular.Text.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace(" ", "");
                    alterar.cep = txtCEP.Text.Replace('-', ' ').Replace(" ", "");
                    alterar.cidade = cbxCidade.Text;
                    alterar.dataNascimento = txtDataDeNascimento.Text;
                    alterar.email = txtEmail.Text;
                    alterar.endereco = txtEndereco.Text;
                    alterar.estado = cbxEstado.Text;
                    alterar.nome = txtNome.Text;
                    alterar.senha = senhaCriptografada;
                    alterar.status = cbAdministrador.Checked;
                    alterar.imagem = usuario.imagem;
                    alterar.telefone = txtTelefone.Text.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace(" ", "");
                    lblErro.Text = "Salvo com sucesso!";
                    bd.SaveChanges();
                }
                else
                {
                    lblErro.Text = "Campos inválidos!";
                }
            }
        }


        //validações
        private bool validarTxt(TextBox valida, PictureBoxRedonda nome)
        {
            int nChar = valida.Text.Length;
            if (!string.IsNullOrEmpty(valida.Text) && nChar >= 2)
            {
                imagemCerto(nome);
                return true;
            }
            else
            {
                imagemErro(nome);
                return false;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            TextBox valida = txtNome;
            PictureBoxRedonda nome = pictureBoxRedonda15;
            nomeValido = validarTxt(valida, nome);

        }
        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            celularValido = false;
            string semMask = txtCelular.Text.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace(" ", "");
            PictureBoxRedonda nome = pictureBoxRedonda18;
            if (semMask.Length == 10 || semMask.Length == 11)
            {

                imagemCerto(nome);
                celularValido = true;
            }
            else
            {
                imagemErro(nome);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            emailValido = false;
            Regex validaEmail = new Regex("^([a-zA_]+)([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
           + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
           + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$");

            PictureBoxRedonda nome = pictureBoxRedonda19;
            if (!validaEmail.IsMatch(txtEmail.Text))
            {
                imagemErro(nome);
            }
            else
            {
                emailValido = true;
                imagemCerto(nome);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            senhaValido = false;
            PictureBoxRedonda nome = pictureBoxRedonda20;
            int nChar = txtSenha.Text.Length;
            if (!string.IsNullOrEmpty(txtSenha.Text) && nChar >= 2)
            {

                imagemCerto(nome);
                if (senhaDescriptografada != txtSenha.Text)
                {
                    lblConfirmarSenha.Visible = true;
                    txtConfirmarSenha.Visible = true;
                    senhaValido = true;
                }
                else
                {
                    senhaValido = false;
                }
                senhaValido = true;
            }
            else
            {
                imagemErro(nome);
                lblConfirmarSenha.Visible = false;
                txtConfirmarSenha.Visible = false;
            }
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            string semMask = txtCEP.Text.Replace('-', ' ').Replace(" ", "");
            PictureBoxRedonda nome = pictureBoxRedonda21;
            cepValido = false;
            if (semMask.Length == 8)
            {
                imagemCerto(nome);
                cepValido = true;
            }
            else
            {
                imagemErro(nome);
            }
        }
        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            TextBox valida = txtBairro;
            PictureBoxRedonda nome = pictureBoxRedonda25;
            bairroValido = validarTxt(valida, nome);
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            TextBox valida = txtEndereco;
            PictureBoxRedonda nome = pictureBoxRedonda26;
            enderecoValido = validarTxt(valida, nome);
        }
        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            pictureBoxRedonda10.Visible = false;
            PictureBoxRedonda nome = pictureBoxRedonda10;
            if (txtSenha.Text == txtConfirmarSenha.Text)
            {
                imagemCerto(nome);
            }
            else
            {
                imagemErro(nome);
            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            string semMask = txtTelefone.Text.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace(" ", "");
            PictureBoxRedonda nome = pictureBoxRedonda17;
            telefoneValido = false;
            if (semMask.Length == 10 || semMask.Length == 11 || string.IsNullOrEmpty(semMask))
            {
                imagemCerto(nome);
                telefoneValido = true;
            }
            else
            {
                imagemErro(nome);
            }
        }

        private void imagemErro(PictureBox nome)
        {
            nome.Visible = true;
            string ImagemErro = @"C:\Users\Hiago Campregher\Desktop\project\Project\IMAGEM\error.png";
            byte[] content = File.ReadAllBytes(ImagemErro);
            MemoryStream ms = new MemoryStream(content);
            nome.Image = Image.FromStream(ms);
        }
        private void imagemCerto(PictureBox nome)
        {
            nome.Visible = true;
            string ImagemCerto = @"C:\Users\Hiago Campregher\Desktop\project\Project\IMAGEM\correct.png";
            byte[] content = File.ReadAllBytes(ImagemCerto);
            MemoryStream ms = new MemoryStream(content);
            nome.Image = Image.FromStream(ms);
        }

        private void cbxPais_TextChanged(object sender, EventArgs e)
        {
            cbxEstado.Items.Clear();
            estados.Clear();
            cbxCidade.Items.Clear();
            cidades.Clear();
            bd.representantes.ToList().ForEach(u =>
            {
                if (!estados.Contains(u.estado) && u.pais == cbxPais.Text)
                {
                    estados.Add(u.estado);
                    cbxEstado.Items.Add(u.estado);
                }
            });
            bd.representantes.ToList().ForEach(u =>
            {
                if (!cidades.Contains(u.cidade) && u.estado == cbxEstado.Text)
                {
                    cidades.Add(u.cidade);
                    cbxCidade.Items.Add(u.cidade);
                }
            });
        }

        private void cbxEstado_TextChanged(object sender, EventArgs e)
        {
            cbxCidade.Items.Clear();
            cidades.Clear();
            bd.representantes.ToList().ForEach(u =>
            {
                if (!cidades.Contains(u.cidade) && u.estado == cbxEstado.Text)
                {
                    cidades.Add(u.cidade);
                    cbxCidade.Items.Add(u.cidade);
                }
            });
            PictureBoxRedonda nome = pictureBoxRedonda23;
            cbxEstadoValido = false;
            if (!string.IsNullOrEmpty(cbxEstado.Text))
            {
                imagemCerto(nome);
                cbxEstadoValido = true;
            }
            else
            {
                imagemErro(nome);
            }
        }


        private void cbxCidade_TextChanged(object sender, EventArgs e)
        {
            PictureBoxRedonda nome = pictureBoxRedonda24;
            cbxCidadeValido = false;
            if (!string.IsNullOrEmpty(cbxCidade.Text))
            {
                imagemCerto(nome);
                cbxCidadeValido = true;
            }
            else
            {
                imagemErro(nome);
            }
        }

        private void cbxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxEstado_TextChanged(sender, e);
            cbxCidade_TextChanged(sender, e);
        }

    }
}
