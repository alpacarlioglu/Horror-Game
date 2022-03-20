using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float hitPoints = 100f;

    public bool isDead = false;
    
    public bool IsDead()
    {
        return isDead;
    }
    
    public void TakeDamage(float damage)
    {   
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Die();
            // Destroy(gameObject);
        }
    }

    private void Die()
    {   
        if (isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("dead");
        // GetComponent<EnemyAI>().enabled = false;
        // Destroy(gameObject);
    }
}
