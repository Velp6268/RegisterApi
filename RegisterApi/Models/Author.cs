using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.Extensions.DependencyInjection;
using RegisterApi;

namespace RegisterApi
{
    public class Author
    {
        public Author(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Author()
        {
           
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}