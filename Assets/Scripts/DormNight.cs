using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DormNight : MonoBehaviour
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
    TextBox.GetComponent<Text>().text = "I'm glad you found something you enjoyed, Now roll the credits!";
    ChoiceMade = 1;
    targetScene = "Credits";
    Invoke(nameof(ChangeScene), 3f);
}
public void ChoiceOption5()
{
    TextBox.GetComponent<Text>().text = "Maybe you should replay to find something you enjoyed...";
    ChoiceMade = 2;
    targetScene = "DormDay";
    Invoke(nameof(ChangeScene), 3f);
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
    }
}