using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Wf.Model
{
    /// <summary>
    /// Pokémon
    /// </summary>
    internal class Pokemon
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
}
