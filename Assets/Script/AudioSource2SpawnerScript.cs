using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSource2SpawnerScript : MonoBehaviour
{
    float timer = 60f;
    float express1Time = 40f;
    float express2Time = 10f;
    public GameObject AudioSource2;
    public bool witch;
    bool witch2;

    // Start is called before the first frame update
    void Start()
    {
        witch = false;
        witch2 = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < express1Time&&witch==false)
        {

            Instantiate(AudioSource2, new Vector3(1.0f, 1.0f, 0.0f), Quaternion.identity);
            witch = true;
        }
        if (timer < express2Time && witch2 == true)
        {
            Instantiate(AudioSource2, new Vector3(1.0f, 1.0f, 0.0f), Quaternion.identity);
            witch2 = false;
        }
       
    }
}