using Microsoft.AspNet.Identity.EntityFramework;

namespace OrisCenter.Key.Models
{
    public class UsuarioAplicacao : IdentityUser
    {
        public string NomeCompleto { get; set; }
    }
}