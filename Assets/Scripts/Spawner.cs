using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroid, player, powerup_multishot, powerup_barrier;
    //int lastRandomIndex = -1
    int wave_count = 0, powerup_spawn_wave = 0;
    float t, spawn_dist = 200f;

    void Start()
    {
        t = Time.time;
        //Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-4f, 4f), 150f), Quaternion.identity);
        //Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-4f, 4f), 150f), Quaternion.identity);
        //Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-4f, 4f), 200f), Quaternion.identity);
        //Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-4f, 4f), 200f), Quaternion.identity);
        //Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-4f, 4f), 250f), Quaternion.identity);
        //Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-4f, 4f), 250f), Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Time.time - t > 1f)
        {
            wave_count += 1;
            //actual obstacle
            Instantiate(asteroid, new Vector3(player.transform.position.x, player.transform.position.y, spawn_dist), Quaternion.identity);

            if (Time.timeSinceLevelLoad < 60)
            {
                Instantiate(asteroid, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
            }
            
            else if(Time.timeSinceLevelLoad < 120)
            {
                Instantiate(asteroid, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
                Instantiate(asteroid, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
            }

            else if (Time.timeSinceLevelLoad < 180)
            {
                Instantiate(asteroid, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
                Instantiate(asteroid, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
                Instantiate(asteroid, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
            }

            else
            {
                Instantiate(asteroid, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
                Instantiate(asteroid, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
                Instantiate(asteroid, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
                Instantiate(asteroid, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist), Quaternion.identity);
            }
            //artificial crowd
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(12f, 25f), UnityEngine.Random.Range(5f, 15f), spawn_dist), Quaternion.identity);
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-12f, -25f), UnityEngine.Random.Range(5f, 15f), spawn_dist), Quaternion.identity);
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-12f, -25f), UnityEngine.Random.Range(-5f, -15f), spawn_dist), Quaternion.identity);
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(12f, 25f), UnityEngine.Random.Range(-5f, -15f), spawn_dist), Quaternion.identity);

            //PowerUp
            if (UnityEngine.Random.Range(0, 100) > 90 && wave_count >= powerup_spawn_wave + 10)
            {
                if (UnityEngine.Random.Range(0, 100) > 50)
                {
                    powerup_spawn_wave = wave_count;
                    Instantiate(powerup_multishot, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist + 20f), Quaternion.identity);
                }
                else
                {
                    powerup_spawn_wave = wave_count;
                    Instantiate(powerup_barrier, new Vector3(UnityEngine.Random.insideUnitCircle.x * 10, UnityEngine.Random.insideUnitCircle.y * 4, spawn_dist + 20f), Quaternion.identity);
                }
            }

            t = Time.time;
        }
    }

    //void RandomObstacle(int range, int distance)
    //{
    //    int index = UnityEngine.Random.Range(0, range);

    //    while(index == lastRandomIndex)
    //    {
    //        index = UnityEngine.Random.Range(0, range);
    //    }

    //    if(index == 0)
    //    {
    //        //Instantiate(blockPrefab, new Vector3(UnityEngine.Random.Range(-5.5f, -2f), 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        //Instantiate(blockPrefab, new Vector3(UnityEngine.Random.Range(2f, 5.5f), 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        Instantiate(blockPrefab, new Vector3(5.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        Instantiate(blockPrefab, new Vector3(-5.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        lastRandomIndex = index;
    //    }

    //    if(index == 1)
    //    {
    //        //Instantiate(blockPrefab1, new Vector3(UnityEngine.Random.Range(-6.5f, -3.5f), 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        //Instantiate(blockPrefab1, new Vector3(UnityEngine.Random.Range(-1.5f, 1.5f), 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        //Instantiate(blockPrefab1, new Vector3(UnityEngine.Random.Range(3.5f, 6.5f), 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        Instantiate(blockPrefab1, new Vector3(-6.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        Instantiate(blockPrefab1, new Vector3(UnityEngine.Random.Range(-2.5f, 2.5f), 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        Instantiate(blockPrefab1, new Vector3(6.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        lastRandomIndex = index;
    //    }

    //    if (index == 2)
    //    {
    //        Instantiate(blockPrefab2, new Vector3(UnityEngine.Random.Range(-3f, 3f), 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        lastRandomIndex = index;
    //    }

    //    if (index == 3)
    //    {
    //        Instantiate(blockPrefab4, new Vector3(0, 0.85f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        lastRandomIndex = index;
    //    }

    //    if (index == 4)
    //    {
    //        int x = UnityEngine.Random.Range(0, 3);

    //        if(x == 0)
    //        {
    //            Instantiate(blockPrefab5, new Vector3(0, 0.85f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //            Instantiate(blockPrefab, new Vector3(-5.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //            Instantiate(blockPrefab, new Vector3(5.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        }
            
    //        if(x == 1)
    //        {
    //            Instantiate(blockPrefab5, new Vector3(4, 0.85f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //            Instantiate(blockPrefab, new Vector3(-5.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //            Instantiate(blockPrefab, new Vector3(-1.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        }

    //        if(x == 2)
    //        {
    //            Instantiate(blockPrefab5, new Vector3(-4, 0.85f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //            Instantiate(blockPrefab, new Vector3(5.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //            Instantiate(blockPrefab, new Vector3(1.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        }

    //        lastRandomIndex = index;
    //    }

    //    if (index == 5)
    //    {
    //        GameObject block = Instantiate(blockPrefab3, new Vector3(UnityEngine.Random.Range(-5.0f, 5.0f), 920f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        block.GetComponent<Rigidbody>().AddForce(0, -1000 - (player.position.z / 2.8f), 0, ForceMode.Impulse);
    //        lastRandomIndex = index;
    //    }

    //    if (index == 6)
    //    {
    //        Instantiate(movingBlockPrefab1, new Vector3(0, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        lastRandomIndex = index;
    //    }

    //    if (index == 7)
    //    {
    //        Instantiate(movingBlockPrefab2Left, new Vector3(-5.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        Instantiate(movingBlockPrefab2Right, new Vector3(5.5f, 1.5f, (float)Math.Truncate(player.position.z) + 490 + distance), Quaternion.identity);
    //        lastRandomIndex = index;
    //    }
    //}
}
