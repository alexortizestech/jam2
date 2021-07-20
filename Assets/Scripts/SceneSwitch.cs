using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update


    public void Play()
    {
       SceneManager.LoadScene("Start");
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
   public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
