Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") // .ToLower позволяет реагировать на string не зависимо от регистра букв в любом положении
{
    Console.WriteLine("Ура, это же Маша!");
}
else; // ";" после else позволяет, при условии TRUTH, выводить последовательно оба действия: TRUTH, затем FALSE
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}