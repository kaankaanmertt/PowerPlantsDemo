using System;

namespace PowerPlant.Application.Dto
{
    public class WebDefinitionDto
    {
        public Guid? Id { get; set; }
        public string WebId { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Good { get; set; }
        public object Value { get; set; }
    }
}
