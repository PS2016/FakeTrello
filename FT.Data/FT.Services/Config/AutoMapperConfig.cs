using AutoMapper;
using FT.Api.Model;
using FT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Services.Config
{
    public static class AutoMapperConfig
    {
        public static IMapper Mapper;

        public static void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                #region Task

                cfg.CreateMap<Data.Task, TaskApiModel>();
                   
                cfg.CreateMap<TaskApiModel, Data.Task>();

                #endregion


                #region User

                cfg.CreateMap<User, UserApiModel>();

                cfg.CreateMap<UserApiModel, User>();

                #endregion

                #region TaskComments

                cfg.CreateMap<TaskComment, TaskCommentApiModel>();

                cfg.CreateMap<TaskCommentApiModel, TaskComment>();

                #endregion

            });

            Mapper = config.CreateMapper();
        }
    }
}
