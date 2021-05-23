using System.IO;

namespace FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // File.Copy(@"E:\DotNet\CSharp_Fundamentals\13. For Each\Program.cs", @"E:\DotNet\CSharp_Fundamentals\a.cs");

            var path = @"E:\DotNet\CSharp_Fundamentals\a.cs";
            File.Delete(path);


        }
    }
}
