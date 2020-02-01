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
            mousePos.x = mousePos.x > 2f ? 2 : mousePos.x;
            mousePos.x = mousePos.x < -2f ? -2 : mousePos.x;
            playerObj.position = Vector2.MoveTowards(playerObj.position, new Vector2(mousePos.x, playerObj.position.y), speed * Time.deltaTime);
        }
    }
}
