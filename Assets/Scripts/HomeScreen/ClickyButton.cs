using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default, _pressed;
    [SerializeField] private AudioClip _pressClip, _releaseClip;
    [SerializeField] private AudioSource _source;

    public void OnPointerDown(PointerEventData eventData)
    {
        _img.sprite = _pressed;
        _source.PlayOneShot(_pressClip);
        
        // Handle specific button functionality here
        if (gameObject.name == "GetDirectionBtn")
        {
            // Handle "Get Direction" button click
        }
        else if (gameObject.name == "QuitBtn")
        {
            // Handle "Quit" button click
            Quit();
            
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _img.sprite = _default;
        _source.PlayOneShot(_releaseClip);
    }

    private void Quit()
    {
        Application.Quit();
    }
}


