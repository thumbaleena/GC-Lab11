namespace LabNumber11
{
    internal class Person
    {
        public Person(string name, string address)
        {
            getName = name;
            getAddress = address;
        }

        public string getName { get; }

        public string getAddress { get; set; }

        public override string ToString()
        {
            return "Person: " + getName + ", " + getAddress;
        }
    }
}