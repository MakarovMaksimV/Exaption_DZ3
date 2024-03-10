using DZ3.impl;
using DZ3.repo;

namespace DZ3
{
    public class View
	{
        List<string> list = new List<string>();
        PersonInfo person = new PersonInfo();
		Repository repository = new Repository();

        public void Person()
		{
			while (true)
			{
				Console.Write("Введите Фамилию: ");
				list.Add(person.GetName());

				Console.Write("Введите Имя: ");
				list.Add(person.GetName());

				Console.Write("Введите Отчество: ");
				list.Add(person.GetName());

				Console.Write("Введите пол (m/f) : ");
				list.Add(person.GetGender().ToString());

				Console.Write("Введите дату рождения формата dd.mm.yyyy: ");
				list.Add(person.GetBirthday());

				Console.Write("Введите номер телефона: ");
				list.Add(person.GetPhoneNumber().ToString());

				repository.Repo(list);

                Console.WriteLine("Для выхода введите exit ,для продолжения нажмите Enter");
			string input = Console.ReadLine().ToLower();
			if (input == "exit") break;
			}
		}
	}
}

