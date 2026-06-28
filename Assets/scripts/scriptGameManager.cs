using UnityEngine;
using TMPro;

public class scriptGameManager : MonoBehaviour
{
    public static scriptGameManager Instancia;

    public int pontuacaoAtual = 0;

    public TextMeshProUGUI textoPontuacao;

    void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        AtualizarHUD();
    }

    public void AdicionarPontos(int valor)
    {
        pontuacaoAtual += valor;
        AtualizarHUD(); 
    }

    private void AtualizarHUD()
    {
        if (textoPontuacao != null)
        {
            textoPontuacao.text = "Pontos: " + pontuacaoAtual;
        }
    }
}