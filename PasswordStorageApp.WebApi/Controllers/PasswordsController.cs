using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PasswordStorageApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var paswords = _passwords;
            return Ok(paswords);
        }

        [HttpGet("{passwordId}")]
        public IActionResult GetById(string passwordId)
        {
          var password = _passwords.FirstOrDefault(p=> p==passwordId);
            if(string.IsNullOrEmpty(password))
                return NotFound();

            return Ok(password);
        }


        [HttpDelete("{passwordId}")]
        public IActionResult Remove(string passwordId)
        {
            var password = _passwords.FirstOrDefault(p => p == passwordId);
            if (string.IsNullOrEmpty(password))
                return NotFound();

            _passwords.Remove(passwordId);

            return NoContent();
        }


        private static List<string> _passwords = new()
        {
            "1213213",
            "sadasda",
            "sadsadsad",
            "xaxsxsxsa",
            "2sadsadsad",

        };
    }
}
