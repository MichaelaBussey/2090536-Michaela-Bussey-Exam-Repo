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
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "papers" && textScript.isTyping == false)
        {
            textScript.NotesText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "sword" && textScript.isTyping == false)
        {
            textScript.SwordText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "Painting" && textScript.isTyping == false)
        {
            textScript.PaintingText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "Books" && textScript.isTyping == false)
        {
            textScript.BooksText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "Cut up paper" && textScript.isTyping == false)
        {
            textScript.PaperText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "crown" && textScript.isTyping == false)
        {
            textScript.CabinetText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "heart" && textScript.isTyping == false)
        {
            textScript.HeartText();
        }
        /*
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "PokerInv" && textScript.isTyping == false)
        {
            textScript.PokerInvText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "DaggerInv" && textScript.isTyping == false)
        {
            textScript.DaggerInvText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "ScissorsInv" && textScript.isTyping == false)
        {
            textScript.ScissorsInvText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "KeyInv" && textScript.isTyping == false)
        {
            textScript.KeysInvText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "StoolInv" && textScript.isTyping == false)
        {
            textScript.StoolInvText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "ChaliceInv" && textScript.isTyping == false)
        {
            textScript.ChaliceInvText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "EyeInv" && textScript.isTyping == false)
        {
            textScript.EyeInvText();
        }
        else if (Input.GetMouseButtonDown(0) && gameObject.name == "PokerInv" && textScript.isTyping == false)
        {
            textScript.PokerInvText();
        }*/

        else { }
        }
    }

