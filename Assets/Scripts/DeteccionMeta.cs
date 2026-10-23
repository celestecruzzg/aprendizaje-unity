using UnityEngine;
using UnityEngine.SceneManagement;

public class DeteccionMeta : MonoBehaviour
{
    public GameObject mensajeVictoria;
    private bool nivelSuperado = false;

    void Update()
    {
        if (nivelSuperado && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "salida" && !nivelSuperado)
        {
            if (mensajeVictoria != null)
            {
                mensajeVictoria.SetActive(true);
            }

            Time.timeScale = 0f;
            nivelSuperado = true;
        }
    }
}