using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidadHorizontal = 5f;
    public float fuerzaSalto = 5.5f;

    private Rigidbody2D rb;

    private bool enElSuelo = true;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimiento = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(movimiento * velocidadHorizontal, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && enElSuelo)
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);

            enElSuelo = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        enElSuelo = true;
    }
}