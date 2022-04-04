using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class User
    {

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        [Column(TypeName ="jsonb")]
        public List<UserAutritry>  Autriry { get; set; }
    }   
    
    public class UserAutritry
    {
        public Guid GroupKey { get; set; }
        public List<Guid> AutriryKeys { get; set; }
    }
}