using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{   
    public AudioClip pium;
    public float speed;
    private Rigidbody2D rigidbody2D;
    private Vector2 Direction;
    // Start is called before the first frame update
    void Start(){
        rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(pium);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        rigidbody2D.velocity=Direction * speed;
    }

    public void setDirection(Vector2 direction){
        Direction=direction;
    }

    public void DestroyBullet(){
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        JohnMovement john = collision.GetComponent<JohnMovement>();
        GruntScript grunt=collision.GetComponent<GruntScript>();

        if(john!=null){
            john.Hit();
        }else if(grunt!=null){
            grunt.Hit();
        }
        DestroyBullet();
    }

}
