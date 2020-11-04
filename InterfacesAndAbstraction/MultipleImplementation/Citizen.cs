namespace PersonInfo
{
    public class Citizen : IBirthable
    {
        public string Id { get; set; }
        public string Birthdate { get; set; }
        private string name;
        private int age;

        public Citizen(string name, int age, string id, string birthDate)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
            this.Birthdate = birthDate;
        }
    }
}
