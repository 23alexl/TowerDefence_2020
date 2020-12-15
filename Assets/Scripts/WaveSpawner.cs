using UnityEngine;

public class WaveSpawner : MonoBehaviour {

    public Transform enemyPrefab;

    public Transform spawnPoint;


    public float timeBetewwnWaves = 5f;
    private float countdown = 2f;

    private int waveNumber = 1;

    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnWave();
            countdown = timeBetewwnWaves;
        }

        countdown -= Time.deltaTime;
    }



    void SpawnWave()
    {
      
        for (int i = 0; i < waveNumber; i++)
        
        Debug.Log("Wave Incoming");
        
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}






   

