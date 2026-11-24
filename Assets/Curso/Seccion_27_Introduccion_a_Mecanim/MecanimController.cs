using UnityEngine;

public class MecanimController : MonoBehaviour
{
    public Animator animController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Avanzar();
        Salto();
        Viento();
        Escala();
    }

    private void Avanzar()
    {
        if (Input.GetButtonDown("Fire1"))
            animController.SetBool("Avanzar", true);
        if (Input.GetButtonDown("Fire2"))
            animController.SetBool("Avanzar", false);
    }

    private void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            animController.SetTrigger("Salto");
    }

    private void Viento()
    {
        if (Input.GetKeyDown(KeyCode.V))
            animController.SetFloat("Viento", 0.5f);
        if (Input.GetKeyDown(KeyCode.B))
            animController.SetFloat("Viento", 0.0f);
    }

    private void Escala()
    {
        if (Input.GetKeyDown(KeyCode.S))
            animController.SetInteger("Escala", 1);
        if (Input.GetKeyDown(KeyCode.D))
            animController.SetInteger("Escala", 0);
    }
}
