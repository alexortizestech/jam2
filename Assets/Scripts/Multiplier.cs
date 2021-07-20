using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplier : MonoBehaviour
{
    public float currentCombo;
    public float multiplier;
    // Start is called before the first frame update
    void Start()
    {
        multiplier = 1;
        currentCombo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentCombo < 5)
        {
            multiplier = 1;
        }

        if (currentCombo >= 5)
        {
            multiplier = 2;
        }

        if (currentCombo >= 10)
        {
            multiplier = 3;
        }

        if (currentCombo >= 15)
        {
            multiplier = 4;
        }
    }
}
