using System;
using System.Collections.Generic;
using System.Text;

namespace AutomapperTests
{
    public class Object1
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

        public Object1()
        {
            Id = Guid.NewGuid();
            Name = Guid.NewGuid().ToString();
            Type = Guid.NewGuid().ToString();
            Count = 55555555;
            Address = Guid.NewGuid().ToString();
            Rules = Guid.NewGuid().ToString();
            UserId = Guid.NewGuid();
            CreatorId = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
            UpdatedDate = DateTime.UtcNow;
        }
    }
}
