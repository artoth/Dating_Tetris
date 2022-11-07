using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choices : MonoBehaviour
{
    //public int targetScene;
    public string nextScene;

    public int ChoiceMade;
    public GameObject TextBox;
    public GameObject Option1;

    public void ChoiceOption4()
    {
        TextBox.GetComponent<Text>().text = "Yes";
        ChoiceMade = 1;
        //targetScene = 1;
        Invoke(nameof(ChangeScene), 2f);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(nextScene);
    }
   
}
