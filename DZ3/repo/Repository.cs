using System.Reflection;

namespace DZ3.repo
{
	public class Repository
	{
		public void Repo(List<string> person)
		{
            // Не могу понять как без принудительного указания пути вновь
            // созданный файл появлялся в solution, вариант пути указанный ниже сохраняет файлв в папке bin\Debug\net7.0
            // подскажите как правильно указать путь
            try
            {
                string path = Path.Combine(Path.GetDirectoryName(Assembly.
				GetExecutingAssembly().Location),person[0] + ".txt");

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

