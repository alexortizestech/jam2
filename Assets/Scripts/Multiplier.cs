using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Multiplier : MonoBehaviour
{
    public TextMeshProUGUI current;
    public TextMeshProUGUI mtp;
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

        current.text ="Combo "+ currentCombo.ToString("F0");
        mtp.text ="Multiplier "+ multiplier.ToString();

    }
}
