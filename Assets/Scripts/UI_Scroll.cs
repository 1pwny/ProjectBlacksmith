using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Scroll : Button
{
    public GameObject me;
    public Image closed, opened;

    private bool open = false; //true = open scroll, false = closed scroll

    // Update is called once per frame
    void Update()
    {
        if(open)
        {
            opened.gameObject.SetActive(true);
            closed.gameObject.SetActive(false);
        }
        else
        {
            opened.gameObject.SetActive(false);
            closed.gameObject.SetActive(true);
        }
    }

    //furls or unfurls the scroll
    public void furl()
    {
        open = !open;
        Debug.Log("furled? " + open);
    }

}
