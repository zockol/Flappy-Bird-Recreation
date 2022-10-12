using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{

    public static int Score = 0;
    public static string ScoreText = "";

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText = Score.ToString();
        GetComponent<UnityEngine.UI.Text>().text = ScoreText;
    }
}
