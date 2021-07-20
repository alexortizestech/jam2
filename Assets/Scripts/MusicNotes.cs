using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNotes : MonoBehaviour
{
    public GameObject bt;
    public bool canPress =true;
    public ButtonController BC;
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
        if (Input.GetKey(BC.press))
        {
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
}
