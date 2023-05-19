using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    public Transform[] goals;
    public NavMeshAgent agent;
    private int currentGoalIndex = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetNextGoal();
    }

    void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance && !agent.pathPending)
        {
            SetNextGoal();
        }
    }

    void SetNextGoal()
    {
        currentGoalIndex = (currentGoalIndex + 1) % goals.Length;
        agent.destination = goals[currentGoalIndex].position;
    }
}
