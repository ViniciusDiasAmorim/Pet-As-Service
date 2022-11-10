using PetAsService.Models;
using PetAsService.Services;

namespace PetAsService
{
    public partial class BuscarRacas : Form
    {
        public BuscarRacas()
        {
            InitializeComponent();
        }

        public Cat CatMemory { get; set; }

        private async void botaoBuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(comboBoxRacas.Text))
            {
                MessageBox.Show("Escolha uma raça para buscar.");
            }
            else
            {
                //Validando se a raça selecionada tem espaço visto que a query do endpoint muda quando a raça possui espaço
                string query = "";
                bool temEspaço = false;

                for (int i = 0; i < comboBoxRacas.Text.Length; i++)
                {
                    if (char.IsWhiteSpace(comboBoxRacas.Text[i]) || comboBoxRacas.Text[i] == '-')
                    {
                        temEspaço = true;
                    }
                }

                if (temEspaço == false)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        query += comboBoxRacas.Text[i];
                    }
                }
                else
                {
                    for (int i = 1; i < comboBoxRacas.Text.Length; i++)
                    {
                        if (char.IsWhiteSpace(comboBoxRacas.Text[i]) || comboBoxRacas.Text[i] == '-')
                        {
                            query += comboBoxRacas.Text[0];
                            query += comboBoxRacas.Text[i + 1];
                            query += comboBoxRacas.Text[i + 2];
                            query += comboBoxRacas.Text[i + 3];
                        }
                    }
                }

                CatService catService = new CatService();

                var cat = await catService.GetCat(query);

                resultadoTemperamento.Text = cat.Temperament;
                resultadoOrigem.Text = cat.Origin;
                resultadoDescricao.Text = cat.Description;
                try
                {
                    imagemUrl.Load($"https://cdn2.thecatapi.com/images/{cat.ReferenceImageId}.jpg");
                }
                catch
                {
                    MessageBox.Show("Nao foi possivel carregar a imagem");
                }
                

                CatMemory = cat;
            }
        }

        private async void botaoFavoritar_Click(object sender, EventArgs e)
        {
            if (CatMemory != null)
            {
                CatService catService = new CatService();
                var resultado = await catService.FavCat(CatMemory);
                MessageBox.Show($"{resultado}");
            }
            else
            {
                MessageBox.Show("Encontre um gatinho para favoritar");
            }
        }

        private void comboBoxRacas_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultadoDescricao.Text = "Resultado";
            resultadoOrigem.Text = "Resultado";
            resultadoTemperamento.Text = "Resultado";
        }
    }
}
