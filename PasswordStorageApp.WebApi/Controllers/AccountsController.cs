using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordStorageApp.WebApi.Dtos;
using PasswordStorageApp.WebApi.Models;
using PasswordStorageApp.WebApi.Persistence;

namespace PasswordStorageApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAll()
        {
            var accounts = FakeDbContext
                .Accounts
                .ToList();
            return Ok(accounts);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var account = FakeDbContext.Accounts.FirstOrDefault(a => a.Id == id);

            if (account is null)
                return NotFound();

            return Ok(account);

        }

        [HttpPost]
        public IActionResult Create(AccountCreateDto newAccount)
        {
          
            var account = newAccount.ToAccount();
            FakeDbContext.Accounts.Add(account);

            return Ok(account.Id);

        }


        [HttpDelete("{id:guid}")]
        public IActionResult Remove(Guid id)
        {
            if (id == Guid.Empty)
                return BadRequest("id mevcut değil");

            var account = FakeDbContext.Accounts.FirstOrDefault(a => a.Id == id);

            if (account is null)
                return NotFound();

            FakeDbContext.Accounts.Remove(account);

            return Ok(account);

        }

    }
}
