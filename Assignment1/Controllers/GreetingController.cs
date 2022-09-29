using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        ///     This API returns the string "Hello World!"
        /// </summary>
        /// <returns> Returns the string "Hello World!"</returns>
        /// <example> 
        ///     /api/Greeting => "Hello World!"
        /// </example>

        // GET /api/Greeting
        public string Get()
        {
            return "Hello World!";
        }

        /// <summary>
        ///     This API returns the string "Greetings to {id} people!"
        /// </summary>
        /// <param name="id"> Number of people to greet </param>
        /// <returns> Returns the string "Greetings to {id} people!"</returns>
        /// <example> 
        ///     /api/Greeting/3 => "Greetings to 3 people!"
        ///     /api/Greeting/0 => "Greetings to 0 people!"
        ///     /api/Greeting/6 => "Greetings to 6 people!"
        /// </example>

        // GET /api/Greeting/{id}
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
