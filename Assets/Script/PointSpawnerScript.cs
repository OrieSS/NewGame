using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawnerScript : MonoBehaviour
{
    public GameObject point;
    float timer;
    GameObject target; // <-[Player]の部分を追いかけたいGameObjectの名前に変える
   
    //public float torque; // 回転力
    //public float firstVelocity;// 初期速度
    //public float accelation; // 加速度

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("unitychan"); // <-[Player]の部分を追いかけたいGameObjectの名前に変える
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            
            Instantiate(point, target.transform.position+target.transform.forward*15+new Vector3(0,2,0) + this.transform.right * Random.Range(-4.0f, 4.0f), target.transform.rotation * new Quaternion(0,180,0,0));
            timer = 0;
        }
        
    }
}
