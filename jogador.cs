namespace Struct;

public struct jogador{
 
 public string registrarNumeroCatoesAmarelos;

 public string registrarNumeroCatoesVermelhos;

 public string verificarVinculoClube;

 public string nomeJogador;

 public string numeroCamisa;

 public string numeroGols;

  public string posicao;

 public jogador(string cartoesAmarelo, string CartoesVermelho, string Clube, string nomeJogador, string numeroCamisa, string numeroGols, string posicao){
    this.registrarNumeroCatoesAmarelos = cartoesAmarelo;
    this.registrarNumeroCatoesVermelhos = CartoesVermelho;
    this.verificarVinculoClube =  Clube;
    this.nomeJogador = nomeJogador;
    this.numeroCamisa = numeroCamisa;
    this.numeroGols = numeroGols;
    this.posicao = posicao;

 }
 public string imprimir(){
    return "\nRegistrarNumeroCatoesAmarelo: " + this.registrarNumeroCatoesAmarelos +
    "\nRegistrarNumeroCatoesVermelho: " + this.registrarNumeroCatoesVermelhos +
    "\nVerificarVinculoClube: " + this.verificarVinculoClube +
    "\nNomeJogador: " + this.nomeJogador +
    "\nNumeroCamisa: " + this.numeroCamisa +
    "\nNumeroGols: " + this.numeroGols + 
    "\nPosicao: " + this.posicao;

 }
}
