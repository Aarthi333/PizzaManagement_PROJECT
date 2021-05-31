using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

//[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

//[assembly: Guid("e268daf6-9845-4f8f-8f23-c9bebbb2ad70")]
namespace day27_API2.Models
{
    public class CustomerContext : DbContext
    {

        public CustomerContext() : base()
        {

        }
        public CustomerContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }   
        public DbSet<OrderDetails> Orders { get; set; }
    }
}


