using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DataAccessFactory
    {
        public static IRepo<User, string, User> UserDate()
        {
            return new UserRepo();
        }

        public static IRepo<UserDetails, int, bool> UserDetailsData()
        {
            return new UserDetailsRepo();
        }
        public static IRepo<UserAcademicInfo, int, bool> UserAcademicData()
        {
            return new AcademicInfoRepo();
        }

        public static IRepo<JobApply, int, bool> JobApplyData()
        {
            return new JobApplyRepo();
        }
    }
}
