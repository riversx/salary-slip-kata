using NUnit.Framework;
using System;
namespace salaryslipkata.test
{
    [TestFixture()]
    public class SalaryGeneratorTest
    {
        [Test()]
        public void GenerateSalary()
        {
            Employee johnDoe = new Employee();
            ISalarySlipGenerator generator = new SalarySlipGenerator();

            SalarySlip salarySlip = generator.GenerateFor(johnDoe);

            Assert.NotNull(salarySlip);
        }

    }
}
