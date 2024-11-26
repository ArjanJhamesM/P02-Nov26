using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUICode : MonoBehaviour
{
    [SerializeField] private Vector2 position;
    [SerializeField] private Vector2 size;
    private float x1;
    private float y1;
    private float x2;
    private float y2;

    private string textPlayerName;
    private string textInteractable;
    private string textStats;

    private string textPlayerOneName;
    private string textPlayerTwoName;
    private string textPlayerThreeName;

    private string textPlayerOneStats;
    private string textPlayerTwoStats;
    private string textPlayerThreeStats;

    private PlayerOneStats playerOneStats;
    private PlayerTwoStats playerTwoStats;
    private PlayerThreeStats playerThreeStats;

    private void Start()
    {
        position = new Vector2(x1, y1);
        size = new Vector2(x2, y2);

        playerOneStats = new PlayerOneStats();
        playerTwoStats = new PlayerTwoStats();
        playerThreeStats = new PlayerThreeStats();

        
    }

    private void OnGUI()
    {
        textPlayerOneStats = "Health: " + playerOneStats.playerOneHealth + 
            "\nMana: " + playerOneStats.playerOneMana +
            "\nAttack: " + playerOneStats.playerOneAttack +
            "\nDefense: " + playerOneStats.playerOneDefense +
            "\nSpeed: " + playerOneStats.playerOneSpeed;

        textPlayerTwoStats = "Health: " + playerTwoStats.playerTwoHealth +
            "\nMana: " + playerTwoStats.playerTwoMana +
            "\nAttack: " + playerTwoStats.playerTwoAttack +
            "\nDefense: " + playerTwoStats.playerTwoDefense +
            "\nSpeed: " + playerTwoStats.playerTwoSpeed;

        textPlayerThreeStats = "Health: " + playerThreeStats.playerThreeHealth +
            "\nMana: " + playerThreeStats.playerThreeMana +
            "\nAttack: " + playerThreeStats.playerThreeAttack +
            "\nDefense: " + playerThreeStats.playerThreeDefense +
            "\nSpeed: " + playerThreeStats.playerThreeSpeed;

        textPlayerOneName = "Player One";
        textPlayerTwoName = "Player Two";
        textPlayerThreeName = "Player Three";


        GUI.Box(new Rect(10, 10, 1900, 1060), "");

        GUI.Box(new Rect(30, 30, 500, 1020), textPlayerName);

        GUI.Box(new Rect(850, 235, 750, 150), "");

        GUI.Box(new Rect(850, 600, 750, 450), "");

        GUI.Label(new Rect(1190, 300, 500, 150), textInteractable);

        GUI.Label(new Rect(1190, 800, 500, 150), textStats);

        if (GUI.Button(new Rect(850, 30, 300, 150), "Chest"))
        {
            textInteractable = "Coin";
        }

        if (GUI.Button(new Rect(1300, 30, 300, 150), "Switch"))
        {
            textInteractable = "Door is open";
        }

        if (GUI.Button(new Rect(850, 450, 240, 100), "Player One"))
        {
            textPlayerName = textPlayerOneName;
            textStats = textPlayerOneStats;
        }

        if (GUI.Button(new Rect(1105, 450, 240, 100), "Player Two"))
        {
            textPlayerName = textPlayerTwoName; 
            textStats = textPlayerTwoStats;
        }

        if (GUI.Button(new Rect(1360, 450, 240, 100), "Player Three"))
        {
            textPlayerName = textPlayerThreeName;
            textStats = textPlayerThreeStats;
        }
    }
}
