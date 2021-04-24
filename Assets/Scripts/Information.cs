using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Information : MonoBehaviour
{
    public int Nowchar_Lv;
    public int NowneedEXP;
    public int NowCurrentExp;

    public int NowMaxhp;
    public int NowCurrentHp;

    public int Nowatk;
    public int Nowdef;

    public int Nowspeed;
    public int dashspeed;

    GameObject Characterinform;

    // Start is called before the first frame update
    void Start()
    {
        Characterinform = GameObject.Find("Statdata");
        Nowchar_Lv = Characterinform.GetComponent<Choosembti>().character_Lv;
        NowneedEXP = Characterinform.GetComponent<Choosembti>().needExp;
        NowCurrentExp = Characterinform.GetComponent<Choosembti>().currentExp;

        NowMaxhp = Characterinform.GetComponent<Choosembti>().Maxhp;
        NowCurrentHp = Characterinform.GetComponent<Choosembti>().currentHp;

        Nowatk = Characterinform.GetComponent<Choosembti>().atk;
        Nowdef = Characterinform.GetComponent<Choosembti>().def;

        Nowspeed = Characterinform.GetComponent<Choosembti>().speed;
        dashspeed = Characterinform.GetComponent<Choosembti>().dashspeed;

        Debug.Log("현재 공격력 : " + Nowatk);
        Debug.Log("현재 방어력 : " + Nowdef);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
