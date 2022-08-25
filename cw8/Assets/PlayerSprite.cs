using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    SpriteRenderer sprite;
    bool facingRight = true;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        flipSprite();
        playerAnimations();
    }

    void flipSprite()
    {
        if(facingRight == true && Input.GetKeyDown(KeyCode.A))
        {
            sprite.flipX = true;
            facingRight = false;
        }
        else if(facingRight == false && Input.GetKeyDown(KeyCode.D))
        {
            sprite.flipX = false;
            facingRight = true;
        }
    }

    void playerAnimations()
    {
        float speed = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(speed));

        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }
    }
}
