using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DotNetTaskDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new
            {
                Name = "Islam fathy",
                Age = 22,
                Skill = ".Net Developer"
            };
            string json= JsonConvert.SerializeObject(person);
            Console.WriteLine(json);
        }
    }
}
