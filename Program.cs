 
namespace TempProjects
 {
 class Primary
 {
    static void Main()
    {
        Working h = new Working();
        string[] moves = { "AB", "CA", "CC" };
        System.Console.WriteLine(h.CupSwap(moves));

    }
 }
 }