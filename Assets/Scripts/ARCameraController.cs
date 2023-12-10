using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;
using TMPro;

public class ARCameraController : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public LayerMask hitLayerMask;
    public NavMeshAgent agent;

    [SerializeField] private TMP_Dropdown navigationTargetDropDown;
    [SerializeField] private List<Target> navigationTargetObjects = new List<Target>();

    private Transform selectedDestination; // Store the selected destination point

    void Start()
    {
        // Subscribe to the dropdown's onValueChanged event
        navigationTargetDropDown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    void Update()
    {
        // Set the destination point for the LineRenderer
        lineRenderer.SetPosition(0, transform.position); // Camera position

        if (selectedDestination != null)
        {
            // Update the LineRenderer's positions to match the NavMesh path
            NavMeshPath path = new NavMeshPath();
            if (agent.CalculatePath(selectedDestination.position, path))
            {
                lineRenderer.positionCount = path.corners.Length;
                lineRenderer.SetPositions(path.corners);
            }
        }
    }

    private void OnDropdownValueChanged(int selectedValue)
    {
        // Handle the dropdown selection and set the selected destination
        if (selectedValue >= 0 && selectedValue < navigationTargetObjects.Count)
        {
            selectedDestination = navigationTargetObjects[selectedValue].PositionObject;
        }
    }
}

[System.Serializable]
public class Target
{
    public string Name;           // The name of the destination
    public Transform PositionObject;  // The position of the destination (a reference to a GameObject)
}
