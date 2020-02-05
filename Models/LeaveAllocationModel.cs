    using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Managment.Models
{
    public class LeaveAllocationModel
    {
        public int Id { get; set; }
      
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }
        [ForeignKey("EmployeeId")]
        public EmployeeModel Employee { get; set; }
        public string EmployeeId { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveTypeModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        
    }
    public class CreateLeaveAllocationVM
    {
        public int NumberUpdated { get; set; }
        public List<LeaveTypeModel> LeaveTypes { get; set; }
    }

    public class EditLeaveAllocationVM
    {   
        public int Id { get; set; }

        public EmployeeModel Employee { get; set; }
        public string EmployeeId { get; set; }
        [Display(Name = "Number Of Days")]
        [Range(1, 50, ErrorMessage = "Enter Valid Number")]
        public int NumberOfDays { get; set; }
        public LeaveTypeModel LeaveType { get; set; }

    }

    public class ViewAllocationsVM
    {
        public EmployeeModel Employee { get; set; }
        public string EmployeeId { get; set; }
        public List<LeaveAllocationModel> LeaveAllocations { get; set; }
    }
}

