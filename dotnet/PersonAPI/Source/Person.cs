﻿using Microsoft.EntityFrameworkCore;

namespace PersonAPI.Source
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; } = true;
    }
}
