using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    //This function is called automatically when the player touches anything that will damage them (a slime enemy or a pit)

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This makes sure that whatever has touched the 'Damage' object, has the player script attached to them.
        Player playerScript = collision.collider.GetComponent<Player>();
        {
            // This will kill the player if it was actually the player that was touched by the Damage object
            if (playerScript != null)

                playerScript.Kill();


        }

    }
}
