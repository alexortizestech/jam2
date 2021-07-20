using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNotes : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {

     
    }


    
    private void OnTriggerStay2D(Collider2D other)
    {
        canPress = true;
        if (Input.GetKey(BC.press))
        {
            HP.currentLife += correct;
            mp.currentCombo += 1;
            score.currentScore += correct*mp.multiplier;
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
            HP.currentLife -= punish;
            mp.currentCombo = 0;
            mp.multiplier = 1;
            Destroy(this.gameObject);
        }
    }

}

