using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("HighScore") < ScoreCounter.Score) {
            PlayerPrefs.SetInt("HighScore", ScoreCounter.Score);
        }

        GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
