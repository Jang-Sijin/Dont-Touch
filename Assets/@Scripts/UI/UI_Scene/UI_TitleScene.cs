using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class UI_TitleScene : UI_Base
{
    enum Buttons
    {
        StartButton,
        OptionButton,
        ExitButton
    }    

    public override bool Init()
    {
        if(base.Init() == false)
            return false;

        BindButton(typeof(Buttons));

        GetButton((int)Buttons.StartButton).gameObject.BindEvent(OnClickStartButton);
        GetButton((int)Buttons.OptionButton).gameObject.BindEvent(OnClickStartButton);
        GetButton((int)Buttons.ExitButton).gameObject.BindEvent(OnClickStartButton);

        return true;
    }


    #region EventHandler
    private void OnClickStartButton()
    {
        Managers.Scene.ChangeScene(Define.SceneType.InGameScene);
    }

    private void OnClickOptionButton()
    {
        // Sound UI ÆË¾÷ ³ëÃâ
    }

    private void OnClickExitButton()
    {
        Application.Quit();
    }

    private void OnClickButtonSound()
    {
        // Managers.Sound
    }

    #endregion
}
