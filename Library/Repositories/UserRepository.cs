using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library.Repositories
{
    public static class UsersRepositoriy
    {
        public static readonly HashSet<User> Users= new() {new User(Guid.Parse("0cbc19bc-0882-4572-8f2f-b5919b303bed"),"Adam","Smith") };
        public static User GetUser(Guid id)
        {
            return Users.SingleOrDefault(x => x.Id == id) ?? throw new Exception($"User with Id {id} not found");
        }
    }
    
}
