using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Start is called before the first frame update

    // Variables will go here
   [SerializeField] private int attack;
   [SerializeField] private int health;
   [SerializeField] private int level;
    [SerializeField] private int exp;
    // Methods will go here

    // Start is called before the first frame update
    private void Start()
    {
        attack = 10;
        health = 100;
        level = 1;
        exp = 0;

    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Hello Kitty slays");
            level++;
        }
        if (level == 5)
        {
            Debug.Log("Hello Kity has slayed.");
        }
    }
}