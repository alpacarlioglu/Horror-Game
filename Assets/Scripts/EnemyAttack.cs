using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] float damage = 40f;
    
    void Start()
    {
            
    }
    
    // Enemy hits exact moment that we set
    public void AttackHitEvent()
    {   
        if (target == null )
            return;
        Debug.Log("Bang bang");
    }
    
}
