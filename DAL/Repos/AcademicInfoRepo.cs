using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AcademicInfoRepo : Repo, IRepo<UserAcademicInfo, int, bool>
    {
        public bool Create(UserAcademicInfo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserAcademicInfo> Read()
        {
            return db.AcademicInfo.ToList();
        }

        public UserAcademicInfo Read(int id)
        {
            return db.AcademicInfo.Find(id);
        }

        public bool Update(UserAcademicInfo obj)
        {
            throw new NotImplementedException();
        }
    }
}
