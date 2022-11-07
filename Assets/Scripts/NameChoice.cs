using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NameChoice : MonoBehaviour
{
    public string[] dialogue;
    public Text dialogueText;
    public GameObject TextBox;
    public GameObject Option1;
    public GameObject Option2;
    public GameObject Option3;
    public GameObject Narr;
    public GameObject Options;
    
    public GameObject Option4;
    public GameObject Option5;
    public GameObject Narr2;
    public GameObject Options2;
    
    public int ChoiceMade;
    int dialogueNum = 0;

    public void ChoiceOption1()
    {
        TextBox.GetComponent<Text>().text = "MJ";
        ChoiceMade = 1;
        Invoke(nameof(ChoiceOption1), 2f);
    }
    public void ChoiceOption2()
    {
        TextBox.GetComponent<Text>().text = "Quinn";
        ChoiceMade = 2;
        Invoke(nameof(ChoiceOption2), 2f);
    }
    public void ChoiceOption3()
    {
        TextBox.GetComponent<Text>().text = "Sky";
        ChoiceMade = 3;
        Invoke(nameof(ChoiceOption3), 2f);
    }

    private void Start()
    {
        dialogueText.text = dialogue[dialogueNum];

       /* Option4.SetActive(false);
        Option5.SetActive(false);*/
        
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {

            if (dialogueNum < dialogue.Length - 1)
            {
                dialogueNum++;
                dialogueText.text = dialogue[dialogueNum];
            }
        }
        /*
        if (Input.GetMouseButtonDown(0))
        {
            if (dialogueNum < dialogue.Length - 1)
            {
                dialogueNum--;
                dialogueText.text = dialogue[dialogueNum];
            }
        }*/

        if(ChoiceMade >= 1)
        {
            Option1.SetActive(false);
            Option2.SetActive(false);
            Option3.SetActive(false);
            Narr.SetActive(false);
            Options.SetActive(false);


            Option4.SetActive(true);
            Option5.SetActive(true);
            Narr2.SetActive(true);
            Options2.SetActive(true);


        }
    }
}
