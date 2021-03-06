using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNotes : MonoBehaviour
{
  
    public float min;
    public float max;
    public FarmerManager FM;
    public string animationside;
    public GameObject Player;
    public GameObject GoodEffect, GreatEffect, PerfectEffect;
    public AudioSource Error;
    public AudioSource Beat;
    public Multiplier mp;
    public HealthBar HP;
    public GameObject bt;
    public bool canPress =false;
    public ButtonController BC;
    public float punish;
    public float correct;
    public Score score;
    // Start is called before the first frame update
    void Start()
    {
       BC= bt.GetComponent<ButtonController>();
        Player.GetComponent<Animator>().Play("Idle");
        
    }
    

    public void Good()
    {
        correct = 1;
        score.GoodCount += 1;
        Instantiate(GoodEffect, transform.position, GoodEffect.transform.rotation);
    }

    public void Great()
    {
        score.GreatCount += 1;
        correct = 3;
        Instantiate(GreatEffect, transform.position, GreatEffect.transform.rotation);
    }

   public void Perfect()
    {
        score.PerfectCount += 1;
        correct = 5;
        Instantiate(PerfectEffect, transform.position, PerfectEffect.transform.rotation);
        
    }
    // Update is called once per frame
    void Update()
    {
        
     
    }

    public void Fail()
    {
        Player.GetComponent<Animator>().Play("Idle");
        Error.Play();
        HP.currentLife -= punish;
        mp.currentCombo = 0;
        mp.multiplier = 1;
        score.fails += 1;
        score.totalNotes += 1;
        score.stack = 0;
        FM.WrongNote();
        Destroy(this.gameObject);
    }
    
    private void OnTriggerStay2D(Collider2D other)    {
        canPress = true;
        if (Input.GetKey(BC.press) || Input.GetKeyDown(BC.press2))
        {
            Player.GetComponent<Animator>().Play(animationside);
            if (this.gameObject.transform.position.y >= max)
            {
                Great();
            }
            if (this.gameObject.transform.position.y >min && this.gameObject.transform.position.y <max)
            {
                Perfect();
            }
            if (this.gameObject.transform.position.y <min)
            {
                Good();
            }
            score.stack += 1;
            score.totalNotes += 1;
            HP.currentLife += correct;
            mp.currentCombo += 1;
            score.currentScore += correct*mp.multiplier;
            Beat.Play();
            FM.CorrectNote();
            Destroy(this.gameObject);
            
        }
      

    }
    private void OnTriggerExit2D(Collider2D other)
    {
       
            if (other.tag == "Activator")
            {
                canPress = false;
       
            }

    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Death")
        {
            Fail();
        }
    }

}

