using UnityEngine;
using UnityEngine.AI;

public class DroneController : MonoBehaviour
{
    public Transform destination; // The destination point for the drone
    public NavMeshAgent agent; // Reference to the NavMeshAgent component

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (agent == null)
        {
            Debug.LogError("NavMeshAgent component not found on the drone.");
        }
        else
        {
            SetDestination();
        }
    }

    private void SetDestination()
    {
        if (destination != null)
        {
            agent.SetDestination(destination.position);
        }
        else
        {
            Debug.LogError("No destination point assigned to the drone.");
        }
    }

    private void Update()
    {
        // Check if the drone has reached the destination
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            // Stop the drone from moving
            agent.isStopped = true;
        }
    }
}

