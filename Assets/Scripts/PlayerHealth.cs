using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int health;

    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "MeleeMinion") {
            var Script = collision.gameObject.GetComponent<EnemyMovement>();
            health -= Script.damage;
            Destroy(collision.gameObject);
            if (health <= 0)
            {
                Debug.Log("dead");
            }
        }
    }
}
