using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace UploadFiles.Models
{
    public class MultipleFileModel :ResponseModel
    {
        [Required(ErrorMessage = "Please Select File")]
        public List<IFormFile> File { get; set; }
    }
}
