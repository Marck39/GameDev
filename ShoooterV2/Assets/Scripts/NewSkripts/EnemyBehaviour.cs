using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public int health;
    public int damage;
    
    public float speed;
    public float StopDist;
    public float RetreatDist;

    public GameObject bullet;
    public Transform player;

    private float TimeBetweenShots;
    public float StartTimeBetweenShots;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        TimeBetweenShots = StartTimeBetweenShots;
    }
    
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > StopDist)
        {         
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        } 
        else if (Vector2.Distance(transform.position, player.position)< StopDist&& Vector2.Distance(transform.position, player.position)>RetreatDist)
        {
            transform.position = this.transform.position;
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }

        if(TimeBetweenShots<=0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            TimeBetweenShots = StartTimeBetweenShots;
        }
        else
        {
            TimeBetweenShots -= Time.deltaTime;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<PlayerMovemant>().health -= damage;
    }
}
