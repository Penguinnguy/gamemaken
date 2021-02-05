using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    private float speed = 240;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Literally just rotates the enemy objects......
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);  
    }
}