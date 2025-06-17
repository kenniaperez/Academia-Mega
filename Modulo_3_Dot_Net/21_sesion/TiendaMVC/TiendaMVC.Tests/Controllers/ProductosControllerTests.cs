using Xunit;
using Moq;
using TiendaMVC.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using TiendaMVC.Controllers;
using TiendaMVC.Models;

public class ProductosControllerTests
{
    [Fact]
    public async Task Index_ReturnsViewWithProductList()
    {
        var mockAPI = new Mock<ApiClient>();
        mockAPI.Setup(s => s.GetProductosAsync())
            .ReturnAsync(new List<Producto>
            {
                new Producto{  Id=1, Nombre="iPhone 16 Pro Max", Precio = 30000.00M}
            });

        var moqObj = new ProductosController(mockAPI.Object);

        var result = await mockObj.Index();

        //Assert
        result.Should().BeOfType<ViewResult>()
            .Which.Model.Should().BeAssignableTo<IEnumerable<Producto>>()
            .And.As<IEnumerable<Producto>>()
            .Should().HaveCount(1);
    }
}