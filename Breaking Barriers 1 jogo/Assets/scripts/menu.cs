using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Nome da cena do jogo (coloque o nome exato que est� no Build Settings)
    public string cenaJogo = "GameScene";

    // Essa fun��o ser� chamada quando voc� apertar o bot�o
    public void Jogar()
    {
        SceneManager.LoadScene(cenaJogo);
    }
}
