using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HelloweenEndSceneScript : MonoBehaviour
{
    public Text endText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        endText.text = "MISSiON CLEaR";
    }
    public void StartButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}
