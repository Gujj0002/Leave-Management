using Leave_Managment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Managment.Contracts
{
    interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        ICollection<LeaveAllocation> GetEmployeesByLeaveAllocation(int id);
    }
}
