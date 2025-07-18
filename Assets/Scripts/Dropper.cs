using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDrop = 3f;
    Rigidbody rb;
    MeshRenderer meshRenderer;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }
    void Update()
    {
        if (Time.time > timeToDrop)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
            
        }
    }
}
