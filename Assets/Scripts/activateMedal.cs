using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateMedal : MonoBehaviour
{

    public int ScoreMin;
    public int ScoreMax;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (ScoreCounter.Score >= ScoreMin && ScoreCounter.Score < ScoreMax) {
            GetComponent<UnityEngine.UI.Image>().enabled = true;
            if (Time.deltaTime <= 0) {
                GetComponent<Animator>().enabled = true;
                GetComponent<Animator>().Play("MedalFadeIn");
            }
        } else {
            GetComponent<UnityEngine.UI.Image>().enabled = false;
        }
    }
}
