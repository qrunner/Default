using System;
using System.Linq;
using Accounting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Model.Test
{
    [TestClass]
    public class TestContext
    {
        [TestMethod]
        public void Test()
        {
            PrepareDatabase();
            MeasureUnits();
            UnitCategories();
            Units();
            DocumentTypes();
            Companies();
            Sites();
            Documents();
            Entries();
            Contractors();
        }

        public void PrepareDatabase()
        {
            // Create database if not exists
            using (var contextDb = new Context())
            {
                contextDb.Database.Delete();
                contextDb.Database.CreateIfNotExists();
            }
        }

        public void MeasureUnits()
        {
            using (var ctx = new Context())
            {
                ctx.MeasureUnits.Add(new MeasureUnit {Name = "Килограмм", ShortName = "кг."});
                ctx.MeasureUnits.Add(new MeasureUnit {Name = "Литр", ShortName = "л."});
                ctx.MeasureUnits.Add(new MeasureUnit {Name = "Штука", ShortName = "шт."});
                ctx.MeasureUnits.Add(new MeasureUnit {Name = "Фейк", ShortName = "фк."});
                ctx.SaveChanges();

                var fakeMu = ctx.MeasureUnits.Single(x => x.ShortName == "фк.");
                fakeMu.Name = "Fake MU";
                ctx.SaveChanges();

                ctx.MeasureUnits.Remove(ctx.MeasureUnits.Single(x => x.Name == "Fake MU"));
                ctx.SaveChanges();
            }
        }

        public void UnitCategories()
        {
            using (var ctx = new Context())
            {
                var raw = ctx.UnitCategories.Add(new UnitCategory {Name = "Сырье", Parent = null});
                ctx.UnitCategories.Add(new UnitCategory {Name = "Мука", Parent = raw});
                ctx.UnitCategories.Add(new UnitCategory {Name = "Начинка", Parent = raw});
                ctx.SaveChanges();

                var mill = ctx.UnitCategories.Single(x => x.Parent == null).ChildItems.Single(x => x.Name == "Мука");
                var contents = ctx.UnitCategories.Single(x => x.Parent == null).ChildItems.Single(x => x.Name == "Начинка");
                Assert.IsNotNull(mill);
                Assert.IsNotNull(contents);
            }
        }

        public void Units()
        {
            using (var ctx = new Context())
            {
                var kg = ctx.MeasureUnits.Single(x => x.ShortName == "кг.");
                var mills = ctx.UnitCategories.Single(x => x.Parent == null).ChildItems.Single(x => x.Name == "Мука");
                var mill1 = ctx.Units.Add(new Unit {Name = "Мука ржаная", MeasureUnit = kg, IsRaw = true, IsProduct = false, UnitCategory = mills});
                var mill2 = ctx.Units.Add(new Unit {Name = "Мука пшеничная", MeasureUnit = kg, IsRaw = true, IsProduct = false, UnitCategory = mills});
                ctx.SaveChanges();
            }
        }

        public void Sites()
        {
            using (var ctx = new Context())
            {
                ctx.Sites.Add(new AccountingSite {Name = "Склад", Company = ctx.Companies.First()});
                ctx.Sites.Add(new AccountingSite {Name = "Пекарня сырьё", Company = ctx.Companies.First()});
                ctx.Sites.Add(new AccountingSite {Name = "Пекарня продукция", Company = ctx.Companies.First()});
                ctx.SaveChanges();
            }
        }

        public void DocumentTypes()
        {
            using (var ctx = new Context())
            {
                ctx.DocumentTypes.Add(new DocumentType {Name = "Приходная накладная", Operation = OperationType.Income});
                ctx.DocumentTypes.Add(new DocumentType {Name = "Расходная накладная", Operation = OperationType.Outcome});
                ctx.DocumentTypes.Add(new DocumentType {Name = "Акт инвентаризации", Operation = OperationType.Income});
                ctx.DocumentTypes.Add(new DocumentType {Name = "Акт на списание", Operation = OperationType.Outcome});
                ctx.SaveChanges();
            }
        }

        public void Documents()
        {
            using (var ctx = new Context())
            {
                var docTypes = ctx.DocumentTypes.ToArray();
                ctx.Documents.Add(new Document {Date = DateTime.Now, Number = 1, Type = docTypes[0], Site = ctx.Sites.First()});
                ctx.Documents.Add(new Document {Date = DateTime.Now, Number = 2, Type = docTypes[1], Site = ctx.Sites.First()});
                ctx.Documents.Add(new Document {Date = DateTime.Now, Number = 3, Type = docTypes[2], Site = ctx.Sites.First()});
                ctx.Documents.Add(new Document {Date = DateTime.Now, Number = 4, Type = docTypes[3], Site = ctx.Sites.First()});
                ctx.SaveChanges();
            }
        }

        public void Entries()
        {
            using (var ctx = new Context())
            {
                ctx.Sites.First().Income(new UnitEntry {Count = 15, Price = 16, Unit = ctx.Units.First()}, new Operation {Document = ctx.Documents.First(), Date = DateTime.Now});
                ctx.Sites.First().Outcom(new UnitEntry {Count = 10, Price = 154, Unit = ctx.Units.First()}, new Operation {Document = ctx.Documents.First(), Date = DateTime.Now});
                ctx.SaveChanges();
            }
        }

        public void Contractors()
        {
            using (var ctx = new Context())
            {
                ctx.Contractors.Add(new Contractor {Name = "OOO Ромашка", IsClient = true});
                ctx.Contractors.Add(new Contractor {Name = "ЗАO Дубок", IsSupplier = true});
                ctx.Contractors.Add(new Contractor {Name = "ПАО Грибок", IsSupplier = true, IsClient = true});
                ctx.Contractors.Add(new Contractor {Name = "Честное лицо", IsClient = true});
                ctx.SaveChanges();
            }
        }

        public void Companies()
        {
            using (var ctx = new Context())
            {
                ctx.Companies.Add(new Company {Name = "OOO Современные пищевые технологии"});
                ctx.Companies.Add(new Company {Name = "ИП Дорофеева"});
                ctx.SaveChanges();
            }
        }
    }
}