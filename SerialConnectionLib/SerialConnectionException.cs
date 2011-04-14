using System;

namespace SerialConnection{
    public class SerialConnectionException: Exception{
        public SerialConnectionException(string format, params object[] args) : base(string.Format(format, args)){
        }

        public SerialConnectionException(string message, Exception innerException) : base(message, innerException){
        }
    }
}