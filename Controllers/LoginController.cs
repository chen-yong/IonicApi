using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IonicApi.Common;
using IonicApi.Config;
using IonicApi.Dtos;
using IonicApi.Models;
using IonicApi.Modes;
using IonicApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IonicApi.Controllers
{
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

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> LoginAsync(string username, string password)
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
                    PeUser user = await _userRepository.GetUserAsync(username, AuthtokenUtility.md5(password));
                    if (user != null)
                    {
                        if (user.UserIdentity01 == AppConstants.UserStatus.Forbiden)
                        {
                            ret.retcode = 12;
                            ret.message = ret.debug = "该帐号已经被禁用";
                        }
                        else
                        {
                            if (user.UserIdentity03 == AppConstants.UserType.Student) 
                            {
                                ret.retcode = 0;
                                ret.authtoken = AuthtokenUtility.Create(user.Id, 24 * 30); //60天过期
                                ret.info = new
                                {
                                    name = user.RealName,
                                    gender = user.Sex,
                                    cls = user.Property00,
                                    phone = user.Mobile,
                                    email = user.Email,
                                    qq = user.Property05,
                                    addr = user.Address,
                                    zipcode = user.Zip,
                                    showQuestionMenu = Initialization.ShowQuestionRedo,
                                    testNumberLabel = Initialization.TestNumberLabel
                                };
                            }
                            else if (user.UserIdentity03 == AppConstants.UserType.Teacher)
                            {
                                ret.retcode = 0;
                                ret.authtoken = AuthtokenUtility.Create(user.Id, 24 * 30); //60天过期
                                ret.info = new
                                {
                                    name = user.RealName,
                                    gender = user.Sex,
                                    phone = user.Mobile,
                                    email = user.Email,
                                    qq = user.Property05,
                                    addr = user.Address,
                                    zipcode = user.Zip,
                                    showQuestionMenu = Initialization.ShowQuestionRedo,
                                    testNumberLabel = Initialization.TestNumberLabel
                                };
                            }
                            else
                            {
                                ret.retcode = 12;
                                ret.message = ret.debug = "用户类型与应用类型不符合";
                            }
                        }
                    }
                    else
                    {
                        ret.retcode = 12;
                        ret.message = ret.debug = "用户验证失败";
                    }
                }
                catch { ret.retcode = 99; }
            }
            return Ok(ret);
        }
        
    }
}
