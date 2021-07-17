using API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/patients/{Id}/appointments")]
    public class AppointmentsController :ControllerBase
    {
        private readonly IDoctorRepository _docOnlineRepository;

        public AppointmentsController(IDoctorRepository docOnlineRepository)
        {
            _docOnlineRepository = docOnlineRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserCredentials(int Id)
        {

            return Ok(await _docOnlineRepository.GetAppointments(Id));
        }
    }
}
