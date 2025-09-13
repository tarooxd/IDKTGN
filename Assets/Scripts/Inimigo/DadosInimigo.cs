using UnityEngine;

[System.Serializable]
public enum TipoAcaoInimigo
{
    Atacar,
    Defender,
    Buff,
    Debuff
}

[System.Serializable]
public class AcaoInimigo
{
    public TipoAcaoInimigo tipo;
    public int valor;
}

[CreateAssetMenu(menuName = "Jogo/Dados Inimigo")]
public class DadosInimigo  : ScriptableObject
{
    [Header("Atributos base")]
    public string nome;
    public int vidaMaxima;
    public Sprite retrato;

    [Header("Configuração da IA")]
    public AcaoInimigo[] possiveisAcoes;
}
