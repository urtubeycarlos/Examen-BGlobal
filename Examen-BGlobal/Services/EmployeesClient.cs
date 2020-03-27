using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Examen_BGlobal.Services
{
    public class EmployeesClient
    {

        private RestClient _client;
        private dynamic _result;
        public EmployeesClient()
        {
            _client = new RestClient("http://dummy.restapiexample.com/api/v1/employees");
            _result = _client.GetObject();

        }

        public List<string> GetEmployees()
        {
            List<string> ret = new List<string>();

            var listOfEmployees = _result.data;

            for (int i = 0; i < listOfEmployees.Count; i++)
            {
                var obj = listOfEmployees[i].employee_name;
                ret.Add(obj.ToString());
            }

            return ret;
        }

    }
}