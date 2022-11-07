using PetAsService.Services;
using System.Diagnostics;

namespace PetAsService
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair?", "Confirma�ao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            };
        }

        private void buscarRa�aMenuItem_Click(object sender, EventArgs e)
        {
            CatApi cat = new CatApi();

            var x = cat.GetCat();

            Trace.WriteLine(x);

            BuscarRacas busca = new BuscarRacas();
            busca.Show();
        }

        private void meusFavoritosMenuItem_Click(object sender, EventArgs e)
        {
            Favoritos favoritos = new Favoritos();
            favoritos.Show();

        }
    }
}