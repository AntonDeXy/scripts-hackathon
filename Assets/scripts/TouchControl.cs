using UnityEngine;

public class TouchControl : MonoBehaviour
{
    public Transform playerObj;
    [SerializeField]
    private float speed = 20;
    private void OnMouseDrag()
    {
        if (!player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2f ? 2f : mousePos.x;
            mousePos.x = mousePos.x < -2f ? -2f : mousePos.x;
            
            mousePos.y = mousePos.y > 2.6f ? 2.6f : mousePos.y;
            mousePos.y = mousePos.y < -3.75f ? -3.75f : mousePos.y;
            
            playerObj.position = Vector2.MoveTowards(playerObj.position, new Vector2(mousePos.x, mousePos.y), speed * Time.deltaTime);
        }
    }
}
