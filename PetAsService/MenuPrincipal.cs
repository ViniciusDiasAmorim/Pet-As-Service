using PetAsService.Models;
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
            if (MessageBox.Show("Deseja Realmente Sair?", "Confirmaçao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            };
        }

        private async void buscarRaçaMenuItem_Click(object sender, EventArgs e)
        {

            CatService catService = new CatService();

            string id = "tang";

            var x = await catService.GetCat(id);

            var a = x.Id;
            var b = x.Name;
            var c = x.Temperament;
            var f = x.Origin;
            var d = x.Description;
            
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