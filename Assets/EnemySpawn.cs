using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float spawnDelay = 2f;
    public GameObject[] enemies;
    public Camera camera;

    private float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        cooldown = spawnDelay;
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if(cooldown <= 0)
        {
            cooldown = spawnDelay;
            var cameraBoundingRect = camera.OrthographicBounds();

            float minX = cameraBoundingRect.min.x;
            float maxX = cameraBoundingRect.max.x;
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), transform.position.y, transform.position.z);
            GameObject enemyObj = enemies[Random.Range(0, enemies.Length)];
            Instantiate(enemyObj, spawnPos,transform.rotation);
        }

        cooldown -= Time.deltaTime;
    }
}
