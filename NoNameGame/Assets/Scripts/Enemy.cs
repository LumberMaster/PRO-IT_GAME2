using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    public int money_per_kill;
    public GameObject gun;

    private void Update()
    {
        if (health <= 0)
        {
            GameObject.FindWithTag("Player").GetComponent<Player>().money += money_per_kill;
            Destroy(gameObject);
        }

        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    
}
