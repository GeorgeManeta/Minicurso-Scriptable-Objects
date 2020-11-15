using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonBehaviour : MonoBehaviour
{
    public Renderer renderer;
    public float level;
    public float currentHP;

    public PokemonSpecies especie;
    public PokemonMove move;

    [ContextMenu("Setup")]
    public void Setup()
    {
        GameManager gm = ServiceLocator.Get<GameManager>();
        Debug.Log(gm.tempoDeJogo);
        currentHP = level * especie.baseHP;
        renderer.material.color = especie.color;
    }

    [ContextMenu("UpdateScale")]
    void UpdateScale()
    {
        transform.localScale = new Vector3(1f, currentHP / (especie.baseHP * level), 1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        PokemonBehaviour pokemonAcertado = other.GetComponent<PokemonBehaviour>();
        if(pokemonAcertado != null)
        {
            move.Move(this, pokemonAcertado);
        }
        UpdateScale();
    }

    public void TakeDamage(float damage, PokemonType damageType)
    {
        if(especie.type.weakness == damageType)
        {
            currentHP -= damage;
        }
    }
}
