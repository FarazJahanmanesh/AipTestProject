using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos.Post
{
    public class AddPostDetailDto
    {
        public bool IsDeleted { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public long UserId { get; set; }
    }
}
