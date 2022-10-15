using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutScore : MonoBehaviour
{
    private bool FadedIn;
    // Update is called once per frame
    void Update()
    {
        if (Time.deltaTime > 0) {
            GetComponent<Animator>().enabled = false;
            GetComponent<Animator>().enabled = true;
            //GetComponent<Animator>().Play("Score Fade In");
            FadedIn = true;
        }
        if (Time.deltaTime <= 0 && FadedIn == true) {
            GetComponent<Animator>().enabled = false;
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().Play("Score Fade Out");
            FadedIn = false;
        }
    }
}
