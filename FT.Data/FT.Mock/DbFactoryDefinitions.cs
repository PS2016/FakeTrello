
using FT.Data;
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
            factory.Define<User>(u =>
            {
                u.Email = MockString.GetEmail();
                u.FirstName = MockString.GetName();
                u.LastName = MockString.GetName();
                u.Id = Guid.NewGuid();
                u.LastLogin = new DateTime();
            });

            factory.Define<Data.Task>(d =>
            {
              
               
                d.Id = Guid.NewGuid();
                d.Priority = Data.Priority.High;
                d.State = Data.State.InProgress;
                d.Title = "title";
                d.Type = Data.Type.UserStory;
            });

            factory.Define<TaskComment>(dm =>
            {
                var user = factory.Create<User>();
                var d = factory.Create<Data.Task>();
                dm.DateCreated = DateTime.Now;
                dm.TaskId = d.Id;
                dm.Id = Guid.NewGuid();
                dm.UserId = user.Id;
            });
        }
    }
}
