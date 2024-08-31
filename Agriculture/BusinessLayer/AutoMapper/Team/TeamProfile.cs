using AutoMapper;
using Entitylayer.Concrete;
using Entitylayer.DTOs.Team;

namespace BusinessLayer.AutoMapper.Team
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<TeamResultDto, Entitylayer.Concrete.Team>().ReverseMap();
        }
    }

}
