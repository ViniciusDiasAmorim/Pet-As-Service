namespace PetAsService
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTextoBemVindo = new System.Windows.Forms.Label();
            this.menuTelaPrincipal = new System.Windows.Forms.MenuStrip();
            this.buscarRaçaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusFavoritosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMenuPrincipal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuTelaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetAsService.Properties.Resources.veterinary;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // labelTextoBemVindo
            // 
            resources.ApplyResources(this.labelTextoBemVindo, "labelTextoBemVindo");
            this.labelTextoBemVindo.Name = "labelTextoBemVindo";
            // 
            // menuTelaPrincipal
            // 
            this.menuTelaPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarRaçaMenuItem,
            this.meusFavoritosMenuItem});
            resources.ApplyResources(this.menuTelaPrincipal, "menuTelaPrincipal");
            this.menuTelaPrincipal.Name = "menuTelaPrincipal";
            // 
            // buscarRaçaMenuItem
            // 
            this.buscarRaçaMenuItem.Name = "buscarRaçaMenuItem";
            resources.ApplyResources(this.buscarRaçaMenuItem, "buscarRaçaMenuItem");
            this.buscarRaçaMenuItem.Click += new System.EventHandler(this.buscarRaçaMenuItem_Click);
            // 
            // meusFavoritosMenuItem
            // 
            this.meusFavoritosMenuItem.Name = "meusFavoritosMenuItem";
            resources.ApplyResources(this.meusFavoritosMenuItem, "meusFavoritosMenuItem");
            this.meusFavoritosMenuItem.Click += new System.EventHandler(this.meusFavoritosMenuItem_Click);
            // 
            // labelMenuPrincipal
            // 
            resources.ApplyResources(this.labelMenuPrincipal, "labelMenuPrincipal");
            this.labelMenuPrincipal.Name = "labelMenuPrincipal";
            // 
            // MenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.labelMenuPrincipal);
            this.Controls.Add(this.labelTextoBemVindo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuTelaPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuTelaPrincipal;
            this.Name = "MenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuTelaPrincipal.ResumeLayout(false);
            this.menuTelaPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTextoBemVindo;
        private MenuStrip menuStrip1;
        private MenuStrip menuTelaPrincipal;
        private ToolStripMenuItem buscarRaçaMenuItem;
        private ToolStripMenuItem meusFavoritosMenuItem;
        private Label labelMenuPrincipal;
    }
}