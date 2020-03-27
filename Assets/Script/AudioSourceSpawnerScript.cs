using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceSpawnerScript : MonoBehaviour
{

    float timer=60f;
    float express1Time = 40f;
    float round2Time = 30f;
    public GameObject AudioSource;
    public GameObject AudioSource2;
    public bool witch;

    // Start is called before the first frame update
    void Start()
    {
        witch = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer > express1Time&&witch==true)
        {
            Instantiate(AudioSource, new Vector3(1.0f, 1.0f, 0.0f), Quaternion.identity);
            witch = false;
        }

        if (timer < round2Time && witch == false)
        {
            Instantiate(AudioSource, new Vector3(1.0f, 1.0f, 0.0f), Quaternion.identity);
            witch = true;
        }
        
        
    }
}
