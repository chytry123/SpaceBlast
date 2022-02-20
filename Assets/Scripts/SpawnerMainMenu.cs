using UnityEngine;
using System;

public class SpawnerMainMenu : MonoBehaviour
{
    public GameObject asteroid;
    //int lastRandomIndex = -1;
    float t;

    void Start()
    {
        Time.timeScale = 1;
        t = Time.time;
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, -4f), UnityEngine.Random.Range(2f, 4f), 150f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(4f, 10f), UnityEngine.Random.Range(-4f, -2f), 150f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, -4f), UnityEngine.Random.Range(-2f, 4f), 150f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(4f, 10f), UnityEngine.Random.Range(-4f, 2f), 150f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, -4f), UnityEngine.Random.Range(-2f, 4f), 200f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(4f, 10f), UnityEngine.Random.Range(-4f, 2f), 200f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, -4f), UnityEngine.Random.Range(-2f, 4f), 200f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(4f, 10f), UnityEngine.Random.Range(-4f, 2f), 200f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, -4f), UnityEngine.Random.Range(-2f, 4f), 200f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(4f, 10f), UnityEngine.Random.Range(-4f, 2f), 200f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, -4f), UnityEngine.Random.Range(-2f, 4f), 200f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(4f, 10f), UnityEngine.Random.Range(-4f, 2f), 200f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, -4f), UnityEngine.Random.Range(-2f, 4f), 250f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(4f, 10f), UnityEngine.Random.Range(-4f, 2f), 250f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, -4f), UnityEngine.Random.Range(-2f, 4f), 250f), Quaternion.identity);
        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(4f, 10f), UnityEngine.Random.Range(-4f, 2f), 250f), Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time - t > 0.7f)
        {
            //actual obstacle
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(4f, 10f), UnityEngine.Random.Range(2f, 4f), 300f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, -4f), UnityEngine.Random.Range(-4f, -2f), 300f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-10f, -4f), UnityEngine.Random.Range(2f, 4f), 300f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(4f, 10f), UnityEngine.Random.Range(-4f, -2f), 300f), Quaternion.identity);
            //artificial crowd
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(12f, 25f), UnityEngine.Random.Range(5f, 15f), 300f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-12f, -25f), UnityEngine.Random.Range(5f, 15f), 300f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(-12f, -25f), UnityEngine.Random.Range(-5f, -15f), 300f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(12f, 25f), UnityEngine.Random.Range(-5f, -15f), 300f), Quaternion.identity);

            t = Time.time;
        }
    }
}
