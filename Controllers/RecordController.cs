﻿using DBMongo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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
        /// створення запису (текст).
        /// </summary>
        /// <returns></returns>
        [Route("CreateText")]
        [HttpPost]
        public IActionResult CreateText( RecordTextModel model)
        {

            
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                var r = _context.CreateRecordTextUser(u.Id, model.Text);
                _context.AddRecordToPage(u.Id, model.PageId, r);

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

            var u = _context.SearchUser(name);
            if (u != null)
            {
                var r = _context.CreateRecordUrlUser(u.Id, model.Text);
                _context.AddRecordToPage(u.Id, model.PageId, r);

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
            //throw new NotImplementedException();
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                var r = _context.CreateRecordImageUser(u.Id, model.File?.FileName, memoryStream);
                _context.AddRecordToPage(u.Id, model.PageId, r);

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
            //throw new NotImplementedException();
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                var r = _context.CreateRecordFileUser(u.Id, model.File?.FileName, memoryStream);
                _context.AddRecordToPage(u.Id, model.PageId, r);

            }

            return Ok();
        }


        ///// <summary>
        ///// создание записи (пока только текст). Обов'язкова авторизація
        ///// </summary>
        ///// <returns></returns>
        //[Route("Create")]
        //[HttpPost]
        //public IActionResult Create([FromForm] RecordTextModel model)
        //{

        //    MemoryStream memoryStream = new MemoryStream();
        //    if (model.File != null)
        //    {
        //        model.File.CopyTo(memoryStream);
        //        memoryStream.Seek(0, SeekOrigin.Begin);
        //    }
        //    //throw new NotImplementedException();
        //    string name = User.Identity.Name;

        //    var u = _context.SearchUser(name);
        //    if (u != null)
        //    {
        //        var r = _context.CreateRecordUser(u.Id, model.Text, model.File?.FileName, memoryStream);
        //        _context.AddRecordToPage(u.Id, model.PageId, r);

        //    }

        //    return Ok();
        //}

        /// <summary>
        /// редагування текстового запису. 
        /// </summary>
        /// <remarks>
        /// Для поля RecordType - 0, якщо текст; 1 - якщо малюнок 
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("Edit")]
        [HttpPut]
        public IActionResult Edit(RecordEditModel model)
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
        /// отримання текстового запису по його id. 
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        [Route("GetTextRecord")]
        [HttpGet]
        public IActionResult GetTextRecord(string recordId)
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
        /// отримання зображення по його id.
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns></returns>
        [Route("GetImage")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetImageRecord(string imageId)
        {
            // string name = User.Identity.Name;
                        // var u = _context.SearchUser(name);
            var s = _context.GetImage(imageId);
            if (s != null)
            {
                s.Seek(0, SeekOrigin.Begin);
                //try { return File(s, "application/octet-stream"); }
                try { return File(s, "image/jpeg"); }
                catch(Exception e) { return BadRequest("От халепа :("); }
                          
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
            // var u = _context.SearchUser(name);
            var s = _context.GetImage(imageId);
            if (s != null)
            {
                s.Seek(0, SeekOrigin.Begin);
                try { return File(s, "application/octet-stream"); }
                //try { return File(s, "image/jpeg"); }
                catch (Exception e) { return BadRequest("От халепа :("); }

            }
            return BadRequest("От халепа :(");
        }



        /// <summary>
        /// пошук всіх записів авторизованого користувача за заданою фразою/словом
        /// </summary>
        /// <returns></returns>
        [Route("GetText")]
        [HttpGet]
        public IActionResult GetText(string str)
        {

            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                string[] arrayStr = str.Split(' ');

                return new JsonResult(_context.GetTextRecordUser(u.Id, arrayStr));
            }

            return BadRequest("От халепа :( Спочатку авторизуйтесь");
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

        /// <summary>
        /// видалення запису авторизованого користувача по id
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        [Route("Delete")]
        [HttpDelete]
        public IActionResult Delete(string recordId)
        {
            string name = User.Identity.Name;

            var u = _context.SearchUser(name);
            if (u != null)
            {
                _context.DeleteRecordUser(u.Id, recordId);
            }
            return Ok();
        }
    }
}
