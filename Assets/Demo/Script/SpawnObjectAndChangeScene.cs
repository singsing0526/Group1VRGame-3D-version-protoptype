using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnObjectAndChangeScene : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnDistance = 2f;
    public float objectLifetime = 20f;
    public string nextSceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 spawnPosition = other.transform.position - other.transform.forward * spawnDistance;
            GameObject spawnedObject = Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
            Invoke("DestroyObject", objectLifetime);
            SceneManager.LoadScene(nextSceneName);
        }
    }

    private void DestroyObject()
    {
        Destroy(GameObject.FindGameObjectWithTag("SpawnedObject"));
    }
}

