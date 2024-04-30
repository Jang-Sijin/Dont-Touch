using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;
using static Extention;

public class UI_TitleManager : UI_Base
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

        GetButton((int)Buttons.StartButton).Bind

        return true;
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
