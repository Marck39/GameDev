using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{    
    public int DealingDamage;
    public Rigidbody2D BulletBody;

    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }
        else
        {
            other.GetComponent<EnemyBehaviour>().health -= DealingDamage;
            Destroy(gameObject);
        }
        
    }
}
