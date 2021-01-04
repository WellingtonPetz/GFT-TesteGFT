using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnico
{
    public interface ITrade
    {

        double Value { get; }
        string ClientSector { get; }


        public void AddTrade(double _value, string _clientSector)
        {}
    }

    public class Trades : ITrade
    {
        private double value;
        private string clientSector;


        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public string ClientSector
        {
            get { return clientSector; }
            set { this.clientSector = value; }
        }

        public void AddTrade(double _value, string _clientSector)
        {
            this.Value = _value;
            this.ClientSector = _clientSector;
        }
    }

}
