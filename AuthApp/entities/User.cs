using Microsoft.AspNetCore.Identity;

namespace AuthApp.entities
{
    public class User:IdentityUser
    {
        string nom;

        public string Nom { get => nom; set => nom = value; }
    }
}
