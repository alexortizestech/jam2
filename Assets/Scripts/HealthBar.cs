using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    bool done = false;
    public Button First;
    public GameObject LoseMenu;
    public Slider Slider;
    public float currentLife = 100;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        currentLife = 100;

    }

    // Update is called once per frame
    void Update()
    {
         Slider.value= currentLife ;

        if (currentLife >= 100)
        {
            currentLife = 100;
        }


        if (currentLife <= 0)
        {
            
            Time.timeScale = 0;
            LoseMenu.SetActive(true);
            if (!done)
            {
                SelectCorrect();
            }
            
        }
    }

    public void SelectCorrect()
    {
        First.Select();
        done = true;
    }
}
