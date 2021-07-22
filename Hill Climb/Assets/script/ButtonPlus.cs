using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ButtonPlus : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler
{
    public Image graphicsComponent;
    public Sprite defaultSprite;
    public Sprite pressedsprite;
    public bool interactable = true;
    public UnityEvent onClick;
    public UnityEvent onMouse;
    public UnityEvent onMouseDown;
    public UnityEvent onMouseUp;
    bool isMouseDown;
     private void Start()
    {
        graphicsComponent.sprite = defaultSprite;
    }
    private void Update()
    {
        if (interactable)
        {
            if (isMouseDown)
            {
                onMouse?.Invoke();
            }
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (interactable)
        {
            onClick?.Invoke();

        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (interactable)
        {
            onMouseDown?.Invoke();
            graphicsComponent.sprite = pressedsprite;
            isMouseDown = true;
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (interactable)
        {
            onMouseUp?.Invoke();
            graphicsComponent.sprite = defaultSprite;
            isMouseDown = false;
        }
    }
}
