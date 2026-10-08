namespace LeetCode.Solution.StringSol.Character;

public class DetectCapitalUseSolution
{
    public static bool DetectCapitalUse(string word)
    {
        string wordCap = word.ToUpper();
        string wordLow = word.ToLower();
        string wordF = string.Concat(wordCap.AsSpan(0, 1), wordLow.AsSpan(1));
        return word == wordCap || word == wordLow || word == wordF;
    }
}