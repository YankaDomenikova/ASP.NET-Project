namespace Application.Models
{
    using System;

    public class BaseModel
    {
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString().Substring(0, 20);
        }

        public string Id { get; set; }
    }
}
