using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Classes;


namespace WebAPI.Controllers
{
    public class MemberController : ApiController
    {
		MemberClass member;

		public MemberController()
		{
			member = new MemberClass();
		}

		public returnMessage Get()
		{
			return member.Get();
		}
	}
}
