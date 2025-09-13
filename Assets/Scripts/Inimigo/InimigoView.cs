using UnityEngine;
using UnityEngine.UI;

public class InimigoView : MonoBehaviour
{
    public DadosInimigo dados;
    public InstanciaInimigo Instancia { get; private set; }

    [Header("UI")]
    public Text textoVida;
    public Image imagemRetrato;

    private void Awake()
    {
        Instancia = new InstanciaInimigo(dados);
        imagemRetrato.sprite = dados.retrato;
        AtualizarUI();
    }

    public void AtualizarUI()
    {
        textoVida.text = $"{Instancia.vidaAtual}/{dados.vidaMaxima}";
    }
}
