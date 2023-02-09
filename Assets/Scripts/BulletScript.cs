using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{   
    public float speed;
    private Rigidbody2D rigidbody2D;
    private Vector2 Direction;
    // Start is called before the first frame update
    void Start(){
        rigidbody2D = GetComponent<Rigidbody2D>();
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
}
