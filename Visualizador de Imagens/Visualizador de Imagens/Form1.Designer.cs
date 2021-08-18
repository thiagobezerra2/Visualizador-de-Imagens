
namespace Visualizador_de_Imagens
{
    partial class imagemListBox
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
            this.imagensListBox = new System.Windows.Forms.ListBox();
            this.favoritosListBox = new System.Windows.Forms.ListBox();
            this.AdicionarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagensListBox
            // 
            this.imagensListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagensListBox.FormattingEnabled = true;
            this.imagensListBox.ItemHeight = 15;
            this.imagensListBox.Location = new System.Drawing.Point(7, 19);
            this.imagensListBox.Name = "imagensListBox";
            this.imagensListBox.Size = new System.Drawing.Size(675, 139);
            this.imagensListBox.TabIndex = 0;
            this.imagensListBox.SelectedIndexChanged += new System.EventHandler(this.imagensListBox_SelectedIndexChanged);
            // 
            // favoritosListBox
            // 
            this.favoritosListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoritosListBox.FormattingEnabled = true;
            this.favoritosListBox.ItemHeight = 15;
            this.favoritosListBox.Location = new System.Drawing.Point(7, 223);
            this.favoritosListBox.Name = "favoritosListBox";
            this.favoritosListBox.Size = new System.Drawing.Size(675, 139);
            this.favoritosListBox.TabIndex = 1;
            this.favoritosListBox.SelectedIndexChanged += new System.EventHandler(this.favoritosListBox_SelectedIndexChanged);
            // 
            // AdicionarButton
            // 
            this.AdicionarButton.Location = new System.Drawing.Point(7, 177);
            this.AdicionarButton.Name = "AdicionarButton";
            this.AdicionarButton.Size = new System.Drawing.Size(204, 23);
            this.AdicionarButton.TabIndex = 2;
            this.AdicionarButton.Text = "Adicionar aos Favoritos";
            this.AdicionarButton.UseVisualStyleBackColor = true;
            this.AdicionarButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(7, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 293);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // removerButton
            // 
            this.removerButton.Location = new System.Drawing.Point(295, 177);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(203, 23);
            this.removerButton.TabIndex = 4;
            this.removerButton.Text = "Remover";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // imagemListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 714);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdicionarButton);
            this.Controls.Add(this.favoritosListBox);
            this.Controls.Add(this.imagensListBox);
            this.Name = "imagemListBox";
            this.Text = "Visualizador de Imagens";
            this.Load += new System.EventHandler(this.imagemListBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox imagensListBox;
        private System.Windows.Forms.ListBox favoritosListBox;
        private System.Windows.Forms.Button AdicionarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button removerButton;
    }
}

