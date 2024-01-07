namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public IEnumerable<int> RemoverNumerosNegativos(List<int> lista)
        {
            // Evite criação de lista desnecessária
            return lista.Where(x => x > 0);
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            return lista.Contains(numero);
        }

        public IEnumerable<int> MultiplicarNumerosPor2(List<int> lista)
        {
            // Evite criação de lista desnecessária
            return lista.Select(x => x * 2);
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}
