namespace CarLib
{
    public class Car
    {
        private int _id;
        private string _make;
        private string _model;
        private int _year;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Id must be a positive integer.");
                }


                _id = value;
            }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private int Year
        {
            get { return _year; }
            set
            {
                if (value < 1886 || value > System.DateTime.Now.Year + 1)
                {
                    throw new System.ArgumentOutOfRangeException("Year must be between 1886 and next year.");
                }
            }
        }


        public Car(int id, string make, string model, int year)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
        }


    }
}
