using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector2 movement;
    private Rigidbody2D rbPacman;

    private int score;

    private void Start()
    {
        rbPacman = GetComponent<Rigidbody2D>();
        ResetMovementValue();
    }

    private void Update()
    {
        CheckInput();
    }
    private void FixedUpdate()
    {
        Run();
    }

    //fungsi untuk mengatur movement Pacman
    void Run() 
    {
        rbPacman.MovePosition(rbPacman.position + movement * speed * Time.fixedDeltaTime);
    }

    //fungsi untuk mengatur input movement Pacman
    void CheckInput() 
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SetMovementValue(0, 1);
        } 
        else if (Input.GetKeyDown(KeyCode.D))
        {
            SetMovementValue(1, 0);
        } 
        else if (Input.GetKeyDown(KeyCode.S))
        {
            SetMovementValue(0, -1);
        } 
        else if (Input.GetKeyDown(KeyCode.A))
        {
            SetMovementValue(-1, 0);
        }
    }

    //untuk konfigurasi variable vector2 movement
    public void SetMovementValue(float x, float y)
    {
        movement.x = x;
        movement.y = y;
    }

    //untuk reset arah movement pada awal level
    public void ResetMovementValue()
    {
        SetMovementValue(1, 0);
    }

    //setter variable score
    public void SetScore(int s)
    {
        score += s;
    }

    //getter variable score
    public int GetScore()
    {
        return score;
    }
}
