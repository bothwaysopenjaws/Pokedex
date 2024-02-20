using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Wf.Model;

/// <summary>
/// Element du pokémon
/// </summary>
internal class Element
{
    /// <summary>
    /// Nom de l'élément
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Liste des pokémons associés
    /// </summary>
    public List<Pokemon> Pokemons { get; set; }

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
