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

        Debug.Log("���� ���� : " + character_Lv);
        Debug.Log("�������� �ʿ��� ����ġ : " + needExp);
        Debug.Log("���� ����ġ : " + currentExp);
    }
    public void ChooseI()
    {
        atk = 10;
        def = 12;
        Maxhp = 70;
        currentHp = 70;

        Debug.Log("���ݷ� : " + atk);
        Debug.Log("���� : " + def);
        Debug.Log("�ִ� ü�� : " + Maxhp);
        Debug.Log("���� ü�� : " + currentHp);
    }

    public void ChooseE()
    {
        atk = 12;
        def = 10;
        Maxhp = 50;
        currentHp = 50;

        Debug.Log("���ݷ� : " + atk);
        Debug.Log("���� : " + def);
        Debug.Log("�ִ� ü�� : " + Maxhp);
        Debug.Log("���� ü�� : " + currentHp);
    }

    public void ChooseS()
    {
        speed = 15;
        Debug.Log("�ӵ� : " + speed);
    }

    public void ChooseN()
    {
        speed = 13;
        dashspeed = 18;
        Debug.Log("���� �ӵ� : " + speed);
        Debug.Log("�뽬���� �ӵ� : " + dashspeed);
    }

    public void Clickbtn()
    {
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;

        Debug.Log("���� MBTI : " + clickObject.name);
    }

}
