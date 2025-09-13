using UnityEngine;

[CreateAssetMenu(fileName = "Nova Carta", menuName = "Cartas/Carta Base")]
public class Carta : ScriptableObject
{
    [Header("Informa��es B�sicas")]
    public string nomeDaCarta;
    [TextArea] public string descricao;
    public Sprite arte;
    public int custoDeEnergia;

    [Header("Tipo de Carta")]
    public TipoDeCarta efeito;
}
