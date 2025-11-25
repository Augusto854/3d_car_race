using UnityEngine;

public class PelaajanAuto : MonoBehaviour
{

    public float speed = 10f;

    public float turnSpeed = 500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameRunning)
        {
        //luetaan pystysuuntainen liike
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //luetaan vaakasuuntainen liike
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * move);

        transform.Rotate(Vector3.up * turn);
        }
    }
}
