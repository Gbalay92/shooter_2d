using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_script : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        JohnMovement john = collision.GetComponent<JohnMovement>();
        john.health=john.health+1;
        Destroy(gameObject);
    }
}
