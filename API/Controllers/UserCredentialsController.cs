using API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class UserCredentialsController : ControllerBase
    {
        private readonly IDoctorRepository _docOnlineRepository;

        public UserCredentialsController(IDoctorRepository docOnlineRepository)
        {
            _docOnlineRepository = docOnlineRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserCredentials([FromQuery] string email,int password)
        {
            return Ok(await _docOnlineRepository.GetUserCredentials(email,password));
        }

        [HttpGet("getpatientid")]
        public async Task<IActionResult> GetPatientId([FromQuery] string email)
        {
            return Ok(await _docOnlineRepository.GetPatientIdByEmail(email));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserCredentials([FromQuery] string email, int password,int patientId)
        {
            _docOnlineRepository.AddUserCredentials(email, password, patientId);
            await _docOnlineRepository.SaveAsync();
            return Ok("done");
        }
    }
}
