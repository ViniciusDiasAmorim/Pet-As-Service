using PetAsService.Models;
using PetAsService.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetAsService
{
    public partial class Favoritos : Form
    {
        public Favoritos()
        {
            InitializeComponent();
        }

        private async void comboBoxFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFavoritos.SelectedIndex == 0)
            {
                MessageBox.Show("Aguarde o carregamento das Informaçoes");
                CatService catService = new CatService();
                List<Cat> cats = await catService.GetFavCat();

                MessageBox.Show($"{cats.Count}");

                //foreach(var item in cats)
                //{
                //    MessageBox.Show(item.Name);
                //}

            }
        }
    }
}
