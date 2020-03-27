using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    //float speed = 0.8f;
    //Vector3 playerpos;

    // Start is called before the first frame update
    GameObject target;
    public float torque; // 回転力
    public float firstVelocity;// 初期速度
    public float accelation; // 加速度
    AudioSource audioSource;
    public AudioClip bgmSound;
    public AudioClip bgm2Sound;
    float timer = 60f;
    float countTimer = 3f;
    float countTimer2 = 3f;
    //public int count;

    float round1Time = 60f;
    float express1Time = 40f;
    float round2Time = 30f;
    float express2Time = 20f;

    public Image direction;

    public GameObject AudioSource;


    public int count;

    void Start()
    {
        target = GameObject.Find("unitychan"); // <-[Player]の部分を追いかけたいGameObjectの名前に変える
        audioSource = this.gameObject.GetComponent<AudioSource>();

        
          //  audioSource.clip = bgmSound;
           // audioSource.Play();
       
   

    }

    void Update()
    {
        timer -= Time.deltaTime;
        
        if (express1Time < timer)
        {
            float velocity = firstVelocity + accelation * Time.deltaTime;
            this.transform.position += this.transform.forward * velocity;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(-target.transform.position + this.transform.position), torque);
            // Destroy(this.gameObject<EnemyScript>().direction);
        }
        else
        {
            if (timer > round2Time)
            {
                float velocity = 0;//firstVelocity + accelation * Time.deltaTime;
                this.transform.position += new Vector3(0, 0, 0);
                
                //audioSource.clip = bgm2Sound;
                //audioSource.Play();

            }
            else
            {
                if (timer > express2Time)
                {
                    float velocity = firstVelocity + accelation * Time.deltaTime;
                    this.transform.position += this.transform.forward * velocity;
                   // audioSource.clip = bgmSound;
                    //audioSource.Play();
                    
                }
                else
                {
                    if (timer > 0f)
                    {
                        float velocity = 0;//firstVelocity + accelation * Time.deltaTime;
                        this.transform.position += new Vector3(0, 0, 0);
                       // audioSource.clip = bgm2Sound;
                        //audioSource.Play();
                    }
                    
                }
            }
        }

           
           
        }


   



    
}





