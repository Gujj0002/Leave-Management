using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Managment.Models
{
    public class LeaveHistoryModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("RequestingEmployeeId")]
        public EmployeeModel RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveTypeModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public IEnumerable<SelectListItem>  LeaveTypes { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        [ForeignKey("ApprovedById")]
        public EmployeeModel ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
    }
}

