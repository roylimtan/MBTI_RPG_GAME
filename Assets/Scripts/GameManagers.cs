using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagers : MonoBehaviour
{

    public GameObject MenuSet;
    public GameObject GameExplain;
    public GameObject MyInform;

    public Text NowatkTxt;
    public Text NowdefTxt;
    public Text NowspeedTxt;

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

        Debug.Log("���� ���ݷ� : " + Nowatk);
        Debug.Log("���� ���� : " + Nowdef);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Opensetting()
    {
        MenuSet.SetActive(true);
    }

    public void Continue()
    {
        MenuSet.SetActive(false);
    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void OpenHowto()
    {
        GameExplain.SetActive(true);
    }

    public void quitExplain()
    {
        GameExplain.SetActive(false);
    }

    public void OpenInform()
    {
        MyInform.SetActive(true);
        NowatkTxt.text = Nowatk.ToString();
        NowdefTxt.text = Nowdef.ToString();
        NowspeedTxt.text = Nowspeed.ToString();
    }

    public void quitInform()
    {
        MyInform.SetActive(false);
    }

}