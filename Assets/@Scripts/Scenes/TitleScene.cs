using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : BaseScene
{
    // Scene의 Root UI를 관리한다.

    protected override bool Init()
    {
        if(base.Init() == false)
        {
            return false;
        }

        SceneType = Define.SceneType.TitleScene;

        return true;
    }
}
