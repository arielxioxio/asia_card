﻿using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("女" )]
   public Transform women;
    [Header("男")]
    public Transform man;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
   [Header("旋轉速度"),Range(0.1f,20f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;
    [Header("女動畫元件")]
    public Animator aniWoman;
    [Header("男動畫元件")]
    public Animator aniMan;


    private void Start()

    {
        print("開始事件執行中");

 
    }
    private void Update()
    {
        print("更新事件");
            print(joystick.Vertical);
        women.Rotate(0, joystick.Horizontal*turn, 0);
        man.Rotate(0, joystick.Horizontal * turn, 0);

        women.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size ;    }
    public void Attack()
    {
        print("攻擊");
        aniWoman.SetTrigger("女生攻擊");
        print("死亡");
        aniWoman.SetTrigger("女生死亡");
    }




}
