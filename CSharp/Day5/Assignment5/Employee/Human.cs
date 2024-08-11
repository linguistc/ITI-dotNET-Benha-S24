namespace clsEmployee
{
    public class Human
    {
        public string Name { get; set; }
        public short Age { get; set; }
        public readonly enGender gender;

        public Human()
        {
            this.Name = string.Empty;
            this.Age = -1;
            this.gender = enGender.male;
        }

        public Human(string name, short age, enGender gender)
        {
            this.Name = name;
            this.Age = age;
            this.gender = gender;
        }

    }
}
