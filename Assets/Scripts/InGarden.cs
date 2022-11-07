using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGarden : MonoBehaviour
{

    public string[] dialogue;
    public Text dialogueText;
    public GameObject TextBox;

    public GameObject Option4;
    public GameObject Option5;

    public string targetScene;

    public GameObject Red;
    
    public Sprite LoveR;
    public Sprite HateR;

    public int ChoiceMade;
    int dialogueNum = 0;

    public void ChoiceOption4()
    {
        TextBox.GetComponent<Text>().text = "Let's spend somemore time talking before we go back <3";
        ChoiceMade = 1;
        targetScene = "RedEnd";
        Invoke(nameof(ChangeScene), 2f);
    }
    public void ChoiceOption5()
    {
        TextBox.GetComponent<Text>().text = "Maybe we should head back to class it is getting late";
        ChoiceMade = 2;
        targetScene = "DormNight";
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

        if (ChoiceMade == 1)
        {
            Red.gameObject.GetComponent<Image>().sprite = LoveR;
        }

        if (ChoiceMade == 2)
        {
            Red.gameObject.GetComponent<Image>().sprite = HateR;

        }
    }
}

