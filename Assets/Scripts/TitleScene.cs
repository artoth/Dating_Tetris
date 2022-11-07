using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    public string nextScene;

    public void ChangeTo()
    {
        Invoke(nameof(ChangeScene), 0.5f);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(nextScene);
    }

}