using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickChecker : MonoBehaviour
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
        if (Input.GetMouseButtonDown(0) && gameObject.name == "LETTERS" && textScript.isTyping == false)
        {
            textScript.LetterText();
        }

        if (Input.GetMouseButtonDown(0) && gameObject.name == "RIDDLE" && textScript.isTyping == false)
        {
            textScript.RiddleText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "POKER" && textScript.isTyping == false)
        {
            textScript.PokerText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "STOOL" && textScript.isTyping == false) 
        {
            textScript.StoolText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "CORNER" && textScript.isTyping == false)
        {
            textScript.Carpet1Text();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "SCISSORS" && textScript.isTyping == false)
        {
            textScript.ScissorsText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "cloth" && textScript.isTyping == false)
        {
            textScript.ClothText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "DAGGER" && textScript.isTyping == false)
        {
            textScript.DaggerText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "BAG" && textScript.isTyping == false)
        {
            textScript.BagText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "hanger" && textScript.isTyping == false)
        {
            textScript.HangerText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "KEY" && textScript.isTyping == false)
        {
            textScript.KeyText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "goat" && textScript.isTyping == false)
        {
            textScript.LockGoatText();
        }
        /*else if (Input.GetMouseButtonDown(0) && gameObject.name == "KEY")
        {
            textScript.KeyText();
        }*/

        else { }
        }
    }

