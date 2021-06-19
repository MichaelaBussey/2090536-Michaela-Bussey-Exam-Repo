using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public GameObject DialogueUI, Dick, Witch, dBoxWitch, dBoxDick, dBoxExamine;
    public GameObject Letters;
    public Text textBox;
    private int index;
    public float textSpeed;
    public List<string> introDial, LettersDial, RiddleDial;
    public List<string> POKERDial, STOOLDial,  SCISSORSDial,  DAGGERDial,  KEYDial,  CHALICEDial, EYEDial;
    public List<string> CarpetDial, LockedGoatDial, ReachGoatDial, NoEyeDial, ClothDial, OpenBagDial, LockBagDial;
    public List<string> CurrentList;
    public GameObject nextButton;
    // Set these active
    public GameObject PokerInv, DaggerInv, StoolInv, EyeInv, ScissorsInv, FileInv, ChaliceInv, carpetTurned, noEyeGoat, hangerMove;
    // Delete these
    public GameObject POKER, STOOL, Cloth, carpetCorner, DAGGER, Goat, Hanger, KEY, SCISSORS;
    public bool keyChecker, pokerChecker, stoolChecker, daggerChecker, scissorsChecker, eyeChecker;
    // Interactables
    DialogueList dialgoueList; 


    void Start()
    {
        CurrentList = introDial;
        StartCoroutine(Type());
        //textBox.text = dialgoueList.GetComponent<Intro>();
    }

    void Update()
    {
        if (textBox.text == CurrentList[index])
        {
            nextButton.SetActive(true);
            //Time.timeScale = 0.00001f;
        }
    }
    IEnumerator Type ()
    {
        DialogueUI.SetActive(true);
        foreach(char letter in CurrentList[index].ToCharArray())
        {
            textBox.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextButton ()
    {
        nextButton.SetActive(false);
        if (index < CurrentList.Count -1)
        {
            index++;
            textBox.text = "";
            StartCoroutine(Type());
        }

        else
        {
            textBox.text = "";
            DialogueUI.SetActive(false);
        }
    }

    public void LetterText ()
    {
        StartCoroutine(objectText(LettersDial, null, null));
    }
    
    public void RiddleText()
    {
        StartCoroutine(objectText(RiddleDial, null, null));
    }

    public void PokerText ()
    {
        pokerChecker = true;
        StartCoroutine(objectText(POKERDial, PokerInv, POKER));
    }
    public void StoolText()
    {
        stoolChecker = true;
        StartCoroutine(objectText(STOOLDial, StoolInv, STOOL));
    }
    public void Carpet1Text()
    {
        SCISSORS.SetActive(true);
        StartCoroutine(objectText(CarpetDial, carpetTurned, carpetCorner));
    }
    public void ScissorsText()
    {
        scissorsChecker = true;
        StartCoroutine(objectText(SCISSORSDial, ScissorsInv, SCISSORS));
    }
    public void ClothText()
    {
        //Only if player has stool
        StartCoroutine(objectText(ClothDial, DAGGER, Cloth));
    }
    public void DaggerText()
    {
        StartCoroutine(objectText(DAGGERDial, DaggerInv, DAGGER));
    }

    public void LockGoatText ()
    {
        if (stoolChecker && !daggerChecker && !scissorsChecker && !pokerChecker) 
        {
            StartCoroutine(objectText(NoEyeDial, null, null));
        }

        else if (stoolChecker && (daggerChecker || scissorsChecker || pokerChecker))
        {
            StartCoroutine(objectText(ReachGoatDial, EyeInv, Goat));
            noEyeGoat.SetActive(true);
            eyeChecker = true;
        }
        else
        {
            StartCoroutine(objectText(LockedGoatDial, null, null));
        }

    }

    public IEnumerator objectText (List<string> input, GameObject objectToTurnOn, GameObject objectToDestroy)
    {

        CurrentList = input;
        index = 0;
        textBox.text = "";
        DialogueUI.SetActive(true);
        Witch.SetActive(false);
        Dick.SetActive(false);
        dBoxWitch.SetActive(false);
        dBoxDick.SetActive(false);
        dBoxExamine.SetActive(true);
        StartCoroutine(Type());
        yield return new WaitForSeconds(3f);

        if (objectToTurnOn != null)
        {
            objectToTurnOn.SetActive(true);
        }

        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }
    }


}
