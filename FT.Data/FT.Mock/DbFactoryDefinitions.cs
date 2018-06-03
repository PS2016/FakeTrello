using FT.Api.Model;
using FT.Mock.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace FT.Mock
{
    public static class DbFactoryDefinitions
    {
        public  static void Configure(DbFactory factory)
        {
            factory.Define<UserApiModel>(u =>
            {
                u.Email = MockString.GetEmail();
                u.FirstName = MockString.GetName();
                u.LastName = MockString.GetName();

              
                u.Id = Guid.NewGuid();
            });

            factory.Define<TaskApiModel>(d =>
            {
                var user = factory.Create<UserApiModel>();

                d.Id = Guid.NewGuid();



            });

            factory.Define<TaskCommentApiModel>(dm =>
            {
                var d = factory.Create<TaskApiModel>();
                dm.DateCreated = DateTime.Now;
                dm.TaskId = d.Id;

                dm.Id = Guid.NewGuid();
            });
        }
    }
}
