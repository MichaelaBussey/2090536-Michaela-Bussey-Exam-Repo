using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public GameObject DialogueUI, Dick, Witch, dBoxWitch, dBoxDick, dBoxExamine, PaperCanvas, PaintingCanvas, FileCanvas;
    public GameObject Letters, ReRiddle;
    public Text textBox;
    private int index;
    public float textSpeed;
    // Necessary dialogue
    public List<string> introDial, LettersDial, RiddleDial, ReRiddleDial, OutroDial;
    // Ritual item dialogue
    public List<string> POKERDial, STOOLDial, SCISSORSDial, DAGGERDial, KEYDial;
    // Item progress dialogue
    public List<string> CarpetDial, LockedGoatDial, ReachGoatDial, NoEyeDial, NoSClothDial, SClothDial, OpenBagDial, LockBagDial, HangerDial;
    // Hints dialogue
    public List<string> NotesDial, SwordDial, PaperDial, BooksDial, CabinateDial, PaintingDial, HeartDial; 
    // Inventory dialogue
    public List<string> ChaliceInvDial, EyeInvDial, PokerInvDial, StoolInvDial,FileInvDial, ScissorsInvDial, DaggerInvDial, KeyInvDial;
    public List<string> CurrentList;
    public GameObject nextButton;
    // Set these active
    public GameObject PokerInv, DaggerInv, StoolInv, EyeInv, ScissorsInv, ChaliceInv, KeyInv, carpetTurned, noEyeGoat, hangerMove, keyHidden;
    // Delete these
    public GameObject POKER, STOOL, Cloth, carpetCorner, DAGGER, Goat, Hanger, KEY, SCISSORS, Riddle, riddleGlow, letterGlow;
    public bool isTyping, keyChecker, pokerChecker, stoolChecker, daggerChecker, scissorsChecker, eyeChecker, chaliceChecker;
    // Interactables
    DialogueList dialgoueList; 


    void Start()
    {
        StartCoroutine(WaitGlow());
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
        StartCoroutine(objectText(LettersDial, riddleGlow, letterGlow));
    }
    public void RiddleText()
    {
        StartCoroutine(objectText(RiddleDial, ReRiddle, Riddle));
        riddleGlow.SetActive(false);
    }
    public void ReRiddleText()
    {
        StartCoroutine(objectText(ReRiddleDial, null, null));
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

    public void NotesText()
    {
        PaperCanvas.SetActive(true);
        StartCoroutine(objectText(NotesDial, null, null)); //fix to reveal close up of notes
    }
    public void SwordText()
    {
        StartCoroutine(objectText(SwordDial, null, null));
    }
    public void PaintingText()
    {
        PaintingCanvas.SetActive(true);
        StartCoroutine(objectText(PaintingDial, null, null)); //fix to reveal close up of painting
    }
    public void BooksText()
    {
        StartCoroutine(objectText(BooksDial, null, null)); //fix to reveal close up of books
    }
    public void PaperText()
    {
        StartCoroutine(objectText(PaperDial, null, null));
    }
    public void CabinetText()
    {
        StartCoroutine(objectText(CabinateDial, null, null));
    }
    public void HeartText()
    {
        StartCoroutine(objectText(HeartDial, null, null));
    }

    public void FileInvText()
    {
        if (isTyping == false)
        {
            StartCoroutine(objectText(FileInvDial, FileCanvas, null));
        }
    }
    public void PokerInvText()
    {
        if (isTyping == false)
        {
            StartCoroutine(objectText(PokerInvDial, null, null));
        }
    }
    public void DaggerInvText()
    {
        if (isTyping == false)
        {
            StartCoroutine(objectText(DaggerInvDial, null, null));
        }
    }
    public void ScissorsInvText()
    {
        if (isTyping == false)
        {
        StartCoroutine(objectText(ScissorsInvDial, null, null));
        }
    }
    public void KeysInvText()
    {
        if (isTyping == false)
        {
        StartCoroutine(objectText(KeyInvDial, null, null));
        }
    }
    public void StoolInvText()
    {
        if (isTyping == false)
        {
        StartCoroutine(objectText(StoolInvDial, null, null));
        }
    }
    public void ChaliceInvText()
    {
        if (isTyping == false)
        {
        StartCoroutine(objectText(ChaliceInvDial, null, null));
        }

    }
    public void EyeInvText()
    {
        if (isTyping == false)
        {
        StartCoroutine(objectText(EyeInvDial, null, null));
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

  public void CloseWindow(GameObject objectToClose)
    {
        objectToClose.SetActive(false);
    }
    

    IEnumerator WaitGlow ()
    {
        yield return new WaitForSeconds(30f);
        letterGlow.SetActive(true);
    }
}
