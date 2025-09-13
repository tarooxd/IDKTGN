using UnityEngine;

[CreateAssetMenu(fileName = "CartaAtaque", menuName = "Cartas/Efeitos/Ataque")]
public class CartaAtaque : TipoDeCarta
{
    public int dano = 5;

    public override void Executar(GameObject alvo)
    {
        InstanciaInimigo inimigo = alvo.GetComponent<InstanciaInimigo>();
        if (inimigo != null)
        {
            inimigo.SofreDano(dano);
            Debug.Log($"{alvo.name} recebeu {dano} de dano!");
        }
    }
}
