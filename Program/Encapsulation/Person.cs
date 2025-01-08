namespace Program.Encapsulation
{
    internal struct Person
    {
        #region Attributes

        private string name;
        private byte age;

        #endregion

        #region Constractor

        public Person(string _Name, byte _Age)
        {
            name = _Name;
            age = _Age;
        }

        #endregion

        #region Methods
        public string Name 
        {
            get 
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public byte Age 
        {
            get 
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        #region overrides

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }

        #endregion
        #endregion
    }
}
