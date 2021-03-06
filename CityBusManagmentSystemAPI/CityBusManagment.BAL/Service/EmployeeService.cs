using CityBusManagment.DAL.Repository;
using CityBusManagment.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CityBusManagment.BAL.Service
{
    public class EmployeeService
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void AddEmployeeDetails(Employee employeedetails)
        {
            _employeeRepository.AddEmployeeDetails(employeedetails);
        }
        public void DeleteEmployeeDetails(int empNo)
        {
            _employeeRepository.DeleteEmployeeDetails(empNo);
        }
        public void UpdateEmployeeDetails(Employee employeedetails)
        {
            _employeeRepository.UpdateEmployeeDetails(employeedetails);
        }
        public void GetEmployeeNo(int empNo)
        {
            _employeeRepository.GetEmployeeNo(empNo);
        }
        public IEnumerable<Employee> GetEmployeeDetails()
        {
            return _employeeRepository.GetEmployeeDetails().ToList();
        }
    }
}
