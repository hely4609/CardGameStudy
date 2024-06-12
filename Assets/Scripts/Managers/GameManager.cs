using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public State currentState;

    private void Start()
    {
        Setting.gameManager = this;
    }
    private void FixedUpdate()
    {
        currentState.Tick(Time.deltaTime);
    }
    public void SetState(State state)
    {
        currentState = state;
    }
}
