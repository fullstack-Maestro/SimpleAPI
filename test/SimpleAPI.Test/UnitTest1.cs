using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    ValuesController controller = new ValuesController();
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get(5);
        Assert.Equal("Jayxun Furkatovich", returnValue.Value);
    }
}