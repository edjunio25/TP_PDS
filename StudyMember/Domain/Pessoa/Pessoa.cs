namespace StudyMember.Domain.Pessoa
{
    public class Pessoa
    {
        public int pessoaId { get; set; }
        public string nome { get; set; }
        public TipoPessoa tipoDePessoa { get; set; }
        public string? emailDeContato { get; set; }
        public string? telefoneDeContato { get; set; }
        public string? endereco { get; set; }
        public int? idade { get; set; }


        public Pessoa(string nome, TipoPessoa tipoDePessoa)
        {
            this.nome = nome;
            this.tipoDePessoa = tipoDePessoa;
        }


    }

    public enum TipoPessoa
    {
        estudante,
        monitor,
        professor
    }
}
