using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    float speed = 3.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 8.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * speed * Time.deltaTime;
    }
}
