using PasswordStorageApp.WebApi.Models;
using System.ComponentModel.DataAnnotations;

namespace PasswordStorageApp.WebApi.Dtos
{
    public class AccountCreateDto
    {
        [Required,MinLength(5),MaxLength(40)]
        public string Username { get; set; }

        [Required, MinLength(5), MaxLength(40)]
        public string Password { get; set; }



        public Account ToAccount()
        {

            return new Account
            {
                Id = Ulid.NewUlid().ToGuid(),
                Username = Username,
                Password = Password,
                CreatedOn = DateTimeOffset.UtcNow
            };

        }
    }
}
