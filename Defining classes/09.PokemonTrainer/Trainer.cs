using System.Collections.Generic;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, Pokemon pokemon)
        {
            Name = name;
            Badges = 0;
            Pokemons.Add(pokemon);
        }

        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Count}";
        }
    }
}
