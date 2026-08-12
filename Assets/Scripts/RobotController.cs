using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

public class RobotController : MonoBehaviour
{
    private NavMeshAgent agent;

    private FirstPersonController player;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        player = FindAnyObjectByType<FirstPersonController>();
    }

    private void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
