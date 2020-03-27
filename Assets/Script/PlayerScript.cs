using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    public int count = 0;
   // GameObject target;
    public Text pointText;
    float maxHP = 8;
    float currentHP = 0;
    float maxHeart = 20f;
    float currentHeart = 20f;
    public Image hp_bar;
    public Image heart;
    float heartTimer = 3f;
    float heartCount = 0;
    float timer = 60f;
    float resultTimer = 10f;
    public Text timerText;
    public Text resultText;



    AudioSource audioSource;
    public AudioClip pointSound;
    public AudioClip point2Sound;
    public AudioClip getSound;
    // Start is called before the first frame update
    void Start()
    {

        

        audioSource = this.gameObject.GetComponent<AudioSource>();
        //audioSource.clip = bgmSound;
        //audioSource.Play();

        
    }

    // Update is called once per frame
    void Update()
    {

        
        timerText.text = timer.ToString("f2");
        pointText.text = count.ToString();
        Debug.Log(count);
        hp_bar.fillAmount = currentHP / maxHP;
        heart.fillAmount = currentHeart / maxHeart;

        if (timer < 0)
        {
            resultTimer -= Time.deltaTime;
            if (resultTimer < 0)
            {
                PlayerPrefs.SetInt("score", count);
                if (count < 35)
                {
                    SceneManager.LoadScene("EndScene");
                }
                else
                {
                    SceneManager.LoadScene("DoorScene");
                }
                
            }
            timerText.text = "0.00";
            if (count < 35)
            {
                resultText.text = "GAME OVER";
            }
            else
            {
                resultText.text = "GAME CLEAR";
            }
            

        }
        else
        {
            timer -= Time.deltaTime;
            if (timer > 59.7f){
                resultText.text = "RUN AND GET!!";
            }
            else
            {
                resultText.text = "";
               
            }
            
        }


    
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Point"||col.gameObject.tag=="Point2")
        {
            Destroy(col.gameObject);
        }
        if (timer > 0)
        {
        
            if (col.gameObject.tag == "Point")
            {
                //target = GameObject.Find("GameManager");

                count += 1;
                currentHP += 0.2f;
                audioSource.clip = pointSound;
                audioSource.Play();


            }
            if (col.gameObject.tag == "Point2")
            {
                //target = GameObject.Find("GameManager");

                count += 2;
                currentHP += 0.4f;
                audioSource.clip = point2Sound;
                audioSource.Play();
                


            }
            if (col.gameObject.tag == "Enemy")
            {
                audioSource.clip = getSound;
                audioSource.Play();
            }

        }
    }
 



}
