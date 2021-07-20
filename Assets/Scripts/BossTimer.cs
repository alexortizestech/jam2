using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTimer : MonoBehaviour
{
    public GameObject currentButtons;
    public GameObject currentHolder;
    public GameObject ButtonsBoss;
    public GameObject HolderBoss;
    public float Timer=20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > Timer)
        {
            currentButtons.SetActive(false);
            currentButtons.SetActive(false);
            ButtonsBoss.SetActive(true);
            HolderBoss.SetActive(true);
        }
    }
}
