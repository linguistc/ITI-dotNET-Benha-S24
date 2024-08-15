namespace Assignment9.PublisherSubscriber
{
    public class Thermostat
    {
        public event Action<float> OnTempChanged;

        private float _temp;

        public Thermostat(float temp)
        {
            this._temp = temp;
        }

        public float CurrentTemp
        {
            get => this._temp;

            set
            {
                if (this._temp != value)
                {
                    this._temp = value;
                    OnTempChanged?.Invoke(this._temp);
                }
                
            }
        }
    }
}
