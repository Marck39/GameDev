using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform FirePoint;

    public float Speed = 20f;    

    public GameObject Bullet;

    private float TimeBetweenShots;
    public float StartTimeBetweenShots;

    public void Start()
    {       
    }

    void Update()
    {
        if (TimeBetweenShots <= 0)
        {  
            TimeBetweenShots = StartTimeBetweenShots;         
            GameObject bullet = Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(FirePoint.up * Speed, ForceMode2D.Impulse);
            
        }
        else
        {
            TimeBetweenShots -= Time.deltaTime;
        }
    }
}
