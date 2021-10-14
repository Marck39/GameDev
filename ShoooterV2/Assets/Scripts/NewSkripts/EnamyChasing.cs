using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnamyChasing : MonoBehaviour
{
    public float speed;
    public float StopDist;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position)> StopDist)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
    }
}
