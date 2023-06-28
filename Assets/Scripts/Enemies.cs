using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour

{
    // Start is called before the first frame update

    // Variables will go here
    [SerializeField] private int attack;
    [SerializeField] private int health;
    [SerializeField] private int level;
    // Methods will go here

    // Start is called before the first frame update
    private void Start()
    {
        attack = 10;
        health = 100;
        level = 1;

    }
}
