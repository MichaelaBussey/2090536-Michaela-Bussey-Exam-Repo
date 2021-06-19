using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueList : MonoBehaviour
{
    void Start()
    {
    List<string> Intro = new List<string>(0-5);
        Intro.Add("Why hello, my dear boy. I hear it's been a long journey from Heaven for you. Thank you for-"); //W
        Intro.Add("Yeah yeah, old geezer. I don't have the time for fuckin chitchat, okay?"); //D
        Intro.Add("I see... Well my dearest daughter has gone missing, as you well know. We are aware of the Vampiric vanishing rituals enacted within these walls."); //W
        Intro.Add("Not much is known on how this process is achieved. I believe that in their hurry to flee the scene, however, the Vilonettes might have left some vital clues and tools around here."); //W
        Intro.Add("Dumbasses, eheh! this should be a piece of cake."); //D
        Intro.Add("I suggest examining those letters over on the centre coffee table first."); //W

        List<string> Letters = new List<string>();
        Letters.Add("You open the letters to reveal a scheme plan."); //Item dBox
        Intro.Add("");
        Intro.Add("");
        Intro.Add("");


        //Item text
        List<string> Poker = new List<string>();
        Poker.Add("Hmmm, a fire poker... Not very sharp but could be a handy tool.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
