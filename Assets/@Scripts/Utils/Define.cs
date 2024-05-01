using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum SceneType
    {
        Unknown,    // ����
        TitleScene, // Ÿ��Ʋ ��
        InGameScene // �ΰ��� ��
    }

    public enum UIEvent
    {
        OnClick,    // Ŭ�� ��, ��� �ߵ�
        OnPress     // Ŭ�� ��, �ߵ�
    }

    public enum Sound
    {
        Bgm,
        Effect,
        Max
    }
}
