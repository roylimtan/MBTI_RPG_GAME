using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Choosembti : MonoBehaviour
{

    public int character_Lv;
    public int needExp;
    public int currentExp;

    public int Maxhp;
    public int currentHp;

    public int atk;
    public int def;

    public int speed;
    public int dashspeed;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Level()
    {
        character_Lv = 1;
        needExp = 30;
        currentExp = 0;

        Debug.Log("현재 레벨 : " + character_Lv);
        Debug.Log("레벨업에 필요한 경험치 : " + needExp);
        Debug.Log("현재 경험치 : " + currentExp);
    }
    public void ChooseI()
    {
        atk = 10;
        def = 12;
        Maxhp = 70;
        currentHp = 70;

        Debug.Log("공격력 : " + atk);
        Debug.Log("방어력 : " + def);
        Debug.Log("최대 체력 : " + Maxhp);
        Debug.Log("현재 체력 : " + currentHp);
    }

    public void ChooseE()
    {
        atk = 12;
        def = 10;
        Maxhp = 50;
        currentHp = 50;

        Debug.Log("공격력 : " + atk);
        Debug.Log("방어력 : " + def);
        Debug.Log("최대 체력 : " + Maxhp);
        Debug.Log("현재 체력 : " + currentHp);
    }

    public void ChooseS()
    {
        speed = 15;
        Debug.Log("속도 : " + speed);
    }

    public void ChooseN()
    {
        speed = 13;
        dashspeed = 18;
        Debug.Log("현재 속도 : " + speed);
        Debug.Log("대쉬사용시 속도 : " + dashspeed);
    }

    public void Clickbtn()
    {
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;

        Debug.Log("나의 MBTI : " + clickObject.name);
    }

}
