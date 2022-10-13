using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{

    public float velocity = 1;
    private Rigidbody2D Vogel;
    public GameOverScript gameManager;

    // Start is called before the first frame update
    void Start()
    {
        Vogel = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space")) {

            if (GetComponent<Animator>().enabled == false) {
                GetComponent<Animator>().enabled = true;
            }

            Vogel.velocity = Vector2.up * velocity;
            if (Time.deltaTime != 0) {
                GetComponent<Animator>().Play("Fly Animation",  -1, 0f);
            }
            

        }

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        gameManager.GameOver();
    }
}
