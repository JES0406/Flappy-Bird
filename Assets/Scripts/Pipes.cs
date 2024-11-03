using UnityEngine;

public class Pipes : MonoBehaviour
{
    [Header("Dependencies")]
    public Transform top;
    public Transform bottom;
    public float pipeSpeed = 3f;

    [Header("Parameters")]

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
         transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
    }

}
