using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{
    public bool done;
    public Button First;
    public Score score;
    public TextMeshProUGUI scr, fails, prc, saved;
    //public GameObject LastNote;
    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        done = false;
    }

    // Update is called once per frame
    void Update()
    {
        scr.text = "Score: "+score.currentScore.ToString("F0");
        prc.text = "Percentage Hit: "+score.Percentage.ToString("F2") + " %";
        fails.text = "Dead Pigs: "+score.fails.ToString("F0");
        saved.text ="Saved Pigs: "+ score.savedPigs.ToString("F0");
        if (Time.timeSinceLevelLoad >= 125)
        {
            Time.timeScale = 0;
            Menu.SetActive(true);
            if (done == false)
            {
                SelectCorrect2();
            }
        }
    }
    public void SelectCorrect2()
    {
        First.Select();
        done = true;
    }
}
