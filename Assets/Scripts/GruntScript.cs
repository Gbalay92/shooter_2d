using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntScript : MonoBehaviour
{
    public GameObject john;
    private float lastShoot;
    public GameObject BulletPrefab;
    private int health=2;

    void Update()
    {
        if(john==null){return;}
        Vector3 direction = john.transform.position-transform.position;
        if(direction.x >= 0.0f){
            transform.localScale=new Vector3(1.0f,1.0f,1.0f);
        }else{
            transform.localScale=new Vector3(-1.0f,1.0f,1.0f);
        }

        float distance =Mathf.Abs(john.transform.position.x-transform.position.x);
        if(distance<1.0f && Time.time>lastShoot+0.25f){
            lastShoot=Time.time;
            Shoot();
        }
        
    }
    private void Shoot(){
        Vector3 direction;
        if(transform.localScale.x==1.0f){
            direction = Vector2.right;
        }else{
            direction = Vector2.left;
        }
        GameObject bullet=Instantiate(BulletPrefab, transform.position + direction*0.1f, Quaternion.identity);
        bullet.GetComponent<BulletScript>().setDirection(direction);
        }

        public void Hit(){
        health-=1;
        if(health==0){
            Destroy(gameObject);
        }
    }
}
