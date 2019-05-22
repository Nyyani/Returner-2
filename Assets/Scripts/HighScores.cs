using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class HighScores : MonoBehaviour {
    //Test component used to display the highscores
    public List<Text> highScoreDisplays = new List<Text>();

    //Internal data for score values
    private List<int> highScoreData = new List<int>();

    // Use this for initialization
    void Start()
    {

        //Load the highscore data from the PlayerPrefs
        LoadHighScoreData();

        //Get our current score from PlayerPrefs
        int currentScore = PlayerPrefs.GetInt("score", 0);


        //Check if we got a new high score
         bool haveNewHighScore = IsNewHighScore(currentScore);
        if (haveNewHighScore == true)
        {

            //Add new score to data
            AddScoreToList(currentScore);

            //Save updated data 
            SaveHighScoreData();
        }



            //Update the visual display
        UpdateVisualDisplay();
    }

    // Update is called once per frame
    void Update() {

    }

    private void LoadHighScoreData()
    {
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            //Using the loop index, get the name for our PlayerPrefs key
            string prefsKey = "highScore" + i.ToString();

            //Use this key to get the high score value from PlayerPrefs
            int highScoreValue = PlayerPrefs.GetInt(prefsKey, 0);

            //Store this score value in our internal data list
            highScoreData.Add(highScoreValue);
        }
    }

    private void UpdateVisualDisplay()
    {
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            highScoreDisplays[i].text = highScoreData[i].ToString();
        }
    }

    private bool IsNewHighScore(int scoreToCheck)
    {
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            if (scoreToCheck > highScoreData[i])
            {
                //Our score is higher
                // Return to the calling code that we DO have a new high score
                return true;
            }
        }

        //default False
        //we did NOt find any scores that our scores was higher than.
        return false;
    }

    private void AddScoreToList(int newScore)
    {
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            if (newScore > highScoreData[i])
            {
                //Our score IS higher
                //Since we're going from highest to lowest, the first time our score is higher, this is where it must go

                //Insert the new score into the list here
                highScoreData.Insert(i, newScore);

                // Trim the last item off the list
                highScoreData.RemoveAt(highScoreData.Count - 1);

                //We're done we must exit early
                return;

            }
        }
    }


    private void SaveHighScoreData()
    {
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            //Using the loop index, get the name for our PlayerPrefs key
            string prefsKey = "highScore" + i.ToString();

            //Get the curent high score entry from the data
            int highScoreEntry = highScoreData[i];

            //Save this data t the PlayerPrefs
            PlayerPrefs.SetInt(prefsKey, highScoreEntry);
        }

        //save the player prefs to disk
        PlayerPrefs.Save();


    }
}
