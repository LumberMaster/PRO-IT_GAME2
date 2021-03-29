using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    public float lifetime;

    public float distance;

    public int damage;

    public LayerMask whatIsSolid;
  
    private void Update()
    {
        // RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        // if (hitInfo.collider != null)
        // {
        //     if (hitInfo.collider.CompareTag("Enemy"))
        //     {
        //         hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
        //     }
        //     Destroy(gameObject);
        // }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }


    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Enemy"){
            other.gameObject.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(gameObject);
        }
        // if(other.gameObject.tag == "Map"){
        //     Destroy(gameObject);
        // }
    }
}

