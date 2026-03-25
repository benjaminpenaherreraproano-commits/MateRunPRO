using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MateRunGame : MonoBehaviour
{
    public int vidas = 3;
    public float velocidad = 6f;
    public float salto = 8f;

    private Rigidbody2D rb;
    private bool enSuelo;

    public Text textoPregunta;
    public InputField inputRespuesta;
    public GameObject panelPregunta;

    private int num1, num2, respuestaCorrecta;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (panelPregunta != null)
            panelPregunta.SetActive(false);
    }

    void Update()
    {
        float mover = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(mover * velocidad, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, salto);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
            enSuelo = true;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
            enSuelo = false;
    }
}
