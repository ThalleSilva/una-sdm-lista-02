public class Faculdade
{
    public string Nome { get; set; }
    public List<string> Cursos { get; set; }
}

public class Universidade
{
    public string Nome { get; set; }
    public string Cidade { get; set; }
    public List<Faculdade> Faculdades { get; set; }
}