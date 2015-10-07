using System;
using System.Linq;
using Bakery.UI;
using Bakery.UI.Commands;
using Fortius.Gui;
using Fortius.Inventory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Model.Test
{
    [TestClass]
    public class TestUiModels
    {
        public TestUiModels()
        {
            //ModelRoutes.Register();
        }

        [TestMethod]
        public void TestNamedEntity()
        {
            var companiesViewModel = new Reference<Company>();
            var companyCount = companiesViewModel.GridSource.Count;
            var company = new Company {Name = StringGenerator.Generate(10)};
            companiesViewModel.GridSource.Add(company);
            companiesViewModel.GridSource.ResetBindings();
            companiesViewModel.Commands.Single(x => x.GetType() == typeof (SaveCommand)).Execute(null);

            using (var ctx = new Context())
                Assert.AreEqual(companyCount + 1, ctx.Companies.Count());

            companiesViewModel.Selected = company;

            companiesViewModel.Commands.Single(x => x.GetType() == typeof (DeleteCurrent<Company>)).Execute(null);
            companiesViewModel.Commands.Single(x => x.GetType() == typeof (SaveCommand)).Execute(null);

            using (var ctx = new Context())
                Assert.AreEqual(companyCount, ctx.Companies.Count());
        }

        [TestMethod]
        public void SiteIncome()
        {

        }

        [TestMethod]
        public void SiteOutcom()
        {

        }
    }
}