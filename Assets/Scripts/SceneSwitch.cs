using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update

   
    public void Play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start");
        
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Credits()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Credits");
    }
   public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Selec()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SelecLevels");
    }
}
