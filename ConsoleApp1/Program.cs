using ConsoleApp1;
using static System.Net.Mime.MediaTypeNames;

MorseCode m = new MorseCode();
Console.WriteLine(m.Encode("chobotnice"));
Console.WriteLine(m.Decode("---- --- -... --- - -. .. -.-. ."));






