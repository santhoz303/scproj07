using ProjCB;
namespace ProjCB.Tests;

public class CBTests
{
    [Fact]
    public void TestMessageResponse()
    {
        ChatBot CBObj = new ChatBot();
        //Arrange
        //Act
        string message = CBObj.Send("Hi");
        //Assert
        Assert.Equal("Hi How are you Akila",message);
    }
    [Fact]
    public void TestMessageResponseisHowCanIHelp()
    {
        //Arrange
        ChatBot CBObj = new ChatBot();
        //Act
        string message = CBObj.Sendmsg("Help");
        //Assert
        Assert.Equal("How Can I Help!",message);
    }
}