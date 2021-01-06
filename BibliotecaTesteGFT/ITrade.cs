using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnico
{
    public interface ITrade
    {

        double Value { get; } //indicates the transaction amount in dollars
        string ClientSector { get; } //indicates the client´s sector which can be "Public" or "Private"
        DateTime NextPaymentDate { get; } //indicates when the next payment from the client to the bank is expected


        public void AddTrade(double _value, string _clientSector)
        {}
    }

    public class Trades : ITrade
    {
        private double value;
        private string clientSector;
        private DateTime nextPaymentDate;


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

        public DateTime NextPaymentDate
        {
            get { return nextPaymentDate; }
            set { this.nextPaymentDate = value; }
        }
        public void AddTrade(double _value, string _clientSector, DateTime _nextPaymentDate)
        {
            this.Value = _value;
            this.ClientSector = _clientSector;
            this.NextPaymentDate = _nextPaymentDate;
        }
    }

}
