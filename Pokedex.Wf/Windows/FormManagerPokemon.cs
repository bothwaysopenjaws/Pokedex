using Pokedex.Wf.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex.Wf.Windows
{
    public partial class FormManagerPokemon : Form
    {
        /// <summary>
        /// Contexte de données
        /// </summary>
        public DataContext Context { get; set; }

        public FormManagerPokemon()
        {
            InitializeComponent();

            //Associations des parents
            labelAddPokemonName.Parent = groupBoxAdd;
            textBoxAddPokemonName.Parent = groupBoxAdd;
            buttonAddPokemonValidate.Parent = groupBoxAdd;
            labelAddPokemonElement.Parent = groupBoxAdd;
            comboBoxAddPokemonElement.Parent = groupBoxAdd;
            groupBoxAdd.Visible = false;

        }

        public void RefreshList()
        {
            listBoxPokemons.DataSource = null;
            listBoxPokemons.DisplayMember = nameof(Pokemon.FullName);
            listBoxPokemons.DataSource = Context.Pokemons;

            comboBoxUpdatePokemonElement.DataSource = null;
            comboBoxUpdatePokemonElement.DisplayMember = nameof(Element.Name);
            comboBoxUpdatePokemonElement.DataSource = Context.Elements;

            comboBoxAddPokemonElement.DataSource = null;
            comboBoxAddPokemonElement.DisplayMember = nameof(Element.Name);
            comboBoxAddPokemonElement.DataSource = Context.Elements;
        }

        private void listBoxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPokemons.SelectedItem != null)
            {
                Pokemon selectedPokemon = (Pokemon)listBoxPokemons.SelectedItem;
                textBoxUpdatePokemonName.Text = selectedPokemon.Name;
                comboBoxUpdatePokemonElement.SelectedItem = selectedPokemon.Element;
                textBoxUpdatePokemonIdApi.Text = selectedPokemon.pokemonApiId.ToString();
                if (!string.IsNullOrWhiteSpace(selectedPokemon.UrlPicture))
                    pictureBoxPokemon.LoadAsync(selectedPokemon.UrlPicture);
            }

        }

        private void buttonAddPokemon_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = true;
        }

        private void buttonAddPokemonValidate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAddPokemonName.Text) && comboBoxAddPokemonElement.SelectedItem != null)
            {
                Pokemon pokemon = new Pokemon(textBoxAddPokemonName.Text, ((Element)comboBoxAddPokemonElement.SelectedItem));
                MessageBox.Show("Ajouté", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBoxAdd.Visible = false;
                Context.Pokemons.Add(pokemon);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Le nom doit être renseigné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDeletePokemon_Click(object sender, EventArgs e)
        {
            if (listBoxPokemons.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Confirmer ? ", "Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Context.Pokemons.Remove((Pokemon)listBoxPokemons.SelectedItem);
                    RefreshList();
                }
            }
        }


        private void buttonUpdatePokemon_Click(object sender, EventArgs e)
        {
            if (
                !string.IsNullOrWhiteSpace(textBoxUpdatePokemonName.Text) 
                && comboBoxUpdatePokemonElement.SelectedItem != null
                && listBoxPokemons.SelectedItem != null
                )
            {
                Pokemon selectedPokemon = (Pokemon)listBoxPokemons.SelectedItem;
                selectedPokemon.Name = textBoxUpdatePokemonName.Text;
                selectedPokemon.Element = ((Element)comboBoxUpdatePokemonElement.SelectedItem);

                if (int.TryParse(textBoxUpdatePokemonName.Text, out int result))
                {
                    selectedPokemon.pokemonApiId = result;
                    MessageBox.Show("Modifié", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Modifié, valeur incorrecte pour l'API", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                RefreshList();
            }
            else
            {
                MessageBox.Show("Le nom doit être renseigné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
