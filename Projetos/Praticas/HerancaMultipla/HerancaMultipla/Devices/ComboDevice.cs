namespace HerancaMultipla.Devices
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string doc)
        {
            Console.WriteLine("ComboDevice print " + doc);
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("ComboDevice processing " + doc);
        }

        public string Scan()
        {
            return "ComboDevce scan result";
        }
    }
}


