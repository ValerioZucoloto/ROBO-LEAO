using System;

class Robo {
  private string nome;
  private string estado;
  private int idade;
  private double ataque;
  public double defesa;

  public Robo (string nome, string estado, int idade,double ataque, double defesa) {
    this.nome = nome;
    this.estado = estado;
    this.idade = idade;
    this.ataque = ataque;
    this.defesa = defesa;
  }

  public Robo () {
    nome = "Não informado";
    estado = "Não informado";
    idade = 0;
    ataque = 0.0;
    defesa = 0.0;
  }

  public string GetNome () {
    return nome;
  }

  public void SetNome (string N) {
    nome = N;
  }

  public int GetIdade () {
    return idade;
  }

  public void SetIdade (int I) {
    idade = I;
  }

  public double GetAtaque () {
    return ataque;
  }

  public void SetAtaque (double A) {
    ataque = A;
  }

  public double GetDefesa () {
    return defesa;
  }

  public void SetDefesa (double D) {
    defesa = D;
  }

  public bool RealizarAtaque (Robo outroRobo) {
    // Só pode atacar se estiver com mais de 10% de força de ataque e se estiver no estado normal ou fraco

    if (this.ataque >= 10 && this.estado == "Normal" || this.ataque >= 10 && this.estado == "Fraco" ) {

      this.ataque = this.ataque - 1;
      outroRobo.defesa = outroRobo.defesa - 15;

      //Caso sua força de defesa fique abaixo de 30% ele passa para o estado Fraco e caso fique abaixo de 0% ele passa para o estado Indefeso.

      if (outroRobo.defesa <= 30) {
        outroRobo.estado = "Fraco";
      }

      if (outroRobo.defesa <= 0) {
        outroRobo.estado = "Indefeso";
      }
      return true;
    }
    return false;
  }

  public void ObterForcaDefesa (Robo RoboRecebedor, int percentual) {
    if (RoboRecebedor.estado == "Fraco"  && this.defesa >= 30 ||  RoboRecebedor.estado == "Indefeso" && this.defesa >= 30) {
      this.defesa = this.defesa - percentual;
      RoboRecebedor.defesa = RoboRecebedor.defesa + percentual;
    }
  }
    

}