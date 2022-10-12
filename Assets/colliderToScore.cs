using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderToScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        ScoreCounter.Score++;
    }
}
