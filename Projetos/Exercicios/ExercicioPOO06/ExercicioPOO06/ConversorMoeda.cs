namespace ExercicioPOO06 {
    internal class ConversorMoeda {

        public static double Iof = 6.0;

        public static double DolarParaReal(double quantia, double cotacao) {
            double totalImposto = cotacao + (cotacao * Iof / 100);
            return totalImposto * quantia;
        }
    }
}
