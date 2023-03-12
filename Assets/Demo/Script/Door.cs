using UnityEngine;

public class Door : MonoBehaviour
{

    public int doorId;
    public bool isUnlocked = false;
    public float openAngle = 90f;
    public float closeAngle = 0f;
    public float smooth = 2f;

    private Quaternion targetRotation;
    private Quaternion startRotation;
    private bool isOpen = false;

    private void Start()
    {
        startRotation = transform.rotation;
        if (isOpen)
        {
            targetRotation = startRotation * Quaternion.Euler(0f, 0f, openAngle);
        }
        else
        {
            targetRotation = startRotation * Quaternion.Euler(0f, 0f, 0f);
        }
    }

    public void Unlock(int keyId)
    {
        if (!isUnlocked && keyId == doorId)
        {
            isUnlocked = true;
            Debug.Log("Door " + doorId + " is unlocked!");
        }
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < 3f && Input.GetKeyDown(KeyCode.E))
        {
            if (!isUnlocked)
            {
                Debug.Log("Door " + doorId + " is locked!");
            }
            else
            {
                if (isOpen)
                {
                    targetRotation = startRotation * Quaternion.Euler(0f, 0f, 0f);
                    isOpen = false;
                }
                else
                {
                    targetRotation = startRotation * Quaternion.Euler(0f, 0f, openAngle);
                    isOpen = true;
                }
            }
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
    }
}