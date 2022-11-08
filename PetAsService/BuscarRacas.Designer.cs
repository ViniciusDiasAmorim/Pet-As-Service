namespace PetAsService
{
    partial class BuscarRacas
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRacas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultadoTemperamento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultadoOrigem = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resultadoDescricao = new System.Windows.Forms.Label();
            this.botaoBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encontre Sua Raça Favorita";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(790, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utilize a caixa de seleçao para buscar caracteristicas sobre um determinado pet e" +
    " descobrir qual o seu pet favorito.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Raça :";
            // 
            // comboBoxRacas
            // 
            this.comboBoxRacas.FormattingEnabled = true;
            this.comboBoxRacas.Items.AddRange(new object[] {
            "Abyssinian",
            "Aegean",
            "American Bobtail",
            "American Curl",
            "American Shorthair",
            "American Wirehair",
            "Arabian Mau",
            "Australian Mist",
            "Balinese",
            "Bambino",
            "Bengal",
            "Birman",
            "Bombay",
            "British Longhair",
            "British Shorthair"});
            this.comboBoxRacas.Location = new System.Drawing.Point(137, 124);
            this.comboBoxRacas.Name = "comboBoxRacas";
            this.comboBoxRacas.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRacas.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Temperamento :";
            // 
            // resultadoTemperamento
            // 
            this.resultadoTemperamento.AutoSize = true;
            this.resultadoTemperamento.Location = new System.Drawing.Point(137, 180);
            this.resultadoTemperamento.Name = "resultadoTemperamento";
            this.resultadoTemperamento.Size = new System.Drawing.Size(59, 15);
            this.resultadoTemperamento.TabIndex = 7;
            this.resultadoTemperamento.Text = "Resultado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Origem :";
            // 
            // resultadoOrigem
            // 
            this.resultadoOrigem.AutoSize = true;
            this.resultadoOrigem.Location = new System.Drawing.Point(137, 227);
            this.resultadoOrigem.Name = "resultadoOrigem";
            this.resultadoOrigem.Size = new System.Drawing.Size(59, 15);
            this.resultadoOrigem.TabIndex = 9;
            this.resultadoOrigem.Text = "Resultado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Descriçao :";
            // 
            // resultadoDescricao
            // 
            this.resultadoDescricao.AutoSize = true;
            this.resultadoDescricao.Location = new System.Drawing.Point(137, 267);
            this.resultadoDescricao.Name = "resultadoDescricao";
            this.resultadoDescricao.Size = new System.Drawing.Size(59, 15);
            this.resultadoDescricao.TabIndex = 11;
            this.resultadoDescricao.Text = "Resultado";
            // 
            // botaoBuscar
            // 
            this.botaoBuscar.Location = new System.Drawing.Point(19, 329);
            this.botaoBuscar.Name = "botaoBuscar";
            this.botaoBuscar.Size = new System.Drawing.Size(75, 23);
            this.botaoBuscar.TabIndex = 12;
            this.botaoBuscar.Text = "Buscar";
            this.botaoBuscar.UseVisualStyleBackColor = true;
            this.botaoBuscar.Click += new System.EventHandler(this.botaoBuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Favoritar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BuscarRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botaoBuscar);
            this.Controls.Add(this.resultadoDescricao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resultadoOrigem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultadoTemperamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxRacas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscarRacas";
            this.Text = "Buscar Raças";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox comboBoxRacas;
        private Label label5;
        private Label resultadoTemperamento;
        private Label label7;
        private Label resultadoOrigem;
        private Label label9;
        private Label resultadoDescricao;
        private Button botaoBuscar;
        private Button button2;
    }
}