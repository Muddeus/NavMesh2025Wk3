using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public SlidingDoor door;
    public int collectedItems = 0;
    public int requiredItems = 3;

    // Update is called once per frame
    void Update()
    {
        if (collectedItems >= requiredItems)
        {
            door.NonagonInfinity();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
        {
            collectedItems++;
            Destroy(other.gameObject);
        }
    }

}
