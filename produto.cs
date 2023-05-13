namespace Struct;

public struct produto{

    public string Produto;

    public string ValorDesconto;

    public string PorcentagemCupom;

    public string Quantidade;


 public produto (string Produto, string ValorDesconto, string PorcentagemCupom, string Quantidade){
    this.Produto = Produto;
    this.ValorDesconto = ValorDesconto;
    this.PorcentagemCupom = PorcentagemCupom;
    this.Quantidade = Quantidade;
 }   

 public string imprimir(){
    return  "\nProduto: " + this.Produto +
    "\nValorDesnconto: " + this.ValorDesconto +
    "\nPorcentagemCupom: " + this.PorcentagemCupom +
    "\nQuantidade: " + this.Quantidade;
 }
}