using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Classes
{
	public class GroupClass
	{
		returnMessage _return;
		Database1Entities db;
		

		public GroupClass()
		{
			_return = new returnMessage();
			db = new Database1Entities();
		}

		public int Group_Id { get; set; }
		public string Group_Name { get; set; }

		public returnMessage Get()
		{
			try
			{
				var data = db.Groups.Select(x => new GroupClass()
				{
					Group_Id = x.Group_Id,
					Group_Name = x.Group_Name,
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