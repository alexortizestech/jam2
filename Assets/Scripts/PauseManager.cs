using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public AudioSource music;
    public KeyCode Pause;
    public GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Pause))
        {
            Time.timeScale = 0;
            music.Pause();
            PauseMenu.SetActive(true);
        }
    }



    public void Resume()
    {
        Time.timeScale = 1;
        music.Play();
        PauseMenu.SetActive(false);
    }

    
}
