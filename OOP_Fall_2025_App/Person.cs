namespace OOP_Fall_2025
{
    internal class Person
    {
        public string Name { get; }
        public string Email { get; }
        public string ID { get; }

        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            ID = id;
        }
    }
}
