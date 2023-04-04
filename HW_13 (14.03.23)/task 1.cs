using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<string> words = new List<string> { "морква", "броколі", "помідор", "огірок", "картопля", "цибахі", "перець" };
string maxWord = words.OrderByDescending(w => w.Length).ThenBy(w => w).FirstOrDefault();
Console.WriteLine("Максимальне по довжині слово: " + maxWord);
