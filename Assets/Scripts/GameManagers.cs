using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour
{

    public GameObject MenuSet;
    public GameObject GameExplain;
    public GameObject MyInform;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    public void quitInform()
    {
        MyInform.SetActive(false);
    }

}
