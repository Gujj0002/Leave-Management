using AutoMapper;
using Leave_Managment.Data;
using Leave_Managment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Managment.Mapping
{
    public class Mapper : Profile
    {
       public Mapper()
        {
            CreateMap<LeaveType, LeaveTypeModel>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeModel>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryModel>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationModel>().ReverseMap();
            CreateMap<Employee, EmployeeModel>().ReverseMap();
        }
    }
}
