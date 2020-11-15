using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

[CreateAssetMenu(menuName = "Pokemon/Especie")]
public class PokemonSpecies : ScriptableObject
{
    public float baseHP;
    public FloatVariable baseATk;

    public Color color;
    public PokemonType type;
}
