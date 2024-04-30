using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public abstract class UI_Base : MonoBehaviour
{
    protected Dictionary<Type, UnityEngine.Object[]> _object = new Dictionary<Type, UnityEngine.Object[]>();
    protected bool _init = false;

    public virtual bool Init()
    {
        if (_init)
            return false;

        // 메인 매니저 데이터 셋팅 진행
        // Manager.Init();

        _init = true;
        return true;
    }

    private void Start()
    {
        Init();
    }

    protected void Bind<T>(Type type) where T : UnityEngine.Object
    {
        // UI Type 별로 Dictionary에 저장하여 관리한다.
        // 예시) 게임 오브젝트, 버튼, 슬라이더, 텍스트 등..
        string[] name = Enum.GetNames(type);
        UnityEngine.Object[] objects = new UnityEngine.Object[name.Length];
        _object.Add(type, objects);

        for (int i = 0; i < name.Length; i++)
        {
            if (typeof(T) == typeof(GameObject))
            {
                objects[i] = Utils.FindChild(gameObject, name[i], true);
            }
            else
            {
                objects[i] = Utils.FindChild<T>(gameObject, name[i], true);
            }

            if (objects[i] == null)
                Debug.Log($"[장시진] UI_Base: Failed to bind({name[i]})");
        }
    }

    protected T Get<T>(int idx) where T : UnityEngine.Object
    {
        UnityEngine.Object[] objects = null;
        if (_object.TryGetValue(typeof(T), out objects) == false)
            return null;

        return objects[idx] as T;
    }

    protected void BindButton(Type type) { Bind<Button>(type); }

    protected Button GetButton(int idx) { return Get<Button>(idx); }

    public static void BindEvent(GameObject go, Action action, Define.UIEvent type = Define.UIEvent.OnClick)
    {
        UI_EventHandler eventHandler = go.GetOrAddComponent<UI_EventHandler>();

        switch (type)
        {
            case Define.UIEvent.OnClick:
                eventHandler.OnClickHandler -= action; // [장시진] 중복 수행 방지를 위한 예외 처리
                eventHandler.OnClickHandler += action;
                break;
            case Define.UIEvent.OnPress:
                eventHandler.OnPressHandler -= action; // [장시진] 중복 수행 방지를 위한 예외 처리
                eventHandler.OnPressHandler += action;
                break;
        }
    }
}