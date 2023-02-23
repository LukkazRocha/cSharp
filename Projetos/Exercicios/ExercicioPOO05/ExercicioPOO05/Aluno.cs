namespace ExercicioPOO05 {
    internal class Aluno {

        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado() {
            return NotaFinal() >= 60.0;
        }

        public double NotaRestante() {
            if (Aprovado()) {
                return 0.0;
            } else {
                return 60.0 - NotaFinal();
            }
        }
    }
}
