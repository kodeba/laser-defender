using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int health = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageDealer damageDealer = collision.gameObject.GetComponent<DamageDealer>();
        if(damageDealer != null)
        {
            health -= damageDealer.GetDamage();
            damageDealer.Hit();
            HealthCheck();
        }
    }

    private void HealthCheck()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
