using UnityEngine;

public class PlayerMovementFast : MonoBehaviour
{
    [SerializeField] float playerSpeed = 100f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Vector2 move = new Vector2(h, 0f);

        if (Input.GetKey(KeyCode.A))
        {
            move += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += Vector2.right;
        }

        transform.Translate(move * playerSpeed * Time.deltaTime);
    }
}
