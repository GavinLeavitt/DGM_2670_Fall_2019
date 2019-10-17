using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavMeshAgentController : MonoBehaviour
{
    public NavMeshAgent agent;
    public PositionData destinationPosition;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = destinationPosition.positionVector;
    }
}
