using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProject.Models;

namespace WebAppProject.Mapp
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, IndexUserDTO>();
        }
    }
}
