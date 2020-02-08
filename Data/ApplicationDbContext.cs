﻿    using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Leave_Managment.Models;

namespace Leave_Managment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<LeaveRequest> leaveRequests { get; set; }
        public DbSet<LeaveType> leaveTypes { get; set; }
        public DbSet<LeaveAllocation> leaveAllocations { get; set; }
       
       
    }
}
