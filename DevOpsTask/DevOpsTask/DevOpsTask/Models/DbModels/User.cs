using Microsoft.AspNetCore.Identity;

namespace DevOpsTask.Models.DbModels
{
    public class User : IdentityUser
    {
        public string Role { get; set; } = null;
    }
}
