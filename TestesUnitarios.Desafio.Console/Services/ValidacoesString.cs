public class ValidacoesString
{
    public int RetornarQuantidadeCaracteres(string texto)
    {
        return texto.Length; // Retorna o comprimento do texto
    }

    public bool ContemCaractere(string texto, string textoProcurado)
    {
        return texto.Contains(textoProcurado); // Verifica se o texto contém o textoProcurado
    }

    public bool TextoTerminaCom(string texto, string textoProcurado)
    {
        return texto.EndsWith(textoProcurado); // Verifica se o texto termina com textoProcurado
    }
}
