using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Wf.Model;

/// <summary>
/// Element du pokémon
/// </summary>
public class Element
{
    /// <summary>
    /// Nom de l'élément
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Liste des pokémons associés
    /// </summary>
    public List<Pokemon> Pokemons { get; set; }

    public string FullName => $"{Name} ({Pokemons.Count})";

    /// <summary>
    /// Constructeur d'un élément
    /// </summary>
    /// <param name="name">Nom</param>
    public Element(string name)
    {
        Name = name;
        Pokemons = new List<Pokemon>();
    }
}
