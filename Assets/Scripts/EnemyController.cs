using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 9)
        {
            if (collider.GetComponent<Rigidbody2D>().velocity.y <= 0f)
            {
                Destroy(this.gameObject);
            }           
        }
    }
}
