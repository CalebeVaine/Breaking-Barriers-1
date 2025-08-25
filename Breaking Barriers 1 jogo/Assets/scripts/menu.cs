using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Nome da cena do jogo (coloque o nome exato que está no Build Settings)
    public string cenaJogo = "GameScene";

    // Essa função será chamada quando você apertar o botão
    public void Jogar()
    {
        SceneManager.LoadScene(cenaJogo);
    }
}
