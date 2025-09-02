using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Nome da cena do jogo
    public string cenaJogo = "GameScene";

    // Refer�ncia ao AudioSource que tocar� o som
    public AudioSource somBotao;

    // Fun��o chamada quando o bot�o for pressionado
    public void Jogar()
    {
        // Toca o som apenas se o AudioSource estiver atribu�do
        if (somBotao != null && somBotao.clip != null)
        {
            somBotao.Play();
            // Inicia a coroutine para carregar a cena depois que o som tocar
            StartCoroutine(CarregarCenaDepoisDoSom());
        }
        else
        {
            // Se n�o tiver som, carrega a cena imediatamente
            SceneManager.LoadScene(cenaJogo);
        }
    }

    private System.Collections.IEnumerator CarregarCenaDepoisDoSom()
    {
        // Espera o tempo de dura��o do som
        yield return new WaitForSeconds(somBotao.clip.length);

        // Agora carrega a cena
        SceneManager.LoadScene(cenaJogo);
    }
}
