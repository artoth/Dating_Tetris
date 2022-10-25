using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 
public class DDayOne : MonoBehaviour
{
    public Text dialogueText;
    int dialogueNum = 0;

    public string[] dialogue;

    private void Start()
    {
        dialogueText.text = dialogue[dialogueNum];
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
            if( dialogueNum < dialogue.Length - 1)
            {
                dialogueNum++;
                dialogueText.text = dialogue[dialogueNum];
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if(dialogueNum < dialogue.Length - 1)
            {
                dialogueNum--;
                dialogueText.text = dialogue[dialogueNum];
            }
        }
    }
}
