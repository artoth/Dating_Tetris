using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WakeUp : MonoBehaviour
{
    public string[] dialogue;
    public Text dialogueText;
    public GameObject TextBox;

    public GameObject Option4;
    public GameObject Option5;

    public string targetScene;

    public int ChoiceMade;
    int dialogueNum = 0;

    public void ChoiceOption4()
    {
        TextBox.GetComponent<Text>().text = "Personal alarm clock it is";
        ChoiceMade = 1;
        targetScene = "Classroom";
        Invoke(nameof(ChangeScene), 2f);
    }
    public void ChoiceOption5()
    {
        TextBox.GetComponent<Text>().text = "It was a late night you need the sleep";
        ChoiceMade = 2;
        targetScene = "Classroom";
        Invoke(nameof(ChangeScene), 2f);
    }


    private void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }

    private void Start()
    {
        dialogueText.text = dialogue[dialogueNum];

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
        }
        */
    }
}

