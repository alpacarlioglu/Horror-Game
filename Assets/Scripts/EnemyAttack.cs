using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 40f;
    
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }
    
    // Enemy hits exact moment that we set
    public void AttackHitEvent()
    {   
        if (target == null )
            return;
        target.TakeDamage(damage);
        Debug.Log("Bang bang");
    }
    
}
