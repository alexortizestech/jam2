using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour
{
    //public GameObject LastNote;
    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>=125)
        {
            Time.timeScale = 0;
            Menu.SetActive(true);
        }
    }
}
