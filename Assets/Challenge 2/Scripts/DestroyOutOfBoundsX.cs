using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private sbyte _leftLimit = -35;
    private sbyte _bottomLimit = -1;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < _leftLimit) // Destroy dogs if x position less than left limit
        {
            Destroy(gameObject);
        } 
        
        else if (transform.position.y < _bottomLimit) // Destroy balls if y position is less than _bottomLimit
        {
            Destroy(gameObject);
        }

    }
}
