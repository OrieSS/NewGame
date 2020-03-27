using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionScript : MonoBehaviour
{
    GameObject target;
    GameObject target2;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Unitychan");
        target2 = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        // this.rectTransform.rotation.z = Mathf.Atan((target2.transform.position.x - target.transform.position.x)/(target2.transform.position.y - target.transform.position.y))+90;
    }
}
