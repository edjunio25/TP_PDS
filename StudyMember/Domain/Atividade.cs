namespace StudyMember.Domain

{
    public class Atividade
    {
        public int Id { get; set; }
        public string NomeAtividade { get; set; }
        public DateTime DataDeInclusaoAtividade { get; set; }
        public DateTime DataPrazoAtividade { get; set; }
        public DateTime? DataEntregaAtividade { get; set; }
        public AtividadeTipo TipoDaAtividade { get; set; }
        public StatusAtividade? statusDaAtividade { get; set; }
        public float Valor { get; set; }
        public float Nota { get; set; }

        public Atividade(string nomeInput, DateTime dataInput, AtividadeTipo tipoInput, int valorInput)
        {
            //TODO implementar ID único ou sequencial ou aleatório

            this.NomeAtividade = nomeInput;
            this.DataDeInclusaoAtividade = DateTime.Now;
            this.DataPrazoAtividade = dataInput;
            this.TipoDaAtividade = tipoInput;
            this.Valor = valorInput;
            this.atualizarStatusAtividade();

        }

        public void atualizarStatusAtividade()
        {
            if (statusDaAtividade is not StatusAtividade.cancelada or null)
            {
                if (DataPrazoAtividade < DateTime.Now && DataEntregaAtividade == null)
                {
                    statusDaAtividade = StatusAtividade.atrasada;
                }
                else if (DataEntregaAtividade > DataPrazoAtividade)
                {
                    statusDaAtividade = StatusAtividade.concluidaComAtraso;
                }
                else if (DataEntregaAtividade >= DataPrazoAtividade)
                {
                    statusDaAtividade = StatusAtividade.concluida;
                }
                else
                {
                    statusDaAtividade = StatusAtividade.pendente;
                }
            }
        }

    }

    public enum AtividadeTipo
    {
        prova,
        atividadeIsolada,
        trabalho
    }

    public enum StatusAtividade
    {
        pendente,
        concluida,
        concluidaComAtraso,
        atrasada,
        cancelada
    }

}
