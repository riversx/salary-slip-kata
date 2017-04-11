using System;
namespace salaryslipkata
{

    public class UKSalarySlipGenerator: SalarySlipGenerator
        public SalarySlip GenerateFor(Employee employee)
        {
            return new SalarySlip();
        }
    }
}