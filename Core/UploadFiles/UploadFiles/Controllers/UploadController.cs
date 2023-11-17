using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UploadFiles.Models;

namespace UploadFiles.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult Index()
        {
            SingleFileModel sm = new SingleFileModel();
            return View(sm);
        }

        [HttpPost]
        public IActionResult Upload(SingleFileModel model)
        {
            if(ModelState.IsValid)
            {
                model.IsResponse = true;

                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                //get the file extension
                FileInfo fileinfo = new FileInfo(model.FileName);
                string filename = model.FileName + fileinfo.Extension;

                string filewithpath = Path.Combine(path, filename);

                using (var stream = new FileStream(filewithpath, FileMode.Create))
                {
                    model.File.CopyTo(stream);
                }
                model.IsSuccess = true;
                model.Message = "File Uploaded Successfully";
            }
            return View("Index", model);
        }

        public IActionResult MultiFiles()
        {
            MultipleFileModel model = new MultipleFileModel();
            return View(model);
        }

        [HttpPost]

        public IActionResult MultiFiles(MultipleFileModel model)
        {
            if(ModelState.IsValid)
            {
                model.IsResponse = true;
                if(model.File.Count > 0)
                {
                    foreach (var file in model.File)
                    {

                        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");

                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);

                        string filewithpath = Path.Combine(path, file.FileName);

                        using (var stream = new FileStream(filewithpath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }
                        model.IsSuccess = true;
                        model.Message = "Files Uploaded Successfully";
                    }
                else
                {
                    model.IsSuccess = false;
                    model.Message = "Please Select Files";
                }
                }
            return View("MultiFiles", model);
            }
        }

    }

