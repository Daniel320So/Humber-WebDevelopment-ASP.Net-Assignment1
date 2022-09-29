using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        ///     This APIs returns 10 more than the interger input {id}
        /// </summary>
        /// <param name="id"> Any integer values </param>
        /// <returns> Returns the integer value of 10 plus input {id} </returns>
        /// <example>
        ///     api/AddTen/21 => 31
        ///     api/AddTen/0 => 10
        ///     api/AddTen/-9 => 1
        /// </example>

        // GET /api/AddTen/{id}
        [HttpGet]
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
