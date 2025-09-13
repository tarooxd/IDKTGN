using UnityEngine;

public class InstanciaInimigo
{
    public DadosInimigo dados;
    public int vidaAtual;
    public int bloqueioAtual;

    public InstanciaInimigo(DadosInimigo  dados)
    {
        this.dados = dados;
        vidaAtual = dados.vidaMaxima;
        bloqueioAtual = 0;
    }
    
    public void SofreDano(int quantidade)
    {
        var danoRestante = Mathf.Max(0, quantidade - bloqueioAtual);
        bloqueioAtual = Mathf.Max(0, bloqueioAtual - quantidade);
        vidaAtual -= danoRestante;
    }

    public bool EstaMorto() => vidaAtual <= 0;

    public AcaoInimigo DecideProximaAcao()
    {
        var index = Random.Range(0, dados.possiveisAcoes.Length);
        return dados.possiveisAcoes[index];
    }
}
