using System;

namespace Part00
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport air1 = new Airport();
            air1.name = "rasht";
            air1.ICAOCode = "OIGG";
            air1.OperationTime = "10-14";




    }
    }

    class Airport
    {
        public string name;
        public string ICAOCode;
        public string OperationTime;
    }
}