using System;
using System.Reflection;


namespace CurrencyConversion
{
    public class CurrencyConversion
    {
        private decimal _valueAfterConversion = 0;
        public decimal ConverseCurrency(string fromCurrency, string toCurrency, decimal valueForConversion, decimal czk, decimal gbp, decimal ron, decimal eur)
        {
            switch (fromCurrency)
            {
                case "EUR":
                    ConversionEur(toCurrency, valueForConversion, czk, gbp, ron, eur);
                    break;
                case "CZK":
                    ConversionCzk(toCurrency, valueForConversion, czk, gbp, ron, eur);
                    break;
                case "GBP":
                    ConversionGbp(toCurrency, valueForConversion, czk, gbp, ron, eur);
                    break;
                case "RON":
                    ConversionRon(toCurrency, valueForConversion, czk, gbp, ron, eur);
                    break;
            }
            return _valueAfterConversion;
        }

        public decimal ConversionEur(string toCurrency, decimal valueForConversion, decimal czk, decimal gbp, decimal ron, decimal eur)
        {
            switch (toCurrency)
            {
                case "EUR":
                    _valueAfterConversion = valueForConversion;
                    break;

                case "CZK":
                    _valueAfterConversion = valueForConversion * czk;
                    break;

                case "GBP":
                    _valueAfterConversion = valueForConversion * gbp;
                    break;

                case "RON":
                    _valueAfterConversion = valueForConversion * ron;
                    break;
            }
            return _valueAfterConversion;
        }



        public decimal ConversionCzk(string toCurrency, decimal valueForConversion, decimal czk, decimal gbp, decimal ron, decimal eur)
        {


            switch (toCurrency)
            {
                case "EUR":
                    _valueAfterConversion = valueForConversion / czk;
                    break;

                case "CZK":
                    _valueAfterConversion = valueForConversion;
                    break;

                case "GBP":
                    _valueAfterConversion = (valueForConversion / czk) * (gbp / eur);
                    break;

                case "RON":
                    _valueAfterConversion = (valueForConversion / czk) * (ron / eur);
                    break;
            }
            return _valueAfterConversion;
        }

        public decimal ConversionGbp(string toCurrency, decimal valueForConversion, decimal czk, decimal gbp, decimal ron, decimal eur)
        {
            switch (toCurrency)
            {
                case "EUR":
                    _valueAfterConversion = valueForConversion / gbp;
                    break;

                case "GBP":
                    _valueAfterConversion = valueForConversion;
                    break;

                case "CZK":
                    _valueAfterConversion = (valueForConversion / gbp) * (czk / eur);
                    break;

                case "RON":
                    _valueAfterConversion = (valueForConversion / gbp) * (ron / eur);
                    break;
            }
            return _valueAfterConversion;
        }

        public decimal ConversionRon(string toCurrency, decimal valueForConversion, decimal czk, decimal gbp, decimal ron, decimal eur)
        {
            switch (toCurrency)
            {
                case "EUR":
                    _valueAfterConversion = valueForConversion / ron;
                    break;

                case "RON":
                    _valueAfterConversion = valueForConversion;
                    break;

                case "CZK":
                    _valueAfterConversion = (valueForConversion / ron) * (czk / eur);
                    break;

                case "GBP":
                    _valueAfterConversion = (valueForConversion / ron) * (gbp / eur);
                    break;
            }
            return _valueAfterConversion;
        }

    }
}
