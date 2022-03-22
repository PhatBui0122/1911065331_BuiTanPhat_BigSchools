using _1911065331_BuiTanPhat_BigSchools.DTOs;
using _1911065331_BuiTanPhat_BigSchools.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1911065331_BuiTanPhat_BigSchools.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;
        public FollowingsController() { _dbContext = new ApplicationDbContext(); }

        //commit lusc 13h20 ngay 22/03

        public IHttpActionResult Follow(FollowingDto  followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FolloweeId == userId && f.FolloweeId == followingDto.FolloweedId))
                return BadRequest("The Attendance already exists!");
            var folowing = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolloweedId

            };

            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();

            return Ok();
        }

    }
}
