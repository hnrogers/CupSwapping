 
namespace TempProjects
 {
 class Primary
 {
    static void Main()
    {
        Working h = new Working();
        string[] moves = { "AB", "BB", "CA", "CC" };
        System.Console.WriteLine(h.CupSwap(moves));

    }
 }
 }