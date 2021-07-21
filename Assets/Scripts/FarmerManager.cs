using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerManager : MonoBehaviour
{
    public Transform Spawner;
    public GameObject SlashEffect;
    public Transform Player;
    public Transform Pigs;
    public AudioSource Scream;
    public GameObject Runner;
    public Transform FirstRunner;
    public GameObject currentrunner;
    // Start is called before the first frame update
    public void CorrectNote()
    {
        transform.LookAt(Player);
       currentrunner= Instantiate(Runner, FirstRunner.position, FirstRunner.rotation);
        Destroy(currentrunner, 0.5f);
    }


    public void WrongNote()
    {
        transform.LookAt(Pigs);
        Instantiate(SlashEffect, Spawner.position, SlashEffect.transform.rotation);
        Scream.Play();
    }

    private void Update()
    {
        currentrunner = Runner;
    }
}
