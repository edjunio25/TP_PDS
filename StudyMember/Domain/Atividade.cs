namespace StudyMember.Domain

{
    public class Atividade
    {
        private int idAtividade { get; set; }
        public string nomeAtividade { get; set; }
        public DateTime dataEntregaAtividade { get; set; }
        public AtividadeTipo tipoDaAtividade { get; set; }

        public bool atividadeConcluida { get; set; }
        public int valor { get; set; }
        public int nota { get; set; }

        public Atividade(string nomeInput, DateTime dataInput, AtividadeTipo tipoInput, int valorInput)
        {
            //TODO implementar ID único ou sequencial ou aleatório

            nomeAtividade = nomeInput;
            dataEntregaAtividade = dataInput;
            tipoDaAtividade = tipoInput;
            valor = valorInput;
            atividadeConcluida = false;

        }
        int getIdAtividade()
        {
            return idAtividade;
        }

    }

    public enum AtividadeTipo
    {
        prova,
        atividadeIsolada,
        trabalho
    }

}
