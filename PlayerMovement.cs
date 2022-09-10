using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidbody;

    public float movementSpeed;
    public float jumpForce;
    public bool canJump = true;

    [SerializeField]
    private AudioSource jumpAudio;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, z);

        rigidbody.AddForce(movement * Time.deltaTime * movementSpeed);

        //Jump Logic
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            jumpAudio.Play();
            Vector3 jumpVector = new Vector3(0, jumpForce, 0);
            rigidbody.AddForce(jumpVector, ForceMode.Impulse);
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision otherObjectCollision)
    {
        if (otherObjectCollision.transform.tag.Equals("ground"))
        {
            canJump = true;
        }
    }
}
