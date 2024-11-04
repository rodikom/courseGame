using UnityEngine;

public class IgnoreCamCollider : MonoBehaviour
{
    public GameObject camCollider;

    private void Start()
    {
        if (camCollider != null)
        {
            Collider2D playerCollider = GetComponent<Collider2D>();
            Collider2D camColliderComponent = camCollider.GetComponent<Collider2D>();

            if (playerCollider != null && camColliderComponent != null)
            {
                Physics2D.IgnoreCollision(playerCollider, camColliderComponent);
            }
        }
    }
}