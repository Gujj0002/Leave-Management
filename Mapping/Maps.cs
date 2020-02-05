using AutoMapper;
using Leave_Managment.Data;
using Leave_Managment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Managment.Mapping
{
    public class Maps : Profile
    {
       public Maps()
        {
            CreateMap<LeaveType, LeaveTypeModel>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryModel>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationModel>().ReverseMap();
            CreateMap<LeaveAllocation, EditLeaveAllocationVM>().ReverseMap();
            CreateMap<Employee, EmployeeModel>().ReverseMap();
        }
    }
}
