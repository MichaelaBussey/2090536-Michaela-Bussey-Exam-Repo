using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool PokerClicked = false;
    public TextScript textScript;
    void Start()
    {

    }

    void Update()
    {

    }

    public void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0) && gameObject.name == "Poker")
        {

            Debug.Log("Clicked");
            textScript.PokerText();
            //Destroy("Poker");

        }

        /*else if (Input.GetMouseButtonDown(0) && gameObject.name == "Coat")
        {
            if (cm.BookNote == true)
            {
                Debug.Log("Coat");
                TextScript.CoatNote();
                cm.CoatNote = true;
            }*/
            else { }
        }
    }

