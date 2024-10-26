namespace LeetCode;

public class RomanToIntClass
{
    [Test]
    public void TestCase1()
    {
        var res = RomanToInt("MCMXCIV");
        Assert.That(res, Is.EqualTo(1994));
    }
    
    private static Dictionary<char, int> _romanNumMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    private char[] _romanNumbers = [];
    
    public int RomanToInt(string s)
    {
        _romanNumbers = s.ToCharArray();
        return RomanToInt(0, 0, 0);
    }

    private int RomanToInt(int i, int previousAmount, int total)
    {
        if (i == _romanNumbers.Length) return total;
        
        int amount = _romanNumMap[_romanNumbers[i]];
        if (previousAmount == 0 || previousAmount >= amount) total += amount;
        else total -= 2 * previousAmount - amount;
        return RomanToInt(i + 1, amount, total);
    }
}