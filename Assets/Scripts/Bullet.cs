using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb.velocity = transform.right * speed;
	}
	
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
       Damage enemy = hitInfo.GetComponent<Damage>();
        if(enemy != null)
        {
            enemy.TakeDamage(100);
        }

        Destroy(gameObject);
    }

}
