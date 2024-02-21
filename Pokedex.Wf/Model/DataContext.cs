using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;

namespace Pokedex.Wf.Model
{
    /// <summary>
    /// Contexte de donnée de l'application
    /// </summary>
    public class DataContext
    {
        /// <summary>
        /// Liste des éléments
        /// </summary>
        public List<Element> Elements { get; set; }

        /// <summary>
        /// Liste des pokémons
        /// </summary>
        public List<Pokemon> Pokemons { get; set; }

        /// <summary>
        /// Constructeurs d'un dataContext
        /// </summary>
        public DataContext() 
        {
            Elements = new List<Element>();
            Pokemons = new List<Pokemon>();

            Element grass       = new Element("Plante");
            Element poison      = new Element("Poison");
            Element fire        = new Element("Feu");
            Element flying      = new Element("Vol");
            Element water       = new Element("Flotte");
            Element bug         = new Element("Insecte");
            Element normal      = new Element("Normal");
            Element electric    = new Element("Electrique");
            Element ground      = new Element("Sol");
            Element fairy       = new Element("Fée");
            Element fighting    = new Element("Combat");
            Element psychic     = new Element("Psy");
            Element rock        = new Element("Roche");
            Element steel       = new Element("Acier");
            Element ice         = new Element("Glace");
            Element ghost       = new Element("Spectre");
            Element dragon      = new Element("Dragon");
            Element dark        = new Element("Rayan");

            Elements.Add(grass);
            Elements.Add(poison);
            Elements.Add(fire);
            Elements.Add(flying);
            Elements.Add(water);
            Elements.Add(bug);
            Elements.Add(normal);
            Elements.Add(electric);
            Elements.Add(ground);
            Elements.Add(fairy); 
            Elements.Add(fighting);
            Elements.Add(psychic);
            Elements.Add(rock); 
            Elements.Add(steel);
            Elements.Add(ice);
            Elements.Add(ghost);
            Elements.Add(dragon);
            Elements.Add(dark);

            Pokemons.Add(new Pokemon("Lipoutou", psychic));
            Pokemons.Add(new Pokemon("Bulbizarre", grass));
            Pokemons.Add(new Pokemon("Gardevoir", psychic));
            Pokemons.Add(new Pokemon("Dracofeu", fire));
            Pokemons.Add(new Pokemon("Pikachu", electric));
            Pokemons.Add(new Pokemon("Evoli", normal));
            Pokemons.Add(new Pokemon("Tiplouf", water));
            Pokemons.Add(new Pokemon("Signabraze", fire));
            Pokemons.Add(new Pokemon("Chetiflore", grass));
            Pokemons.Add(new Pokemon("Palkia", steel));
            Pokemons.Add(new Pokemon("Calinos", fire));
            Pokemons.Add(new Pokemon("Tadmorv", poison));


        }
    }
}
