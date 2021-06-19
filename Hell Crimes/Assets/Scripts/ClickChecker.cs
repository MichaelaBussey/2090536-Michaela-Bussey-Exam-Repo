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
        if (Input.GetMouseButtonDown(0) && gameObject.name == "LETTERS")
        {
            textScript.LetterText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "POKER")
        {
            textScript.PokerText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "STOOL") 
        {
            textScript.StoolText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "CORNER")
        {
            textScript.Carpet1Text();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "SCISSORS")
        {
            textScript.ScissorsText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "Cloth")
        {
            textScript.ClothText();
        }

        else if (Input.GetMouseButtonDown(0) && gameObject.name == "DAGGER")
        {
            textScript.DaggerText();
        }

        else { }
        }
    }

