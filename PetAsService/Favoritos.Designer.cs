namespace PetAsService
{
    partial class Favoritos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFavoritos = new System.Windows.Forms.ComboBox();
            this.botaoBuscar = new System.Windows.Forms.Button();
            this.listaFavoritos = new System.Windows.Forms.ListBox();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.imagemFavorito = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagemFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favoritos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aqui voce encontra seus favoritos.";
            // 
            // comboBoxFavoritos
            // 
            this.comboBoxFavoritos.FormattingEnabled = true;
            this.comboBoxFavoritos.Items.AddRange(new object[] {
            "Gatos",
            "Cachorros"});
            this.comboBoxFavoritos.Location = new System.Drawing.Point(39, 119);
            this.comboBoxFavoritos.Name = "comboBoxFavoritos";
            this.comboBoxFavoritos.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFavoritos.TabIndex = 3;
            // 
            // botaoBuscar
            // 
            this.botaoBuscar.Location = new System.Drawing.Point(176, 118);
            this.botaoBuscar.Name = "botaoBuscar";
            this.botaoBuscar.Size = new System.Drawing.Size(97, 23);
            this.botaoBuscar.TabIndex = 4;
            this.botaoBuscar.Text = "Buscar";
            this.botaoBuscar.UseVisualStyleBackColor = true;
            this.botaoBuscar.Click += new System.EventHandler(this.botaoBuscar_Click);
            // 
            // listaFavoritos
            // 
            this.listaFavoritos.FormattingEnabled = true;
            this.listaFavoritos.ItemHeight = 15;
            this.listaFavoritos.Location = new System.Drawing.Point(39, 174);
            this.listaFavoritos.Name = "listaFavoritos";
            this.listaFavoritos.Size = new System.Drawing.Size(234, 214);
            this.listaFavoritos.TabIndex = 5;
            this.listaFavoritos.SelectedIndexChanged += new System.EventHandler(this.listaFavoritos_SelectedIndexChanged);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Enabled = false;
            this.botaoExcluir.Location = new System.Drawing.Point(39, 408);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(124, 28);
            this.botaoExcluir.TabIndex = 6;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // imagemFavorito
            // 
            this.imagemFavorito.Location = new System.Drawing.Point(374, 118);
            this.imagemFavorito.Name = "imagemFavorito";
            this.imagemFavorito.Size = new System.Drawing.Size(431, 370);
            this.imagemFavorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemFavorito.TabIndex = 7;
            this.imagemFavorito.TabStop = false;
            // 
            // Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 500);
            this.Controls.Add(this.imagemFavorito);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.listaFavoritos);
            this.Controls.Add(this.botaoBuscar);
            this.Controls.Add(this.comboBoxFavoritos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Favoritos";
            this.Text = "Favoritos";
            ((System.ComponentModel.ISupportInitialize)(this.imagemFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxFavoritos;
        private Button botaoBuscar;
        private ListBox listaFavoritos;
        private Button botaoExcluir;
        private PictureBox imagemFavorito;
    }
}