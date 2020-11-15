using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Service Locator/GameManager")]
public class GameManager : GameService
{
    public float tempoDeJogo = 0;

    public override void Update()
    {
        tempoDeJogo += Time.deltaTime;
    }
    public override void Start()
    {
        tempoDeJogo = 0;
    }
}
