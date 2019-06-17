using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{

    // Variable for adding to the score
    public Score scoreObject;

    // Variable to hold the pickup's point value
    public int timepieceValue;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Unity calls this function when our pickup touches any other object
    //If the player touches the pickup object, it will disappear and the player's score will go up

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Check if the thing we touched was the Player
        Player playerScript = collision.collider.GetComponent<Player>();

        //If the thing we touched has the player script, that means it IS the player, so....
        if (playerScript)
        {
            //We hit the player!
            SoundManagerScript.PlaySound("coinSound");
            //Add to the score based on our value
            scoreObject.AddScore(timepieceValue);

            //Destroy the gameObject that this script is attached to (the coin)
            Destroy(gameObject);

        }

    }



}