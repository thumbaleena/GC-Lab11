namespace PersonClasses
{
    internal class Student : Person
    {
        public Student(string name, string address, string program, int year, double fee)
            : base(name, address)
        {
            getProgram = program;
            getYear = year;
            getFee = fee;
        }

        public string getProgram { get; set; }

        public int getYear { get; set; }

        public double getFee { get; set; }

        public override string ToString()
        {
            return "Person: " + getName + ", " + getAddress + ", " + getProgram + ", " + getYear + ", " + getFee;
        }
    }
}