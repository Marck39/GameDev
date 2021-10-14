using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour
{
    [SerializeField] Transform target;

    private NavMeshAgent agent;
   
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        agent = GetComponent<NavMeshAgent>();
        agent.updatePosition = false;
        agent.updateRotation = false;

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
