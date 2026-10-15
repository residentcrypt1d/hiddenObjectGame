using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // shortcut so any script can use this
    public TMP_Text scoreText; // this is where the game object goes in the inspector
    private int score = 0; // current score, here so it remembers values btwn frames
    private int totalObjects; // how many hidden objects are in the game
    private int foundCount = 0; // how many have been found so far

    void Start()
    {
    }

    void Update()
    {
    }

}
