using AuthAPI.Models;

namespace AuthAPI.Interfaces
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeesDetails();
        public Employee AddEmployee(Employee employee);


    }
}
