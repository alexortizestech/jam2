using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinManager : MonoBehaviour
{
    public Score score;
    public TextMeshProUGUI scr, fails, prc, saved;
    //public GameObject LastNote;
    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scr.text = "Score: "+score.currentScore.ToString("F0");
        prc.text = "Percentage Hit: "+score.Percentage.ToString("F2") + " %";
        fails.text = "Dead Pigs: "+score.fails.ToString("F0");
        saved.text ="Saved Pigs: "+ score.savedPigs.ToString("F0");
        if (Time.time>=125)
        {
            Time.timeScale = 0;
            Menu.SetActive(true);
        }
    }
}
