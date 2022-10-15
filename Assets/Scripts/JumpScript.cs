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

            if (transform.position.y < 4.5) {
                Vogel.velocity = Vector2.up * velocity;
            } else {
                Vogel.velocity = Vector2.up * 1;
            }
            if (Time.deltaTime != 0) {
                GetComponent<Animator>().Play("Fly Animation",  -1, 0f);
            }
            

        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        gameManager.GameOver();
    }
}

    



