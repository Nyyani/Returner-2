using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Lives : MonoBehaviour {

    public Text livesText;
    private int numericalLives = 3;

	// Use this for initialization
	void Start () {
        numericalLives = PlayerPrefs.GetInt("lives", 3);
        livesText.text = numericalLives.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //This takes 1 life away from the player's count when they are hit by an enemy or fall into a pit
    public void LoseLife()
    {
        numericalLives = numericalLives - 1;
        livesText.text = numericalLives.ToString();
    }


    //This saves the lives that the player has remaining for the next level
    public void SaveLives()
    {
        PlayerPrefs.SetInt("lives", numericalLives);
    }


    //This checks if the player has ran out of their available lives, and if so, sends them to the Game Over screen
    public bool IsGameOver()
    {
        if (numericalLives <=0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
