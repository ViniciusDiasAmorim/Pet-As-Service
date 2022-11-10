using PetAsService.Models;
using PetAsService.Services;

namespace PetAsService
{
    public partial class Favoritos : Form
    {
        public List<FavoriteCat> CatMemory { get; set; }
        public Favoritos()
        {
            InitializeComponent();
            bloqueiBotao();
        }
        private async void botaoBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxFavoritos.Text))
            {
                MessageBox.Show("Selecione uma raça para ver seus favoritos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                listaFavoritos.Items.Clear();

                if (comboBoxFavoritos.SelectedIndex == 0)
                {
                    MessageBox.Show("CLIQUE EM Ok e aguarde alguns segundos, o programa ira buscar seus favoritos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    CatService catService = new CatService();

                    List<FavoriteCat> cats = await catService.GetFavCat();

                    foreach (var item in cats)
                    {
                        listaFavoritos.Items.Add(item.Name);
                    }

                    CatMemory = cats;
                }
                if(listaFavoritos.Items.Count > 0)
                {
                    botaoExcluir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Voce nao favoritou nenhum animalzinho procure alguns para favoritar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void bloqueiBotao()
        {
            if(listaFavoritos.Items == null)
            {
                botaoBuscar.Enabled = false;
            }
        }
        private void listaFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in CatMemory)
            {
                if (listaFavoritos.SelectedItem == item.Name)
                {
                    imagemFavorito.Load($"https://cdn2.thecatapi.com/images/{item.ImageId}.jpg");
                }
            }
        }

        private async void botaoExcluir_Click(object sender, EventArgs e)
        {
            if (listaFavoritos.SelectedItem == null)
            {
                MessageBox.Show("Nenhum animalzinho foi escolhido para deletar", "Erro ao Deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CatService catService = new CatService();
                string selectedItemAux = listaFavoritos.SelectedItem.ToString();

                foreach (var item in CatMemory)
                {
                    
                    if (selectedItemAux == item.Name)
                    {
                        var resultado = await catService.DeleteFavCat(item.Id);

                        if (resultado)
                        {
                            listaFavoritos.Items.Remove(item.Name);
                            MessageBox.Show("Removido com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Algo deu errado na hora de remover o bichinho");
                        }
                    }
                }

                if(listaFavoritos.Items.Count == 0)
                {
                    botaoExcluir.Enabled = false;
                }
            }
        }
    }
}
