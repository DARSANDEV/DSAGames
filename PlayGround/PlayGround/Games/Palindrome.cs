using PlayGround;
public class Palindrome : Game
{
    public override void StartGame()
    {
        Console.WriteLine("Enter the word : ");
        string word = Console.ReadLine();
        var isPalindrome = CheckPalindrom(word) ? "is": "is not";
        Console.WriteLine($" The word {word} {isPalindrome} Palindrome");
    }

    public override void GameDescription(){
        var msg = "Check whether given word is palindrome or not";
        Console.WriteLine(msg);
    }
    public bool CheckPalindrom( string str)
    {
        str = str.ToLower().Replace(" ","");
        int left = 0;
        int right =str.Length-1;
        while (left<right)
        {
            if(str[left] != str[right])
                return false;
            left ++;
            right --;
        }
        return true;  
    }
}