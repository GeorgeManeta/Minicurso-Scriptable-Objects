using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Pokemon/Attack")]
public class Attack : PokemonMove
{
    public float power;
    public float accuracy;
    public PokemonType type;

    public override void Move(PokemonBehaviour attackingPokemon, PokemonBehaviour defendingPokemon)
    {
        if(Random.Range(0f,100f) > (100-accuracy))
        {
            Debug.Log($"{attackingPokemon.name} acertou o ataque {name}");
            float damage = power * attackingPokemon.especie.baseATk.Value;
            defendingPokemon.TakeDamage(damage, type);
        }
        else
        {
            Debug.Log($"{attackingPokemon.name} errou");
        }
    }
}
