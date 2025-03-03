using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject bomb;

    const float maxTime = 2.0f;
    float currentTime = 0.0f;

    [SerializeField]
    Transform SpawnLocation;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         currentTime = Time.deltaTime;   
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if ( currentTime <= 0)
        {
            Spawn();
            ResetTimer();
        }
    }
    private void ResetTimer()
    {
        currentTime = maxTime;
    }
    void Spawn()
    {
        Debug.Log("Spawn called");

        var go = Instantiate(bomb);
        go.transform.position = SpawnLocation.position;

    }


}
