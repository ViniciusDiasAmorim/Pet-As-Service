using PetAsService.Services;

namespace PetAsService
{
    public partial class BuscarRacas : Form
    {
        public BuscarRacas()
        {
            InitializeComponent();
        }

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
            }
        }
    }
}
