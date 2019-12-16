using System;

class MainClass {
  public static void Main (string[] args) {
    Robo L1 = new Robo ("Gato", "Normal", 20,100,100);
    Robo L2 = new Robo ("Feio", "Fraco", 23, 100,100);

    //Console.WriteLine (L1.RealizarAtaque (L2));

    L1.ObterForcaDefesa (L2, 40);

    Console.WriteLine ("Nível de defesa de L1 = " + L1.GetDefesa());
    Console.WriteLine ("Nível de defesa de L2 = " + L2.GetDefesa());
    
  }
}