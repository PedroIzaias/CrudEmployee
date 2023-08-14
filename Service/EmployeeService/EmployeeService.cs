using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DataContext;
using WebApi.Models;

namespace WebApi.Service.EmployeeService
{
    public class EmployeeService : IEmployeeInterface
    {
        private readonly ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<ServiceResponse<List<EmployeeModel>>> CreateEmployee(EmployeeModel newEmployee)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<EmployeeModel>>> DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<EmployeeModel>> GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<EmployeeModel>>> GetEmployees()
        {
            ServiceResponse<List<EmployeeModel>> serviceResponse = new ServiceResponse<List<EmployeeModel>>();

            try
            {
                serviceResponse.Data = _context.Employees.ToList();

                if (serviceResponse.Data.Count == 0) 
                {
                    serviceResponse.Message = "No data found!";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Success = false;
            }

            return serviceResponse;
        }

        public Task<ServiceResponse<List<EmployeeModel>>> InactiveEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<EmployeeModel>>> UpdateEmployee(EmployeeModel editEmployee)
        {
            throw new NotImplementedException();
        }
    }
}