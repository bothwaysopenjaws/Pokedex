using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Wf.Model;

/// <summary>
/// Pokémon
/// </summary>
public class Pokemon
{
    /// <summary>
    /// Nom
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Element principal
    /// </summary>
    public Element Element { get; set; }

    /// <summary>
    /// Identifiant du pokémon sur l'API
    /// </summary>
    public int pokemonApiId { get; set; }

    /// <summary>
    /// Propriété calculée donnant l'url de l'image
    /// </summary>
    public string? UrlPicture => $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{pokemonApiId}.png";

    public string FullName => $"{Name}  - [{Element.Name}]";

    /// <summary>
    /// Constructeur d'un pokémon
    /// </summary>
    /// <param name="name">Nom</param>
    /// <param name="element">Elément principal</param>
    public Pokemon(string name, Element element)
    {
        Name = name;
        Element = element;
        Element.Pokemons.Add(this);
    }
}
