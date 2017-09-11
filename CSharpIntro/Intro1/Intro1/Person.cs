namespace Intro1
{
    public class Person
    {
        public const int MaxPersons = 10;
        private static int s_personCount = 0;

        public Person()
            :this(string.Empty)  // constructor initializer
        { }

        public Person(string firstName)
        {
            _firstName = firstName;
            s_personCount++;

        }

        //public static int PersonCount
        //{
        //    get => s_personCount;
        //}
        public static int PersonCount => s_personCount;  // property mit get accessor, C# 6

        private string _firstName; // field

        public string FirstName  // property
        {
            get  // get accessor
            {
                return _firstName;
            }
            set  // set accessor
            {
                _firstName = value;
            }
        }

        public string LastName { get; set; }  // auto property

        private int _age;

        public int Age
        {
            get => _age;  // C# 7
            set => _age = value;
        }

    }
}
