using System.ComponentModel.DataAnnotations;
using PlayGround;

namespace PlayGround.Games;
public class MergeSort : Game
{
    List<int> _SearchArray = new List<int>{34,45,23,45,97,12,75,99,33,57,68,49,83};
    public override void StartGame()
    {
         System.Console.WriteLine( "Starting Sorting");
         int[] arr= _SearchArray.ToArray();

    }
    
    public void MSorting(int[] arr,int leftIndex,int rightIndex)
    {
        if(rightIndex > leftIndex){
            int middlePoint = (leftIndex + rightIndex)/2;
            MSorting(arr,leftIndex,middlePoint);
            MSorting(arr,middlePoint,rightIndex);

        }
    }
    
    public void Merge(int[] arr, int leftIndex, int middlePoint, int rightIndex)
    {

    }
}