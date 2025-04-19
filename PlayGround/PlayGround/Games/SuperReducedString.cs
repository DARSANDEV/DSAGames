using System.ComponentModel.DataAnnotations;
using System.Text;
using PlayGround;

namespace PlayGround.Games;
public class SuperReducedString : Game
{
    //private const string Description = "Reduce a string of lowercase characters in range ascii[‘a’..’z’]by doing a series of operations. \n In each operation, select a pair of adjacent letters that match, and delete them.Delete as many characters as possible using this method and return the resulting string. \n If the final string is empty, return Empty String";
    public override void GameDescription(){
     
        Console.WriteLine("-------------------------------------------------------");
       Console.WriteLine("Reduce a string of lowercase characters in range ascii[‘a’..’z’] " +
                          "by doing a series of operations. In each operation, select a pair of adjacent letters " +
                          "that match, and delete them.\n");

        Console.WriteLine("Delete as many characters as possible using this method and return the resulting string. " +
                          "If the final string is empty, return 'Empty String'.\n");

        Console.WriteLine("Example:");
        Console.WriteLine("Input: aaabccddd");
        Console.WriteLine("Output: abd\n");

        Console.WriteLine("Input: baab");
        Console.WriteLine("Output: Empty String\n");
        Console.WriteLine("-------------------------------------------------------");
    }
    public override void StartGame()
    {
        Console.WriteLine( $"Starting {nameof(SuperReducedString)}");
        Console.WriteLine("Enter input:  eg: 'aaabccddd'");
        var input = Console.ReadLine();

        string result = superReducedString(input);
        System.Console.WriteLine($"result : {result}");
    }
     public static string superReducedString(string s)
    {
       var word = Reduce(s);
        return word?.Length>0 ? word.ToString() : "Empty String";
    }
    public static string Reduce(string s){
        if(s.Length <2){
            return s;
        }
        var word = new StringBuilder();
        char right = s[0];
        char current;
        for (int i =0;i<s.Length;){
            current=s[i];
            if(i== s.Length-1){
                word.Append(current);
                break;
            }
            right = s[i+1];

            if(right == current){
                i+=2;
               continue;
            }
            else{
                word.Append(current);
                i++;
            }  
            
        }
        var result = word.ToString();
        if(result == s){
            return result;
        }
        return Reduce(result);
    }
    
   
}