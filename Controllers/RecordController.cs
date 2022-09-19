﻿using DBMongo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;
using System;
using System.IO;

namespace MVC_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [EnableCors]
    [Authorize]
    public class RecordController : ControllerBase
    {
        private readonly RecordDBService _context;
        private readonly UserDBService _ucontext;
        private readonly PageDBService _pcontext;

        public RecordController(RecordDBService context, UserDBService ucontext, PageDBService pcontext)
        {
            _context = context;
            _ucontext = ucontext;
            _pcontext = pcontext;
        }

        /// <summary>
        /// створення запису (текст).
        /// </summary>
        /// <returns></returns>
        [Route("CreateText")]
        [HttpPost]
        public IActionResult CreateText(RecordTextModel model)
        {
            string name = User.Identity.Name;
            var u = _ucontext.SearchUser(name);
            if (u != null)
            {
                var r = _context.CreateRecordTextUser(u.Id, model.Text);
                _pcontext.AddRecordToPage(u.Id, model.PageId, r);
            }
            return Ok();
        }

        /// <summary>
        /// створення запису (посилання).
        /// </summary>
        /// <returns></returns>
        [Route("CreateUrl")]
        [HttpPost]
        public IActionResult CreateUrl(RecordTextModel model)
        {
            string name = User.Identity.Name;
            var u = _ucontext.SearchUser(name);
            if (u != null)
            {
                var r = _context.CreateRecordUrlUser(u.Id, model.Text);
                _pcontext.AddRecordToPage(u.Id, model.PageId, r);
            }
            return Ok();
        }

        /// <summary>
        /// посилання на YouTube
        /// </summary>
        /// <returns></returns>
        [Route("CreateYouTube")]
        [HttpPost]
        public IActionResult CreateYouTube(RecordTextModel model)
        {
            string name = User.Identity.Name;
            var u = _ucontext.SearchUser(name);
            if (u != null)
            {
                var r = _context.CreateRecordYouTubeUser(u.Id, model.Text);
                _pcontext.AddRecordToPage(u.Id, model.PageId, r);
            }
            return Ok();
        }

        /// <summary>
        /// створення запису (зображення). 
        /// </summary>
        /// <returns></returns>
        [Route("CreateImage")]
        [HttpPost]
        public IActionResult CreateImage([FromForm] RecordImageModel model)
        {
            MemoryStream memoryStream = new MemoryStream();
            if (model.File != null)
            {
                model.File.CopyTo(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);
            }
            string name = User.Identity.Name;

            var u = _ucontext.SearchUser(name);
            if (u != null)
            {
                var r = _context.CreateRecordImageUser(u.Id, model.File?.FileName, memoryStream);
                _pcontext.AddRecordToPage(u.Id, model.PageId, r);
            }
            return Ok();
        }

        /// <summary>
        /// створення запису (файлу). 
        /// </summary>
        /// <returns></returns>
        [Route("CreateFile")]
        [HttpPost]
        public IActionResult CreateFile([FromForm] RecordImageModel model)
        {
            MemoryStream memoryStream = new MemoryStream();
            if (model.File != null)
            {
                model.File.CopyTo(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);
            }
            string name = User.Identity.Name;

            var u = _ucontext.SearchUser(name);
            if (u != null)
            {
                var r = _context.CreateRecordFileUser(u.Id, model.File?.FileName, memoryStream);
                _pcontext.AddRecordToPage(u.Id, model.PageId, r);
            }
            return Ok();
        }

        /// <summary>
        /// редагування текстового запису. 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("Edit")]
        [HttpPut]
        public IActionResult Edit(RecordEditModel model)
        {
            string name = User.Identity.Name;
            var u = _ucontext.SearchUser(name);
            if (u != null)
            {
                _context.EditRecordUser(u.Id, model.IdRecord, model.Text, model.PageId);
                return Ok();
            }
            return BadRequest("От халепа :(");
        }

        /// <summary>
        /// -отримання текстового запису по його id. 
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        [Route("GetTextRecord")]
        [HttpGet]
        public IActionResult GetTextRecord(string recordId)
        {
            string name = User.Identity.Name;
            var u = _ucontext.SearchUser(name);
            if (u != null)
            {
                return new JsonResult(_context.GetRecordUser(u.Id, recordId));
            }
            return BadRequest("От халепа :(");
        }


        /// <summary>
        /// отримання зображення по його id.
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns></returns>
        [Route("GetImage")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetImageRecord(string imageId)
        {
            var s = _context.GetImage(imageId);
            if (s != null)
            {
                s.Seek(0, SeekOrigin.Begin);
                try { return File(s, "image/jpeg"); }
                catch { return BadRequest("От халепа :("); }
            }
            return BadRequest("От халепа :(");
        }

        /// <summary>
        /// отримання файлу по його id.
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns></returns>
        [Route("GetFile")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetFileRecord(string imageId)
        {
            // string name = User.Identity.Name;
            // var u = _ucontext.SearchUser(name);
            var s = _context.GetImage(imageId);
            if (s != null)
            {

                s.Seek(0, SeekOrigin.Begin);
                try { return File(s, "application/octet-stream", _context.GetFileName(imageId)); } 
                //try { return File(s, "image/jpeg"); }
                catch (Exception e) { return BadRequest("От халепа :("); }

            }
            return BadRequest("От халепа :(");
        }

        /// <summary>
        /// пошук всіх сторінок авторизованого користувача за заданою фразою/словом у записах
        /// </summary>
        /// <returns></returns>
        [Route("GetText")]
        [HttpGet]
        public IActionResult GetText(string str)
        {
            string name = User.Identity.Name;
            var u = _ucontext.SearchUser(name);
            if (u != null)
            {
                string[] arrayStr = str.Split(' ');
                return new JsonResult(_context.GetTextRecordUser(u.Id, arrayStr));
            }
            return BadRequest("От халепа :( Спочатку авторизуйтесь");
        }

        /// <summary>
        /// -отримання всіх записів авторизованого користувача
        /// </summary>
        /// <returns></returns>
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            string name = User.Identity.Name;
            var u = _ucontext.SearchUser(name);
            if (u != null)
            {
                return new JsonResult(_context.GetAllRecordUser(u.Id));
            }
            return BadRequest("От халепа :(");
        }

        /// <summary>
        /// видалення запису авторизованого користувача по id
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="recordId"></param>
        /// <returns></returns>
        [Route("Delete")]
        [HttpDelete]
        public IActionResult Delete(string pageId, string recordId)
        {
            string name = User.Identity.Name;

            var u = _ucontext.SearchUser(name);
            if (u != null)
            {
                _context.DeleteRecordUser(u.Id, pageId, recordId);
            }
            return Ok();
        }
    }
}
