using DBMongo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [EnableCors]
    [Authorize]
    public class RecordController : ControllerBase
    {
        private readonly DBService _context;

        public RecordController(DBService context)
        {
            _context = context;
        }

        /// <summary>
        /// создание записи (пока только текст). Обов'язкова авторизація
        /// </summary>
        /// <returns></returns>
        [Route("Create")]
        [HttpPost]
        public IActionResult Create(RecordModel model)
        {
            //throw new NotImplementedException();
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                _context.CreateRecordUser(u.Id, model.Text);
            }

            return Ok();
        }

        /// <summary>
        /// редагування запису. Id запису поки що копіюю з бази. Обов'язкова авторизація
        /// </summary>
        /// <remarks>
        /// Для поля RecordType - 0, якщо текст; 1 - якщо малюнок (малюнки не працюють)
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("Edit")]
        [HttpPut]
        public IActionResult Edit(RecordModel model)
        {
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                _context.EditRecordUser(u.Id, model.IdRecord, model.Text);
            }

            return Ok();
        }
        /// <summary>
        /// отримання запису по його id. (брати з бази)
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        [Route("GetRecord")]
        [HttpGet]
        public IActionResult GetRecord(string recordId)
        {
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                return new JsonResult(_context.GetRecordUser(u.Id, recordId));
            }

            return BadRequest("От халепа :(");
        }

        /// <summary>
        /// отримання всіх записів авторизованого користувача
        /// </summary>
        /// <returns></returns>
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {

            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                return new JsonResult(_context.GetAllRecordUser(u.Id));
            }

            return BadRequest("От халепа :(");
        }

        [Route("Delete")]
        [HttpDelete]
        public IActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
