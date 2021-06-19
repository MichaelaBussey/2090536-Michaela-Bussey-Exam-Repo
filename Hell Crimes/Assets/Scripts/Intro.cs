using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public GameObject Tag, Open, UI;
    public Text DescBox;
    private int index;
    public float textSpeed;
    public string [] Desc;

    void Start()
    {
        
    }

    void Update()
    {
    if (Input.GetMouseButtonDown(0) && Tag)
        {
            Open.SetActive(true);
            UI.SetActive(true);
            Tag.SetActive(false);
            StartCoroutine(Type());
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in Desc[index].ToCharArray())
        {
            DescBox.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void Begin ()
    {
        SceneManager.LoadScene(2);
    }
}
