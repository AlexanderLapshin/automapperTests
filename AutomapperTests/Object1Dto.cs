using System;
using System.Collections.Generic;
using System.Text;

namespace AutomapperTests
{
    public class Object1Dto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }
        public string Address { get; set; }
        public string Rules { get; set; }
        public Guid UserId { get; set; }
        public Guid CreatorId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
