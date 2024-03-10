using System.Reflection;

namespace DZ3.repo
{
	public class Repository
	{
		public void Repo(List<string> person)
		{
            // Не могу понять как без принудительного указания пути для вновь
			// создаваемого файла отразить его в solution
            // если указать только наименование файл то он 
			// сохраняется в папке bin\Debug\net7.0
            // подскажите как правильно указать путь
            string path = ("/Users/maksimmakarov/Desktop/GB/Исключения в программировании и их обработка/DZ/DZ3/DZ3/" + person[0] + ".txt");
			try
            {
				using (StreamWriter sw = new StreamWriter(path,true))
				{
					for (int i = 0; i < person.Count; i++)
					{
						sw.Write("<" + person[i] + "> "); 
                    }
                    sw.Write("\n");
					person.Clear();
                }
			}
			catch(IOException e)
			{
				Console.WriteLine(e.GetType().Name + "\n" + e.ToString());
			}
        }
	}
}

