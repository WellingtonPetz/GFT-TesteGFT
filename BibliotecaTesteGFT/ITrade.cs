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
        //bool IsPoliticallyExposed { get; }


    }

    public class Trades : ITrade
    {
        private double value;
        private string clientSector;
        private DateTime nextPaymentDate;
        //private bool isPoliticallyExposed;


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

        //public bool IsPoliticallyExposed
        //{
        //    get { return IsPoliticallyExposed; }
        //    set { this.IsPoliticallyExposed = value; }
        //}
        //public void AddTrade(double _value, string _clientSector, DateTime _nextPaymentDate, bool _IsPoliticallyExposed)

        //{
        //    this.Value = _value;
        //    this.ClientSector = _clientSector;
        //    this.NextPaymentDate = _nextPaymentDate;
        //    this.IsPoliticallyExposed = _IsPoliticallyExposed;
        //}

        public void AddTrade(double _value, string _clientSector, DateTime _nextPaymentDate)

        {
            this.Value = _value;
            this.ClientSector = _clientSector;
            this.NextPaymentDate = _nextPaymentDate;
        }
    }

}
