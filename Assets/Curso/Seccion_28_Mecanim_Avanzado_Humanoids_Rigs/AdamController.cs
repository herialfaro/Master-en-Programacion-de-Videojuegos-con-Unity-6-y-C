using UnityEngine;

public class AdamController : MonoBehaviour
{
    public Animator anim;
    public float vert;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        vert = Input.GetAxis("Vertical");
        anim.SetFloat("walk", vert);
    }
}
