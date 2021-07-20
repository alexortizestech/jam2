using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNotes : MonoBehaviour
{
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
     
    }


    public void Good()
    {
        correct = 1;
        Instantiate(GoodEffect, transform.position, GoodEffect.transform.rotation);
    }

    public void Great()
    {
        correct = 3;
        Instantiate(GreatEffect, transform.position, GreatEffect.transform.rotation);
    }

   public void Perfect()
    {
        correct = 5;
        Instantiate(PerfectEffect, transform.position, PerfectEffect.transform.rotation);
        Destroy(PerfectEffect, 1f);
    }
    // Update is called once per frame
    void Update()
    {

     
    }

    public void Fail()
    {
        Error.Play();
        HP.currentLife -= punish;
        mp.currentCombo = 0;
        mp.multiplier = 1;
        Destroy(this.gameObject);
    }
    
    private void OnTriggerStay2D(Collider2D other)    {
        canPress = true;
        if (Input.GetKey(BC.press))
        {
            if (this.gameObject.transform.position.y >= 0.25)
            {
                Great();
            }
            if (this.gameObject.transform.position.y >0 && this.gameObject.transform.position.y <0.25f)
            {
                Perfect();
            }
            if (this.gameObject.transform.position.y <0)
            {
                Good();
            }
            HP.currentLife += correct;
            mp.currentCombo += 1;
            score.currentScore += correct*mp.multiplier;
            Beat.Play();
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

