using UnityEngine;
using UnityEngine.AI;

public class PathDrawer : MonoBehaviour
{
    public LineRenderer line; // Reference to the LineRenderer
    public Transform target; // The target transform
    private NavMeshAgent agent; // Reference to the NavMeshAgent

    private void Start()
    {
        line = GetComponent<LineRenderer>(); // Get the LineRenderer component
        agent = GetComponent<NavMeshAgent>(); // Get the NavMeshAgent component
        GetPath();
    }

    private void GetPath()
    {
        line.SetPosition(0, transform.position); // Set the line's origin

        agent.SetDestination(target.position); // Create the path
        StartCoroutine(WaitForPathGeneration());
    }

    private System.Collections.IEnumerator WaitForPathGeneration()
    {
        yield return new WaitForEndOfFrame(); // Wait for the path to generate
        DrawPath(agent.path);
        agent.isStopped = true; // Optionally stop the agent from moving
    }

    private void DrawPath(NavMeshPath path)
    {
        if (path.corners.Length < 2) // If the path has 1 or no corners, there is no need
            return;

        line.positionCount = path.corners.Length; // Set the array of positions to the amount of corners

        for (int i = 1; i < path.corners.Length; i++)
        {
            line.SetPosition(i, path.corners[i]); // Go through each corner and set that to the LineRenderer's position
        }
    }
}

