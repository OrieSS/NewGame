using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelloweenStartSceneScript2 : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip bgm;

    // Start is called before the first frame update
    void Start()
    {
        audioSource=this.gameObject.GetComponent<AudioSource>();
        audioSource.clip = bgm;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButton()
    {
        SceneManager.LoadScene("HelloweenStage");
    }
}
