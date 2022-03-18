using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Camera FPCamera;
    [SerializeField] private float range = 100f;
    [SerializeField] private float damage = 30f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {   
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        {
            Debug.Log("I hit this thing " + hit.transform.name);
            // TODO: Add some hit effect for visiual players
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            // Call a method on EnemyHealth that decreases the enemy's health
            
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }
     
        
    }
}
