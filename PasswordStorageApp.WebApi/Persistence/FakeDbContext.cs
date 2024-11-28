using PasswordStorageApp.WebApi.Models;

namespace PasswordStorageApp.WebApi.Persistence
{
    public static class FakeDbContext
    {

        public static List<Account> Accounts { get; set; } =
            [
              new Account
              {
                        Id=Guid.NewGuid(),
                        Username="test",
                        Password="test",
                        CreatedOn = DateTimeOffset.UtcNow,
               },
              new Account
              {
                        Id=Guid.NewGuid(),
                        Username="user",
                        Password="user",
                        CreatedOn = DateTimeOffset.UtcNow,
               },
              new Account
              {
                        Id=Guid.NewGuid(),
                        Username="xaxa",
                        Password="xaxa",
                        CreatedOn = DateTimeOffset.UtcNow,

                },

            ];




    }
}
