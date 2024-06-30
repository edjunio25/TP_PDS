using StudyMember.Domain.Semestres;

namespace StudyMember.Domain
{
    public class Disciplina
    {
        public int nomeDisciplina { get; set; }

        public int idDisciplina { get; set; }

        public int numFaltasDisciplina { get; set; }

        public int tempoDeEstudo { get; }

        public int cargaHoraria { get; private set; }

        public StatusDisciplina statusDaDisciplina { get; set; }

        public int notaTotalObtida { get; set; } 

        public int notaTotalDistribuida { get; set; }

        //colocar em número inteiro (ex: 20% = 20)
        public int percentualDeFaltasPermitidas { get; set; }

        public int faltasRestantes { get; set; }

        public List<Atividade>? listaDeAtividades { get; set; }

        public Disciplina(int nomeDisciplina, int idDisciplina, int cargaHoraria, int percentualDeFaltasPermitidas)
        {
            this.nomeDisciplina = nomeDisciplina;
            this.idDisciplina = idDisciplina;
            this.numFaltasDisciplina = 0;
            this.tempoDeEstudo = 0;
            this.cargaHoraria = cargaHoraria;
            this.statusDaDisciplina = StatusDisciplina.Cursando;
            this.notaTotalObtida = 0;
            this.notaTotalDistribuida = 0;
            this.percentualDeFaltasPermitidas = percentualDeFaltasPermitidas;
            this.calcularFaltasRestantes();
        }



        //passando entidade falta, rever talvez incluir como caso de uso
        public void adicionarFalta(Falta faltaInput)
        {
            numFaltasDisciplina += faltaInput.HoraAula;
        }

        public void removerFalta(int numeroDeFaltas)
        {
            numFaltasDisciplina -= numeroDeFaltas;
        }

        public void calcularFaltasRestantes()
        {
            faltasRestantes = (cargaHoraria * percentualDeFaltasPermitidas) / 100;
        }

        // atualiza a nota total da disciplina com base nas notas das atividades
        // pode ter que mudar com a implementação do banco de dados
        public void atualizarNotaObtidaeNotaDistribuida()
        {
            int notaTotal = 0, totalDistribuido = 0;
            if (listaDeAtividades != null)
            {
                for (int i = 0; i < listaDeAtividades.Count; i++)
                {
                    notaTotal += listaDeAtividades[i].nota;
                    totalDistribuido = listaDeAtividades[i].valor;
                }
            }
            notaTotalObtida = notaTotal;
            notaTotalDistribuida = totalDistribuido;
            atualizarStatusDaDisciplina();
        }

        public void atualizarStatusDaDisciplina()
        {
            if (statusDaDisciplina != StatusDisciplina.Trancada)
            {
                if (notaTotalObtida >= 60)
                {
                    statusDaDisciplina = StatusDisciplina.Aprovada;
                }
                else if ((notaTotalObtida + (100 - notaTotalDistribuida)) < 60)
                {
                    statusDaDisciplina = StatusDisciplina.Reprovada;
                }
                else
                {
                    statusDaDisciplina = StatusDisciplina.Cursando;
                }
            }

        }
    }

    public enum StatusDisciplina
    {
        Cursando,
        Aprovada,
        Reprovada,
        Trancada
    }



}
