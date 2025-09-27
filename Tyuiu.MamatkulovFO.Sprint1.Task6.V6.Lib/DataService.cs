using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MamatkulovFO.Sprint1.Task6.V6.Lib;


public class DataService: ISprint1Task6V6
{
  
    public string RemoveFirstLetterFromEachWord(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        var words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        var resultWords = words.Select(word => word.Length > 1 ? word.Substring(1) : "");

        return string.Join(" ", resultWords);
    }

    string ISprint1Task6V6.DeleteFirstLetter(string value)
    {
        throw new NotImplementedException();
    }
}