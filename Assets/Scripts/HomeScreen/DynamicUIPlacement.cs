using UnityEngine;

public class DynamicUIPlacement : MonoBehaviour
{
    public RectTransform uiElement; // Reference to the UI element you want to adjust.

    void Start()
    {
        // Calculate the screen's aspect ratio.
        float screenAspect = (float)Screen.width / Screen.height;

        // Define a reference aspect ratio (e.g., 16:9).
        float referenceAspect = 16f / 9f;

        // Calculate the position adjustment factor based on the aspect ratio difference.
        float aspectRatioAdjustment = screenAspect / referenceAspect;

        // Adjust the position of the UI element based on the aspect ratio.
        Vector2 newPosition = uiElement.anchoredPosition;
        newPosition.x *= aspectRatioAdjustment; // Adjust the X position.
        uiElement.anchoredPosition = newPosition;
    }
}

