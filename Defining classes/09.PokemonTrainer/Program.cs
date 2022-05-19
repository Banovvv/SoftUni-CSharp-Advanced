using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            #region Trainers
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Tournament")
                {
                    break;
                }

                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string trainerName = commandArgs[0];
                string pokemonName = commandArgs[1];
                string pokemonElement = commandArgs[2];
                int pokemonHealth = int.Parse(commandArgs[3]);

                Trainer trainer = trainers.Where(x => x.Name == trainerName).FirstOrDefault();
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainer == null)
                {
                    trainers.Add(new Trainer(trainerName, pokemon));
                }
                else
                {
                    trainer.Pokemons.Add(pokemon);
                }
            }
            #endregion

            #region Tournament
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                PlayOutTurn(trainers, command);
            }
            #endregion

            foreach (Trainer trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine(trainer);
            }
        }

        static void PlayOutTurn(List<Trainer> trainers, string elementType)
        {
            foreach (Trainer trainer in trainers)
            {
                UpdateTrainer(trainer, elementType);
            }

        }

        static void UpdateTrainer(Trainer trainer, string elementType)
        {
            if (trainer.Pokemons.FirstOrDefault(x => x.Element == elementType) != null)
            {
                trainer.Badges++;
            }
            else
            {
                foreach (Pokemon pokemon in trainer.Pokemons)
                {
                    pokemon.Health -= 10;
                }
            }

            RemoveDeadPokemons(trainer);
        }
        static void RemoveDeadPokemons(Trainer trainer) => trainer.Pokemons = trainer.Pokemons.Where(x => x.Health > 0).ToList();
    }
}
