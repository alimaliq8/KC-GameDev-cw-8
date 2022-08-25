using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    bool faceRight = false;
    SpriteRenderer sprite;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        sprite=GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        flipe();
        playeranimations();
    }
    void flipe()
    {
        if (Input.GetKeyDown(KeyCode.D) && faceRight == false)
        {
            sprite.flipX = false;
            faceRight = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && faceRight == true)
        {
            sprite.flipX = true;
            faceRight = false;
        }
    }
    void playeranimations()
    {
        float speed = Input.GetAxis("Horizontal");
        anim.SetFloat("speed", speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jump");
        }
    }
}
