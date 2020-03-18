using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SwipeController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerExitHandler, IPointerEnterHandler
{
    [SerializeField]
    private Rect swipeScope;

    private Image image;

    private bool pointerLeftScope;
    
    private void Awake()
    {
        image = GetComponent<Image>();
        InitializeScope();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        pointerLeftScope = false;
        if (!swipeScope.Contains(eventData.pressPosition))
        {
            return;
        }

        Debug.Log($"OnBeginDrag, position: {eventData.pressPosition}");
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (pointerLeftScope)
        {
            return;
        }

        //Debug.Log($"OnDrag, position: {eventData.position}");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!swipeScope.Contains(eventData.position))
        {
            return;
        }

        Vector2 movement = eventData.position - eventData.pressPosition;

        Debug.Log($"OnEndDrag, start: {eventData.pressPosition}, end: {eventData.position}, distance: {movement.magnitude}");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        pointerLeftScope = true;
        image.color = Color.white;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {        
        image.color = Color.red;
    }

    private void InitializeScope()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        swipeScope.width = rectTransform.rect.width;
        swipeScope.height = rectTransform.rect.height;
        Vector3 position = transform.position;
        swipeScope.x = position.x - swipeScope.width / 2;
        swipeScope.y = position.y - swipeScope.height / 2;
    }


}
