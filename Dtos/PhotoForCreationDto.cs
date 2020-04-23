using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dating.Dtos
{
    public class PhotoForCreationDto
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }  // photo that we're uploading
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }  // what we get back from cloudinary

        public PhotoForCreationDto()
        {
            DateAdded = DateTime.Now;
        }
    }
}
