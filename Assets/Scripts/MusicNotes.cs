using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNotes : MonoBehaviour
{
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
    }

    public void Great()
    {
        correct = 3;
    }

   public void Perfect()
    {
        correct = 5;
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
    
    private void OnTriggerStay2D(Collider2D other)
    {
        canPress = true;
        if (Input.GetKey(BC.press))
        {
            if (this.gameObject.transform.position.y >= 0.25)
            {
                Great();
            }
            if (this.gameObject.transform.position.y >0)
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

