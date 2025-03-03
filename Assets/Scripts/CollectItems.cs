using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

public class CollectItems : MonoBehaviour
{
    public SlidingDoor door;
    public int collectedItems = 0;

    private NavMeshAgent agent;

    List<GameObject> collectables;
    private GameObject currentCollectable = null;


    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        collectables = GameObject.FindGameObjectsWithTag("Collectable").ToList();
    }


    // Update is called once per frame
    void Update()
    {
        if(currentCollectable == null && collectables.Count > 0)
        {
            int randomIndex = Random.Range(0, collectables.Count);
            currentCollectable = collectables[randomIndex];
            collectables.RemoveAt(randomIndex);
        }


        if (currentCollectable != null)
        {
            agent.destination = currentCollectable.transform.position;
        }

        if(collectables.Count == 0)
        {
            door.NonagonInfinity();
        }


    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Collectable")
        {
            Debug.Log("bebebfe");
            collectedItems++;
            Destroy(other.gameObject);
        }
    }

}
