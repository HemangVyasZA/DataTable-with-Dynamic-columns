using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ReturnData
    {
        public  List<KeyValuePair<string, string>> Columns { get; set; }
        public dynamic Data { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/Employee
        [HttpGet]
        public ActionResult<dynamic> Get(bool isDetailReequired)
        {
            return isDetailReequired ? GetEmployeesWithExtraDetails() : GetEmployeesWithBasicDetails();
        }

        private ActionResult<dynamic> GetEmployeesWithBasicDetails()
        {
            //your data
            var employees = new List<object>
            {
                new {Name="abcdefg", DateOfJoin=new DateTime(1980, 12, 2).ToString("dd/MM/yyyy"), Salary= "23000.3"},
                new {Name="qwkeridkdk", DateOfJoin= new DateTime(1990, 5, 9).ToString("dd/MM/yyyy"), Salary="50000.23"},
                new {Name="qifeyshh", DateOfJoin= new DateTime(2010, 11, 13).ToString("dd/MM/yyyy"),Salary= "78000.26"},
                new {Name="xdkfads",  DateOfJoin=new DateTime(2011, 2, 28).ToString("dd/MM/yyyy"),Salary= "120000.56"},
                new {Name="abcdefg", DateOfJoin= new DateTime(2000, 7, 11).ToString("dd/MM/yyyy"), Salary="963323.21"}
            };

            //collection need for data table header
            var columns = new List<object>
            {
                new {data="name", title="Name"},
                new {data="dateOfJoin", title="Date Of Join"},
                new {data="salary", title="salary"},
             
            };
          
            //return data and columns
            var  data = new  {Columns = columns, Data = employees};
            return data;
          
        }
        private ActionResult<dynamic> GetEmployeesWithExtraDetails()
        {
            //your data
            var employees = new List<object>
            {
                new {Name="abcdefg", DateOfJoin=new DateTime(1980, 12, 2).ToString("dd/MM/yyyy"),Salary= "23000.3",Department="HR",IsHead="false",EmployeeType="Permanent"},
                new {Name="qwkeridkdk",DateOfJoin= new DateTime(1990, 5, 9).ToString("dd/MM/yyyy"), Salary="50000.23",Department="IT",IsHead="true",EmployeeType="Temporary"},
                new {Name="qifeyshh", DateOfJoin=new DateTime(2010, 11, 13).ToString("dd/MM/yyyy"),Salary= "78000.26",Department="Marketing",IsHead="true",EmployeeType="Permanent"},
                new {Name="xdkfads", DateOfJoin=new DateTime(2011, 2, 28).ToString("dd/MM/yyyy"), Salary="120000.56",Department="IT",IsHead="false",EmployeeType="Temporary"},
                new {Name="abcdefg", DateOfJoin=new DateTime(2000, 7, 11).ToString("dd/MM/yyyy"),Salary= "963323.21",Department="Finance",IsHead="false",EmployeeType="Permanent"},
            };
            //collection need for data table header

            var columns = new List<object>
            {
                new {data="name", title="Name"},
                new {data="dateOfJoin", title="Date Of Join"},
                new {data="salary", title="Salary"},
                new {data="department", title="Department"},
                new {data="isHead", title="Is Head"},
                new {data="employeeType", title="Employee Type"}
            };


            //return data and columns
            var  data = new  {Columns = columns, Data = employees};
            return data;
        }
        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
