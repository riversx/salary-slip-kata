using NUnit.Framework;
using System;
namespace salaryslipkata.test
{
    [TestFixture()]
    public class SalaryGeneratorTest
    {
        [Test()]
        public void GenerateSalaryForJohnDoeWithAnnualGrosSalaryOf_5000pound()
        {
            Employee johnDoe = new Employee() {
                ID = 12345,
                Name = "John Doe",
                AnnualGrossSalary = 5000.00m
            };
            ISalarySlipGenerator generator = new SalarySlipGenerator();

            SalarySlip salarySlip = generator.GenerateFor(johnDoe);

            Assert.NotNull(salarySlip);
            Assert.AreEqual(12345, salarySlip.EmployeeID);
            Assert.AreEqual("John Doe", salarySlip.EmployeeName);
            Assert.AreEqual(416.67, salarySlip.MonthlyGrossSalary);
        }

    }
}
