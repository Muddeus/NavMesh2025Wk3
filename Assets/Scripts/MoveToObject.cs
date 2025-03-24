using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class MoveToObject : MonoBehaviour
{
    public GameObject moveToObject;
    private NavMeshAgent agent;
    public SlidingDoor door;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (door.transform.position.y <= 0)
        {
            Debug.Log("movetosphere " + moveToObject.transform.position);

            agent.destination = moveToObject.transform.position;
        }
    }
}
