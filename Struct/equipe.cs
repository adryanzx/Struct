namespace Struct;

public struct equipe{
    public string CampeonatoVencido;

    public float ValorTotalPremiacoes;

    public string AnoEstreia;

    public string ValoresArrecados;

    public string QuantosMundial;

    public string ChampionsLeague;

    public equipe (string CampeonatoVencido, string ValorTotalPremiacoes, string AnoEstreia, string ValoresArrecados, string QuantosMundial, string ChampionsLeague){
        this.CampeonatoVencido = CampeonatoVencido;
        this.ValorTotalPremiacoes = 0;
        this.AnoEstreia = AnoEstreia;
        this.ValoresArrecados = ValoresArrecados;
        this.QuantosMundial = QuantosMundial;
        this.ChampionsLeague = ChampionsLeague;
    }

    public void total(float atualizavalor){
        this.ValorTotalPremiacoes = this.ValorTotalPremiacoes + atualizavalor;
    }

public string imprimir(){
    return "\nCampeonatoVencido: " + this.CampeonatoVencido +
    "\nValorTotalPremiacoes: " + this.ValorTotalPremiacoes +
    "\nAnoEstreia: " + this.AnoEstreia + 
    "\nValoresArrecados: " + this.ValoresArrecados +
    "\nQuantosMundial: " + this.QuantosMundial +
    "\nChampionsLeague: " + this.QuantosMundial;
}


}


