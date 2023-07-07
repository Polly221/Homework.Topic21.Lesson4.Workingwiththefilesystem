using System.IO;

Console.Write("Введите путь к файлу/папке: ");
string path = Console.ReadLine()!;

if (AskForConfirmation())
{
    try
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("Файл успешно удален.");
        }
        else if (Directory.Exists(path))
        {
            Directory.Delete(path, true);
            Console.WriteLine("Папка успешно удалена.");
        }
        else
        {
            Console.WriteLine("Файл/папка по указанному пути не существует.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ошибка при удалении файла или папки: " + ex.Message);
    }
}
else
{
    Console.WriteLine("Удаление отменено пользователем.");
}

Console.ReadLine();
        

        static bool AskForConfirmation()
{
    Console.Write("Вы уверены, что хотите удалить файл или папку? (да/нет): ");
    string answer = Console.ReadLine()!;

    return (answer == "да");
}