using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeCollision : MonoBehaviour
{
    public GameObject monsterPrefab;
    public float spawnDistance = 2f;
    public float monsterLifetime = 15f;
    public string nextSceneName;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 spawnPosition = collision.transform.position - collision.transform.forward * spawnDistance;
            GameObject spawnedMonster = Instantiate(monsterPrefab, spawnPosition, new Quaternion(0f,250f,0f,-170f));
            Invoke("DestroyMonster", monsterLifetime);
        }
    }

    private void DestroyMonster()
    {
        Destroy(GameObject.FindGameObjectWithTag("SpawnedMonster"));
    }
}

