using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class JobApplyRepo : Repo, IRepo<JobApply, int, bool>
    {
        public bool Create(JobApply obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<JobApply> Read()
        {
            throw new NotImplementedException();
        }

        public JobApply Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(JobApply obj)
        {
            throw new NotImplementedException();
        }
    }
}
