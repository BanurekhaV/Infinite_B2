using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UploadFiles.Models
{
    public class SingleFileModel : ResponseModel
    {
        [Required(ErrorMessage ="Please Enter File Name")]
        public string FileName { get; set; }
        [Required(ErrorMessage ="Please Select File")]
        public IFormFile File { get; set; }
    }
}
