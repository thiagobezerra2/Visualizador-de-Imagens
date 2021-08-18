using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Visualizador_de_Imagens
{
    public partial class imagemListBox : Form
    {
        public imagemListBox()
        {
            InitializeComponent();
        }

        private void imagemListBox_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"c:\windows\web\wallpaper", "*.jpg", SearchOption.AllDirectories);
            imagensListBox.Items.AddRange(arquivos);
        }

        private void imagensListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagensListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            favoritosListBox.Items.Add(imagensListBox.Text);
        }

        private void favoritosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagensListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            favoritosListBox.Items.Remove(imagensListBox.Text);
        }
    }
}
