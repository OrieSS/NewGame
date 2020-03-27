using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Attack : MonoBehaviour
{
    private Animator animator;
    int point;
    float timer=5f;
    public Text pointText;
    AudioSource audioSource;
    public AudioClip bgm;

    //左手のコライダー
    private Collider handCollider;
    //右足のコライダー
    private Collider footCollider;

    // Use this for initialization
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        audioSource.clip = bgm;
        audioSource.Play();
        //PlayerのAnimatorコンポーネントを取得する
        animator = GetComponent<Animator>();

        //左手のコライダーを取得
        handCollider = GameObject.Find("Character1_LeftHand").GetComponent<SphereCollider>();
        //右足のコライダーを取得
        footCollider = GameObject.Find("Character1_RightFoot").GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {

        //Aを押すとjab
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Jab", true);

            //左手コライダーをオンにする
            handCollider.enabled = true;

            //一定時間後にコライダーの機能をオフにする
            Invoke("ColliderReset", 0.3f);
        }

        //Sを押すとHikick
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Hikick", true);

            //右足コライダーをオンにする
            footCollider.enabled = true;

            //一定時間後にコライダーの機能をオフにする
            Invoke("ColliderReset", 1.5f);
        }

        //Dを押すとSpinkick
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Spinkick", true);

            //右足コライダーをオンにする
            footCollider.enabled = true;

            //一定時間後にコライダーの機能をオフにする
            Invoke("ColliderReset", 1.5f);
        }


    }


    private void ColliderReset()
    {
        handCollider.enabled = false;
        footCollider.enabled = false;
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Destroy(col.gameObject);
            point += 1;
            pointText.text = point.ToString();

        }
        
    }


}
