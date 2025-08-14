using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{

    public MovementSp pl;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            
            pl.enabled = false;
            pl.rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
            FindFirstObjectByType<GameManager>().EndGame();
            FindFirstObjectByType<Score>().enabled = false;
            

        }
    }
}
