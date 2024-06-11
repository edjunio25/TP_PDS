using System;
namespace StudyMember.ClientApp.src.core.dominio
  // Não me lembro se bibliotecas também precisam de adaptadores, então vou implementar
  // o datetime aqui mesmo qualquer coisa eu crio um adaptador
 

{
  // Provavelmente vou substituir por datetime posteriormente
  public class Data
  {
    // poderia declarar junto, mas fica mais legível
    // AVALIAR
    private int dia;
    private int mes;
    private int ano;
    private int hora;
    private int minuto;


    public void Data(int diaInput, int mesInput, int anoInput, int horaInput, int minutoInput)
    {
      dia = diaInput;
      mes = mesInput;
      ano = anoInput;
      // opcional, deve ser pouco utilizado
      hora = horaInput;
      minuto = minutoInput;
    }

    public void obterDataDeAgora ()
    {
      // Retorna a data e hora na Timezone do usuário, pode ocorrer de pegar a timezone do servidor e aparecer em UTC
      System.DateTime dataAgora = new System.DateTime.Now;

      dia = dataAgora.Day;
      mes = dataAgora.Month;
      ano = dataAgora.Year;
      hora = dataAgora.Hour;
      minuto = dataAgora.Minute;
    }

    public void mudarData(int diaInput, int mesInput, int anoInput)
    {
      dia = diaInput;
      mes = mesInput;
      ano = anoInput;
    }

    public void mudarHora(int horaInput, int minutoInput)
    {
      hora = minutoInput;
      minuto = minutoInput;
    }

    // feita originalmente, provavelmente será depreciada em favor das duas funcoes acima
    public void mudarAtributoData(string parametroMudado, int valor)
    {
      switch (parametroMudado)
      {
        case "dia":
          dia = parametroMudado;
          break;
        case "mes":
          mes = parametroMudado;
          break;
        case "ano":
          ano = parametroMudado;
          break;
        case "hora":
          hora = parametroMudado;
          break;
        case "minuto":
          hora = parametroMudado;
          break;
      }
    }

    public int getData()
    {
      return (dia, mes, ano);
    }

    // novamente, metodos separados pois "hora" será menos utilizado
    public int getHora()
    {
      return (hora, minuto);
    }
  }
}
