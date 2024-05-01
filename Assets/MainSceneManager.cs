using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    public void FirstButton()
    {
        SoundManager_Old.Instance.PlaySFXSound("Button");
        SceneManager.LoadScene(1);
    }
    public void SecondButton()
    {
        SoundManager_Old.Instance.PlaySFXSound("Button");
    }

    public void ThirdButton()
    {
        SoundManager_Old.Instance.PlaySFXSound("Button");
        Application.Quit();
    }
}
