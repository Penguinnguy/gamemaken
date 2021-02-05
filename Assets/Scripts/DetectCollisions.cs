using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // When a player collides with an enemy object the enemy object gets destroyed and 10 points get added to the score
        if (collision.collider.CompareTag("Enemy"))
        {
            ScoreScript.scoreValue += 10;
            Debug.Log("Collision detected");
            Destroy(collision.gameObject);
        }
    }
}