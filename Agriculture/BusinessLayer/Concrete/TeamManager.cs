using BusinessLayer.Abstract;
using DataAcccessLayer.Abstract;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeamManager : GenericManager<Team> , ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal) : base(teamDal)
        {
            _teamDal = teamDal;
        }

        
    }
}
