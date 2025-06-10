namespace DesafioFundamentos.Models
{
    class Car
    {
        public Car(string licensePlate)
        {
            LicensePlate = licensePlate;
        }

        private string _licensePlate;

        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value.Count() == 6 || value.Count() == 7)
                    _licensePlate = value;
            }
        }
    }
}