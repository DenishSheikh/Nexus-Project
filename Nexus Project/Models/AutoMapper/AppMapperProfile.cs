using AutoMapper;
using Nexus_Project.Models.DTO;

namespace Nexus_Project.Models.AutoMapper
{
    public class AppMapperProfile :Profile
    {
        public AppMapperProfile() 
        {
            CreateMap<BillingDto, Billing>();
            
        }
    }
}
