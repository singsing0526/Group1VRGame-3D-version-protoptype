using UnityEngine;

public class DoorUnlocker : MonoBehaviour
{

    public int doorId;
    public int keyId;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnlockDoor();
            gameObject.SetActive(false);
        }
    }

    private void UnlockDoor()
    {
        GameObject[] doors = GameObject.FindGameObjectsWithTag("Door");

        foreach (GameObject door in doors)
        {
            Door doorScript = door.GetComponent<Door>();
            if (doorScript != null && doorScript.doorId == doorId && !doorScript.isUnlocked)
            {
                doorScript.Unlock(keyId);
                break;
            }
        }
    }
}
