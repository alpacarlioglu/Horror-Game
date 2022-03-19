using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;
     
    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;
    private Animator myAnim;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        myAnim = GetComponent<Animator>();
    }

    void Update()
    {  
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (isProvoked)
        {
            EngageTarget();
        }

        else if(distanceToTarget < chaseRange)
        {   
            isProvoked = true;
        }
    }

    private void EngageTarget()
    {
        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }

        if(distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            AttackTarget();
        }
    } 

    private void ChaseTarget() 
    {   
        myAnim.SetBool("attack", false);
        myAnim.SetTrigger("move");
        navMeshAgent.SetDestination(target.position);
    }
        
    void AttackTarget()
    {   
        myAnim.SetBool("attack", true);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
