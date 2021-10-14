using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int Health;      
        
    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health<=0)
        {
            Destroy(gameObject);
        }
    }
    
}
