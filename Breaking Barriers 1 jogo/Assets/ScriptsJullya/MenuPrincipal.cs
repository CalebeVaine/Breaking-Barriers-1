using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("Jogo"); // Nome da cena do jogo
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos"); // Nome da cena de créditos
    }

    public void Sair()
    {
        Application.Quit(); // Fecha o jogo (funciona no build)
        Debug.Log("Jogo encerrado."); // Mostra no console do editor
    }
}
