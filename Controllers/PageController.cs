using DBMongo;
using DBMongo.Models;
using Diplom_webAPI_REST.Models;
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
        /// Створення нової сторінки
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
                _context.CreatePageUser(u.Id, model.NewName, model.Group);
            }

            return Ok();
        }

        /// <summary>
        /// Створення тегу
        /// </summary>
        /// <returns></returns>
        [Route("CreateTag")]
        [HttpPost]
        public IActionResult CreateTag(PageTagModel model)
        {
            if (model.Group == "" || model.Group == null)
                return BadRequest("No tag");
            else
            {
                string name = User.Identity.Name;

                var u = _context.SearchUser(name);
                if (u != null)
                {
                    _context.AddTagPage(u.Id, model.IdPage, model.Group);
                }
                return Ok();
            }
        }

        /// <summary>
        /// редагування назви сторінки.
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
                _context.RenamePageUser(u.Id, model.IdPage, model.NewName, model.Group);
            }

            return Ok();
        }

        /// <summary>
        /// отримання сторінки по  id. 
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
        /// отримання списку тегів
        /// </summary>
        /// <returns></returns>
        [Route("GetTag")]
        [HttpGet]
        public IActionResult GetTag()
        {

            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                return new JsonResult(_context.GetAllTagUser(u.Id).Select(s => new GroupModel { Tag = s }).ToList());
            }

            return BadRequest("От халепа :( Спочатку авторизуйтесь");
        }


        /// <summary>
        /// пошук сторінок авторизованого користувача за назвою
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
        /// отримання всіх сторінок авторизованого користувача
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
        // [Route("Delete")]
        // [HttpDelete]
        //public IActionResult Delete(string PageId)
        //{
        //    string name = User.Identity.Name;

        //    var u = _context.SearchUser(name);
        //    if (u != null)
        //    {
        //        _context.DeletePageUser(u.Id, PageId);
        //    }
        //    return Ok();
        //}

        /// <summary>
        /// видалення сторынки авторизованого користувача по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> 
        [HttpDelete("{id}")]

        public IActionResult Delete(string id)
        {
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                _context.DeletePageUser(u.Id, id);
            }
            return Ok();
        }


        /// <summary>
        /// Видалення тегу
        /// </summary>
        /// <returns></returns>
        [Route("DeleteTag")]
        [HttpDelete]
        public IActionResult DeleteTag(PageTagModel model)
        {
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                _context.DeleteTagPage(u.Id, model.IdPage, model.Group);
            }

            return Ok();
        }
    }
}
