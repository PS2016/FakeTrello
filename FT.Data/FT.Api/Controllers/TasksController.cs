﻿using FT.Api.Model;
using FT.Data;
using FT.Services;
using System;
using System.Web.Http;

namespace FT.Api.Controllers
{
    [VersionRoute("tasks")]
    public class TasksController : ApiController
    {
        private TaskService _service;
        public TasksController(TaskService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("getall")]
        public async System.Threading.Tasks.Task<ListResponse<TaskApiModel>> GetAll()
        {
            return new ListResponse<TaskApiModel> { Items = await _service.GetAllAsync() };
        }

        [HttpDelete]
        public async System.Threading.Tasks.Task<bool> Delete(Guid Id)
        {
            return await _service.DeleteAsync(Id);
        }


        [HttpPost]
        public async System.Threading.Tasks.Task<ModelResponse<TaskApiModel>> Create(TaskApiModel model)
        {
            return new ModelResponse<TaskApiModel> { Item = await _service.CreateAsync(model) };
        }

        [HttpPut]
        public async System.Threading.Tasks.Task<ModelResponse<TaskApiModel>> Put(TaskApiModel model)
        {
            return new ModelResponse<TaskApiModel> { Item = await _service.UpdateAsync(model) };
        }
    }
}
