using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Classes;

namespace WebAPI.Controllers
{
    public class GroupController : ApiController
    {
		GroupClass group;

		public GroupController()
		{
			group = new GroupClass();
		}

		public returnMessage Get()
		{
			return group.Get();
		}
	}
}
