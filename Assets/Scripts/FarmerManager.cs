using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerManager : MonoBehaviour
{
    public GameObject Farmer;
    public Transform Spawner;
    public GameObject SlashEffect;
    public Transform Player;
    public Transform Pigs;
    public AudioSource Scream;
    public GameObject Runner;
    public Transform FirstRunner;
    public GameObject currentrunner;
    // Start is called before the first frame update

    private void Start()
    {
        transform.rotation = Player.transform.rotation;
    }
    public void CorrectNote()
    {
        Farmer.GetComponent<Animator>().Play("Idle");
        transform.rotation = Player.transform.rotation;
       currentrunner= Instantiate(Runner, FirstRunner.position, FirstRunner.rotation);
        Destroy(currentrunner, 0.5f);
    }


    public void WrongNote()
    {

        transform.LookAt(Pigs);
        Instantiate(SlashEffect, Spawner.position, SlashEffect.transform.rotation);
        Scream.Play(); 
        Farmer.GetComponent<Animator>().Play("Attack");
    }

    private void Update()
    {
        currentrunner = Runner;
    }
}
