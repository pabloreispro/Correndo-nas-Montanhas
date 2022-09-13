using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botoes : MonoBehaviour
{

    public void Restart()
    {
        SceneManager.LoadScene("Jogo");
        Time.timeScale = 1;
    }
    public void RestartYeti()
    {
        SceneManager.LoadScene("Jogo1");
        Time.timeScale = 1;
    }
    public void Menuprincipal()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Jogar()
    {
        SceneManager.LoadScene("Jogo");
        Time.timeScale = 1;
    }
    public void Sair()
    {
        Application.Quit();
    }
    public void JogarYeti()
    {
        SceneManager.LoadScene("Jogo1");
        Time.timeScale = 1;
    }
    public void pause()
    {
        Time.timeScale = 0;
    }
    public void resume()
    {
        Time.timeScale = 1;
    }

}
