using System;
namespace salaryslipkata
{
    public class SalarySlipGenerator : ISalarySlipGenerator
    {
        public SalarySlipGenerator()
        {
        }

        public SalarySlip GenerateFor(Employee employee)
        {
            SalarySlip salarySlip = new SalarySlip();
            salarySlip.EmployeeID = employee.ID;
            salarySlip.EmployeeName = employee.Name;
            salarySlip.MonthlyGrossSalary = Math.Round(employee.AnnualGrossSalary / 12, 2);
            return salarySlip;
        }
    }
}