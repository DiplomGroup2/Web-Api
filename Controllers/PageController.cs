using DBMongo;
using DBMongo.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class PageController : ControllerBase
    {
        private readonly DBService _context;

        public PageController(DBService context)
        {
            _context = context;
        }

        /// <summary>
        /// создание стика(документа). Обов'язкова авторизація
        /// </summary>
        /// <returns></returns>
        [Route("Create")]
        [HttpPost]
        public IActionResult Create(PageRenameModel model)
        {
            //throw new NotImplementedException();
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                _context.CreatePageUser(u.Id, model.NewName, "");
            }

            return Ok();
        }

        /// <summary>
        /// редагування імені/назви стіку. Id  поки що копіюю з бази. Обов'язкова авторизація
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("Rename")]
        [HttpPut]
        public IActionResult Rename(PageRenameModel model)
        {
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                _context.RenamePageUser(u.Id, model.IdPage, model.NewName);
            }

            return Ok();
        }

        ///// <summary>
        ///// редагування стіку - додавання записів. 
        ///// </summary>
        ///// <param name="model"></param>
        ///// <param name="PageId"></param>

        ///// <returns></returns>
        //[Route("Edit")]
        //[HttpPut]
        //public IActionResult Edit(string PageId, RecordModel model)
        //{
        //    string name = User.Identity.Name;

        //    var u = _context.SearchUser(name);
        //    if (u != null)
        //    {
        //        Record r = new Record()
        //        { Id= model.IdRecord,Text= model.Text,RecordType= RecordType.Text};
        //        _context.AddRecordToPage(u.Id, PageId, r);
        //    }

        //    return Ok();
        //}

        /// <summary>
        /// отримання стіку по його id. (брати з бази)
        /// </summary>
        /// <param name="PageId"></param>
        /// <returns></returns>
        [Route("GetPage")]
        [HttpGet]
        public IActionResult GetPage(string PageId)
        {
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                return new JsonResult(_context.GetPageUser(u.Id, PageId));
            }

            return BadRequest("От халепа :(");
        }


        /// <summary>
        /// пошук стіку авторизованого користувача за назвою
        /// </summary>
        /// <returns></returns>
        [Route("GetName")]
        [HttpGet]
        public IActionResult GetName(string str)
        {

            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                string[] arrayStr = str.Split(' ');

                return new JsonResult(_context.GetNamePageUser(u.Id, arrayStr));
            }

            return BadRequest("От халепа :( Спочатку авторизуйтесь");
        }

        /// <summary>
        /// отримання всіх стіків авторизованого користувача
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
                return new JsonResult(_context.GetAllPageUser(u.Id));
            }

            return BadRequest("От халепа :(");
        }

        /// <summary>
        /// видалення стіку авторизованого користувача по id
        /// </summary>
        /// <param name="PageId"></param>
        /// <returns></returns>
        [Route("Delete")]
        [HttpDelete]
        public IActionResult Delete(string PageId)
        {
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                _context.DeletePageUser(u.Id, PageId);
            }
            return Ok();
        }

    }
}
