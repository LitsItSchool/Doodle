using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float speed;
    public float jumpForce;
    public SpriteRenderer spriteRenderer;
    GameConfig gameConfig;
    public Sprite[] sprites;
    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        var config = GameObject.Find("Config");
        if (config != null)
        {
            gameConfig = config.GetComponent<GameConfig>();
        }

        if (gameConfig == null)
        {
            spriteRenderer.sprite = sprites[0];

        }
        else
        {
            spriteRenderer.sprite = sprites[gameConfig.choosedCharacter];
        }
    }
    private void Awake()
    {
    }
    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal") * speed;
        rigidbody.velocity = new Vector2(horizontal, rigidbody.velocity.y);

        CheckPosition();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            if (collision.relativeVelocity.y >= 0)
            {
                rigidbody.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
            }
        }
    }

    private void CheckPosition()
    {
        if (transform.position.x < -4)
        {
            transform.position = new Vector3(4, transform.position.y);
        }
        if (transform.position.x > 4)
        {
            transform.position = new Vector3(-4, transform.position.y);
        }
    }

}
