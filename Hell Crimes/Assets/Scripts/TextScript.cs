using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public GameObject DialogueUI, Dick, Witch, dBoxWitch, dBoxDick, dBoxExamine;
    public Text textBox;
    private int index;
    public float textSpeed;
    public string[] Sentences;
    public GameObject nextButton;
    public GameObject PokerInv, DaggerInv, StoolInv, EyeInv, ScissorsInv, FileInv, ChaliceInv;
    private GameObject Poker;
    DialogueList dialgoueList; 


    void Start()
    {
        Poker = GameObject.Find("Poker");
        StartCoroutine(Type());
        //textBox.text = dialgoueList.GetComponent<Intro>();
    }

    void Update()
    {
        if (textBox.text == Sentences[index])
        {
            nextButton.SetActive(true);
            //Time.timeScale = 0.00001f;
        }
    }
    IEnumerator Type ()
    {
        foreach(char letter in Sentences[index].ToCharArray())
        {
            textBox.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextButton ()
    {
        nextButton.SetActive(false);
        if (index < Sentences.Length -1)
        {
            index++;
            textBox.text = "";
            StartCoroutine(Type());
        }

        else
        {
            textBox.text = "";
        }
    }
    public void PokerText ()
    {
        StartCoroutine(pokerText());
    }

    public IEnumerator pokerText ()
    {        
        textBox.text = "";
        DialogueUI.SetActive(true);
        Witch.SetActive(false);
        Dick.SetActive(false);
        dBoxWitch.SetActive(false);
        dBoxDick.SetActive(false);
        dBoxExamine.SetActive(true);

        //Time.timeScale = 0.00001f;
        StartCoroutine(Type());
        textBox.text = "Hmmm, a fire poker... Sadly not very dangerous, but could be a handy tool.";
        yield return new WaitForSeconds(3f);
        PokerInv.SetActive(true);
        Destroy(Poker);
    }


}
