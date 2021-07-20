using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider Slider;
    public float currentLife = 100;
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}
