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
        public List<Cat> CatMemory { get; set; }
        public Favoritos()
        {
            InitializeComponent();
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

                    List<Cat> cats = await catService.GetFavCat();

                    foreach (var item in cats)
                    {
                        listaFavoritos.Items.Add(item.Name);
                    }

                    CatMemory = cats;
                }
            }
        }

        private void listaFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in CatMemory)
            {
                if (listaFavoritos.SelectedItem == item.Name)
                {
                    imagemFavorito.Load($"https://cdn2.thecatapi.com/images/{item.ReferenceImageId}.jpg");
                }
            }
        }
    }
}
