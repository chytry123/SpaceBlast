using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroid, player, powerup_multishot, powerup_barrier, alien;
    //int lastRandomIndex = -1
    int wave_count = 0, powerup_spawn_wave = 0, alien_spawn_time = 0;
    float t, spawn_dist = 200f;

    void Start()
    {
        t = Time.time;
        //Instantiate(asteroid, new Vector3(Random.Range(-10f, 10f), Random.Range(-4f, 4f), 150f), Quaternion.identity);
        //Instantiate(asteroid, new Vector3(Random.Range(-10f, 10f), Random.Range(-4f, 4f), 150f), Quaternion.identity);
        //Instantiate(asteroid, new Vector3(Random.Range(-10f, 10f), Random.Range(-4f, 4f), 200f), Quaternion.identity);
        //Instantiate(asteroid, new Vector3(Random.Range(-10f, 10f), Random.Range(-4f, 4f), 200f), Quaternion.identity);
        //Instantiate(asteroid, new Vector3(Random.Range(-10f, 10f), Random.Range(-4f, 4f), 250f), Quaternion.identity);
        //Instantiate(asteroid, new Vector3(Random.Range(-10f, 10f), Random.Range(-4f, 4f), 250f), Quaternion.identity);
    }

    void SpawnAsteroids()
    {
        Instantiate(asteroid, new Vector3(player.transform.position.x, player.transform.position.y, spawn_dist), Quaternion.identity);

        if (Time.timeSinceLevelLoad < 60)
        {
            Instantiate(asteroid, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
        }

        else if (Time.timeSinceLevelLoad < 120)
        {
            Instantiate(asteroid, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
        }

        else if (Time.timeSinceLevelLoad < 180)
        {
            Instantiate(asteroid, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
        }

        else
        {
            Instantiate(asteroid, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
        }
    }

    void SpawnCrowdAsteroids()
    {
        Instantiate(asteroid, new Vector3(Random.Range(12f, 25f), Random.Range(5f, 15f), spawn_dist), Quaternion.identity);
        Instantiate(asteroid, new Vector3(Random.Range(-12f, -25f), Random.Range(5f, 15f), spawn_dist), Quaternion.identity);
        Instantiate(asteroid, new Vector3(Random.Range(-12f, -25f), Random.Range(-5f, -15f), spawn_dist), Quaternion.identity);
        Instantiate(asteroid, new Vector3(Random.Range(12f, 25f), Random.Range(-5f, -15f), spawn_dist), Quaternion.identity);
    }

    void SpawnAlien()
    {
        Instantiate(alien, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
    }

    void SpawnPowerups()
    {
        if (Random.Range(0, 100) > 50)
        {
            powerup_spawn_wave = wave_count;
            Instantiate(powerup_multishot, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist + 20f), Quaternion.identity);
        }
        else
        {
            powerup_spawn_wave = wave_count;
            Instantiate(powerup_barrier, new Vector3(Random.insideUnitCircle.x * 10, Random.insideUnitCircle.y * 4, spawn_dist + 20f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Time.time - t > 1f)
        {
            wave_count += 1;

            if (Random.Range(0, 100) > 10 | Time.timeSinceLevelLoad < 15)
            {
                SpawnAsteroids();
            }
            else
            {
                SpawnAlien();
            }

            SpawnCrowdAsteroids();

            //Powerups
            if (Random.Range(0, 100) > 90 && wave_count >= powerup_spawn_wave + 10)
            {
                SpawnPowerups();
            }

            t = Time.time;
        }
    }
}
