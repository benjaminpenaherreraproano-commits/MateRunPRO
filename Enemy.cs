using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float velocidad = 2f;
    private bool derecha = true;

    void Update()
    {
        if (derecha)
            transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        else
            transform.Translate(Vector2.left * velocidad * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Wall"))
            derecha = !derecha;
    }
}
