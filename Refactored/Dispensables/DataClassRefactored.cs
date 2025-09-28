namespace CodeSmells.Refactored.Dispensables
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void CelebrateBirthday()
        {
            _age++;
            Console.WriteLine($"{_name} is now {_age}");
        }
    }
}