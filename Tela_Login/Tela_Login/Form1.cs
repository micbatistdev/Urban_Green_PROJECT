using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tela_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void CardLogin_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20; // Ajuste o raio das bordas arredondadas

            // Criar o caminho para bordas arredondadas
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(CardLogin.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(CardLogin.Width - cornerRadius, CardLogin.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, CardLogin.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Configurar o modo de suavização para bordas mais suaves
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Preencher o fundo com a cor preta semi-transparente
                using (Brush b = new SolidBrush(Color.FromArgb(40, Color.Black)))
                {
                    e.Graphics.FillPath(b, path);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ViewPassword_Click(object sender, EventArgs e)
        {
 
        }

        private void inputSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}