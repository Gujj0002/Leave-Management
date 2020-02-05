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
        public DbSet<LeaveHistory> leaveHistories { get; set; }
        public DbSet<LeaveType> leaveTypes { get; set; }
        public DbSet<LeaveAllocation> leaveAllocations { get; set; }
        public DbSet<Leave_Managment.Models.LeaveTypeModel> LeaveTypeModel { get; set; }
        public DbSet<Leave_Managment.Models.EmployeeModel> EmployeeModel { get; set; }
        public DbSet<Leave_Managment.Models.LeaveAllocationModel> LeaveAllocationModel { get; set; }
        public DbSet<Leave_Managment.Models.EditLeaveAllocationVM> EditLeaveAllocationVM { get; set; }
    }
}
