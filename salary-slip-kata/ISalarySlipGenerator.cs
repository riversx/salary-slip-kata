using System;
namespace salaryslipkata
{
    public interface ISalarySlipGenerator
    {
        SalarySlip GenerateFor(Employee employee);
    }
}
