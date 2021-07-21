using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public KeyCode press2;
    public Animation anim;
    public SpriteRenderer Sr;
    public Sprite defaultSprite;
    public Sprite pressedSprite;
    public KeyCode press; 
    // Start is called before the first frame update
    void Start()
    {
        Sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(press)||Input.GetKeyDown(press2))
        {
            Sr.sprite = pressedSprite;
        }

        if (Input.GetKeyUp(press) || Input.GetKeyDown(press2))
        {
            Sr.sprite = defaultSprite;
        }
    }
}
