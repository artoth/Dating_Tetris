using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LastScene : MonoBehaviour
{

    public GameObject Option4;
    public GameObject Option5;

    public string targetScene;

    public void ChoiceOption4()
    {
        Invoke(nameof(ChangeScene), 2f);
    }
    public void ChoiceOption5()
    {
        Invoke(nameof(ChangeScene), 2f);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }

}
