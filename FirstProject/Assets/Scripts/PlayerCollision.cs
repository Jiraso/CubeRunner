using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "Obstacle") 
        {
            //will take the enabled property from the play movement script and disable it
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
