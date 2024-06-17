using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PokemonManager
{
    public partial class MainForm : Form
    {
        private List<Pokemon> pokedex;
        private int contadorPokedex = 1;

        public MainForm()
        {
            InitializeComponent();
            pokedex = new List<Pokemon>();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string tipo = txtTipo.Text;
            string descricao = txtDescricao.Text;
            string curiosidade = txtCuriosidade.Text;

            AdicionarPokemon(nome, tipo, descricao, curiosidade);

            MessageBox.Show("Pokémon adicionado à Pokédex!");

            txtNome.Clear();
            txtTipo.Clear();
            txtDescricao.Clear();
            txtCuriosidade.Clear();
        }

        private void AdicionarPokemon(string nome, string tipo, string descricao, string curiosidade)
        {
            Pokemon novoPokemon = new Pokemon(nome, tipo, descricao, curiosidade, contadorPokedex);
            pokedex.Add(novoPokemon);
            contadorPokedex++;
        }

        private void tabMostrar_Enter(object sender, EventArgs e)
        {
            lstPokedex.Items.Clear();
            var sortedPokedex = pokedex.OrderBy(p => p.NumeroPokedex);
            foreach (Pokemon pokemon in sortedPokedex)
            {
                lstPokedex.Items.Add($"Número: {pokemon.NumeroPokedex}, Nome: {pokemon.Nome}, Tipo: {pokemon.Tipo}, Descrição: {pokemon.Descricao}, Curiosidade: {pokemon.Curiosidade}");
            }
        }

        private void tabCadastrar_Click(object sender, EventArgs e)
        {

        }
    }

    public class Pokemon
    {
        public string Nome { get; }
        public string Tipo { get; }
        public string Descricao { get; }
        public string Curiosidade { get; }
        public int NumeroPokedex { get; }

        public Pokemon(string nome, string tipo, string descricao, string curiosidade, int numeroPokedex)
        {
            Nome = nome;
            Tipo = tipo;
            Descricao = descricao;
            Curiosidade = curiosidade;
            NumeroPokedex = numeroPokedex;
        }
    }
}
