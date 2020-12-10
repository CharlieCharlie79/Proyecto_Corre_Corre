using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearth_System : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    private bool dead;
    public GameObject player;
    public int damage = 1;
    public GameObject playerParticle;
    public GameManager ScreenEnd;

    private void Start()
    {
        life = hearts.Length;
    }

    // Start is called before the first frame update
    void Update()
    {
       if(dead == true)
        {
            //Debug.Log("Particles");
            Instantiate(playerParticle, transform.position, Quaternion.identity);

            //Play death effect sound
            FindObjectOfType<AudioManager>().Play("Death");

            ScreenEnd.GameEnd();

            Destroy(player);

        }
    }

    
   public void TakeDamage()
    {
        if (life >= 1)
        {
            life -= damage;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                dead = true;
            }
        }
    }

   

}
