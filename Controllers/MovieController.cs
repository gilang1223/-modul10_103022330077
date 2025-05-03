using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _modul10_103022330077.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private static List<string> stars1 = new List<string> { "Frank Darabont", "morgan freeman", "bob gunton" };
        private static List<string> stars2 = new List<string> { "marlon brando", "al pacino", "james caan" };
        private static List<string> stars3 = new List<string> { "bale", "H ledger", "aron eckhart" };
        private static List<Movies> movie = new List<Movies>
        {
            new Movies ( "The Shawshank Redemption", "Frank Darabont", stars1, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion" ),
            new Movies ( "The Godfather", "Francis Ford Coppola", stars2, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son." ),
            new Movies ( "The Dark Knight", "Christopher Nolan", stars3, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness." ),

        };
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            return movie;
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public Movies Get(int id)
        {
            return movie[id];
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movies value)
        {
            movie.Add(value);
        }

   
        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          movie.RemoveAt(id);
        }
    }
}
