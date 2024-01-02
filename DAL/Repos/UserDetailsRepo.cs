using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserDetailsRepo : Repo, IRepo<UserDetails, int, bool>
    {
        public bool Create(UserDetails obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserDetails> Read()
        {
            return db.UsersDetails.ToList();
        }

        public UserDetails Read(int id)
        {
            return db.UsersDetails.Find(id);
        }

        public bool Update(UserDetails obj)
        {
            throw new NotImplementedException();
        }
    }
}
