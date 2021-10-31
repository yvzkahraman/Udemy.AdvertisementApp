using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Dtos.Interfaces;

namespace Udemy.AdvertisementApp.Dtos.AppRoleDtos
{
    public class AppRoleCreateDto : IDto
    {
        public string Definition { get; set; }
    }
}
