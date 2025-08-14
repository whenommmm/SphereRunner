using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;
    public TextMeshProUGUI scoreText;


    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = ((int)player.position.z).ToString();
    }
}
