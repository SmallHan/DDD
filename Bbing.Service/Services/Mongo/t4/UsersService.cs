﻿// <autogenerated>
//   This file was generated by T4 code generator Bbing_Template.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bbing.Domain.IRepositories;
using Bbing.Domain.Model;
using Bbing.Domain.Service;

namespace Bbing.Service.Services.Mongo
{
	public partial class  UsersService:MongoBaseService< Users>,IUsersService 
	{
		public UsersService(IUsersRepository repository)
		{
			this.CurrentRepository = repository;
		}
		public IUsersRepository CurrentRepository { get; set; }
	}
}
