using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Pacman player;
    [SerializeField] private Text scoreValue;

    void Start()
    {
        player = FindObjectOfType<Pacman>();
        SpawnFood();
    }

    private void Update()
    {
        ShowScore();
    }

    void SpawnFood()
    {
        ObjectFactory.Instance.GetObject("Food");
    }

    void ShowScore()
    {
        scoreValue.text = player.GetScore().ToString();
    }
}
