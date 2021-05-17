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

    void Run() 
    {
        rbPacman.MovePosition(rbPacman.position + movement * speed * Time.fixedDeltaTime);
    }

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

    public void SetMovementValue(float x, float y)
    {
        movement.x = x;
        movement.y = y;
    }

    void ResetMovementValue()
    {
        SetMovementValue(1, 0);
    }

    void SetScore(int s)
    {
        score += s;
    }

    int GetScore()
    {
        return score;
    }
}
