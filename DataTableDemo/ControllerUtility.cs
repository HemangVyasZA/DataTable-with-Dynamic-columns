using System;
using System.Collections.Generic;
using DataTableDemo.Models;

namespace DataTableDemo
{
    public static class ControllerUtility
    {
        public static List<EmployeeVm> GetEmployee()
        {
            return new List<EmployeeVm>
            {
                new EmployeeVm
                {
                    Id = 1,
                    Name = "John Doe",
                    DateOfJoin = new DateTime(1985, 12, 12),
                    IsHod = true,
                    Salary = 9856523.45m,
                    EmployeeType = "Permanent",
                    Department = "HR"
                },
                new EmployeeVm
                {
                    Id = 2,
                    Name = "John Wick",
                    DateOfJoin = new DateTime(1995, 5, 15),
                    IsHod = false,
                    Salary = 10021.12m,
                    EmployeeType = "Temporary",
                    Department = "HR"
                },
                new EmployeeVm
                {
                    Id = 3,
                    Name = "Sundar Pichayi",
                    DateOfJoin = new DateTime(2010, 7, 24),
                    IsHod = true,
                    Salary = 18541973.78m,
                    EmployeeType = "Permanent",
                    Department = "IT"
                },
                new EmployeeVm
                {
                    Id = 4,
                    Name = "Tom cruise",
                    DateOfJoin = new DateTime(2000, 9, 11),
                    IsHod = false,
                    Salary = 5945684.11m,
                    EmployeeType = "Temporary",
                    Department = "IT"
                },
                new EmployeeVm
                {
                    Id = 5,
                    Name = "Daniel Craig",
                    DateOfJoin = new DateTime(2011, 6, 4),
                    IsHod = true,
                    Salary = 7541286.89m,
                    EmployeeType = "Permanent",
                    Department = "Finance"
                },
                new EmployeeVm
                {
                    Id = 6,
                    Name = "Satya Nadela",
                    DateOfJoin = new DateTime(1986, 11, 17),
                    IsHod = false,
                    Salary = 3574856.72m,
                    EmployeeType = "Temporary",
                    Department = "Marketing"
                },
                new EmployeeVm
                {
                    Id = 7,
                    Name = "Bill Gates",
                    DateOfJoin = new DateTime(2013, 2, 25),
                    IsHod = true,
                    Salary = 68742598.46m,
                    EmployeeType = "Permanent",
                    Department = "Marketing"
                }
            };
        }
    }
}