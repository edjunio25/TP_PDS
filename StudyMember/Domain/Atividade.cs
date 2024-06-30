namespace StudyMember.Domain

{
    public class Atividade
    {
        private int idAtividade { get; set; }
        public string nomeAtividade { get; set; }
        public DateTime dataDeInclusaoAtividade { get; set; }
        public DateTime dataPrazoAtividade { get; set; }
        public DateTime? dataEntregaAtividade { get; set; }
        public AtividadeTipo tipoDaAtividade { get; set; }

        //public bool atividadeConcluida { get; set; }
        public StatusAtividade? statusDaAtividade { get; set; }
        public int valor { get; set; }
        public int nota { get; set; }

        public Atividade(string nomeInput, DateTime dataInput, AtividadeTipo tipoInput, int valorInput)
        {
            //TODO implementar ID único ou sequencial ou aleatório

            this.nomeAtividade = nomeInput;
            this.dataDeInclusaoAtividade = DateTime.Now;
            this.dataPrazoAtividade = dataInput;
            this.tipoDaAtividade = tipoInput;
            this.valor = valorInput;
            this.atualizarStatusAtividade();

        }

        public void atualizarStatusAtividade()
        {
            if (statusDaAtividade is not StatusAtividade.cancelada or null)
            {
                if (dataPrazoAtividade < DateTime.Now && dataEntregaAtividade == null)
                {
                    statusDaAtividade = StatusAtividade.atrasada;
                }
                else if (dataEntregaAtividade > dataPrazoAtividade)
                {
                    statusDaAtividade = StatusAtividade.concluidaComAtraso;
                }
                else if (dataEntregaAtividade >= dataPrazoAtividade)
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
