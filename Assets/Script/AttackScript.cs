using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AttackScript : MonoBehaviour
{
    public Text pointText;
    int point;
    int x;
    float timer = 5f;
    //public GameObject death;
    AudioSource audioSource;
    public AudioClip bgm;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        point = 0;
        audioSource = this.gameObject.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = point.ToString();
        Destroy(this.gameObject, 4.0f);
      
     
    }
     void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")//ok
        {
            // this.transform.localScale = this.transform.localScale + new Vector3(0.1f, 0.1f, 0.1f);

            // Instantiate(death, new Vector3(2.07f, 1.003f, -3.58f), Quaternion.identity);
            audioSource.clip = bgm;
            audioSource.Play();
            //point += 1;
            //pointText.text = point.ToString();
            if (point > 5)
            {
                timer -= Time.deltaTime;
                if (timer < 0)
                {
                    SceneManager.LoadScene("HelloweenEndScene");
                }


            }


        }
    }
  }

