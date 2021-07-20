using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public TextMeshProUGUI prc;
    public Slider slider;
    public float totalNotes;
    public float Percentage;
    public float TotalCount;
    public float GoodCount;
    public float GreatCount;
    public float PerfectCount;
    public TextMeshProUGUI text;
    public float currentScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        GoodCount = 0;
        GreatCount = 0;
        PerfectCount = 0;
      
    }

    // Update is called once per frame
    void Update()
    {
        currentScore += 1 * Time.deltaTime;
        text.text = "Score "+currentScore.ToString("F0");
        TotalCount = GoodCount*0.5f + GreatCount*0.75f + PerfectCount;
        Percentage = (TotalCount / totalNotes) * 100f;
        slider.value = Percentage;
        prc.text = Percentage.ToString("F2") + " %";
    }
}
