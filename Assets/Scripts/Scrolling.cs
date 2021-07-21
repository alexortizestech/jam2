using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float beat;
    public bool ON;
    // Start is called before the first frame update
    void Start()
    {
        beat = beat / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        
            
        
        
            transform.position -= new Vector3(0f, beat*Time.deltaTime, 0f);
        
    }
}
