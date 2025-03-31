using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pokemonactivity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pokemoncontroller : ControllerBase
    {

        public Pokemoncontroller()
        {
            pokemonrep.Initialize();
        }

        [HttpGet]
        [Route("get-all")]
        public IActionResult GetAction()
        {

            return Ok(pokemonrep.GetPokemonList());
        }

        [HttpGet]
        public IActionResult GetPokemon(string? name)
        {
            if (name == null) return Ok("not okay!");
            var result = pokemonrep.GetPokemonList()
                .Where(x => name.ToLower() == x.Name.ToLower())
                .SingleOrDefault();

            if (result != null) return Ok(result);

            return NoContent();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pokemon pokemon)
        {
            pokemonrep.AddPokemon(pokemon);
            return Created("", null);
        }
    }

}
