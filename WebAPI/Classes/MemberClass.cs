using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Classes
{
	public class MemberClass
	{
		returnMessage _return;
		Database1Entities db;


		public MemberClass()
		{
			_return = new returnMessage();
			db = new Database1Entities();
		}


		public int Member_Id { get; set; }
		public Nullable<int> Group_Id { get; set; }
		public string Member_Name { get; set; }
		public Nullable<int> Score { get; set; }

		public returnMessage Get()
		{
			try
			{
				var data = db.Member.Select(x => new MemberClass()
				{
					Member_Id = x.Member_Id,
					Group_Id = x.Group_Id,
					Member_Name = x.Member_Name,
					Score = x.Score

				}).ToList();

				_return.items = data;
				_return.code = 200;
			}
			catch (Exception e)
			{
				_return.code = 401;
				_return.message = e.Message;
			}
			return _return;
		}
	}
}