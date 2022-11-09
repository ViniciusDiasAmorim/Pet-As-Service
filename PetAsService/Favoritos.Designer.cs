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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaFavoritos = new System.Windows.Forms.ListView();
            this.comboBoxFavoritos = new System.Windows.Forms.ComboBox();
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
            // listaFavoritos
            // 
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Persa";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "Siames";
            this.listaFavoritos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listaFavoritos.Location = new System.Drawing.Point(28, 160);
            this.listaFavoritos.Name = "listaFavoritos";
            this.listaFavoritos.Size = new System.Drawing.Size(302, 278);
            this.listaFavoritos.TabIndex = 2;
            this.listaFavoritos.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxFavoritos
            // 
            this.comboBoxFavoritos.FormattingEnabled = true;
            this.comboBoxFavoritos.Items.AddRange(new object[] {
            "Cats",
            "Dogs"});
            this.comboBoxFavoritos.Location = new System.Drawing.Point(39, 119);
            this.comboBoxFavoritos.Name = "comboBoxFavoritos";
            this.comboBoxFavoritos.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFavoritos.TabIndex = 3;
            this.comboBoxFavoritos.SelectedIndexChanged += new System.EventHandler(this.comboBoxFavoritos_SelectedIndexChanged);
            // 
            // Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxFavoritos);
            this.Controls.Add(this.listaFavoritos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Favoritos";
            this.Text = "Favoritos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listaFavoritos;
        private ComboBox comboBoxFavoritos;
    }
}