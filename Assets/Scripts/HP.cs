using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int health = 100;


    public GameObject deathFX;
        private void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

        private void Die()
    {
        // Load the GameOver Scene
        FindObjectOfType<Level>().LoadGameOver();

        deathFX.transform.position = transform.position;
        deathFX.transform.rotation = Quaternion.identity;
        deathFX.SetActive(true);

        Destroy(transform.parent.gameObject);
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageDealer damageDealer = collision.gameObject.GetComponent<DamageDealer>();

        if (damageDealer)
        {
            TakeDamage(damageDealer.GetDamage());

            damageDealer.Hit();
        }

        Shield shield = GetComponent<Shield>();

        if (shield != null)
        {
            Debug.Log("Got a " + shield);
        }
    }
}
