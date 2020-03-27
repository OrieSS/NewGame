using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitychanManagerScript : MonoBehaviour
{
    private Animator anim;
    private GameObject obj;
    public float speed; //Playerの移動スピード
    bool canMoveUp, canMoveDown, canMoveRight, canMoveLeft = false;


    static int idleState = Animator.StringToHash("Base Layer.Idle");
    static int locoState = Animator.StringToHash("Base Layer.Locomotion");
    static int jumpState = Animator.StringToHash("Base Layer.Jump");
    static int restState = Animator.StringToHash("Base Layer.Rest");

    void Start()
    {
        obj = GameObject.Find("unitychan");
        anim = obj.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (canMoveUp == true)
        {
            obj.transform.position += new Vector3(0, 0, speed * Time.deltaTime); //上方向に移動
        }

        if (canMoveDown == true)
        {
            obj.transform.position += new Vector3(0, 0, -speed * Time.deltaTime); //下方向に移動
        }

        if (canMoveRight == true)
        {
            obj.transform.position += new Vector3(speed * Time.deltaTime, 0, 0); //右方向に移動
        }

        if (canMoveLeft == true)
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0); //左方向に移動
        }
    }
    public void Jumpbuttom()
    {
        anim.SetTrigger("Jump");
    }
    //上方向のボタン押した時に呼ばれる関数
    public void MoveUpButton_down()
    {
        canMoveUp = true;
    }

    //上方向のボタン離した時に呼ばれる関数
    public void MoveUpButton_up()
    {
        canMoveUp = false;
    }

    //下方向のボタン押した時に呼ばれる関数
    public void MoveDownButton_down()
    {
        canMoveDown = true;
    }

    //下方向のボタン離した時に呼ばれる関数
    public void MoveDownButton_up()
    {
        canMoveDown = false;
    }

    //右方向のボタン押した時に呼ばれる関数
    public void MoveRightButton_down()
    {
        canMoveRight = true;
    }

    //右方向のボタン離した時に呼ばれる関数
    public void MoveRightButton_up()
    {
        canMoveRight = false;
    }

    //左方向のボタン押した時に呼ばれる関数
    public void MoveLeftButton_down()
    {
        canMoveLeft = true;
    }

    //左方向のボタン離した時に呼ばれる関数
    public void MoveLeftButton_up()
    {
        canMoveLeft = false;
    }
}
