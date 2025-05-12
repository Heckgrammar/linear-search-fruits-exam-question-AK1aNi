namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };
    		Console.WriteLine("What fruit would you like to find: ");
    		string user_fruit = Console.ReadLine();
    		bool found = false ; 
    		foreach(string fruit in fruits)
    		{
    				if (fruit == user_fruit)
    				{
    					found = true;
    				}
    		}	
    		if (found==true)
    		{
    			Console.WriteLine("Word is found");
    		}
    		else{
    			Console.WriteLine("Word is not found");
    		}
            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found
            
            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
        }
    }
}
