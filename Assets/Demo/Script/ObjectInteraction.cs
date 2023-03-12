using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public Canvas interactCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactCanvas.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactCanvas.gameObject.SetActive(false);
        }
    }
}

