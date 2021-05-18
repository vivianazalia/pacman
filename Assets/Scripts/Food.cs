using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour, ISpawn
{
    private Pacman player;

    void Start()
    {
        player = FindObjectOfType<Pacman>();
    }

    public void SpawnPosition()
    {
        float posX = Random.Range(-8.75f, 8.75f);
        float posY = Random.Range(-3.6f, 3.6f);

        transform.position = new Vector3(posX, posY, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.SetScore(100);
            Destroy(gameObject);
        }
    }
}
