using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Taco")
        {
            Score.scoreAmount += 1;
            Destroy(collision.gameObject);
        }        
    }
    
}
