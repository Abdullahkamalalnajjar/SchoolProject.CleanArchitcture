﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Mapping.Students.Queres.Moduls;

namespace SchoolProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("/ Student/List")]
        public async Task<IActionResult> GetStudentList()
        {
            var Response = await _mediator.Send(new GetStudentListQuerey());
            return Ok(Response);
        }
    }
}
