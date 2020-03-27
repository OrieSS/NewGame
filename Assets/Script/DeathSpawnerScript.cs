using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpawnerScript : MonoBehaviour
{
    public GameObject death;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //if (timer > 3)
        //{
        //    Instantiate(death, new Vector3(2.07f, 1.003f, -3.58f), Quaternion.identity);
        //    timer = 0;
        //}
    }
}
