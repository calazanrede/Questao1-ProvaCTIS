using System;

class MainClass {
  static void diagonalDifference(){
    //Declaração Váriaveis
    int n = 0;
    int resultado = 0;
    int a = 0;
    string s = "";
    bool f = true;
    int[,] matriz;
    matriz = new int[n,n];
    int somade = 0;
    int somadd = 0;

    //Definindo Matriz
    Console.WriteLine("Ordem da matriz quadrada:");   
    s = Console.ReadLine();
    f = int.TryParse(s, out n);
    while((n<-100) | (n > 100) | (f==false)){
      Console.WriteLine("Valor invalido insira um número de -100 a 100");
      n = Convert.ToInt32(Console.ReadLine());
    }

   //Formação da Matriz e somas pedidas
    for (int i=1;i<(n+1);i++){
      Console.WriteLine("Digite os valores da linha "+(i)+" da matriz:");
      for (int j=1;j<(n+1);j++){
        s = Console.ReadLine();
        f = int.TryParse(s, out a);
        while(f==false){
          Console.WriteLine("Valor inválido, digite novamente:");
          s = Console.ReadLine();
          f = int.TryParse(s, out a);
        }
        if (i==j){
          somade = somade + a;
        }
        if((i+j)==(n+1)){
          somadd = somadd + a;
        }
      }
    }

    //Obtenção do resultado
    resultado = somadd-somade;
    if(resultado < 0){
      resultado = resultado*(-1);
    }
    Console.WriteLine("Diferença absoluta entre as somas das diagonais: "+resultado);
  }
  public static void Main (string[] args) {
    diagonalDifference();

}
}