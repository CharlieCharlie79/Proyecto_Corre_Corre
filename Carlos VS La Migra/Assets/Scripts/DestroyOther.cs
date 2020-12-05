using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{
    public GameObject somethingElse;

   // public PlayerController controller;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag =="character")
        {
            Destroy(somethingElse);
            //Debug.Log("Is touching");
           // FindObjectOfType<GameManager>().GameEnd();
        }


    }

   
}
