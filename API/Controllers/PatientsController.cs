using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/patients")]
    public class PatientsController : ControllerBase
    {
        private readonly IDoctorRepository _docOnlineRepository;
        
        public PatientsController(IDoctorRepository docOnlineRepository)
        {
            _docOnlineRepository = docOnlineRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            return Ok(await _docOnlineRepository.GetPatients());
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatient(int id)
        {
            return Ok(await _docOnlineRepository.GetPatient(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatient([FromQuery]string firstName,string lastName,
            string email,string bloodGroup,string dateOfBirth,int mobile,string imgUrl,string address)
        {
            _docOnlineRepository.AddPatient(firstName, lastName, email, bloodGroup, dateOfBirth, mobile,
              imgUrl, address);
            await _docOnlineRepository.SaveAsync();
            return Ok("done");
        }

        [HttpGet("patientId")]
        public async Task<IActionResult> GetPatientId()
        {
            var id = await _docOnlineRepository.GetPatientId();
            return Ok(id);
        }
    }
}
