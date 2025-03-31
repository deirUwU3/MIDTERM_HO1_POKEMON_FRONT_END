namespace pokemonactivity
{
    public class pokemonrep
    {
        
        private static List<Pokemon> _pokemons = new List<Pokemon>();

        public static void Initialize()
        {
            _pokemons.Add(new Pokemon
            {
                Name = "Balbasaus",
                Type = "Grass",
                Height = 0.7f,
                Weight = 6.9f,
            });
        }

        public static List<Pokemon> GetPokemonList()
        {
            if (_pokemons.Count == 0 || _pokemons.Count() == 0)
            {
                Initialize();
            }
            return _pokemons;
        }

        public static void AddPokemon(Pokemon pokemon)
        {
            _pokemons.Add(pokemon);
        }
    }
}
