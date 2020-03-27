using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawnerScript : MonoBehaviour
{
    public GameObject sphere;
    public GameObject death;

    float timer=0;
    // Start is called before the first frame update
    void Start()
    {
      //  x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer>5)
        {
            Instantiate(sphere, new Vector3(2.07f, 1.003f, -3.58f), Quaternion.identity);
            Instantiate(death, new Vector3(2.0f, 1.00f, -3f), Quaternion.identity);
            timer=0;
           // x = 0;
        }
    }
 
}
