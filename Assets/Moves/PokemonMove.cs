using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PokemonMove : ScriptableObject
{
    public abstract void Move(PokemonBehaviour attackingPokemon, PokemonBehaviour defendingPokemon);
}
