using System.Runtime.CompilerServices;

namespace Assignment9.PublisherSubscriber
{
    public class Cooler
    {
        private float _temp;
        Thermostat _thermostat;

        public float Temp
        {
            get => this._temp;
            set => this._temp = value;
        }
        public Cooler(float temp)
        {
            this._temp = temp;
        }

        public void TempChanged(float newTemp)
        {
            if (newTemp > this._temp)
                Console.WriteLine("Cooler On...");
            else
                Console.WriteLine("Cooler Of....");
        }

        public void Subscribe(Thermostat thermostat)
        {
            // Unsubscribe from any previously subscribed thermostat to avoid multiple subscriptions
            if (this._thermostat != null)
                this._thermostat.OnTempChanged -= this.TempChanged;

            this._thermostat = thermostat;
            this._thermostat.OnTempChanged += this.TempChanged;
        }

        public void UnSubscribe()
        {
            if (this._thermostat != null)
            {
                this._thermostat.OnTempChanged -= TempChanged;
                this._thermostat = null; // Clear the reference to avoid potential issues
            }
        }
    }
}
