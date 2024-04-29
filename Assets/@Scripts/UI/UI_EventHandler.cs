using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_EventHandler : MonoBehaviour, IPointerDownHandler, IPointerClickHandler
{
    public event Action OnClickHandler = null;
    public event Action OnPressHandler = null;

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClickHandler?.Invoke();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnPressHandler?.Invoke();
    }
}
