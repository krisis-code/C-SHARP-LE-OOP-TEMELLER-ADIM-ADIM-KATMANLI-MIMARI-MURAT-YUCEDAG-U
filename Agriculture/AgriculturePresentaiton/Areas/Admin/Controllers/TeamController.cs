using AutoMapper;
using BusinessLayer.Abstract;
using Entitylayer.DTOs.Team;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentaiton.Areas.Admin.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _service;
        private readonly IMapper _mapper;

        public TeamController(ITeamService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var teams = await _service.TGetListAsync(); // Bu method Team nesnelerini döndürür
            var teamDtos = _mapper.Map<List<TeamResultDto>>(teams); // AutoMapper ile dönüşüm yapın

            return View(teamDtos); // View'a TeamResultDto nesnelerini gönderin
        }

    }
}
