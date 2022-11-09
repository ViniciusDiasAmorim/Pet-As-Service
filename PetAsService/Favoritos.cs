using PetAsService.Models;
using PetAsService.Services;
using System;
using System.Collections;
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
        private async void botaoBuscar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(comboBoxFavoritos.Text))
            {
                MessageBox.Show("Selecione uma raça para ver seus favoritos", "Aviso" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            else
            {
                if (comboBoxFavoritos.SelectedIndex == 0)
                {
                    MessageBox.Show(" Clique em Ok e aguarde alguns segundos, o programa ira buscar seus favoritos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CatService catService = new CatService();
                   
                    List<Cat> cats = await catService.GetFavCat();

                    foreach (var item in cats)
                    {
                        listaFavoritos.Items.Add(item.Name);
                    }
                }
            }
        }

        private void listaFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
               
                imagemFavorito.Load($"https://cdn2.thecatapi.com/images/ebv.jpg");

                //imagemUrl.Load($"https://cdn2.thecatapi.com/images/{cat.ReferenceImageId}.jpg");

        }
    }
}
