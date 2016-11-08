namespace PersonClasses
{
    internal class Staff : Person
    {
        public Staff(string name, string address, string school, double pay)
            : base(name, address)
        {
            getSchool = school;
            getPay = pay;
        }

        public string getSchool { get; set; }

        public double getPay { get; set; }

        public override string ToString()
        {
            return "Person: " + getName + ", " + getAddress + ", " + getSchool + ", " + getPay;
        }
    }
}