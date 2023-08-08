using ProjCB;
namespace ProjCB.Tests;

public class CBTests
{
    [Fact]
    public void TestMessageResponse()
    {
        //Arrange
        string Message="";
        ChatBot CBObj = new ChatBot();
        //Act
        Message = CBObj.send("Hi");
        //Assert
        Assert.Equal("Hi How are you Akila",Message);
    }
}