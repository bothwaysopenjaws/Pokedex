using Pokedex.Wf.Model;
using Pokedex.Wf.Windows;

namespace Pokedex.Wf;

public partial class MainWindow : Form
{

    public DataContext Context { get; set; }

    public MainWindow()
    {
        InitializeComponent();
        labelTitle.BackColor = Color.FromArgb(128, 255, 232, 232);
        Context = new DataContext();

    }

    private void buttonManagerElement_Click(object sender, EventArgs e)
    {
        FormManagerElement form = new FormManagerElement();
        form.Context = Context;
        form.RefreshList();
        this.Visible = false;
        form.ShowDialog();
        this.Visible = true;
    }

    private void buttonManagerPokemons_Click(object sender, EventArgs e)
    {
        FormManagerPokemon form = new FormManagerPokemon();
        form.Context = Context;
        form.RefreshList();
        this.Visible = false;
        form.ShowDialog();
        this.Visible = true;
    }
}
