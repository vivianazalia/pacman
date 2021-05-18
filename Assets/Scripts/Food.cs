using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour, ISpawn
{
    private Vector2 newPos;

    //fungsi implementasi dari interface ISpawn.
    //dipanggil saat akan mengatur posisi spawn dari object food.
    public void SpawnPosition()
    {
        transform.position = GetPosition();
    }

    //fungsi untuk konfigurasi posisi food 
    public void SetPosition(float x, float y)
    {
        newPos = new Vector2(x, y);
    }

    Vector2 GetPosition()
    {
        return newPos;
    }
}
