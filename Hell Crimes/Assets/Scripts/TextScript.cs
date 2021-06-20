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
    // Necessary dialogue
    public List<string> introDial, LettersDial, RiddleDial, OutroDial;
    // Ritual item dialogue
    public List<string> POKERDial, STOOLDial, SCISSORSDial, DAGGERDial, KEYDial;
    // Item progress dialogue
    public List<string> CarpetDial, LockedGoatDial, ReachGoatDial, NoEyeDial, NoSClothDial, SClothDial, OpenBagDial, LockBagDial, HangerDial;
    // Hints dialogue
    public List<string> NotesDial, SwordDial, PaperDial, BooksDial, CabinateDial, PaintingDial, HeartDial; 
    // Inventory dialogue
    public List<string> ChaliceInvDial, EyeInvDial, PokerInvDial, StoolInvDial, ScissorsInvDial, DaggerInvDial, KeyInvDial;
    public List<string> CurrentList;
    public GameObject nextButton;
    // Set these active
    public GameObject PokerInv, DaggerInv, StoolInv, EyeInv, ScissorsInv, FileInv, ChaliceInv, KeyInv, carpetTurned, noEyeGoat, hangerMove, keyHidden;
    // Delete these
    public GameObject POKER, STOOL, Cloth, carpetCorner, DAGGER, Goat, Hanger, KEY, SCISSORS;
    public bool isTyping, keyChecker, pokerChecker, stoolChecker, daggerChecker, scissorsChecker, eyeChecker, chaliceChecker;
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
            //isTyping = true;
            //Time.timeScale = 0.00001f;
        }

        else
        {
            //isTyping = true; 
        }

        if (chaliceChecker && eyeChecker && (daggerChecker || scissorsChecker))
        {
            Witch.SetActive(true);
            Dick.SetActive(true);
            CurrentList = OutroDial;
        }
    }
    IEnumerator Type ()
    {
        DialogueUI.SetActive(true);
        foreach(char letter in CurrentList[index].ToCharArray())
        {
            textBox.text += letter;
            yield return new WaitForSeconds(textSpeed);
            isTyping = true;
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
            isTyping = false;
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
        StartCoroutine(objectText(CarpetDial, carpetTurned, carpetCorner));
        SCISSORS.SetActive(true);
    }
    public void ScissorsText()
    {
        scissorsChecker = true;
        StartCoroutine(objectText(SCISSORSDial, ScissorsInv, SCISSORS));
    }

    public void ClothText()
    {
        if(stoolChecker == true)
        {
          StartCoroutine(objectText(SClothDial, DAGGER, Cloth));
        }

        else if(stoolChecker == false)
        {
            StartCoroutine(objectText(NoSClothDial, null, null));
        }


    }
    public void DaggerText()
    {
        StartCoroutine(objectText(DAGGERDial, DaggerInv, DAGGER));
    }

    public void BagText ()
    {
        if (keyChecker == true)
        {
            chaliceChecker = true;
            StartCoroutine(objectText(OpenBagDial, ChaliceInv, KeyInv));
        }
        else if (keyChecker == false)
        {
            StartCoroutine(objectText(LockBagDial, null, null));
        }
    }
    public void HangerText ()
    {
        StartCoroutine(objectText(HangerDial, hangerMove, Hanger));
        keyHidden.SetActive(false);
        KEY.SetActive(true);
    }
    public void KeyText()
    {
        keyChecker = true;
        StartCoroutine(objectText(KEYDial, KeyInv, KEY));
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
        yield return new WaitForSeconds(0.5f);
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
