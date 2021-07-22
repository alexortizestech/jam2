using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public GameObject TutorialText;
    public MusicNotes mc;
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
    public float fails;
    public float savedPigs;
    // Start is called before the first frame update
    void Start()
    {
        TutorialText.SetActive(true);
        TotalCount = 0;
        currentScore = 0;
        GoodCount = 0;
        GreatCount = 0;
        PerfectCount = 0;
        totalNotes = 0;
        Percentage = 0;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey|| Time.timeSinceLevelLoad >= 4)
        {
            TutorialText.SetActive(false);
        }


        currentScore += 1 * Time.deltaTime;
        text.text = "Score "+currentScore.ToString("F0");
        TotalCount = GoodCount*0.5f + GreatCount*0.75f + PerfectCount;
        savedPigs = GoodCount + GreatCount + PerfectCount;
        if (TotalCount>=1){
  
            Percentage = (TotalCount / totalNotes) * 100f;
        }
        slider.value = Percentage;
        prc.text = Percentage.ToString("F2") + " %";
    }
}
