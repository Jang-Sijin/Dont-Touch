using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    public void FirstButton()
    {
        SoundManager.Instance.PlaySFXSound("Button");
        SceneManager.LoadScene(1);
    }
    public void SecondButton()
    {
        SoundManager.Instance.PlaySFXSound("Button");
    }

    public void ThirdButton()
    {
        SoundManager.Instance.PlaySFXSound("Button");
        Application.Quit();
    }
}
