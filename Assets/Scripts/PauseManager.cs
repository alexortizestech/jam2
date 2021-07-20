using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            PauseMenu.SetActive(true);
        }
    }



    public void Resume()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }

    
}
