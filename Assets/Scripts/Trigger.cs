using System.Diagnostics;
using UnityEngine;

public class Trigger : MonoBehaviour
{ 
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
       gameManager.LevelComplete();
       gameManager.CompleteScreen();
    }
}
}
