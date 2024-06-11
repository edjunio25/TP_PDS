namespace StudyMember.ClientApp.src.core.dominio
{
    public class Falta
    {
    private int idFaltaUnica;
    private Data dataFaltaUnica;

    void modDataFalta (int dia, int mes, int ano)
    {
      // aqui trocar pela implementação BD da falta 
      dataFaltaUnica.mudarData(dia, mes, ano);
    }

    int getFaltaId()
    {
      return idFaltaUnica;
    }

    int getFaltaData()
    {
      return dataFaltaUnica
    }
   }

}
