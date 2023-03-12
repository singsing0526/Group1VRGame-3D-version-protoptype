using UnityEngine;

public class Key : MonoBehaviour
{

    public int keyID;
    public int doorID;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }

    public void UseKey(int doorIDToUnlock)
    {
        if (doorIDToUnlock == doorID)
        {
            gameObject.SetActive(true);
        }
    }
}
