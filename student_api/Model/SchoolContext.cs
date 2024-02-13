﻿using Microsoft.EntityFrameworkCore;

namespace student_api.Model
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public SchoolContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
