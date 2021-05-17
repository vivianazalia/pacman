using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour, ISpawn
{
    private float timeToSpawn = 10;

    void Start()
    {
        
    }

    public void SpawnPosition()
    {
        float posX = Random.Range(-8.75f, 8.75f);
        float posY = Random.Range(-3.6f, 3.6f);

        transform.position = new Vector2(posX, posY);
        gameObject.SetActive(true);
    }

    IEnumerator Spawn()
    {
        if(timeToSpawn <= 0)
        {
            SpawnPosition();
            timeToSpawn = 10;
            yield return new WaitForSeconds(3);
            gameObject.SetActive(false);
        }
        else
        {
            timeToSpawn -= Time.deltaTime;
        }
    }

    public void SpawnCall()
    {
        StartCoroutine(Spawn());
    }
}
