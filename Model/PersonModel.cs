namespace Test.Model
{
    public class PersonModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Objects { get; set; }
        public class PersonDetail
        {
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
        }
        public PersonDetail Detail { get; set; }
    }
}