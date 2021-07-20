using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float currentScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
      
    }

    // Update is called once per frame
    void Update()
    {
        currentScore += 1 * Time.deltaTime;
        text.text = currentScore.ToString("F0");
    }
}
