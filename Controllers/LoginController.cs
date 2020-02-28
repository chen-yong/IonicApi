using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IonicApi.Common;
using IonicApi.Dtos;
using IonicApi.Models;
using IonicApi.Modes;
using IonicApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IonicApi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route(template: "api/Login")]
    public class LoginController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public LoginController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            //注册AutoMapper
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeUser>>> GetUsers()
        {
            var users = await _userRepository.GetUsersAsync();
            var userDtos = _mapper.Map<IEnumerable<UserDto>>(users);
            return Ok(userDtos);
        }

        public ActionResult login(string username, string password)
        {
            MapiData ret = new MapiData();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ret.retcode = 11;
            }
            else
            {
                try
                {
                    
                }
                catch { ret.retcode = 99; }

            }
            return Ok(ret);
        }
    }
}
