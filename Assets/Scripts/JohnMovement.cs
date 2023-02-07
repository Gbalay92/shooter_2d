using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnMovement : MonoBehaviour
{
    public float speed;
    public float jump_force;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    private float horizontal;
    private bool suelo;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D=GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontal=Input.GetAxisRaw("Horizontal");

        if (horizontal<0.0f){
            transform.localScale=new Vector3(-1.0f, 1.0f, 1.0f);
        }else if (horizontal>0.0f){
            transform.localScale=new Vector3(1.0f, 1.0f, 1.0f);
        }


        animator.SetBool("running", horizontal != 0.0f);

        if(Physics2D.Raycast(transform.position, Vector3.down, 0.1f)){
            suelo=true;
        }else{
            suelo=false;
        }
        if (Input.GetKeyDown(KeyCode.W) && suelo)
        {
            Jump();
        }
    
    }

    void Jump(){
        rigidbody2D.AddForce(Vector2.up*jump_force);
    }

    void FixedUpdate(){
        rigidbody2D.velocity=new Vector2(horizontal*speed, rigidbody2D.velocity.y);

    }
}
