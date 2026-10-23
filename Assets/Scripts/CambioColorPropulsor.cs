using UnityEngine;

public class CambioColorPropulsor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.color = Color.orange;
        }

        if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.color = Color.orange;
        }

        if (Input.GetKey(KeyCode.W))
        {
            spriteRenderer.color = Color.red;
        }

        if (Input.GetKey(KeyCode.S))
        {
            spriteRenderer.color = Color.yellow;  
        }
    }
}