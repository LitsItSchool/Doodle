using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    // Use this for initialization
    public LevelGenerator levelGenerator;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.SetActive(false);
            SceneManager.LoadScene(0);
        }

        if (collision.tag == "Platform")
        {
            levelGenerator.ResetPosition(collision.gameObject);
        }
    }
}
