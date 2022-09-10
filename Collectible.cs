using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private Score score;

    [SerializeField]
    private GameObject effect;

    [SerializeField]
    private GameObject audioEffect;

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(GetComponent<MeshRenderer>());
        audioEffect.SetActive(true);
        effect.SetActive(true);
        score.UpdateScore(1);
        Destroy(gameObject, 0.5f);
    }
}
