using System;

namespace aspnetcorebackend.Models.Dtos
{
    public class DepartmentDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Head { get; set; }
        public string Code { get; set; }
    }
}