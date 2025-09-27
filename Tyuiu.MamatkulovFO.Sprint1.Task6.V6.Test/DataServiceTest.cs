using Tyuiu.MamatkulovFO.Sprint1.Task6.V6.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task6.V6.Test;


public class DataServiceTest
{
    private readonly DataService _service = new();

    [Fact]
    public void RemoveFirstLetterFromEachWord_NormalText_ReturnsCorrectResult()
    {
        string input = "Hello World CSharp";
        string expected = "ello orld Sharp";
        string actual = _service.RemoveFirstLetterFromEachWord(input);
        Assert.AreEqual(expected, actual);
    }

    [Fact]
    public void RemoveFirstLetterFromEachWord_SingleLetterWords_ReturnsEmptyStrings()
    {
        string input = "I am A";
        string expected = "  "; 
        
        string actual = _service.RemoveFirstLetterFromEachWord(input);
        Assert.AreEqual("m", actual);
    }

    [Fact]
    public void RemoveFirstLetterFromEachWord_EmptyInput_ReturnsEmpty()
    {
        string actual = _service.RemoveFirstLetterFromEachWord("");
        Assert.AreEqual("", actual);
    }

    [Fact]
    public void RemoveFirstLetterFromEachWord_OnlySpaces_ReturnsEmpty()
    {
        string actual = _service.RemoveFirstLetterFromEachWord("   ");
        Assert.AreEqual("", actual);
    }
}