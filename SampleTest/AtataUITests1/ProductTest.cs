using SampleProject.PageObjectModel;
using NUnit.Framework;
using System;
using System.Linq;
using Atata;

namespace SampleProject
{
    
    public class ProductTest : UITestFixture
    {
        decimal totalPrice=570;
        long totalAmount = 245;

        [SetUp]
        public void LoginAndNavigateToProductPage()
        {
        Login();
        }

        [Test,Order(2)]
        public void DeleteUsingJSConfirm()
        {
            Go.To<ProductsPage>(url: "/products").Header.Should.Equal("Products")
            .Products.Rows.Count.Get(out int count).AggregateAssert(page => page
            .Products.Rows[x => x.Name == "Armchair"].DeleteUsingJSConfirm.Click()
            .Products.Rows[x => x.Name == "Armchair"].Should.Not.BePresent()
            .Products.Rows.Count.Should.Equal(count - 1).Products.Rows.Select(x => x.Price.Get()).ToArray().Sum().ToSutSubject().Should.Equal(totalPrice)).
             Products.Rows.Select(x => x.Amount.Value).ToArray().Sum().ToSutSubject().Should.Equal(totalAmount);
            Thread.Sleep(5000);
        }

        [Test, Order(1)]
        public void DeleteUsingBSModelConfirm()
        {
            Go.To<ProductsPage>(url: "/products").Header.Should.Equal("Products")
           .Products.Rows.Count.Get(out int count).AggregateAssert(page => page
            .Products.Rows[x => x.Name == "Armchair"].DeleteUsingBSModel()
            .Products.Rows[x => x.Name == "Armchair"].Should.Not.BePresent()
            .Products.Rows.Count.Should.Equal(count - 1).Products.Rows.Select(x => x.Price.Get()).ToArray().Sum().ToSutSubject().Should.Equal(totalPrice))
            .Products.Rows.Select(x => x.Amount.Value).ToArray().Sum().ToSutSubject().Should.Equal(totalAmount);
            Thread.Sleep(5000);

        }


        [Test, Order(3)]
        public void DeleteUsingJqueryConfirm()
        {
            Go.To<ProductsPage>(url: "/products").Header.Should.Equal("Products")
           .Products.Rows.Count.Get(out int count).AggregateAssert(page => page
            .Products.Rows[x => x.Name == "Armchair"].DeleteUsingJQuery()
            .Products.Rows[x => x.Name == "Armchair"].Should.Not.BePresent()
            .Products.Rows.Count.Should.Equal(count - 1).Products.Rows.Select(x => x.Price.Get()).ToArray().Sum().ToSutSubject().Should.Equal(totalPrice))
            .Products.Rows.Select(x => x.Amount.Value).ToArray().Sum().ToSutSubject().Should.Equal(totalAmount);
            Thread.Sleep(5000);
        }

    }
}
