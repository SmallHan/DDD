﻿// <autogenerated>
//   This file was generated by T4 code generator Bbing_Template.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Text;
using System.Threading.Tasks;
using Bbing.Domain.IRepositories;
using Bbing.Domain.Model;
using Bbing.Domain.Service;

namespace Bbing.Service.Services.Mongo
{
	public partial class TB_MENUService :  MongoBaseService<TB_MENU>, ITB_MENUService
	{
	      public TB_MENUService(ITB_MENUService Service)
          {
              SetCurrentService(Service);
          }
	}
}
