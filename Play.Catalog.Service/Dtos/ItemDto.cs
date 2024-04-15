using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Catalog.Service.Dtos
{
    public class ItemDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }

        public ItemDto(Guid id, string name, string description, decimal price, DateTime createdDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            CreatedDate = createdDate;

        }

    }

    public class CreateItemDto
    {
        // public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }

        public CreateItemDto(string name, string description, decimal price, DateTime createdDate)
        {

            Name = name;
            Description = description;
            Price = price;
            CreatedDate = createdDate;

        }

    }

    public class UpdateItemDto
    {
        // public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }

        public UpdateItemDto(string name, string description, decimal price, DateTime createdDate)
        {

            Name = name;
            Description = description;
            Price = price;
            CreatedDate = createdDate;

        }

    }
}