using System.Globalization;

namespace DZ3.impl
{
	public class PersonInfo
	{
        string name;
        string bDate;
        char gender;
        long phone;

        public string GetBirthday()
        {
            bDate = Console.ReadLine();
            try
            {
                if (!DateTime.TryParseExact(bDate, "dd.MM.yyyy", CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out var date))
                    throw new FormatException("Неверный формат даты");
                if (date > DateTime.Now)
                    throw new FormatException("Введённая дата больше текущей");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e);
                throw;
            }
            return bDate;
        }

        public string GetName()
        {
            name = Console.ReadLine();
            try
            {
                if (String.IsNullOrEmpty(name)) throw new FormatException("Поле не должно быть пустым");
                if (!name.All(char.IsLetter))
                {
                    throw new FormatException("Введены символы отличные от буквенных");
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e);
                throw;
            }
            return name;
        }

        public char GetGender()
        {
            try
            {
                gender = char.Parse(Console.ReadLine().ToLower());
                if (gender == 'm' || gender == 'f' || gender == 'м') ;
                else throw new FormatException("Введены не допустимые значения"); 
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                throw;
            }
            return gender;
        }

        public long GetPhoneNumber()
        {
            // Не стал делать проверку на кол-во цифр в номере так как кол-во их бывает разное
            try
            {
                phone = long.Parse(Console.ReadLine());
                if (phone < 0 || phone.Equals(0)) throw new FormatException("Введены не допустимые значения");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e);
                throw;
            }
            return phone;
        }
    }
}

