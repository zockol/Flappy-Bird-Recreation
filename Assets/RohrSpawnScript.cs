using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RohrSpawnScript : MonoBehaviour
{

public float maxTime = 1;
private float timer = 0;
public GameObject Rohr;
public float hoehe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime) {
            GameObject neuesRohr = Instantiate(Rohr);
            neuesRohr.transform.position = transform.position + new Vector3(0, Random.Range(-hoehe, hoehe), 0);
            Destroy(neuesRohr, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
        
    }
}
