using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallPlayController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text gemText;
    public Text winText;

    private int count;
    private int gemcount;
    private Rigidbody rb;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        count = 0;
        gemcount = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Vertical");
        float moveVertical = Input.GetAxis("Horizontal") * (-1);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Gem"))
        {
            other.gameObject.SetActive(false);
            gemcount = gemcount + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        gemText.text = "Gems: " + gemcount.ToString();
        if ((count >= 13) && (gemcount == 1))
        {
            winText.text = "You Win!";
        }
    }

}